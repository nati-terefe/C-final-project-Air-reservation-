using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
// Import Statments

namespace Airline_reservation
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void contact_Load(object sender, EventArgs e) // Function for Initial loading of About Window
        {
            // First Name Label
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor = Color.Transparent; // Making Button Transparent
            // Last Name Label
            lastnamelabel.Parent = pictureBox1;
            lastnamelabel.BackColor = Color.Transparent; // Making Button Transparent
            // Email Label
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent; // Making Button Transparent
            // Message Label
            messagelabel.Parent = pictureBox1;
            messagelabel.BackColor = Color.Transparent; // Making Button Transparent
            // Logo
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent; // Making Button Transparent
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
            contactheaderbutton.FlatAppearance.BorderSize = 1; // removing the boarder of the button
            // FAQ Header Button 
            faqheaderbuttom.Parent = pictureBox1;
            faqheaderbuttom.BackColor = Color.Transparent; // Making Button Transparent
            faqheaderbuttom.FlatAppearance.BorderSize = 0; // Removing Border of Button
        }

        private void contactbutton_Click(object sender, EventArgs e) //Listener Function when contact button is clicked
        {
            firstnameerror.Clear(); // Clearing firstnameerror
            lastnameerror.Clear(); // Clearing lastnameerror
            emailerror.Clear(); // Clearing emailerror
            messageerror.Clear(); // Clearing messageerror
            // Error Provider List
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
            if (string.IsNullOrEmpty(messagetextbox.Text)) // Error of empty message
            {
                messageerror.Clear(); // Clearing messageerror
                messageerror.SetError(messagetextbox, "Enter you're message here"); // Setting messageerror message
            }
            // validation for contact us page 
            if (validatename(firstnametextbox.Text) && validatename(lastnametextbox.Text) && !string.IsNullOrEmpty(emailtextbox.Text) && emailtextbox.Text.Contains('@') && emailtextbox.Text.Contains('.') && !string.IsNullOrEmpty(messagetextbox.Text))
            { // Selection for all filleds filled accordingly
                contactstore cs = new contactstore // Declaring contact store object
                {
                    contactfirstname = firstnametextbox.Text, // Assigning values to property
                    contactlastname = lastnametextbox.Text, // Assigning values to property
                    contactemail = emailtextbox.Text, // Assigning values to property
                    contactmessage = messagetextbox.Text, // Assigning values to property
                };
                int rowaffected=cs.save(); // Saving Progress on cs object and database messages
                if(rowaffected>0)
                {
                    MessageBox.Show("We will contact you soon."); // Pop Up message
                }
                else
                {
                    MessageBox.Show("Unable to contact right now. Please Try Again"); // Pop Up message
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
            // MessageBox.Show("You're already here"); // Popup Message
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e) //Listener Function when about button at the header is clicked
        {
            About a = new About(); //Declaring new About Window
            a.Show(); //Show About Window
            Hide(); //Hide Currently Active Window
        }

        private void faqheaderbuttom_Click(object sender, EventArgs e) //Listener Function when FAQ Header button is clicked
        {
            FAQ f = new FAQ(); //Declaring new FAQ Window
            f.Show(); //Show FAQ Window
            Hide(); //Hide Currently Active Window
        }

        private void donebutton_Click(object sender, EventArgs e) //Listener Function when done button at the header is clicked
        {
            this.Close(); //Close Current Window
        }
    }
}
