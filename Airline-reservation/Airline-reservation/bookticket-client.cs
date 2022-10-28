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
    public partial class bookticket : Form
    {
        public bookticket()
        {
            InitializeComponent();
        }

        private void bookticket_Load(object sender, EventArgs e)
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
            this.fromcomboBox.Visible = false;
            this.tocomboBox.Visible = false;
            this.flightgroupbox.Visible = false;
            this.flightgroupbox.Visible = false;
            this.flightclasscomboBox.Visible = false;
            this.departuredate.Visible = false;
            ///
            this.fromlabel.Visible = false;
            this.tolabel.Visible = false;
            this.flightclasslabel.Visible = false;
            this.flighttypelabel.Visible = false;
            this.flightclasslabel.Visible = false;
            this.departurelabel.Visible = false;
            //making the book button invisible
            this.bookbutton.Visible = false;


        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            // getting the selected radio button
            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator
            string age = agecomboBox.SelectedText.ToString();

            // error provider for the visible one's
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
            if (string.IsNullOrEmpty(passporttextbox.Text))
            {
                flighttypeerror.SetError(passporttextbox, "please select you're passport number");
            }


            if (string.IsNullOrEmpty(age))
            {
                ageerror.SetError(agecomboBox, "please select you're age group");
            }

            // varification before the book button appears

            if (!string.IsNullOrEmpty(firstnametextbox.Text)
                && !string.IsNullOrEmpty(lastnametextbox.Text)
                && !string.IsNullOrEmpty(emailtextbox.Text)
                && !string.IsNullOrEmpty(passporttextbox.Text)

                && !string.IsNullOrEmpty(gender))
            {


                // making the book button visiable when next button is clicked
                this.Viewbutton.Visible = true;
                this.nextbutton.Visible = false;

                //making some of the labels, text box's and combobox visible when next button is pushed 
                this.fromcomboBox.Visible = true;
                this.tocomboBox.Visible = true;
                this.flightgroupbox.Visible = true;
                this.flightgroupbox.Visible = true;
                this.flightclasscomboBox.Visible = true;
                this.departuredate.Visible = true;
                ///
                this.fromlabel.Visible = true;
                this.tolabel.Visible = true;
                this.flightclasslabel.Visible = true;
                this.flighttypelabel.Visible = true;
                this.flightclasslabel.Visible = true;
                this.departurelabel.Visible = true;

                // making the personal info labels and textbox's etc.. invisible when the next button is pushed
                this.firstnamelabel.Visible = false;
                this.lastnamelabel.Visible = false;
                this.agelabel.Visible = false;
                this.genderlabel.Visible = false;
                this.emaillabel.Visible = false;
                this.passportlabel.Visible = false;
                ///
                this.firstnametextbox.Visible = false;
                this.lastnametextbox.Visible = false;
                this.agecomboBox.Visible = false;
                this.gendergroupbox.Visible = false;
                this.emailtextbox.Visible = false;
                this.passporttextbox.Visible = false;

            }

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
            string selectedfrom = fromcomboBox.Text.ToString();

            string selectedto = tocomboBox.Text.ToString();
            string flightclass = flightclasscomboBox.Text.ToString();
            string selectedage = agecomboBox.Text.ToString();
            string selecteddate = departuredate.Text.ToString();



            // error provider for the rest of them


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
                flightclasserror.SetError(flightclasscomboBox, "please select you're flight class");
            }

            if (string.IsNullOrEmpty(flighttype))
            {
                flighttypeerror.SetError(flightgroupbox, "please select you're flight group");
            }
            if (string.IsNullOrEmpty(selecteddate))
            {
                departureerror.SetError(departuredate, "please select you're departure date");
            }



            if (!string.IsNullOrEmpty(flighttype)
               && !string.IsNullOrEmpty(selectedage)
               && !string.IsNullOrEmpty(selectedfrom)
               && !string.IsNullOrEmpty(selectedto)
               && !string.IsNullOrEmpty(flightclass))
            {




                // random number generator for flight id 
                Random r = new Random();

                // setting the property of flight info
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


                    tf.flowLayoutPanel1.Controls.Add(tick);
                    tf.Show();
                }

               
            }



            
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {

            // getting the selected radio button
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



            if (!string.IsNullOrEmpty(flighttype)
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
               
               
            }
        }
    }
}
