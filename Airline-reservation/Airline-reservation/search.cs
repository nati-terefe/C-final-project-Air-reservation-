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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {
            flightinfolabel.Parent = pictureBox1;
            flightinfolabel.BackColor = Color.Transparent;
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
            departuretextbox.ReadOnly = false;
            destinationtextbox.ReadOnly = false;
            aircrafttextbox.ReadOnly = false;
            flighthourtextbox.ReadOnly= false;
            noofseatstextbox.ReadOnly= false;
            availableseatstextbox.ReadOnly = false;
            
        }

        private void deleteflightbutton_Click(object sender, EventArgs e)
        {
            //write delete sql code that will take the flight id at the where statement
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
                departuretextbox.Text = fi.departure;
                destinationtextbox.Text = fi.destination;
                flightidtextbox.Text = enterflightidtextbox.Text;
                availableseatstextbox.Text = fi.availseat.ToString();
                flighthourtextbox.Text = fi.duration.ToString();
                depdateandtimepick.Value=fi.departuretime;
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("planeandnoofseat", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    con.Open(); // Opening Connection
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                               // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@flightid", SqlDbType.Int).Value = Convert.ToInt32(enterflightidtextbox.Text); //Defining the command parameter for usrname
                    cmd.Parameters.Add("@aircraft", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output
                    cmd.Parameters.Add("@totseat", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output

                    cmd.ExecuteNonQuery(); // Executing Query
                    aircrafttextbox.Text = Convert.ToString(cmd.Parameters["@aircraft"].Value); // Assigning output value of stored procedure by converting to int
                    noofseatstextbox.Text = Convert.ToString(cmd.Parameters["@totseat"].Value); // Assigning output value of stored procedure by converting to int
                }
            }
        }
        private void changevisible(int appear)
        {
            if (appear == 0)
            {
                enterflightidlabel.Visible = true; // Making Visible
                enterflightidtextbox.Visible = true; // Making Visible
                searchbutton.Visible = true; // Making Visible

                pilotslabel.Visible = false; // Hiding Element
                pilolttextbox.Visible = false; // Hiding Element
                copilolttextbox.Visible = false; // Hiding Element
                flightidlabel.Visible = false; // Hiding Element
                flightidtextbox.Visible = false; // Hiding Element
                aircraftlabel.Visible = false; // Hiding Element
                aircrafttextbox.Visible = false; // Hiding Element
                departurelabel.Visible = false; // Hiding Element
                departuretextbox.Visible = false; // Hiding Element
                destinationlabel.Visible = false; // Hiding Element
                destinationtextbox.Visible = false; // Hiding Element
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
            }
            else if (appear == 1)
            {
                enterflightidlabel.Visible = false; // Hiding Element
                enterflightidtextbox.Visible = false; // Hiding Element
                searchbutton.Visible = false; // Hiding Element

                pilotslabel.Visible = true; // Making Visible
                pilolttextbox.Visible = true; // Making Visible
                copilolttextbox.Visible = true; // Making Visible
                flightidlabel.Visible = true; // Making Visible
                flightidtextbox.Visible = true; // Making Visible
                aircraftlabel.Visible = true; // Making Visible
                aircrafttextbox.Visible = true; // Making Visible
                departurelabel.Visible = true; // Making Visible
                departuretextbox.Visible = true; // Making Visible
                destinationlabel.Visible = true; // Making Visible
                destinationtextbox.Visible = true; // Making Visible
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
                char[] flightidchar = flightid.ToCharArray();
                for (int i = 0; i < flightidchar.Length; i++)
                {
                    if (flightidchar[i] >= 'A' && flightidchar[i] <= 'z')
                    {
                        enterflightiderror.Clear();
                        enterflightiderror.SetError(enterflightidtextbox, "Flight ID Can't Contain any Character");
                        return false;
                    }
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            flightinfo fi = new flightinfo();
            fi.departure = departuretextbox.Text;
            fi.destination = destinationtextbox.Text;
            // fi.departuretime =
            fi.pilot = pilolttextbox.Text;
            fi.copilot = copilolttextbox.Text;
            fi.availseat = Convert.ToInt32(availableseatstextbox.Text);
            fi.duration = Convert.ToInt32(flighthourtextbox.Text);
            // fi.planeid = 
            fi.save(0);

        }
    }
}