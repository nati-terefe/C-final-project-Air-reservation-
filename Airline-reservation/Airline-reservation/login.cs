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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {  // making the labels and logo transparent 
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            //making the header buttons transparent
            //menuStrip1.Parent = pictureBox1;
            //menuStrip1.BackColor = Color.Transparent;

            /////making the buttons transparent
            forgotbutton.Parent = pictureBox1;
            forgotbutton.BackColor = Color.Transparent;
            forgotbutton.FlatAppearance.BorderSize = 0;// removing the boarder of the button
            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent=pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize=0;
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

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextbox_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            register screen = new register();
            screen.MdiParent = this;
            screen.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            
            contact screen = new contact();
            screen.MdiParent = this;
            screen.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
            forgotpassword f = new forgotpassword();
            f.Show();
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

        private void aboutheaderbutton_Click(object sender, EventArgs e)
        {
            contact c = new contact();
            About a = new About();
            a.Show();
            Hide();
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {
            contact c = new contact();
            About a = new About();
             c.Show();
            Hide();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=usernametextbox.Text;
            string password=passwordtextbox.Text;
            if (password == "admin" && username=="admin")
            {
                Homepage_admin ha = new Homepage_admin();
                ha.Show();
            }
            else if (password == "client"&&username == "client")
            {
                Homepage_client hc = new Homepage_client();
                hc.Show();
            }
            loginstore ls = new loginstore
            {
                loginusername = usernametextbox.Text,
                loginpassword = passwordtextbox.Text,
            };
            if (string.IsNullOrEmpty(usernametextbox.Text))
            {
                usernameerror.SetError(usernametextbox, "user name can't be left empty");
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text))
            {
                passworderror.SetError(passwordtextbox, "password can't be left empty");
            }
             // login validation
            if(!string.IsNullOrEmpty(usernametextbox.Text) && !string.IsNullOrEmpty(passwordtextbox.Text))
            {
                // the main page
            }
        }
    }
}
