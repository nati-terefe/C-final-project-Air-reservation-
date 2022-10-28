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
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            loginheaderbutton.FlatAppearance.BorderSize = 1; // Creating Border of Button to show its the current window
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
            // FAQ Header Button 
            faqheaderbuttom.Parent = pictureBox1;
            faqheaderbuttom.BackColor = Color.Transparent; // Making Button Transparent
            faqheaderbuttom.FlatAppearance.BorderSize = 0; // Removing Border of Button
        }

        private void forgotbutton_Click(object sender, EventArgs e) //Listener Function when forgot password button is clicked
        {
            forgotpassword f = new forgotpassword(); //Declaring new Forgot Password Window
            f.Show(); //Show forgot password Window
            Hide(); //Hide Currently Active Window
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

        private void faqheaderbuttom_Click(object sender, EventArgs e) //Listener Function when FAQ Header button is clicked
        {
            FAQ f = new FAQ(); //Declaring new FAQ Window
            f.Show(); //Show FAQ Window
            Hide(); //Hide Currently Active Window
        }

        private void loginbutton_Click(object sender, EventArgs e) //Listener Function when login button is clicked
        {
            string username = usernametextbox.Text; //Declaring Variable and Assigning
            string password = passwordtextbox.Text; //Declaring Variable and Assigning
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing Psername Error Provider
            if (string.IsNullOrEmpty(usernametextbox.Text) || usernametextbox.Text.Length < 4 || usernametextbox.Text.Length >= 20 || usernametextbox.Text.Contains(' ')) //Selection for Invalid Username
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                usernameerror.SetError(usernametextbox, "Enter Valid Username"); //Setting Username Error Provider
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text) || passwordtextbox.Text.Length < 4 || passwordtextbox.Text.Length >= 20 || passwordtextbox.Text.Contains(' ')) //Selection for Invalid Password
            {
                passworderror.Clear(); //Clearing Psername Error Provider
                passworderror.SetError(passwordtextbox, "Enter Valid Password"); //Setting Password Error Provider
            }
            if (!string.IsNullOrEmpty(usernametextbox.Text) 
                && !string.IsNullOrEmpty(passwordtextbox.Text)
                && usernametextbox.Text.Length >= 4 && usernametextbox.Text.Length < 20 && !usernametextbox.Text.Contains(' ')
                && passwordtextbox.Text.Length >= 4 && passwordtextbox.Text.Length < 20 && !passwordtextbox.Text.Contains(' ')
                ) //Selection for accordingly filled Username and Password
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                passworderror.Clear(); //Clearing Psername Error Provider
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("whatrole", con);
                    // Sql Command Stored Procedure that returns role of the inserted login info from database
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                    // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@usrname", SqlDbType.VarChar).Value = usernametextbox.Text; //Defining the command parameter for usrname
                    cmd.Parameters["@usrname"].Direction = ParameterDirection.Input; //Defining the parameter direction as input
                    cmd.Parameters.Add("@passwd", SqlDbType.VarChar).Value = passwordtextbox.Text; //Defining the command parameter for passwd
                    cmd.Parameters["@passwd"].Direction = ParameterDirection.Input; //Defining the command parameter direction as input
                    cmd.Parameters.Add("@roleis", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for roleis and setting direction as output
                    con.Open(); //Opening Connection
                    cmd.ExecuteNonQuery(); // Executing Query
                    int role = Convert.ToInt32(cmd.Parameters["@roleis"].Value); // Assigning output value of stored procedure by converting to int
                    if (role != 0) // Selection of Correct Credentials
                    {
                        loginstore ls = new loginstore // Declaring login store object
                        {
                            loginusername = usernametextbox.Text, // Assigning values to property
                            loginpassword = passwordtextbox.Text, // Assigning values to property
                        };
                        ls.loginrole = role; // Assigning values to property
                        int rowaffected=ls.save(); // Saving Progress on ls object and database login history
                        if (rowaffected > 0) // Selection of Successful Insert
                        {
                            if (role == 1) // Selection of Admins
                            {
                                Homepage_admin ha = new Homepage_admin(username, 1); //Declaring new Home page admin Window the 1 indicating role as admin
                                ha.Show(); //Show Homepage admin Window
                                Hide(); //Hide Currently Active Window
                            }
                            else if (role == 2) // Selection of Sub-Admins
                            {
                                Homepage_admin ha = new Homepage_admin(username, 2); //Declaring new Home page admin Window the 2 indicating role as subadmin
                                ha.Show(); //Show Homepage admin Window
                                Hide(); //Hide Currently Active Window
                            }
                            else if (role == 3) // Selection of Users
                            {
                                Homepage_client hc = new Homepage_client(username); //Declaring new Home page client Window
                                hc.Show(); //Show Homepage client Window
                                Hide(); //Hide Currently Active Window
                            }
                        }
                        else if (rowaffected <= 0) // Selection of Unsuccessful Insert
                        {
                            MessageBox.Show("Unable to login rightnow. Try Again"); // Pop-up Message
                        }
                    }
                    else // Selection of Wrong Credentials
                    {
                        SqlCommand cmd2 = new SqlCommand("userexist", con);
                        // Sql Command to return existance of the inserted Username from database
                        cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                        // Using parametrized query to avoid sql injection attack
                        cmd2.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = usernametextbox.Text; //Defining the command parameter for usrname
                        cmd2.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                        cmd2.ExecuteNonQuery(); // Executing Query
                        int existance = Convert.ToInt32(cmd2.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                        if (existance == 0) // Selection when user is not existing 
                        {
                            MessageBox.Show("User not Found. Try Again or Sign Up"); // Pop Up message

                        }
                        else // Selection when username and password ain't a match 
                        {
                            MessageBox.Show("Incorrect Password. Try Again"); // Pop-up Message
                        }
                    }
                }   
            }
        }
        
        private void closebutton_Click(object sender, EventArgs e) //Listener Function when close button is clicked
        {
            this.Close(); //Close Current Window
        }
    }
}
