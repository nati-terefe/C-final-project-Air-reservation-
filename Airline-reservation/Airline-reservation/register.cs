using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
// Import Statments

namespace Airline_reservation
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e) // Function for Initial loading of Register Window
        {
            // Username Label
            usernamelabel.Parent = bgpic;
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Password Label
            passwordlabel.Parent = bgpic;
            passwordlabel.BackColor = Color.Transparent; // Making Label Transparent
            // First Name Label
            firstnamelabel.Parent = bgpic;
            firstnamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Last Name Label
            lastnamelabel.Parent = bgpic;
            lastnamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Email Label
            emaillabel.Parent = bgpic;
            emaillabel.BackColor = Color.Transparent; // Making Label Transparent
            // Phone Label
            phonelabel.Parent = bgpic;
            phonelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Birthdate Label
            birthdatelabel.Parent = bgpic;
            birthdatelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Gender Label
            genderlabel.Parent = bgpic;
            genderlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Register Label
            registerlabel.Parent = bgpic;
            registerlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Profile Picture Label
            profilepicturelabel.Parent = bgpic;
            profilepicturelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Logo
            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent; // Making Logo Transparent
            // Hint Label
            hintlable.Parent = bgpic;
            hintlable.BackColor = Color.Transparent; // Making Label Transparent
            // Question Label
            questionlabel.Parent = bgpic;
            questionlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Login Header Button
            loginheaderbutton.Parent = bgpic;
            loginheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // Register Header Button
            registerheaderbutton.Parent = bgpic;
            registerheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            registerheaderbutton.FlatAppearance.BorderSize = 1; // Creating Border of Button to show its the current window
            // About us Header Button 
            aboutheaderbutton.Parent = bgpic;
            aboutheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            aboutheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // Contact us Header Button 
            contactheaderbutton.Parent = bgpic;
            contactheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            contactheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // FAQ Header Button 
            faqheaderbuttom.Parent = bgpic;
            faqheaderbuttom.BackColor = Color.Transparent; // Making Button Transparent
            faqheaderbuttom.FlatAppearance.BorderSize = 0; // Removing Border of Button
        }

        private void upload_Click(object sender, EventArgs e) //Listener Function when upload button is clicked
        {
            OpenFileDialog open = new OpenFileDialog();  // Creating New Open File Dialog   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // Filter for what type of files to be selected
            if (open.ShowDialog() == DialogResult.OK) // Selection when user finish selecting image
            {
                profilepicture.Image = new Bitmap(open.FileName); //Display image in picture box
                piclocation.Text= open.FileName;  // image file path  
            }
        }

        private void registerbutton_Click(object sender, EventArgs e) //Listener Function when register button is clicked
        {
            firstnameerror.Clear(); // Clearing firstnameerror
            lastnameerror.Clear(); // Clearing lastnameerror
            emailerror.Clear(); // Clearing emailerror
            phonerror.Clear(); // Clearing phonerror
            gendererror.Clear(); // Clearing gendererror
            usernameerror.Clear(); // Clearing usernameerror
            passworderror.Clear(); // Clearing passworderror
            questionerror.Clear(); // Clearing questionerror
            hinterror.Clear(); // Clearing hinterror
            photoerror.Clear(); // Clearing photo error
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
                phonerror.SetError(phonetextbox,"Please enter you're phone number"); // Setting phonerror message
            }
            if (string.IsNullOrEmpty(gender)) // Error of unselected gender
            {   
                gendererror.Clear(); // Clearing gendererror
                gendererror.SetError(gendergroupbox, "Please enter you're gender"); // Setting gendererror message
            }
            if (string.IsNullOrEmpty(usernametextbox.Text) || usernametextbox.Text.Length<4 || usernametextbox.Text.Length >= 20) // Error of invalid username
            {   
                usernameerror.Clear(); // Clearing usernameerror
                usernameerror.SetError(usernametextbox, "Please enter a valid user name"); // Setting usernameerror message
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text) || passwordtextbox.Text.Length<4 || usernametextbox.Text.Length >= 20) // Error of invalid password
            {   
                passworderror.Clear(); // Clearing passworderror
                passworderror.SetError(passwordtextbox, "Please enter a valid password "); // Setting passworderror message
            }
            if (string.IsNullOrEmpty(questiontextbox.Text) || questiontextbox.Text.Length>=100) // Error of empty hint question
            {
                questionerror.Clear(); // Clearing questionerror
                questionerror.SetError(questiontextbox, "Please enter a valid hint question"); // Setting questionerror message
            }
            if (string.IsNullOrEmpty(hinttextbox.Text) || hinttextbox.Text.Length>=20) // Error of empty hint answer
            {
                hinterror.Clear(); // Clearing hinterror
                hinterror.SetError(hinttextbox, "Please enter a valid hint answer"); // Setting hinterror message
            }
            if(string.IsNullOrEmpty(piclocation.Text)) // Error of empty profile
            {
                photoerror.Clear(); // Clearing photo error
                photoerror.SetError(piclocation, "Please select a photo"); // Setting photoerror message
            }
            if (!string.IsNullOrEmpty(firstnametextbox.Text) 
                && !string.IsNullOrEmpty(lastnametextbox.Text) 
                && !string.IsNullOrEmpty(emailtextbox.Text) 
                && !string.IsNullOrEmpty(hinttextbox.Text) 
                && !string.IsNullOrEmpty(birthdate.ToString()) 
                && !string.IsNullOrEmpty(piclocation.Text)
                && !string.IsNullOrEmpty(phonetextbox.Text) 
                && !string.IsNullOrEmpty(passwordtextbox.Text) 
                && !string.IsNullOrEmpty(gender)
                && !string.IsNullOrEmpty(usernametextbox.Text)
                && !string.IsNullOrEmpty(questiontextbox.Text)) // Selection where all fields are field accordingly
            {
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
                if (existance == 0) // Selection when username is not taken
                {
                    registerstore rs = new registerstore // Declaring register store object
                    {
                        registerfirstname = firstnametextbox.Text, // Assigning values to property
                        registerlastname = lastnametextbox.Text, // Assigning values to property
                        registeremail = emailtextbox.Text, // Assigning values to property
                        registerhint = hinttextbox.Text, // Assigning values to property
                        registerphone = phonetextbox.Text, // Assigning values to property
                        registerusername = usernametextbox.Text, // Assigning values to property
                        registerpassword = passwordtextbox.Text, // Assigning values to property
                        registergender = gender, // Assigning values to property
                        registerprofilepic = profilepicture.Image, // Assigning values to property
                        registebirthdate = birthdate.Value.Date, // Assigning values to property
                        role = 3, // Assigning values to property
                        question = questiontextbox.Text, // Assigning values to property
                    };
                    int rowaffected=rs.save(); // Saving Progress on rs object and database registered
                    if(rowaffected > 0)
                    {
                        registerbutton.BackColor = Color.Silver; // Changing back color of register button
                        MessageBox.Show("You have been registered"); // Pop up window
                    }
                    else
                    {
                        MessageBox.Show("Registration Unsuccessful"); // Pop up window
                    }
                }
                else if (existance==1) // Selection when username is taken
                {
                    MessageBox.Show("Username already taken. Please Enter another one"); // Pop up window
                }
            }
        }
        private bool validatename(string name) // Function to validate name
        {
            char [] namechar = name.ToCharArray(); // Converting String to char array
            if(string.IsNullOrEmpty(name)) // Selection of Empty String
            {
                return false;
            }
            else if(namechar.Length>=20) // Selection of long name
            {
                return false;
            }
            else
            {
                for (int i = 0; i < namechar.Length; i++) // loop to find invalid character in name
                {
                    char c = namechar[i];
                    if (!(c >= 'A' && c <='z') )
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
        private void loginheaderbutton_Click(object sender, EventArgs e) //Listener Function when login button at the header is clicked
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
            this.Close(); //Hide Currently Active Window
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

        private void donebutton_Click(object sender, EventArgs e) //Listener Function when Done button is clicked
        {
            this.Close(); //Close Current Window
        }

        private void faqheaderbuttom_Click(object sender, EventArgs e) //Listener Function when FAQ Header button is clicked
        {
            FAQ f = new FAQ(); //Declaring new FAQ Window
            f.Show(); //Show FAQ Window
            Hide(); //Hide Currently Active Window
        }
    }
}
