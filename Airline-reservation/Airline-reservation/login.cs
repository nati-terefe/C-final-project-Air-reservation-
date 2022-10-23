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
// Import Statments

namespace Airline_reservation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e) // Function for Initial loading of Login Window
        {   // Usename Label
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Password Label
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Logo
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent; // Making Logo Transparent
            // Forgot Password Button
            forgotbutton.Parent = pictureBox1;
            forgotbutton.BackColor = Color.Transparent; // Making Button Transparent
            forgotbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // login Header Button 
            loginheaderbutton.Parent=pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            loginheaderbutton.FlatAppearance.BorderSize=1; // Creating Border of Button to show its the current window
            loginheaderbutton.FlatAppearance.BorderColor = Color.Gray; // Making Border color gray
            // Register Header Button
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            registerheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // About Us Header Button
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            aboutheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // Contact Us Header Button 
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            contactheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
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

        private void forgotbutton_Click(object sender, EventArgs e) //Listener Function when forgot password button is clicked
        {
            forgotpassword f = new forgotpassword(); //Declaring new Forgot Password Window
            f.Show(); //Show forgot password Window
        }

        private void registerheaderbutton_Click(object sender, EventArgs e) //Listener Function when register button at the header is clicked
        {
            register r = new register(); //Declaring new Register Window
            r.Show(); //Show Register Window
            Hide(); //Hide Currently Active Window
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e) //Listener Function when about button at the header is clicked
        {
            About a = new About(); //Declaring new About Window
            a.Show(); //Show About Window
            Hide(); //Hide Currently Active Window
        }

        private void contactheaderbutton_Click(object sender, EventArgs e) //Listener Function when contact button at the header is clicked
        {
            contact c = new contact(); //Declaring new Contact Window
            c.Show(); //Show Contact Window
            Hide(); //Hide Currently Active Window
        }

        private void closebutton_Click(object sender, EventArgs e) //Listener Function when close button is clicked
        {
            this.Close(); //Close Current Window
        }

        private void loginbutton_Click(object sender, EventArgs e) //Listener Function when login button is clicked
        {
            string username = usernametextbox.Text; //Declaring Variable and Assigning
            string password = passwordtextbox.Text; //Declaring Variable and Assigning
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing Psername Error Provider
            if (string.IsNullOrEmpty(usernametextbox.Text)) //Selection for Empty Username
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                usernameerror.SetError(usernametextbox, "User name can't be empty"); //Setting Username Error Provider
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text)) //Selection for Empty Password
            {
                passworderror.Clear(); //Clearing Psername Error Provider
                passworderror.SetError(passwordtextbox, "Password can't be empty"); //Setting Password Error Provider
            }
            if (!string.IsNullOrEmpty(usernametextbox.Text) && !string.IsNullOrEmpty(passwordtextbox.Text)) //Selection for Non Empty Username and Password
            {
                if (Convert.ToInt32(usernametextbox.Text.ToString().Length) < 4) //Selection for Short Username
                {
                    usernameerror.Clear(); //Clearing Username Error Provider
                    usernameerror.SetError(usernametextbox, "Username must at least be 4 characters long"); //Setting Username Error Provider
                }
                if (Convert.ToInt32(usernametextbox.Text.ToString().Length) < 4) //Selection for Short Password
                {
                    passworderror.Clear(); //Clearing Psername Error Provider
                    passworderror.SetError(passwordtextbox, "Password must at least be 4 characters long"); //Setting Password Error Provider
                }
                else if (usernametextbox.Text.Length > 4 && passwordtextbox.Text.Length > 4) //Selection for Non Short Username and Password
                {
                    usernameerror.Clear(); //Clearing Username Error Provider
                    passworderror.Clear(); //Clearing Psername Error Provider
                    String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                    //Declaring and Assigning Connection String
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlCommand cmd = new SqlCommand("select rol from login where usrname='" + usernametextbox.Text + "' and passwd='" + passwordtextbox.Text + "'", con);
                        // Sql Command to return rol of the inserted login info from database
                        con.Open(); //Opening Connection
                        var role = Convert.ToInt32(cmd.ExecuteScalar()); // Converting returned type of object to int
                        if (role == 1) // Selection of Admins
                        {
                            SqlCommand cmd2 = new SqlCommand("Insert into loginhistory values('" + usernametextbox.Text + "', " + role + ", Getdate());", con);
                            // Sql Command to insert successful Login into Login History on database
                            int rowaffected = cmd2.ExecuteNonQuery(); // Executing the Insert Query
                            if (rowaffected > 0) // Selection for Successful Insert
                            {
                                MessageBox.Show("Admin Login Successful"); // Pop-up Message
                            }
                            else // Selection for UnSuccessful Insert
                            {
                                MessageBox.Show("Admin Login UnSuccessful"); // Pop-up Message
                            }
                        }
                        else if (role == 2) // Selection of Sub-Admins
                        {
                            SqlCommand cmd3 = new SqlCommand("Insert into loginhistory values('" + usernametextbox.Text + "', " + role + ", Getdate());", con);
                            // Sql Command to insert successful Login into Login History on database
                            int rowaffected = cmd3.ExecuteNonQuery(); // Executing the Insert Query
                            if (rowaffected > 0) // Selection for Successful Insert
                            {
                                MessageBox.Show("Sub Admin Login Successful"); // Pop-up Message
                            }
                            else // Selection for UnSuccessful Insert
                            {
                                MessageBox.Show("Sub Admin Login UnSuccessful"); // Pop-up Message
                            }
                        }
                        else if (role == 3) // Selection of Users
                        {
                            SqlCommand cmd3 = new SqlCommand("Insert into loginhistory values('" + usernametextbox.Text + "', " + role + ", Getdate());", con);
                            // Sql Command to insert successful Login into Login History on database
                            int rowaffected = cmd3.ExecuteNonQuery(); // Executing the Insert Query
                            if (rowaffected > 0) // Selection for Successful Insert
                            {
                                MessageBox.Show("User Login Successful"); // Pop-up Message
                            }
                            else // Selection for UnSuccessful Insert
                            {
                                MessageBox.Show("User Login UnSuccessful"); // Pop-up Message
                            }
                        }
                        else // Selection of Wrong Credentials
                        {
                            MessageBox.Show("Incorrect Credentials. Try Again"); // Pop-up Message
                        }
                    }
                }
            }
        }
    }
}
