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
        }

        private void contactbutton_Click(object sender, EventArgs e) //Listener Function when contact button is clicked
        {
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                String query = "Insert into contactmessages(fname, lname, email, suggetion, sugdate) values(@fname,@lname,@email,@message, getdate()); ";
                SqlCommand cmd = new SqlCommand(query, con);
                // Sql Command to insert contact values to databse
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = usernametextbox.Text; //Defining the command parameter for fname
                cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lastnametextbox.Text; //Defining the command parameter for lname
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emailtextbox.Text; //Defining the command parameter for email
                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = messagetextbox.Text; //Defining the command parameter for message
                con.Open(); //Opening Connection
                int rowaffect = cmd.ExecuteNonQuery(); // Executing the Insert Query
                if (rowaffect > 0) // Selection for Successful Insert
                {
                    MessageBox.Show("Thank you for the message. We will contact you soon."); // Pop up Message
                }
                else // Selection for UnSuccessful Insert
                {
                    MessageBox.Show("Unable to contact please try again"); // Pop up Message
                }

            }
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
            /*contact c = new contact(); //Declaring new Contact Window
            c.Show(); //Show Contact Window
            Hide(); //Hide Currently Active Window*/
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e) //Listener Function when about button at the header is clicked
        {
            About a = new About(); //Declaring new About Window
            a.Show(); //Show About Window
            Hide(); //Hide Currently Active Window
        }

        private void donebutton_Click(object sender, EventArgs e) //Listener Function when done button at the header is clicked
        {
            this.Close(); //Close Current Window
        }
    }
}
