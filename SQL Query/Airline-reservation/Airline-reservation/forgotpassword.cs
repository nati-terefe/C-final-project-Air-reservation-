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
            // Hint Answer Label
            hintlable.Parent = pictureBox1;
            hintlable.BackColor = Color.Transparent; // Making Label Transparent
            // Hint Question Label
            questionlabel.Parent = pictureBox1;
            questionlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Hint Question Button
            btnhintq.FlatAppearance.BorderSize = 0; // Removing Border of Button
        }

        private void btnhintq_Click(object sender, EventArgs e)  //Listener Function when hint question button is clicked
        {
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("whathintq", con);
                // Sql Command Stored Procedure that returns hint quetion of the inserted username from database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar,100).Value = usernametextbox.Text; //Defining the command parameter for usrname
                cmd.Parameters["@usrname"].Direction = ParameterDirection.Input; //Defining the parameter direction as input
                cmd.Parameters.Add("@hintqis", SqlDbType.VarChar,100).Direction = ParameterDirection.Output; //Defining the parameter for hintqis and setting direction as output
                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                string hintq = Convert.ToString(cmd.Parameters["@hintqis"].Value); // Assigning output value of stored procedure by converting to string
                questionlabel.Text = hintq; // Displaying returned hint quetion in label
            }
        }

        private void resetbutton_Click(object sender, EventArgs e) //Listener Function when Reset button is clicked
        {
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing New Password Error Provider
            hinterror.Clear(); //Clearing Hint Answer Error Provider
            if (string.IsNullOrEmpty(usernametextbox.Text) || usernametextbox.Text.Length <4 || usernametextbox.Text.Length > 20) // Selection for invalid username 
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                usernameerror.SetError(usernametextbox, "Enter a valid username"); //Setting Username Error Provider
            }
            if (string.IsNullOrEmpty(newpasswordtextbox.Text) || newpasswordtextbox.Text.Length<4 || usernametextbox.Text.Length > 20) // Selection for invalid new password
            {
                passworderror.Clear(); //Clearing New Password Error Provider
                passworderror.SetError(newpasswordtextbox, "Enter a valid Password"); //Setting New Password Error Provider
            }
            if (string.IsNullOrEmpty(hinttextbox.Text)) // Selection for empty hint answer
            {
                hinterror.Clear(); //Clearing Hint Answer Error Provider
                hinterror.SetError(hinttextbox, "Enter a valid Hint Answer"); //Setting Hint Answer Error Provider
            } 
            if (!string.IsNullOrEmpty(usernametextbox.Text) && !string.IsNullOrEmpty(newpasswordtextbox.Text) && !string.IsNullOrEmpty(hinttextbox.Text) && newpasswordtextbox.Text.Length >= 4 && usernametextbox.Text.Length >= 4)
            { // Selection for all fields field accordingly
                int existance; // Declaring Variable
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("userexist", con);
                    // Sql Command to return if user exists on database
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                     // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = usernametextbox.Text; //Defining the command parameter for usrname
                    cmd.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                    con.Open(); //Opening Connection
                    cmd.ExecuteNonQuery(); // Executing Query
                    existance = Convert.ToInt32(cmd.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                }
                if (existance==0) // Selection when user is not existing 
                {
                    MessageBox.Show("User not Found. Try Again"); // Pop Up message
                }
                else if (existance==1 && newpasswordtextbox.Text.Length < 20) // Selection when user is existing and password isn't long
                {
                    forgotpasswordstore fp = new forgotpasswordstore // Declaring forget password store object
                    {
                        fpusername = usernametextbox.Text, // Assigning values to property
                        fppassword = newpasswordtextbox.Text, // Assigning values to property
                        fphint = hinttextbox.Text, // Assigning values to property
                    };
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlCommand cmd = new SqlCommand("whathinta", con);
                        // Sql Command to return Hint Answer of the inserted Username from database
                        cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                        // Using parametrized query to avoid sql injection attack
                        cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = fp.fpusername; //Defining the command parameter for usrname
                        cmd.Parameters.Add("@hintais", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for hintais and setting direction as output
                        con.Open(); //Opening Connection
                        cmd.ExecuteNonQuery(); // Executing Query
                        string hintans = Convert.ToString(cmd.Parameters["@hintais"].Value); // Assigning output value of stored procedure by converting to string
                        if (hintans.Equals(hinttextbox.Text)) // Selection of Correct Hint Answer
                        {
                            int rowaffected = fp.save(); // Executing the Update Query and saving on list
                            if (rowaffected > 0) // Selection for Successful Update
                            {
                                MessageBox.Show("Password Reset Successful"); // Pop-up Message
                                login l = new login(); //Declaring new Login Window
                                l.Show(); //Show Login Window
                                this.Close(); //Hide Currently Active Window
                            }
                            else // Selection for UnSuccessful Update
                            {
                                MessageBox.Show("Password Reset UnSuccessful"); // Pop-up Message
                            }
                        }
                        else // Selection of Wrong Hint Answer
                        {
                            MessageBox.Show("Hint Answer Incorrect. Try again"); // Pop-up Message
                        }
                    }
                }
                else // Selection when password is long
                {
                    passworderror.Clear(); //Clearing New Password Error Provider
                    passworderror.SetError(newpasswordtextbox, "Password must be less than 20 characters"); //Setting New Password Error Provider
                }
            }
        }
        private void btnclose_Click_1(object sender, EventArgs e) // Listener Function when Close button is clicked
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
            this.Close(); //Hide Currently Active Window
        }
    }
}
