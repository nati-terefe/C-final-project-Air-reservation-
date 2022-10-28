using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import Statments

namespace Airline_reservation
{
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void FAQ_Load(object sender, EventArgs e) // Function for Initial loading of About Window
        {
            // About Label
            faqlabel.Parent = pictureBox1;
            faqlabel.BackColor = Color.Transparent; // Making Button Transparent
            // Logo
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent; // Making Button Transparent
            // About Us Body
            aboutusbodylabel.Parent = pictureBox1;
            aboutusbodylabel.BackColor = Color.Transparent; // Making Button Transparent
            // Login Header Button
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // Register Header Button
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            registerheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // About Us Header Button
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            aboutheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // Contact Us Header Button
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            contactheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // FAQ Header Button 
            faqheaderbuttom.Parent = pictureBox1;
            faqheaderbuttom.BackColor = Color.Transparent; // Making Button Transparent
            faqheaderbuttom.FlatAppearance.BorderSize = 1; // Removing Border of Button
        }

        private void loginheaderbutton_Click(object sender, EventArgs e) //Listener Function when login button at the header is clicked
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
            Hide(); //Hide Currently Active Window
        }

        private void registerheaderbutton_Click(object sender, EventArgs e) //Listener Function when register button at the header is clicked
        {
            register r = new register(); //Declaring new Register Window
            r.Show(); //Show Register Window
            Hide(); //Hide Currently Active Window
        }

        private void contactheaderbutton_Click(object sender, EventArgs e) //Listener Function when contact button at the header is clicked
        {
            contact c = new contact(); //Declaring new Contact Window
            c.Show(); //Show Contact Window
            Hide(); //Hide Currently Active Window
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e) //Listener Function when about button at the header is clicked
        {
            /*About a = new About(); //Declaring new About Window
            a.Show(); //Show About Window
            Hide(); //Hide Currently Active Window*/
        }

        private void donebutton_Click(object sender, EventArgs e) //Listener Function when done button at the header is clicked
        {
            this.Close(); //Close Current Window
        }
    }
}
