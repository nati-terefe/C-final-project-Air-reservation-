using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_reservation
{
    public partial class addflight : Form
    {
        public addflight()
        {
            InitializeComponent();
        }

        private void addflight_Load(object sender, EventArgs e)
        {

            // making the labels and the logo transparent 
            aircraftlabel.Parent = pictureBox1;
            aircraftlabel.BackColor = Color.Transparent;
            departurelabel.Parent = pictureBox1;
            departurelabel.BackColor = Color.Transparent;
            destinationlabel.Parent = pictureBox1;
            destinationlabel.BackColor = Color.Transparent;
            flighthourlabel.Parent = pictureBox1;
            flighthourlabel.BackColor = Color.Transparent;
            noofseatslabel.Parent = pictureBox1;
            noofseatslabel.BackColor = Color.Transparent;
            deptime.Parent = pictureBox1;
            deptime.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            addflightlabel.Parent = pictureBox1;
            addflightlabel.BackColor = Color.Transparent;

            depdateandtimepick.Format = DateTimePickerFormat.Custom;
            depdateandtimepick.CustomFormat = "yyyy/mm/d hh:mm:ss";

            pilotcombobox.Items.Clear();
            copilotcombobox.Items.Clear();
            destinationcombobox.Items.Clear();
            //making some of the labels, text box's and combobox invisiable unitl next button is pushed 
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select * from dest()", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                con.Open();
                // Using parametrized query to avoid sql injection attack
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    destinationcombobox.Items.Add(dr["city"]);
                }
                dr.Close();
                SqlCommand cmd2 = new SqlCommand("select * from availplanes()", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                // Using parametrized query to avoid sql injection attack
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    aircraftcombobox.Items.Add(dr2["id"] + " - " + dr2["aircraft"]);
                }
                dr2.Close();
                SqlCommand cmd3 = new SqlCommand("select * from availpilots()", con);
                // Sql Command stored procedure to insert successful Login into Login History on database

                // Using parametrized query to avoid sql injection attack
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    pilotcombobox.Items.Add(dr3["full_name"]);
                    copilotcombobox.Items.Add(dr3["full_name"]);
                }
                dr3.Close();
            }
            depcomboBox.Text = "Addis Ababa";
            cancelbutton.Text = "Cancel";
        }
        private bool validatename(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(name))
            {
                if (name.Length > 70)
                {
                    return false;
                }
                char[] namechar = name.ToCharArray();
                for (int i = 0; i < namechar.Length; i++)
                {
                    if (!(namechar[i] >= 'A' && namechar[i] <= 'z') && !name.Contains('.') && !name.Contains(' '))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool validatehour(string hour)
        {
            if (string.IsNullOrEmpty(hour))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(hour))
            {
                char[] hourchar = hour.ToCharArray();
                for (int i = 0; i < hourchar.Length; i++)
                {
                    if (hourchar[i] >= 'A' && hourchar[i] <= 'z')
                    {
                        return false;
                    }
                }
            }
            if (Convert.ToInt32(hour) > 30)
            {
                return false;
            }
            return true;
        }
        
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            if(cancelbutton.Text.Equals("Done"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Adding Flight Cancelled");
                this.Close();
            }
        }

        private void addflightbutton_Click(object sender, EventArgs e)
        {
            piloterror.Clear();
            copiloterror.Clear();
            flighthourerror.Clear();
            noofseatserror.Clear();
            aircrafterror.Clear();
            if (!validatename(pilotcombobox.Text))
            {
                piloterror.Clear();
                piloterror.SetError(pilotcombobox, "Enter a valid Pilot Name");
            }
            if (!validatename(copilotcombobox.Text))
            {
                copiloterror.Clear();
                copiloterror.SetError(copilotcombobox, "Enter a valid Co-Pilot Name");
            }
            if (!validatehour(flighthourtextbox.Text))
            {
                flighthourerror.Clear();
                flighthourerror.SetError(flighthourtextbox, "Enter a valid flight hour");
            }
            if (string.IsNullOrEmpty(noofseatstextbox.Text) || Convert.ToInt32(noofseatstextbox.Text)>500 || Convert.ToInt32(noofseatstextbox.Text) < 10)
            {
                noofseatserror.Clear();
                noofseatserror.SetError(noofseatstextbox, "Select a valid aircraft");
            }
            if(string.IsNullOrEmpty(destinationcombobox.Text) || !destinationexist(destinationcombobox.Text))
            {
                destinationcombobox.Text = null;
                destinationerror.Clear();
                destinationerror.SetError(destinationcombobox, "Select Destination City");
            }
            if (string.IsNullOrEmpty(aircraftcombobox.Text) || !aircraftexist(aircraftcombobox.Text))
            {
                aircraftcombobox.Text = null;
                aircrafterror.Clear();
                aircrafterror.SetError(aircraftcombobox, "Select Aircraft");
            }
            if (copilotcombobox.Text.Equals(pilotcombobox.Text))
            {
                piloterror.Clear();
                piloterror.SetError(pilotcombobox, "Pilot and co pilot can't be the same");
                copiloterror.Clear();
                copiloterror.SetError(copilotcombobox, "CoPilot and pilot can't be the same");
            }
            else if (validatename(pilotcombobox.Text)
                && validatename(copilotcombobox.Text) && !copilotcombobox.Text.Equals(pilotcombobox.Text)
                && validatehour(flighthourtextbox.Text)
                && !string.IsNullOrEmpty(noofseatstextbox.Text) && Convert.ToInt32(noofseatstextbox.Text) <= 500 && Convert.ToInt32(noofseatstextbox.Text) >= 10
                && !string.IsNullOrEmpty(destinationcombobox.Text) && destinationexist(destinationcombobox.Text)
                && !string.IsNullOrEmpty(aircraftcombobox.Text) && aircraftexist(aircraftcombobox.Text))
            {
                piloterror.Clear();
                copiloterror.Clear();
                flighthourerror.Clear();
                noofseatserror.Clear();
                destinationerror.Clear();
                aircrafterror.Clear();
                int rowaffected = 0;
                flightinfo fi = new flightinfo();
                fi.departure = depcomboBox.Text;
                fi.destination = destinationcombobox.Text;
                fi.departuretime = depdateandtimepick.Value;
                fi.pilot = pilotcombobox.Text;
                fi.copilot = copilotcombobox.Text;
                fi.availseat = Convert.ToInt32(noofseatstextbox.Text);
                fi.duration = Convert.ToInt32(flighthourtextbox.Text);
                fi.planeid = Convert.ToInt32(aircraftcombobox.Text.Substring(0, 4));
                try
                {
                    rowaffected = fi.save(1);
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Flight added successfully");
                        cancelbutton.Text = "Done";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add flight. Try Again");
                    }
                }
                catch
                {
                    MessageBox.Show("Pilot or Copilot is onboard of another flight");
                }
            }
        }
        private bool destinationexist(string dest)
        {
            int existance = 0;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("destexist", con);
                // Sql Command to return if user exists on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 20).Value = dest; //Defining the command parameter for usrname
                cmd.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                existance = Convert.ToInt32(cmd.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                if(existance > 0)
                {
                    return true;
                }
            }
            return false;
        }
        private bool aircraftexist(string aircraft)
        {
            if (aircraft.Length < 10)
            {
                return false;
            }
            int existance = 0;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("aircraftexist", con);
                // Sql Command to return if user exists on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@aircraft", SqlDbType.VarChar, 20).Value = aircraft.Substring(7, aircraft.Length-7); //Defining the command parameter for usrname
                cmd.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                existance = Convert.ToInt32(cmd.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                if (existance > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void aircraftcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(aircraftcombobox.Text.Substring(0, 4))>1000)
            {
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("select dbo.whatnoofseat(@planesid)", con);
                    // Sql Command to check if entered flight exist
                    // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@planesid", SqlDbType.Int).Value = Convert.ToInt32(aircraftcombobox.Text.Substring(0, 4)); //Defining the command parameter for backup location
                    con.Open(); //Opening Connection
                    int noofseats = Convert.ToInt32(cmd.ExecuteScalar()); // Executing Query
                    noofseatstextbox.Text = noofseats.ToString();
                }
            }
        }
    }
}
