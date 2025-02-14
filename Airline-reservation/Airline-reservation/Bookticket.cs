﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Airline_reservation
{
    public partial class Bookticket : Form
    {
        public static double price = -1;
        public static string loginusername = " ";
        public static int edit=0;
        public Bookticket()
        {
            InitializeComponent();
            loginusername = "Non-USER";
        }
        public Bookticket(string usrname)
        {
            InitializeComponent();
            loginusername = usrname;
            edit = 0;
        }

        public Bookticket(string usrname, int editview)
        {
            edit = editview;
            InitializeComponent();
            loginusername = usrname;
        }
        public Bookticket(int editview)
        {
            edit = editview;
            InitializeComponent();
            loginusername = "admin";
        }

        private void Bookticket_admin_Load(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                // making the labels and the logo transparent 
                bookticketlabel.Text = "Book Ticket";
                Viewbutton.Text = "View Price";
                donebtn.Text = "Done";
                bookticketlabel.Parent = bgpic;
                bookticketlabel.BackColor = Color.Transparent;
                firstnamelabel.Parent = bgpic;
                firstnamelabel.BackColor = Color.Transparent;
                lastnamelabel.Parent = bgpic;
                lastnamelabel.BackColor = Color.Transparent;
                emaillabel.Parent = bgpic;
                emaillabel.BackColor = Color.Transparent;
                passportlabel.Parent = bgpic;
                passportlabel.BackColor = Color.Transparent;
                agelabel.Parent = bgpic;
                agelabel.BackColor = Color.Transparent;
                genderlabel.Parent = bgpic;
                genderlabel.BackColor = Color.Transparent;
                gendergroupbox.Parent = bgpic;
                gendergroupbox.BackColor = Color.Transparent;
                fromlabel.Parent = bgpic;
                fromlabel.BackColor = Color.Transparent;
                tolabel.Parent = bgpic;
                tolabel.BackColor = Color.Transparent;
                flightclasslabel.Parent = bgpic;
                flightclasslabel.BackColor = Color.Transparent;
                departurelabel.Parent = bgpic;
                departurelabel.BackColor = Color.Transparent;
                flighttypelabel.Parent = bgpic;
                flighttypelabel.BackColor = Color.Transparent;
                flightgroupbox.Parent = bgpic;
                flightgroupbox.BackColor = Color.Transparent;
                logo.Parent = bgpic;
                logo.BackColor = Color.Transparent;
                //making some of the labels, text box's and combobox invisiable unitl next button is pushed 
                enterticketidlabel.Visible = false;
                enterticketidtextbox.Visible = false;
                searchbutton.Visible = false;
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
                        tocomboBox.Items.Add(dr["city"]);
                    }
                    dr.Close();
                    tocomboBox.Text = null;

                }
                fromcomboBox.Text = "Addis Ababa";
                departuredate.Items.Clear();
            }
            else
            {
                enterticketidlabel.Visible = true;
                enterticketidtextbox.Visible = true;
                searchbutton.Visible = true;

                bookticketlabel.Text = "Manage Bookings";
                bookticketlabel.Parent = bgpic;
                bookticketlabel.BackColor = Color.Transparent;
                enterticketidlabel.Parent = bgpic;
                enterticketidlabel.BackColor = Color.Transparent;
                firstnamelabel.Visible = false;
                lastnamelabel.Visible = false;
                emaillabel.Visible = false;
                passportlabel.Visible = false;
                agelabel.Visible = false;
                genderlabel.Visible = false;
                gendergroupbox.Visible = false;
                fromlabel.Visible = false;
                tolabel.Visible = false;
                flightclasslabel.Visible = false;
                departurelabel.Visible = false;
                flighttypelabel.Visible = false;
                flightgroupbox.Visible = false;
                firstnametextbox.Visible = false;
                lastnametextbox.Visible = false;
                emailtextbox.Visible = false;
                passporttextbox.Visible= false;
                agecomboBox.Visible = false;
                fromcomboBox.Visible = false;
                tocomboBox.Visible = false;
                flightclasscomboBox.Visible = false;
                departuredate.Visible = false;
                Viewbutton.Visible = false;
                deletebookingbutton.Visible = false;
                donebtn.Text = "Done";
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            donebtn.Text = "Cancel";
            string gender;
            bool b1 = Male.Checked;
            gender = b1 ? "Male" : "Female"; // ternary operator
            string flighttype;
            bool button = oneway.Checked;
            flighttype = button ? "One-Way" : "Round Trip";
            // getting value from combo box
            firstnameerror.Clear();
            lastnameerror.Clear();
            emailerror.Clear();
            gendererror.Clear();
            ageerror.Clear();
            fromerror.Clear();
            toerror.Clear();
            flightclasserror.Clear();
            flighttypeerror.Clear();
            depdateerror.Clear();
            passporterror.Clear();
            // error provider code
            if (string.IsNullOrEmpty(firstnametextbox.Text) || !validatename(firstnametextbox.Text))
            {
                firstnameerror.Clear();
                firstnameerror.SetError(firstnametextbox, "please enter a valid First name");
            }
            if (string.IsNullOrEmpty(lastnametextbox.Text) || !validatename(lastnametextbox.Text))
            {
                lastnameerror.Clear();
                lastnameerror.SetError(lastnametextbox, "please enter a valid Last name");
            }
            if (string.IsNullOrEmpty(emailtextbox.Text) || !emailtextbox.Text.Contains('@') || !emailtextbox.Text.Contains('.') || emailtextbox.Text.Length>=80)
            {
                emailerror.Clear();
                emailerror.SetError(emailtextbox, "please enter a valid Email ");
            }
            if (string.IsNullOrEmpty(gender))
            {
                gendererror.Clear();
                gendererror.SetError(gendergroupbox, "please select you're gender");
            }
            if (string.IsNullOrEmpty(agecomboBox.Text) || (!agecomboBox.Text.Equals("18+") && !agecomboBox.Text.Equals("Below 18")))
            {
                ageerror.Clear();
                ageerror.SetError(agecomboBox, "please select a valid age");
            }
            if (string.IsNullOrEmpty(fromcomboBox.Text) || !fromcomboBox.Text.Equals("Addis Ababa"))
            {
                fromerror.Clear();
                fromerror.SetError(fromcomboBox, "please selected a valid departure");
            }

            if (string.IsNullOrEmpty(tocomboBox.Text) || !destinationexist(tocomboBox.Text))
            {
                toerror.Clear();
                toerror.SetError(tocomboBox, "please select you're to");
            }
            if (string.IsNullOrEmpty(flightclasscomboBox.Text) || (!flightclasscomboBox.Text.Equals("First class") && !flightclasscomboBox.Text.Equals("Economy class")))
            {
                flightclasserror.Clear();
                flightclasserror.SetError(flightclasscomboBox, "please selec you're flight class");
            }
             
            if (string.IsNullOrEmpty(flighttype) || (!flighttype.Equals("One-Way") && !flighttype.Equals("Round Trip")))
            {
                flighttypeerror.Clear();
                flighttypeerror.SetError(flightgroupbox, "please select you're flight group");
            }
            if (string.IsNullOrEmpty(departuredate.Text) || !validdeptime(tocomboBox.Text,departuredate.Text))
            {
                depdateerror.Clear();
                depdateerror.SetError(departuredate, "please select you're departure date");
            }
            if (string.IsNullOrEmpty(passporttextbox.Text) || !validatepassport(passporttextbox.Text))
            {
                passporterror.Clear();
                passporterror.SetError(passporttextbox, "please select you're passport number");
            }
            if (!string.IsNullOrEmpty(firstnametextbox.Text)
               && !string.IsNullOrEmpty(lastnametextbox.Text)
               && !string.IsNullOrEmpty(emailtextbox.Text)
               && !string.IsNullOrEmpty(passporttextbox.Text) && validatepassport(passporttextbox.Text)
               && !string.IsNullOrEmpty(flighttype) && (flighttype.Equals("One-Way") || flighttype.Equals("Round Trip"))
               && !string.IsNullOrEmpty(departuredate.Text) && validdeptime(tocomboBox.Text, departuredate.Text)
               && !string.IsNullOrEmpty(agecomboBox.Text) && (agecomboBox.Text.Equals("18+") || agecomboBox.Text.Equals("Below 18"))
               && !string.IsNullOrEmpty(gender)
               && !string.IsNullOrEmpty(fromcomboBox.Text) && fromcomboBox.Text.Equals("Addis Ababa")
               && !string.IsNullOrEmpty(tocomboBox.Text) && destinationexist(tocomboBox.Text)
               && !string.IsNullOrEmpty(flightclasscomboBox.Text) && (flightclasscomboBox.Text.Equals("First class") || flightclasscomboBox.Text.Equals("Economy class")))
            {
                firstnameerror.Clear();
                lastnameerror.Clear();
                emailerror.Clear();
                gendererror.Clear();
                ageerror.Clear();
                fromerror.Clear();
                toerror.Clear();
                flightclasserror.Clear();
                flighttypeerror.Clear();
                depdateerror.Clear();
                passporterror.Clear();
                double differenceprice=0;
                double firstclassvar = 1, economyclassvar = 0.7;
                int durationrate = 200;
                int noofhour = 0;
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("select dbo.howmanyhour(@dest,@deptime)", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    con.Open();
                    // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = tocomboBox.Text; //Defining the command parameter for usrname

                    cmd.Parameters.Add("@deptime", SqlDbType.DateTime).Value = DateTime.ParseExact(departuredate.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture); //Defining the command parameter for usrname
         
                    noofhour = Convert.ToInt32(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int


                }
                
                // flight price determining
                if (flightclasscomboBox.Text == "First class" && flighttype == "One-Way")
                {
                    price = (durationrate * firstclassvar * noofhour * 1);
                }
                if (flightclasscomboBox.Text == "Economy class" && flighttype == "Round Trip")
                {
                    price = (durationrate * economyclassvar * noofhour * 1.75);
                }
                if (flightclasscomboBox.Text == "First class" && flighttype == "Round Trip")
                {
                    price = (durationrate * firstclassvar * noofhour * 1.75 );
                }
                if (flightclasscomboBox.Text == "Economy class" && flighttype == "One-Way")
                {
                    price = (durationrate * economyclassvar * noofhour * 1);
                }
                if (Viewbutton.Text.Equals("Save")) 
                {
                    double alreadypaid = 0;
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlCommand cmd = new SqlCommand("select dbo.howmuchpaid(@ticketid)", con);
                        // Sql Command stored procedure to insert successful Login into Login History on database
                        con.Open();
                        // Using parametrized query to avoid sql injection attack
                        cmd.Parameters.Add("@ticketid", SqlDbType.VarChar, 30).Value = enterticketidtextbox.Text; //Defining the command parameter for usrname
                        alreadypaid = Convert.ToDouble(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int
                    }
                    differenceprice = price - alreadypaid;
                    if (differenceprice > 0)
                    {
                        MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                  "\n" + "From:" + "                    " + fromcomboBox.Text +
                                   "\n" + "TO:" + "                    " + tocomboBox.Text +
                                "\n" + "Bill:" + "                          " + "$ " + differenceprice.ToString());
                    }
                    else if (differenceprice < 0)
                    {
                        MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                  "\n" + "From:" + "                    " + fromcomboBox.Text +
                                   "\n" + "TO:" + "                    " + tocomboBox.Text +
                                "\n" + "You will have a refund of amount $ " + differenceprice.ToString());
                    }
                    else if (differenceprice == 0)
                    {
                        MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                  "\n" + "From:" + "                    " + fromcomboBox.Text +
                                   "\n" + "TO:" + "                    " + tocomboBox.Text +
                                "\n" + "Price is eqal to past price $ " + differenceprice.ToString());
                    }
                   savechanges(alreadypaid+price);
                }
                if(Viewbutton.Text.Equals("View Price"))
                {
                    if (price == -1)
                    {
                        MessageBox.Show("Unable to show price right now. please try again");
                    }
                    else
                    {
                        MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                     "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                      "\n" + "From:" + "                    " + fromcomboBox.Text +
                                       "\n" + "TO:" + "                    " + tocomboBox.Text +
                                    "\n" + "Bill:" + "                          " + "$ " + price.ToString());
                        bookbutton.Visible = true;
                    }

                }
            }
        }

        private void savechanges(double totprice=0)
        {
            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "Male" : "Female"; // ternary operator

            string flighttype;
            bool button = oneway.Checked;
            flighttype = button ? "One-Way" : "Round trip";
            // getting value from combo box




            //////// validation for register

            // random number generator for flight id 
            Random r = new Random();

            // setting property of flight info
            bookinginfo bi = new bookinginfo
            {
                username = loginusername,
                firstname = firstnametextbox.Text,
                lastname = lastnametextbox.Text,
                email = emailtextbox.Text,
                passportnumber = passporttextbox.Text,
                from = fromcomboBox.Text,
                to = tocomboBox.Text,
                flightclass = flightclasscomboBox.Text,
                flighttype = flighttype,
                departuredate = DateTime.ParseExact(departuredate.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                age = agecomboBox.Text,
                bigender = gender,
                bookingprice = price,
            };
            int rowaffected = 0;
            if (totprice > 0)
            {
                rowaffected = bi.save(totprice, Convert.ToInt32(enterticketidtextbox.Text)); // saving the info
            }
            else
            {
                 rowaffected = bi.save(); // saving the info
            }
            if (rowaffected > 0)
            {
                MessageBox.Show("Flight Booked Sucessfully");
                ticketform tf = new ticketform();
                if (tf.flowLayoutPanel1.Controls.Count > 0)
                    tf.flowLayoutPanel1.Controls.RemoveAt(0);

                foreach (Control item in tf.flowLayoutPanel1.Controls.OfType<Ticket>().ToList())
                {
                    tf.flowLayoutPanel1.Controls.Remove(item);
                }
                foreach (var item in bookinginfo.getall())
                {
                    // setting the info we get from the user to the user control(ticket) 
                    Ticket tick = new Ticket();
                    tick.firstname = item.firstname;
                    tick.lastname = item.lastname;
                    tick.from = item.from;
                    tick.to = item.to;
                    tick.flightclass = item.flightclass;
                    tick.passportnumber = item.passportnumber;
                    tick.date = item.departuredate.ToString("yyyy-MM-dd HH:mm:ss");
                    String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                    //Declaring and Assigning Connection String
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlCommand cmd = new SqlCommand("select dbo.lastticketid()", con);
                        // Sql Command stored procedure to insert successful Login into Login History on database
                        con.Open();
                        tick.ticketid = Convert.ToInt32(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int

                    }

                    tf.flowLayoutPanel1.Controls.Add(tick);
                    tf.Show();

                }

                donebtn.Text = "Done";
            }
            else if (rowaffected == 0)
            {
                MessageBox.Show("Unable to book flight. Please Try Again");
            }
        }
        private void bookbutton_Click(object sender, EventArgs e)
        {
            int availseat;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.availseats(@dest, @deptime)", con);
                // Sql Command to add new registry on database
                con.Open(); //Opening Connection
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = tocomboBox.Text; //Defining the command parameter for usrname

                cmd.Parameters.Add("@deptime", SqlDbType.DateTime).Value = departuredate.Text;// Using parametrized query to avoid sql injection attack
                availseat = Convert.ToInt32(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int

            }
            if(availseat == 0)
            {
                MessageBox.Show("Flight Fully Booked choose another one");
            }
            else
            {
                savechanges();
            }
            
            
        }
        private bool validatename(string name) // Function to validate name
        {
            char[] namechar = name.ToCharArray(); // Converting String to char array
            if (string.IsNullOrEmpty(name)) // Selection of Empty String
            {
                return false;
            }
            else if (namechar.Length >= 20) // Selection of long name
            {
                return false;
            }
            else
            {
                for (int i = 0; i < namechar.Length; i++) // loop to find invalid character in name
                {
                    char c = namechar[i];
                    if (!(c >= 'A' && c <= 'z'))
                        return false;
                }
            }
            return true;
        }
        

        private bool validatepassport(string passport)
        {
            char[] passchar = passport.ToCharArray(); 
            if (passchar.Length >= 20) // Selection of long name
            {
                return false;
            }
            else
            {
                for (int i = 0; i < passchar.Length; i++) // loop to find invalid character in name
                {
                    char c = passchar[i];
                    if (!(c >= 'A' && c <= 'z') && !isnum(c.ToString()))
                        return false;
                }
            }
            return true;
        }
        private bool isnum(string inp)
        {
            try
            {
                int inpnum = Convert.ToInt32(inp);
            }
            catch
            {
                return false;
            }
            return true;
        }
        private bool destinationexist(string dest)
        {
            if (dest.Length > 30)
            {
                return false;
            }
            int existance = 0;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("destexist", con);
                // Sql Command to return if user exists on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = dest; //Defining the command parameter for usrname
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
        private bool validdeptime(string dest, string deptime)
        {
            try
            {
                
                Convert.ToDateTime(deptime);
               
            }
            catch
            {
                return false;
            }
            int existance = 0;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("deptimematch", con);
                // Sql Command to return if user exists on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = dest; //Defining the command parameter for usrname
                
                cmd.Parameters.Add("@deptime", SqlDbType.DateTime).Value = Convert.ToDateTime(deptime);
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
        private void tocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departuredate.Items.Clear();
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select * from deptime(@dest)", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                con.Open(); // Opening Connection
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = tocomboBox.Text; //Defining the command parameter for usrname
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    departuredate.Items.Add(((DateTime)dr["depdate"]).ToString("yyyy-MM-dd HH:mm:ss"));
                }
                dr.Close();
                departuredate.Text = null;
            }
        }

        private void firstnametextbox_TextChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void lastnametextbox_TextChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void emailtextbox_TextChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void passporttextbox_TextChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void agecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void flightclasscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void departuredate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void flightgroupbox_Enter(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void gendergroupbox_Enter(object sender, EventArgs e)
        {
            if (bookbutton.Visible == true)
            {
                donebtn.Text = "Cancel";
                bookbutton.Visible = false;
            }
            if (editinfobutton.Visible == true)
            {
                Viewbutton.Visible = true;
                Viewbutton.Text = "Save";
            }
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (donebtn.Text == "Cancel")
            {
                MessageBox.Show("Ticket booking Canceled");
            }

            else if(donebtn.Text == "Discard")
            {
                MessageBox.Show("Changes have been discarded");
            }
            this.Close();
        }

        private bool isticketyours(string username)
        {
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.isticketyours(@ticketid, @usrname)", con);
                // Sql Command to check if entered flight exist
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@ticketid", SqlDbType.VarChar, 1000).Value = enterticketidtextbox.Text; //Defining the command parameter for backup location
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 1000).Value = username; //Defining the command parameter for backup location
                con.Open(); //Opening Connection
                int existance = Convert.ToInt32(cmd.ExecuteScalar()); // Executing Query
                if (existance <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            enterticketiderror.Clear();
            if(!validticketid(enterticketidtextbox.Text))
            {
                enterticketiderror.Clear();
                enterticketiderror.SetError(enterticketidtextbox, "Enter a valid Ticket ID");
            }
            else if (!isticketyours(loginusername) && loginusername!="admin")
            {
                enterticketiderror.Clear();
                enterticketiderror.SetError(enterticketidtextbox, "Can only Search tickets you booked");
            }
            if (validticketid(enterticketidtextbox.Text) && (isticketyours(loginusername) || loginusername == "admin"))
            {
                enterticketiderror.Clear();
                enterticketidlabel.Visible = false;
                enterticketidtextbox.Visible = false;
                searchbutton.Visible = false;

                bookticketlabel.Text = "Edit Bookings";
                bookticketlabel.Parent = bgpic;
                bookticketlabel.BackColor = Color.Transparent;
                enterticketidlabel.Parent = bgpic;
                enterticketidlabel.BackColor = Color.Transparent;
                firstnamelabel.Visible = true;
                lastnamelabel.Visible = true;
                emaillabel.Visible = true;
                passportlabel.Visible = true;
                agelabel.Visible = true;
                genderlabel.Visible = true;
                gendergroupbox.Visible = true;
                fromlabel.Visible = true;
                tolabel.Visible = true;
                flightclasslabel.Visible = true;
                departurelabel.Visible = true;
                flighttypelabel.Visible = true;
                flightgroupbox.Visible = true;
                firstnametextbox.Visible = true;
                lastnametextbox.Visible = true;
                emailtextbox.Visible = true;
                passporttextbox.Visible = true;
                agecomboBox.Visible = true;
                fromcomboBox.Visible = true;
                tocomboBox.Visible = true;
                flightclasscomboBox.Visible = true;
                departuredate.Visible = true;
                Viewbutton.Visible = false;
                editinfobutton.Visible = true;
                deletebookingbutton.Visible = true;
                flightgroupbox.Enabled = false;
                firstnametextbox.ReadOnly = true;
                lastnametextbox.ReadOnly= true;
                emailtextbox.ReadOnly = true;
                passporttextbox.ReadOnly = true;
                agecomboBox.Enabled=false;
                fromcomboBox.Enabled=false;
                tocomboBox.Enabled=false;
                flightclasscomboBox.Enabled=false;
                departuredate.Enabled=false;
                bookinginfo bi = new bookinginfo();
                bi=bookinginfo.getall(Convert.ToInt32(enterticketidtextbox.Text));
                
                
                flightgroupbox.Visible = true;
                firstnametextbox.Text=bi.firstname;
                lastnametextbox.Text =bi.lastname;
                emailtextbox.Text=bi.email;
                passporttextbox.Text = bi.passportnumber;
                agecomboBox.Text = bi.age;
                fromcomboBox.Text = bi.from;
                string gender;
                bool b1 = bi.bigender.Equals("Male");
                if(bi.bigender.Equals("Male"))
                    Male.Checked = true;
                else if (bi.bigender.Equals("Female"))
                    Female.Checked = true;
                if (bi.flighttype.Equals("One-Way"))
                    oneway.Checked = true;
                else if (bi.flighttype.Equals("Round Trip"))
                    roundtrip.Checked = true;
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
                        tocomboBox.Items.Add(dr["city"]);
                    }
                    dr.Close();
                    tocomboBox.Text = bi.to;

                }
                flightclasscomboBox.Text = bi.flightclass;
                departuredate.Text = bi.departuredate.ToString("yyyy-MM-dd HH:mm:ss");
                Viewbutton.Visible = false;
            }

        }
        private bool validticketid(string ticketid)
        {
            try
            {
                Convert.ToInt32(enterticketidtextbox.Text);
            }
            catch
            {
                return false;
            }
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.ticketexist(@ticketid)", con);
                // Sql Command to check if entered flight exist
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@ticketid", SqlDbType.Int).Value = Convert.ToInt32(ticketid); //Defining the command parameter for backup location
                con.Open(); //Opening Connection
                int existance = Convert.ToInt32(cmd.ExecuteScalar()); // Executing Query
                if (existance <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void editinfobutton_Click(object sender, EventArgs e)
        {
            flightgroupbox.Enabled = true;
            firstnametextbox.ReadOnly = false;
            lastnametextbox.ReadOnly = false;
            emailtextbox.ReadOnly = false;
            passporttextbox.ReadOnly = false;
            agecomboBox.Enabled = true;
            tocomboBox.Enabled = true;
            flightclasscomboBox.Enabled = true;
            departuredate.Enabled = true;
            
            donebtn.Text = "Discard";
        }

        private void deletebookingbutton_Click(object sender, EventArgs e)
        {
            double alreadypaid;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.howmuchpaid(@ticketid)", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                con.Open();
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@ticketid", SqlDbType.VarChar, 30).Value = enterticketidtextbox.Text; //Defining the command parameter for usrname
                alreadypaid = Convert.ToDouble(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int

                SqlCommand cmd2 = new SqlCommand("deletebooking", con);
                // Sql Command to check if entered flight exist
                cmd2.CommandType = CommandType.StoredProcedure;
                // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@ticketid", SqlDbType.Int).Value = Convert.ToInt32(enterticketidtextbox.Text); //Defining the command parameter for backup location
                int rowaffected = cmd2.ExecuteNonQuery(); // Executing Query
                if (rowaffected <= 0)
                {
                    MessageBox.Show("Unable to delete at the moment. Please try again");
                }
                else if (rowaffected > 0)
                {
                    MessageBox.Show("Booking tickets deleted successfully.\nYou will get 70% of paid amount which is: $ " + (alreadypaid*0.7).ToString());
                    this.Close();
                }
            }
        }
    }
}
