using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_reservation
{
    public partial class Bookticket_admin : Form
    {
        public Bookticket_admin()
        {
            InitializeComponent();
        }

        private void Bookticket_admin_Load(object sender, EventArgs e)
        {






            // making the labels and the logo transparent 


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
            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent;
            //making some of the labels, text box's and combobox invisiable unitl next button is pushed 


            //this.savebutton.Visible = true;

        }

        private void bookbutton_Click(object sender, EventArgs e)
        {

            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator

            string flighttype;
            bool button = oneway.Checked;
            flighttype = button ? "Oneway" : "Round trip";
            // getting value from combo box
            string selectedfrom = fromcomboBox.Text.ToString();

            string selectedto = tocomboBox.Text.ToString();
            string flightclass = flightclasscomboBox.Text.ToString();
            string selectedage = agecomboBox.Text.ToString();
            string selecteddate = departuredate.Text.ToString();
            firstnameerror.Clear(); // Clearing firstnameerror
            lastnameerror.Clear(); // Clearing lastnameerror
            emailerror.Clear(); // Clearing emailerror
            gendererror.Clear(); // Clearing gendererror

            if (!validatename(firstnametextbox.Text))  // Error of invalid first name
            {
                firstnameerror.Clear(); // Clearing firstnameerror
                firstnameerror.SetError(firstnametextbox, "Please enter a valid First name"); // Setting firstnameerror message
            }
            if (!validatename(lastnametextbox.Text)) // Error of invalid last name
            {
                lastnameerror.Clear(); // Clearing lastnameerror
                lastnameerror.SetError(lastnametextbox, "Please enter a valid Last name"); // Setting lastnameerror message
            }
            if (string.IsNullOrEmpty(emailtextbox.Text) || !emailtextbox.Text.Contains('@') || !emailtextbox.Text.Contains('.')) // Error of invalid email
            {
                emailerror.Clear(); // Clearing emailerror
                emailerror.SetError(emailtextbox, "Please enter a valid Email"); // Setting emailerror message
            }
            if (string.IsNullOrEmpty(gender)) // Error of unselected gender
            {
                gendererror.Clear(); // Clearing gendererror
                gendererror.SetError(gendergroupbox, "Please enter you're gender"); // Setting gendererror message
            }


            //////// validation for register
            if (!string.IsNullOrEmpty(firstnametextbox.Text)
                && !string.IsNullOrEmpty(lastnametextbox.Text)
                && !string.IsNullOrEmpty(emailtextbox.Text)
                && !string.IsNullOrEmpty(passporttextbox.Text)
                && !string.IsNullOrEmpty(flighttype)
                && !string.IsNullOrEmpty(selectedage)
                && !string.IsNullOrEmpty(gender)
                && !string.IsNullOrEmpty(selectedfrom)
                && !string.IsNullOrEmpty(selectedto)
                && !string.IsNullOrEmpty(flightclass))
            {
                // random number generator for flight id 
                Random r = new Random();

                // setting property of flight info
                bookinginfo bi = new bookinginfo
                {
                    firstname = firstnametextbox.Text,
                    lastname = lastnametextbox.Text,
                    email = emailtextbox.Text,
                    passportnumber = passporttextbox.Text,
                    from = selectedfrom,
                    to = selectedto,
                    flightclass = flightclass,
                    flighttype = flighttype,
                    departuredate = departuredate.Value.ToString(),
                    age = selectedage,
                    gender = gender,
                    flightid = r.Next().ToString(),


                };

                bi.save(); // saving the info

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
                    tick.date = item.departuredate;



                    //tick.Show();
                    //tf.Show();
                    tf.flowLayoutPanel1.Controls.Add(tick);
                    tf.Show();

                }
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
        private bool validatephone(String phone) // Function to validate a phone
        {
            char[] phonechar = phone.ToCharArray(); // Changing the accepting string to character array
            if (string.IsNullOrEmpty(phone))// Selection of Empty String
            {
                return false;
            }
            else if (phonechar.Length < 10 || phonechar.Length > 15) // Selecting invalid inputs of being less than 10 or greater than 15 long
            {
                return false;
            }
            for (int i = 0; i < phonechar.Length; i++) //Iterating on array looking for invalid input
            {
                if (phonechar[i] == ' ' || (phonechar[i] >= 'A' && phonechar[i] <= 'z')) // Selecting invalid inputs of being a letter or space
                {
                    return false;
                }
            }
            return true;
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            string gender;
            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator
            string flighttype;
            bool button = oneway.Checked;
            flighttype = button ? "Oneway" : "Round trip";
            // getting value from combo box
            string selectedfrom = fromcomboBox.Text.ToString();
            string selectedto = tocomboBox.Text.ToString();
            string flightclass = flightclasscomboBox.Text.ToString();
            string selectedage = agecomboBox.Text.ToString();
            string selecteddate = departuredate.Text.ToString();
            MessageBox.Show(selectedto);

            // error provider code
            if (string.IsNullOrEmpty(firstnametextbox.Text))
            {
                firstnameerror.SetError(firstnametextbox, "please enter First name");
            }
            if (string.IsNullOrEmpty(lastnametextbox.Text))
            {
                lastnameerror.SetError(lastnametextbox, "please enter Last name");
            }
            if (string.IsNullOrEmpty(emailtextbox.Text))
            {
                emailerror.SetError(emailtextbox, "please enter you're Email ");
            }
            if (string.IsNullOrEmpty(gender))
            {
                gendererror.SetError(gendergroupbox, "please select you're gender");
            }

            if (string.IsNullOrEmpty(selectedfrom))
            {
                fromerror.SetError(fromcomboBox, "please enter you're from");
            }

            if (string.IsNullOrEmpty(selectedto))
            {
                toerror.SetError(tocomboBox, "please select you're to");
            }
            if (string.IsNullOrEmpty(flightclass))
            {
                flightclasserror.SetError(flightclasscomboBox, "please selec you're flight class");
            }
            if (string.IsNullOrEmpty(selectedage))
            {
                ageerror.SetError(agecomboBox, "please select you're age group");
            }
            if (string.IsNullOrEmpty(flighttype))
            {
                flighttypeerror.SetError(flightgroupbox, "please select you're flight group");
            }
            if (string.IsNullOrEmpty(selecteddate))
            {
                departureerror.SetError(departuredate, "please select you're departure date");
            }
            if (string.IsNullOrEmpty(passporttextbox.Text))
            {
                flighttypeerror.SetError(passporttextbox, "please select you're passport number");
            }

            if (!string.IsNullOrEmpty(firstnametextbox.Text)
               && !string.IsNullOrEmpty(lastnametextbox.Text)
               && !string.IsNullOrEmpty(emailtextbox.Text)
               && !string.IsNullOrEmpty(passporttextbox.Text)
               && !string.IsNullOrEmpty(flighttype)
               && !string.IsNullOrEmpty(selectedage)
               && !string.IsNullOrEmpty(gender)
               && !string.IsNullOrEmpty(selectedfrom)
               && !string.IsNullOrEmpty(selectedto)
               && !string.IsNullOrEmpty(flightclass))
            {
                // flight price determining
                if (flightclass == "First class" && flighttype == "Oneway")
                {
                    MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                  "\n" + "From:" + "                    " + selectedfrom +
                                   "\n" + "TO:" + "                    " + selectedto +
                                "\n" + "Bill:" + "                          " + "101,000");
                }
                if (flightclass == "Economy class" && flighttype == "Round trip")
                {
                    MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                 "\n" + "From:" + "                    " + selectedfrom +
                                   "\n" + "TO:" + "                    " + selectedto +
                                "\n" + "Bill:" + "                          " + "120,000");
                }
                if (flightclass == "First class" && flighttype == "Round trip")
                {
                    MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                 "\n" + "From:" + "                    " + selectedfrom +
                                   "\n" + "TO:" + "                    " + selectedto +
                                "\n" + "Bill:" + "                          " + "250,000");
                }
                if (flightclass == "Economy class" && flighttype == "Oneway")
                {
                    MessageBox.Show("First name:" + "                      " + firstnametextbox.Text + "  " +
                                 "\n" + "Last name:" + "                    " + lastnametextbox.Text +
                                 "\n" + "From:" + "                    " + selectedfrom +
                                   "\n" + "TO:" + "                    " + selectedto +
                                "\n" + "Bill:" + "                          " + "85,000");
                }
                this.bookbutton.Visible = true;
                this.Viewbutton.Visible = true;
            }
            bookbutton.Visible = true;
        }
    }
}
