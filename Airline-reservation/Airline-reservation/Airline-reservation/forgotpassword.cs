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
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }

        private void forgotpassword_Load(object sender, EventArgs e) // Function for Initial loading of Forgot Password Window
        {
            // Logo
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent; // Making Logo Transparent
            // Username Label
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // New Password Label
            newpasswordlabel.Parent = pictureBox1;
            newpasswordlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Hint Label
            hintlable.Parent = pictureBox1;
            hintlable.BackColor = Color.Transparent; // Making Label Transparent
        }

        private void resetbutton_Click(object sender, EventArgs e) //Listener Function when Reset button is clicked
        {
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select hintA from login where usrname=@usrname", con);
                // Sql Command to return Hint Answer of the inserted Username from database
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar).Value = usernametextbox.Text; //Defining the command parameter for usrname
                cmd.CommandType = System.Data.CommandType.Text; // Defining command type as text. This is must with Execute Scalar
                con.Open(); //Opening Connection
                String hintans = cmd.ExecuteScalar().ToString(); // Converting returned type of object to String
                if (hintans.Equals(hinttextbox.Text)) // Selection of Correct Hint Answer
                {
                    SqlCommand cmd2 = new SqlCommand("update login set passwd=@newpasswd where usrname=@usrname", con);
                    // Sql Command to update password of inserted Username on database
                    // Using parametrized query to avoid sql injection attack
                    cmd2.Parameters.Add("@newpasswd", SqlDbType.VarChar).Value = newpasswordtextbox.Text; //Defining the command parameter for newpasswd
                    cmd2.Parameters.Add("@usrname", SqlDbType.VarChar).Value = usernametextbox.Text; //Defining the command parameter for usrname
                    int rowaffected = cmd2.ExecuteNonQuery(); // Executing the Update Query
                    if (rowaffected > 0) // Selection for Successful Update
                    {
                        MessageBox.Show("Password Reset Successful"); // Pop-up Message
                    }
                    else // Selection for UnSuccessful Update
                    {
                        MessageBox.Show("Password Reset UnSuccessful"); // Pop-up Message
                    }
                }
                else // Selection of Wrong Hint Answer
                {
                    MessageBox.Show("Password Reset UnSuccessful"); // Pop-up Message
                }
            }
        }

        private void btnclose_Click_1(object sender, EventArgs e) // Listener Function when Close button is clicked
        {
            this.Close(); // Closing Current (Forgot Password) Window
        }
    }
}
