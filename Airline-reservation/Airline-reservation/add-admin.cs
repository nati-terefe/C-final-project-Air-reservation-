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
    public partial class add_admin : Form
    {
        public add_admin()
        {
            InitializeComponent();
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {

        }

        private void aboutheaderbutton_Click(object sender, EventArgs e)
        {

        }

        private void registerheaderbutton_Click(object sender, EventArgs e)
        {

        }

        private void loginheaderbutton_Click(object sender, EventArgs e)
        {

        }

        private void add_admin_Load(object sender, EventArgs e)
        {
            // making the labels and the logo transparent 
            usernamelabel.Parent = bgpic;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = bgpic;
            passwordlabel.BackColor = Color.Transparent;
            firstnamelabel.Parent = bgpic;
            firstnamelabel.BackColor = Color.Transparent;
            lastnamelabel.Parent = bgpic;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = bgpic;
            emaillabel.BackColor = Color.Transparent;
            phonelabel.Parent = bgpic;
            phonelabel.BackColor = Color.Transparent;
            birthdatelabel.Parent = bgpic;
            birthdatelabel.BackColor = Color.Transparent;
            genderlabel.Parent = bgpic;
            genderlabel.BackColor = Color.Transparent;
            addadminlabel.Parent = bgpic;
            addadminlabel.BackColor = Color.Transparent;
            profilepicturelabel.Parent = bgpic;
            profilepicturelabel.BackColor = Color.Transparent;
            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent;
            hintlable.Parent = bgpic;
            hintlable.BackColor = Color.Transparent;
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {

            registerstore s = new registerstore();

            OpenFileDialog open = new OpenFileDialog();  // open file dialog   

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {

                profilepicture.Image = new Bitmap(open.FileName);// display image in picture box  

                piclocation.Text = open.FileName;  // image file path  
            }
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator


            createbutton.BackColor = Color.Silver;
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
                emailerror.SetError(emailtextbox, "please enter Email ");
            }
            if (string.IsNullOrEmpty(phonetextbox.Text))
            {
                phonerror.SetError(phonetextbox, "please enter phone number");
            }

            if (string.IsNullOrEmpty(gender))
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
            
              
            //////// validation for register
            if (!string.IsNullOrEmpty(firstnametextbox.Text)
                && !string.IsNullOrEmpty(lastnametextbox.Text)
                && !string.IsNullOrEmpty(emailtextbox.Text)
                && !string.IsNullOrEmpty(hinttextbox.Text)
                && !string.IsNullOrEmpty(birthdate.ToString())
                && !string.IsNullOrEmpty(piclocation.Text)
                && !string.IsNullOrEmpty(phonetextbox.Text)
                && !string.IsNullOrEmpty(passwordtextbox.Text)
                && !string.IsNullOrEmpty(gender)
                && !string.IsNullOrEmpty(usernametextbox.Text))
            {

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
                    registerprofilepic = piclocation.Text,
                    registebirthdate = birthdate.ToString(),
                    role = "admin",



                };
                MessageBox.Show("Admin has been added");
            }
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

