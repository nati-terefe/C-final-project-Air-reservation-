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
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void contact_Load(object sender, EventArgs e)
        {
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor = Color.Transparent;
            lastnamelabel.Parent = pictureBox1;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent;
            messagelabel.Parent = pictureBox1;
            messagelabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;


            /////making the buttons transparent
           ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0;// removing the boarder of the button
            ////////////// register header button //////////////////
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent;
            registerheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// About us header button //////////////////
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent;
            aboutheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// contact us header button //////////////////
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent;
            contactheaderbutton.FlatAppearance.BorderSize = 0;

        }

        private void contactbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(firstnamelabel.Text))
            {
                firstnameerror.SetError(firstnametextbox, "first name can't be left empty");
            }
            if (string.IsNullOrEmpty(lastnametextbox.Text))
            {
                lastnameerror.SetError(lastnametextbox, "last name can't be left empty");
            }
            if (string.IsNullOrEmpty(emailtextbox.Text))
            {
                emailerror.SetError(emailtextbox, "email can't be left empty");
            }
            if (string.IsNullOrEmpty(messagetextbox.Text))
            {
                messageerror.SetError(messagetextbox, "enter you're message here");
            }
            // validation for contact us page 
            if (!string.IsNullOrEmpty(firstnametextbox.Text) && !string.IsNullOrEmpty(lastnametextbox.Text) && !string.IsNullOrEmpty(emailtextbox.Text) && !string.IsNullOrEmpty(messagetextbox.Text))
            {
                MessageBox.Show("We will contact you soon.");
            }
        }

        private void loginheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            l.Show();
            Hide();
        }

        private void registerheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            r.Show();
            Hide();
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {
            /*register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            c.Show();
            Hide(); */
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            a.Show();
            Hide();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
