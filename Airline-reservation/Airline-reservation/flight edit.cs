using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_reservation
{
    public partial class flight_edit : Form
    {
        static string usrnamebc; // Declaring Static variable to store username before change
        public flight_edit(int whattodisplay)
        {
            InitializeComponent();
            if (whattodisplay == 0)
            {
                changevisible(whattodisplay);
            }
            else if (whattodisplay == 1)
            {
                changevisible(whattodisplay);
            }
        }
        private void changevisible(int appear) // Function to clear page and display edit profile elements
        {
            if (appear == 0)
            {
                editflightlabel.Text = "Add or Remove Flight";
                initialusrnamelabel.Visible = false;
                initialusernametextbox.Visible = false;
                searchbutton.Visible = false;
                removeaddtextbox.Visible = true;
                addbuttom.Visible = true;
                removebutton.Visible = true;
            }
            else if (appear == 1)
            {
                editflightlabel.Text = "Edit Users";
                initialusrnamelabel.Visible = true;
                initialusernametextbox.Visible = true;
                searchbutton.Visible = true;
                removeaddtextbox.Visible = false;
                addbuttom.Visible = false;
                removebutton.Visible = false;
                // Hiding Edit profile elements
                savebutton.Visible = false; // Hiding from page
                firstnamelabel.Visible = false; // Hiding from page
                firstnametextbox.Visible = false; // Hiding from page
                lastnamelabel.Visible = false; // Hiding from page
                lastnametextbox.Visible = false; // Hiding from page
                emaillabel.Visible = false; // Hiding from page
                emailtextbox.Visible = false; // Hiding from page
                phonelabel.Visible = false; // Hiding from page
                phonetextbox.Visible = false; // Hiding from page
                editpasswordlabel.Visible = false; // Hiding from page
                editpasswordtextbox.Visible = false; // Hiding from page
                editusrnametextbox.Visible = false; // Hiding from page
                usernamelabel.Visible = false; // Hiding from page
                genderlabel.Visible = false; // Hiding from page
                gendergroupbox.Visible = false; // Hiding from page
                hintqlabel.Visible = false; // Hiding from page
                hintqtextbox.Visible = false; // Hiding from page
                birthdatelabel.Visible = false; // Hiding from page
                birthdate.Visible = false; // Hiding from page
                hintalabel.Visible = false; // Hiding from page
                hintatextbox.Visible = false; // Hiding from page
                changepfpbtn.Visible = false; // Hiding from page
                cancelbutton.Visible = false; // Hiding from page
                propicadmin.Visible = false;
                yourprofilelabel.Visible = false;
                deletebutton.Visible = false;
            }
            else if (appear == 2)
            {
                // Adjusting and filling page
                initialusrnamelabel.Visible = false;
                initialusernametextbox.Visible = false;
                searchbutton.Visible = false;
                savebutton.Visible = true; // Making Visible
                firstnamelabel.Visible = true; // Making Visible
                firstnametextbox.Visible = true; // Making Visible
                lastnamelabel.Visible = true; // Making Visible
                lastnametextbox.Visible = true; // Making Visible
                emaillabel.Visible = true; // Making Visible
                emailtextbox.Visible = true; // Making Visible
                phonelabel.Visible = true; // Making Visible
                phonetextbox.Visible = true; // Making Visible
                editpasswordlabel.Visible = true; // Making Visible
                editpasswordtextbox.Visible = true; // Making Visible
                editusrnametextbox.Visible = true; // Making Visible
                usernamelabel.Visible = true; // Making Visible
                genderlabel.Visible = true; // Making Visible
                gendergroupbox.Visible = true; // Making Visible
                hintqlabel.Visible = true; // Making Visible
                hintqtextbox.Visible = true; // Making Visible
                birthdatelabel.Visible = true; // Making Visible
                birthdate.Visible = true; // Making Visible
                hintalabel.Visible = true; // Making Visible
                hintatextbox.Visible = true; // Making Visible
                changepfpbtn.Visible = true; // Making Visible
                cancelbutton.Visible = true; // Making Visible
                propicadmin.Visible = true;
                yourprofilelabel.Visible = true;
                deletebutton.Visible = true;
                // Username Label
                usernamelabel.Parent = pictureBox1;
                usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
                                                            // Password Label
                editpasswordlabel.Parent = pictureBox1;
                editpasswordlabel.BackColor = Color.Transparent; // Making Label Transparent
                                                                 // First Name Label
                firstnamelabel.Parent = pictureBox1;
                firstnamelabel.BackColor = Color.Transparent; // Making Label Transparent
                                                              // Last Name Label
                lastnamelabel.Parent = pictureBox1;
                lastnamelabel.BackColor = Color.Transparent; // Making Label Transparent
                                                             // Email Label
                emaillabel.Parent = pictureBox1;
                emaillabel.BackColor = Color.Transparent; // Making Label Transparent
                                                          // Phone Label
                phonelabel.Parent = pictureBox1;
                phonelabel.BackColor = Color.Transparent; // Making Label Transparent
                                                          // Birthdate Label
                birthdatelabel.Parent = pictureBox1;
                birthdatelabel.BackColor = Color.Transparent; // Making Label Transparent
                                                              // Gender Label
                genderlabel.Parent = pictureBox1;
                genderlabel.BackColor = Color.Transparent; // Making Label Transparent
                gendergroupbox.Parent = pictureBox1;
                gendergroupbox.BackColor = Color.Transparent;
                                                           // Hint Label
                hintalabel.Parent = pictureBox1;
                hintalabel.BackColor = Color.Transparent; // Making Label Transparent
                                                          // Question Label
                hintqlabel.Parent = pictureBox1;
                hintqlabel.BackColor = Color.Transparent; // Making Label Transparent
                yourprofilelabel.Parent = pictureBox1;
                yourprofilelabel.BackColor = Color.Transparent; // Making Label Transparent
            }
        }
        private void flight_edit_Load(object sender, EventArgs e)
        {
            editflightlabel.Parent = pictureBox1;
            editflightlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;

        }
       

        private void addbuttom_Click(object sender, EventArgs e)
        {
            string add = removeaddtextbox.Text;
            string dbstring = "F";
            // write insert sql code that will add the new place to the table called destination
            if (add == dbstring)
            {
                MessageBox.Show("the flight already exists");
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            string remove = removeaddtextbox.Text;
            // write delete sql with where=remove that will remove flight destination from the table destination
            string dbstring = "F";
            if (remove != dbstring)
            {
                MessageBox.Show("the flight doesn't exists");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(initialusernametextbox.Text) && initialusernametextbox.Text.Length >= 4 && initialusernametextbox.Text.Length < 20)
            {
                
                usernameerror.Clear(); // Clearing usernameerror
                int existance; // Declaring Variable
                String cs2 = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs2)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("userexist", con);
                    // Sql Command to return if user exists on database
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                               // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = initialusernametextbox.Text; //Defining the command parameter for usrname
                    cmd.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                    con.Open(); //Opening Connection
                    cmd.ExecuteNonQuery(); // Executing Query
                    existance = Convert.ToInt32(cmd.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                }
                if (existance == 0) // Selection when username is not taken
                {
                    MessageBox.Show("User Doesn't exist.");
                }
                if (existance == 1) // Selection when username is taken
                {
                    usernameerror.Clear(); // Clearing usernameerror
                    changevisible(2);
                    String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                    //Declaring and Assigning Connection String
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("select * from whatphoto ('" + initialusernametextbox.Text + "')", con);
                        // Sql Command Stored Procedure that returns photo of certain username from database
                        con.Open(); // Opening Connection
                        DataSet ds = new DataSet(); // Executing and retriving value from function
                        cmd.Fill(ds); // Filling dataset from dataadapter
                        byte[] photoarray = (byte[])ds.Tables[0].Rows[0][0]; // Finding the byte array
                        MemoryStream ms = new MemoryStream(photoarray); // Filling memory stream from byte array
                        propicadmin.Image = Image.FromStream(ms); // Loading image into picture box
                        propicadmin.SizeMode = PictureBoxSizeMode.StretchImage; // Streting Image to fit picture box               
                    }
                    registerstore rs = new registerstore(); // Declaring object of register store
                    rs = registerstore.getall(initialusernametextbox.Text); // Retriving value from database
                    usrnamebc = rs.registerusername; // Assigning retrived value to filled
                    firstnametextbox.Text = rs.registerfirstname; // Assigning retrived value to filled
                    lastnametextbox.Text = rs.registerlastname; // Assigning retrived value to filled
                    emailtextbox.Text = rs.registeremail; // Assigning retrived value to filled
                    phonetextbox.Text = rs.registerphone; // Assigning retrived value to filled
                    editpasswordtextbox.Text = rs.registerpassword; // Assigning retrived value to filled
                    editusrnametextbox.Text = rs.registerusername; // Assigning retrived value to filled
                    if (rs.registergender.Equals("Male"))
                    {
                        Male.Checked = true;
                        Female.Checked = false;
                    }
                    else if (rs.registergender.Equals("Female"))
                    {
                        Female.Checked = true;
                        Male.Checked = false;
                    }
                    hintqtextbox.Text = rs.question; // Assigning retrived value to filled
                    birthdate.Value = rs.registebirthdate; // Assigning retrived value to filled
                    hintatextbox.Text = rs.registerhint; // Assigning retrived value to fill
                }
            }
            else
            {
                usernameerror.Clear(); // Clearing usernameerror
                usernameerror.SetError(initialusernametextbox, "Please enter a valid user name"); // Setting usernameerror message
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
        private bool validatephone(String phone) // Function to validate a phone
        {
            char[] phonechar = phone.ToCharArray(); // Changing the accepting string to character array
            if (string.IsNullOrEmpty(phone))// Selection of Empty String
            {
                return false;
            }
            else if (phonechar.Length < 10 || phonechar.Length > 15) // Selecting invalid inputs of being less than 10 or greater than 15 long
            {
                return false;
            }
            for (int i = 0; i < phonechar.Length; i++) //Iterating on array looking for invalid input
            {
                if (phonechar[i] == ' ' || (phonechar[i] >= 'A' && phonechar[i] <= 'z')) // Selecting invalid inputs of being a letter or space
                {
                    return false;
                }
            }
            return true;
        }
        private void cancelbutton_Click(object sender, EventArgs e)  //Listener Function when cancel button is clicked
        {
            MessageBox.Show("Changes Discarded. No Changes Made"); // Pop up window
            changevisible(1); // Calling function to display edit profile elements
        }
        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            usrnamebc = initialusernametextbox.Text;
            string gender; // Declaring Function
            bool b1 = Male.Checked; // Checking if male is checked
            gender = b1 ? "Male" : "Female"; // ternary operator assigning gender value based on selection
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
            if (!validatephone(phonetextbox.Text)) // Error of invalid phone
            {
                phonerror.Clear(); // Clearing phonerror
                phonerror.SetError(phonetextbox, "Please enter you're phone number"); // Setting phonerror message
            }
            if (string.IsNullOrEmpty(gender)) // Error of unselected gender
            {
                gendererror.Clear(); // Clearing gendererror
                gendererror.SetError(gendergroupbox, "Please enter you're gender"); // Setting gendererror message
            }
            if (string.IsNullOrEmpty(editusrnametextbox.Text) || editusrnametextbox.Text.Length < 4 || editusrnametextbox.Text.Length >= 20) // Error of invalid username
            {
                usernameerror.Clear(); // Clearing usernameerror
                usernameerror.SetError(editusrnametextbox, "Please enter a valid user name"); // Setting usernameerror message
            }
            if (string.IsNullOrEmpty(editpasswordtextbox.Text) || editpasswordtextbox.Text.Length < 4 || editpasswordtextbox.Text.Length >= 20) // Error of invalid password
            {
                passworderror.Clear(); // Clearing passworderror
                passworderror.SetError(editpasswordtextbox, "Please enter a valid password "); // Setting passworderror message
            }
            if (string.IsNullOrEmpty(hintqtextbox.Text) || hintqtextbox.Text.Length >= 100) // Error of empty hint question
            {
                questionerror.Clear(); // Clearing questionerror
                questionerror.SetError(hintqtextbox, "Please enter a valid hint question"); // Setting questionerror message
            }
            if (string.IsNullOrEmpty(hintatextbox.Text) || hintatextbox.Text.Length >= 20) // Error of empty hint answer
            {
                hinterror.Clear(); // Clearing hinterror
                hinterror.SetError(hintatextbox, "Please enter a valid hint answer"); // Setting hinterror message
            }
            if (propicadmin.Image == null) // Error of empty profile
            {
                photoerror.Clear(); // Clearing photo error
                photoerror.SetError(changepfpbtn, "Please select a photo"); // Setting photoerror message
            }
            Console.WriteLine("Here");
            if (validatename(firstnametextbox.Text)
                && validatename(lastnametextbox.Text)
                && !string.IsNullOrEmpty(emailtextbox.Text)
                && emailtextbox.Text.Contains('@') && emailtextbox.Text.Contains('.')
                && !string.IsNullOrEmpty(hintatextbox.Text)
                && hintatextbox.Text.Length < 20
                && !string.IsNullOrEmpty(birthdate.ToString())
                && !(propicadmin.Image == null)
                && validatephone(phonetextbox.Text)
                && !string.IsNullOrEmpty(editpasswordtextbox.Text)
                && editpasswordtextbox.Text.Length >= 4 && editpasswordtextbox.Text.Length < 20
                && !string.IsNullOrEmpty(gender)
                && !string.IsNullOrEmpty(editusrnametextbox.Text)
                && editusrnametextbox.Text.Length >= 4 && editusrnametextbox.Text.Length < 20
                && !string.IsNullOrEmpty(hintqtextbox.Text)
                && hintqtextbox.Text.Length < 100) // Selection where all fields are field accordingly
            {

                registerstore rs = new registerstore // Declaring register store object
                {
                    initialusrname = usrnamebc, // Assigning values to property
                    registerfirstname = firstnametextbox.Text, // Assigning values to property
                    registerlastname = lastnametextbox.Text, // Assigning values to property
                    registeremail = emailtextbox.Text, // Assigning values to property
                    registerhint = hintatextbox.Text, // Assigning values to property
                    registerphone = phonetextbox.Text, // Assigning values to property
                    registerusername = editusrnametextbox.Text, // Assigning values to property
                    registerpassword = editpasswordtextbox.Text, // Assigning values to property
                    registergender = gender, // Assigning values to property
                    registerprofilepic = propicadmin.Image, // Assigning values to property
                    registebirthdate = birthdate.Value.Date, // Assigning values to property
                    role = 3, // Assigning values to property
                    question = hintqtextbox.Text, // Assigning values to property
                };
                int rowaffected = 0;
                if (editusrnametextbox.Text.Equals(usrnamebc))
                {
                    rowaffected = rs.save(0); // Saving Progress on rs object and database registered
                }
                if (!editusrnametextbox.Text.Equals(usrnamebc))
                {
                    rowaffected = rs.save(1); // Saving Progress on rs object and database registered
                }
                if (rowaffected > 0)
                {
                    MessageBox.Show("Changes Successfully Saved"); // Pop up window
                    changevisible(1); // Calling function to display edit profile elements
                }
                else
                {
                    MessageBox.Show("Unable to save Changes. Try Again"); // Pop up window
                }
            }
        }

        private void changepfpbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();  // Creating New Open File Dialog   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // Filter for what type of files to be selected
            if (open.ShowDialog() == DialogResult.OK) // Selection when user finish selecting image
            {
                propicadmin.Image = new Bitmap(open.FileName); //Display image in picture box 
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int rowaffected = 0;
            String cs2 = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs2)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("deleteregistrywithlogin", con);
                // Sql Command to delete a user
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                           // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = initialusernametextbox.Text; //Defining the command parameter for usrname
                con.Open(); //Opening Connection
                rowaffected=cmd.ExecuteNonQuery(); // Executing Query
                if(rowaffected > 0)
                {
                    MessageBox.Show("User Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Unable to perform delete. Try again");
                }
            }
        }
    }
}
