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
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent;
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor=Color.Transparent;
            lastnamelabel.Parent= pictureBox1;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent;
            phonelabel.Parent= pictureBox1;
            phonelabel.BackColor = Color.Transparent;
            birthdatelabel.Parent = pictureBox1;
            birthdatelabel.BackColor = Color.Transparent;
            genderlabel.Parent = pictureBox1;
            genderlabel.BackColor = Color.Transparent;
            registerlabel.Parent = pictureBox1;
            registerlabel.BackColor = Color.Transparent;
            profilepicturelabel.Parent = pictureBox1;
            profilepicturelabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            hintlable.Parent = pictureBox1;
            hintlable.BackColor = Color.Transparent;

            /////making the buttons transparent

            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
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
            string firstname, lastname, email, hint, phone, username, password, bd;
            firstname = firstnametextbox.Text;
            lastname = lastnametextbox.Text;
            email=emailtextbox.Text;
            hint=hinttextbox.Text;
            phone=phonetextbox.Text;
            username = usernametextbox.Text;
            password = passwordtextbox.Text;
            bd = birthdate.ToString();
        }

        private void loginheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            l.Show();
            

            
            
            
            
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
            
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();

            a.Show();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
