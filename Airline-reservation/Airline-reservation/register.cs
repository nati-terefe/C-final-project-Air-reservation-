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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            // making the labels and the logo transparent 
            usernamelabel.Parent = phoneerror;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = phoneerror;
            passwordlabel.BackColor = Color.Transparent;
            firstnamelabel.Parent = phoneerror;
            firstnamelabel.BackColor = Color.Transparent;
            lastnamelabel.Parent = phoneerror;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = phoneerror;
            emaillabel.BackColor = Color.Transparent;
            phonelabel.Parent = phoneerror;
            phonelabel.BackColor = Color.Transparent;
            birthdatelabel.Parent = phoneerror;
            birthdatelabel.BackColor = Color.Transparent;
            genderlabel.Parent = phoneerror;
            genderlabel.BackColor = Color.Transparent;
            registerlabel.Parent = phoneerror;
            registerlabel.BackColor = Color.Transparent;
            profilepicturelabel.Parent = phoneerror;
            profilepicturelabel.BackColor = Color.Transparent;
            logo.Parent = phoneerror;
            logo.BackColor = Color.Transparent;
            hintlable.Parent = phoneerror;
            hintlable.BackColor = Color.Transparent;

            /////making the buttons transparent

            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = phoneerror;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            ////////////// register header button //////////////////
            registerheaderbutton.Parent = phoneerror;
            registerheaderbutton.BackColor = Color.Transparent;
            registerheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// About us header button //////////////////
            aboutheaderbutton.Parent = phoneerror;
            aboutheaderbutton.BackColor = Color.Transparent;
            aboutheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// contact us header button //////////////////
            contactheaderbutton.Parent = phoneerror;
            contactheaderbutton.BackColor = Color.Transparent;
            contactheaderbutton.FlatAppearance.BorderSize = 0;






        }

        private void upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();  // open file dialog   

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {

                profilepicture.Image = new Bitmap(open.FileName);// display image in picture box  

                //textBox1.Text = open.FileName;  // image file path  
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            
            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator
            

            registerbutton.BackColor = Color.Silver;
            donebutton.BackColor = Color.Red;
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
                emailerror.SetError(emailtextbox, "please enter Email name");
            }
            if (string.IsNullOrEmpty(phonetextbox.Text))
            {
                phonerror.SetError(phonetextbox,"please enter phone number");
            }
            
            if (string.IsNullOrEmpty(gendergroupbox.Text))
            {
                gendererror.SetError(gendergroupbox, "please enter gender");
            }
            if (string.IsNullOrEmpty(usernametextbox.Text))
            {
                usernameerror.SetError(usernametextbox, "please enter user name");
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text))
            {
                passworderror.SetError(passwordtextbox, "please enter password ");
            }
            if (string.IsNullOrEmpty(hinttextbox.Text))
            {
                hinterror.SetError(hinttextbox, "please enter hint");
            }
            registerstore rs = new registerstore
            {
                registerfirstname = firstnametextbox.Text,
                registerlastname = lastnametextbox.Text,
                registeremail = emailtextbox.Text,
                registerhint = hinttextbox.Text,
                registerphone = phonetextbox.Text,
                registerusername = usernametextbox.Text,
                registerpassword = passwordtextbox.Text,
                registergender = gender,
        };





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
            
            
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();

            c.Show();
            Hide();

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
