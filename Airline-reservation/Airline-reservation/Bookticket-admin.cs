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
            birthdatelabel.Parent = bgpic;
            birthdatelabel.BackColor = Color.Transparent;
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
            // getting the selected radio button
            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator

            string flighttype;
            bool button = oneway.Checked;
            flighttype = button ? "Oneway" : "Round trip";
            // getting value from combo box
            string selectedfrom = fromcomboBox.SelectedItem.ToString();
            string selectedto = tocomboBox.SelectedItem.ToString();
            string flightclass = flightclasscomboBox.SelectedItem.ToString();
            string selectedage = agecomboBox.SelectedItem.ToString();
            string selecteddate = departuredate.Value.ToString();

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
                flightinfo fi = new flightinfo
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

                fi.save(); // saving the info

                ticketform tf = new ticketform();
                if (tf.flowLayoutPanel1.Controls.Count > 0)
                    tf.flowLayoutPanel1.Controls.RemoveAt(0);

                foreach (Control item in tf.flowLayoutPanel1.Controls.OfType<Ticket>().ToList())
                {
                    tf.flowLayoutPanel1.Controls.Remove(item);
                }
                foreach (var item in flightinfo.getall())
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

                    MessageBox.Show(item.departuredate);

                    //tick.Show();
                    //tf.Show();
                    tf.flowLayoutPanel1.Controls.Add(tick);
                    tf.Show();
                }





                //add verification here
                // ticket form will display
               // ticketform t = new ticketform();
                //t.Show();
            }
            }
        }
    }

