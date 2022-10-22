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
            registerlabel.Parent = bgpic;
            registerlabel.BackColor = Color.Transparent;
            profilepicturelabel.Parent = bgpic;
            profilepicturelabel.BackColor = Color.Transparent;
            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent;
            hintlable.Parent = bgpic;
            hintlable.BackColor = Color.Transparent;

            /////making the buttons transparent

            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = bgpic;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            ////////////// register header button //////////////////
            registerheaderbutton.Parent = bgpic;
            registerheaderbutton.BackColor = Color.Transparent;
            registerheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// About us header button //////////////////
            aboutheaderbutton.Parent = bgpic;
            aboutheaderbutton.BackColor = Color.Transparent;
            aboutheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// contact us header button //////////////////
            contactheaderbutton.Parent = bgpic;
            contactheaderbutton.BackColor = Color.Transparent;
            contactheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// faq header button //////////////////
            faqheaderbuttom.Parent = bgpic;
            faqheaderbuttom.BackColor = Color.Transparent;
            faqheaderbuttom.FlatAppearance.BorderSize = 0;






        }

        private void upload_Click(object sender, EventArgs e)
        {
            
            registerstore s = new registerstore();

            OpenFileDialog open = new OpenFileDialog();  // open file dialog   

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {

                profilepicture.Image = new Bitmap(open.FileName);// display image in picture box  

               piclocation.Text= open.FileName;  // image file path  
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {// getting the selected radio button

            string gender;

            bool b1 = Male.Checked;
            gender = b1 ? "male" : "female"; // ternary operator
            

            

            //error provider code
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
                emailerror.SetError(emailtextbox, "please enter  your're Email name");
            }
            if (string.IsNullOrEmpty(phonetextbox.Text))
            {
                phonerror.SetError(phonetextbox,"please enter you're phone number");
            }
            
            if (string.IsNullOrEmpty(gender))
            {
                gendererror.SetError(gendergroupbox, "please enter you're gender");
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
                    registebirthdate = birthdate.Value.ToString(),
                    role = "client",
                   
                };
                rs.save();

                registerbutton.BackColor = Color.Silver;
                donebutton.BackColor = Color.Red;
                MessageBox.Show("You have been registered");
            }
}

    private void loginheaderbutton_Click(object sender, EventArgs e)
        {

            
            login l = new login();
            l.Show();
            Hide();






        }

        private void registerheaderbutton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {
        
            contact c = new contact();
         

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

        private void faqheaderbuttom_Click(object sender, EventArgs e)
        {
            FAQ f = new FAQ();
            f.Show();
            Hide();
        }
    }
}
