using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            if (donebutton.Text.Equals("Cancel"))
            {
                MessageBox.Show("Changes Discarded. No Changes Made"); // Pop up window
                changevisible(0); // Calling function to display edit profile elements
            }
            else if (donebutton.Text.Equals("Done"))
            {
                this.Close();
            }
            
        }

        private void search_Load(object sender, EventArgs e)
        {
            whatdoyouwantlabel.Parent = pictureBox1;
            whatdoyouwantlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            enterflightidlabel.Parent = pictureBox1;
            enterflightidlabel.BackColor = Color.Transparent;

            pilotslabel.Parent = pictureBox1;
            pilotslabel.BackColor = Color.Transparent;

            flightidlabel.BackColor = Color.Transparent;
            flightidlabel.Parent = pictureBox1;

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
            availableseatslabel.Parent = pictureBox1;
            availableseatslabel.BackColor = Color.Transparent;
            deptime.Parent = pictureBox1;
            deptime.BackColor = Color.Transparent;
        }

        private void Editinfo_Click(object sender, EventArgs e)
        {
            savebutton.Visible = true;
            pilolttextbox.ReadOnly = false;
            copilolttextbox.ReadOnly = false;
            destinationcombobox.Enabled=true;
            aircraftcombobox.Enabled = true;
            flighthourtextbox.ReadOnly= false;
            depdateandtimepick.Enabled =true;
            donebutton.Text = "Cancel";
        }

        private void deleteflightbutton_Click(object sender, EventArgs e)
        {
            int rowaffected = 0;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("deleteflight", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                con.Open(); // Opening Connection
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@flightid", SqlDbType.Int).Value = Convert.ToInt32(enterflightidtextbox.Text); //Defining the command parameter for usrname
                rowaffected=cmd.ExecuteNonQuery(); // Executing Query
            }
            if (rowaffected == 0)
            {
                MessageBox.Show("Delete unsuccessful. Please Try again");
            }
            else if (rowaffected > 0)
            {
                MessageBox.Show("Flight Deleted Successfully. Passengers will be notified");
                changevisible(0);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            if (validflightid(enterflightidtextbox.Text))
            {
                changevisible(1);
                flightinfo fi = new flightinfo();
                fi = flightinfo.getall(enterflightidtextbox.Text);
                pilolttextbox.Text = fi.pilot;
                copilolttextbox.Text = fi.copilot;
                depcomboBox.Text = fi.departure;
                flightidtextbox.Text =fi.flightid.ToString();
                availableseatstextbox.Text = fi.availseat.ToString();
                flighthourtextbox.Text = fi.duration.ToString();
                depdateandtimepick.Value=fi.departuretime;
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("select * from availplanes()", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    con.Open(); // Opening Connection
                   
                    // Using parametrized query to avoid sql injection attack
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        aircraftcombobox.Items.Add(dr["id"] + " - " + dr["aircraft"]);
                    }
                    dr.Close();
                    SqlCommand cmd2 = new SqlCommand("whatplane", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                               // Using parametrized query to avoid sql injection attack
                    cmd2.Parameters.Add("@flightid", SqlDbType.Int).Value = Convert.ToInt32(enterflightidtextbox.Text); //Defining the command parameter for usrname
                    cmd2.Parameters.Add("@aircraft", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output
                    cmd2.Parameters.Add("@totseat", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output
                    cmd2.Parameters.Add("@planeid", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output

                    cmd2.ExecuteNonQuery(); // Executing Query
                    aircraftcombobox.Text = Convert.ToString(cmd2.Parameters["@planeid"].Value) + " - " + Convert.ToString(cmd2.Parameters["@aircraft"].Value); // Assigning output value of stored procedure by converting to int
                    noofseatstextbox.Text = Convert.ToString(cmd2.Parameters["@totseat"].Value); // Assigning output value of stored procedure by converting to int
                    
                    SqlCommand cmd3 = new SqlCommand("select * from dest()", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database

                    // Using parametrized query to avoid sql injection attack
                    SqlDataReader dr2 = cmd3.ExecuteReader();
                    while (dr2.Read())
                    {
                        destinationcombobox.Items.Add(dr2["city"]);
                    }
                    dr2.Close();
                    destinationcombobox.Text = fi.destination;
                }
            }
        }
        private void changevisible(int appear)
        {
            if (appear == 0)
            {
                addflightbutton.Visible = true;
                editflightbutton.Visible = true;
                enterflightidlabel.Visible = false; // Making Visible
                enterflightidtextbox.Visible = false; // Making Visible
                searchbutton.Visible = false; // Making Visible
                whatdoyouwantlabel.Text = "What do you want to do";
                pilotslabel.Visible = false; // Hiding Element
                pilolttextbox.Visible = false; // Hiding Element
                copilolttextbox.Visible = false; // Hiding Element
                flightidlabel.Visible = false; // Hiding Element
                flightidtextbox.Visible = false; // Hiding Element
                aircraftlabel.Visible = false; // Hiding Element
                aircraftcombobox.Visible = false; // Hiding Element
                departurelabel.Visible = false; // Hiding Element
                depcomboBox.Visible = false; // Hiding Element
                destinationlabel.Visible = false; // Hiding Element
                destinationcombobox.Visible = false; // Hiding Element
                flighthourlabel.Visible = false; // Hiding Element
                flighthourtextbox.Visible = false; // Hiding Element
                noofseatslabel.Visible = false; // Hiding Element
                noofseatstextbox.Visible = false; // Hiding Element
                availableseatslabel.Visible = false; // Hiding Element
                availableseatstextbox.Visible = false; // Hiding Element
                deptime.Visible = false;
                depdateandtimepick.Visible = false;
                Editinfobutton.Visible = false; // Hiding Element
                savebutton.Visible = false; // Hiding Element
                deleteflightbutton.Visible = false; // Hiding Element
                donebutton.Text = "Done";
            }
            else if (appear == 1)
            {
                whatdoyouwantlabel.Text = "Flight Information";
                enterflightidlabel.Visible = false; // Hiding Element
                enterflightidtextbox.Visible = false; // Hiding Element
                searchbutton.Visible = false; // Hiding Element
                addflightbutton.Visible = false;
                editflightbutton.Visible = false;
                pilotslabel.Visible = true; // Making Visible
                pilolttextbox.Visible = true; // Making Visible
                copilolttextbox.Visible = true; // Making Visible
                flightidlabel.Visible = true; // Making Visible
                flightidtextbox.Visible = true; // Making Visible
                aircraftlabel.Visible = true; // Making Visible
                aircraftcombobox.Visible = true; // Making Visible
                departurelabel.Visible = true; // Making Visible
                depcomboBox.Visible = true; // Making Visible
                destinationlabel.Visible = true; // Making Visible
                destinationcombobox.Visible = true; // Making Visible
                flighthourlabel.Visible = true; // Making Visible
                flighthourtextbox.Visible = true; // Making Visible
                noofseatslabel.Visible = true; // Making Visible
                noofseatstextbox.Visible = true; // Making Visible
                availableseatslabel.Visible = true; // Making Visible
                availableseatstextbox.Visible = true; // Making Visible
                depdateandtimepick.Visible = true;
                deptime.Visible = true;
                Editinfobutton.Visible = true; // Making Visible
                deleteflightbutton.Visible = true; // Making Visible
            }
        }
        private bool validflightid(string flightid)
        {
            if (string.IsNullOrEmpty(flightid))
            {
                enterflightiderror.Clear();
                enterflightiderror.SetError(enterflightidtextbox, "Enter a valid flight ID");
                return false;
            }

            if (!string.IsNullOrEmpty(flightid))
            {
                try
                {
                    int flightidnum = Convert.ToInt32(flightid);
                }
                catch
                {
                    enterflightiderror.Clear();
                    enterflightiderror.SetError(enterflightidtextbox, "Flight ID Can't Contain any Character");
                    return false;
                }
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("select dbo.flightexist(@flightid)", con);
                    // Sql Command to check if entered flight exist
                    // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@flightid", SqlDbType.VarChar, 1000).Value = flightid; //Defining the command parameter for backup location
                    con.Open(); //Opening Connection
                    int existance = Convert.ToInt32(cmd.ExecuteScalar()); // Executing Query
                    if (existance <= 0)
                    {
                        enterflightiderror.Clear();
                        enterflightiderror.SetError(enterflightidtextbox, "Flight Doesn't Exist");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool validatename(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(name))
            {
                if(name.Length>70)
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
        private void savebutton_Click(object sender, EventArgs e)
        {
            piloterror.Clear();
            copiloterror.Clear();
            flighthourerror.Clear();
            destinationerror.Clear();
            aircrafterror.Clear();
            if (!validatename(pilolttextbox.Text))
            {
                piloterror.Clear();
                piloterror.SetError(pilolttextbox, "Enter a valid Pilot Name");
            }
            if (!validatename(copilolttextbox.Text))
            {
                copiloterror.Clear();
                copiloterror.SetError(copilolttextbox, "Enter a valid Co-Pilot Name");
            }
            if (!validatehour(flighthourtextbox.Text))
            {
                flighthourerror.Clear();
                flighthourerror.SetError(flighthourtextbox, "Enter a valid flight hour");
            }
            if (string.IsNullOrEmpty(destinationcombobox.Text) || !destinationexist(destinationcombobox.Text))
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
            else if(validatename(pilolttextbox.Text) 
                && validatename(copilolttextbox.Text)
                && validatehour(flighthourtextbox.Text)
                && !string.IsNullOrEmpty(destinationcombobox.Text)
                && !string.IsNullOrEmpty(destinationcombobox.Text) && destinationexist(destinationcombobox.Text)
                && !string.IsNullOrEmpty(aircraftcombobox.Text) && aircraftexist(aircraftcombobox.Text))
            {
                piloterror.Clear();
                copiloterror.Clear();
                flighthourerror.Clear();
                destinationerror.Clear();
                aircrafterror.Clear();
                int rowaffected = 0;
                flightinfo fi = new flightinfo();
                fi.departure = depcomboBox.Text;
                fi.destination = destinationcombobox.Text;
                fi.departuretime = depdateandtimepick.Value;
                fi.pilot = pilolttextbox.Text;
                fi.copilot = copilolttextbox.Text;
                fi.availseat = Convert.ToInt32(availableseatstextbox.Text);
                fi.duration = Convert.ToInt32(flighthourtextbox.Text);
                fi.planeid = Convert.ToInt32(aircraftcombobox.Text.Substring(0, 4));
                fi.flightid = Convert.ToInt32(enterflightidtextbox.Text);
                rowaffected = fi.save(0);
                if (rowaffected > 0)
                {
                    MessageBox.Show("Changes saved successfylly. Passengers will be notified of the changes");
                    
                }
                else
                {
                    MessageBox.Show("Unable to save changes. Try Again");
                }
                changevisible(0);
                enterflightidtextbox.Text = null;
                donebutton.Text = "Done";
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
                if (existance > 0)
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
                cmd.Parameters.Add("@aircraft", SqlDbType.VarChar, 20).Value = aircraft.Substring(7, aircraft.Length - 7); //Defining the command parameter for usrname
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
        private void searchflightbutton_Click(object sender, EventArgs e)
        {
            enterflightidlabel.Visible = true;
            enterflightidtextbox.Visible = true;
            enterflightidtextbox.Text = null;
            searchbutton.Visible = true;
            addflightbutton.Visible = false;
            editflightbutton.Visible = false;
        }

        private void addflightbutton_Click(object sender, EventArgs e)
        {
            addflight fl=new addflight();
            fl.Show();
        }

        private void aircraftcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(aircraftcombobox.Text.Substring(0, 4)) > 1000)
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
                    availableseatstextbox.Text=noofseats.ToString();
                }
            }
        }
    }
}