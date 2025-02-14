﻿using System;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
// Import Statments

namespace Airline_reservation
{
    public partial class Homepage_admin : Form
    {
        static string usrnamebc; // Declaring Static variable to store username before any change in edit profile
        static int role; // Declaring Static variable to store role to differentiate between admin and subadmin

        public Homepage_admin(string user, int rol) // Constructor thats called when creating class object
        {
            role = rol; // Assigning the role of the loginner
            InitializeComponent();
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter cmd = new SqlDataAdapter ("select * from whatphoto ('"+user+"')", con);
                // Sql Command Stored Procedure that returns photo of certain username from database
                con.Open(); // Opening Connection
                DataSet ds= new DataSet(); // Declaring new dataset object
                cmd.Fill(ds); // Filling dataset by executing cmd datadapter
                byte[] photoarray = (byte [])ds.Tables[0].Rows[0][0]; // Finding the byte array
                MemoryStream ms = new MemoryStream(photoarray); // Filling memory stream from byte array
                propicadmin.Image = Image.FromStream(ms); // Loading image into picture box
                propicadmin.SizeMode = PictureBoxSizeMode.StretchImage; // Streting Image to fit picture box               
            }
            usernameblank.Text = user; // Loading username
            if (role == 2) // Selection for when the loginner is subadmin
            {
                addadminbutton.Visible = false; // Hidding ability to add an admin
            }
        }
        
        private void Homepage_admin_Load(object sender, EventArgs e) // Function for Initial loading of Home Page of Admin Window
        {
            // Logo
            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent; // Making Logo Transparent
            // Username Label
            usernamelabel.Parent = bgpic;
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Usernaem Text Field
            usernameblank.Parent = bgpic;
            usernameblank.BackColor = Color.Transparent; // Making Label Transparent
            // Edit Profile Button
            Editprofile.Parent = bgpic;
            Editprofile.BackColor = Color.Transparent; // Making Label Transparent
            Editprofile.FlatAppearance.BorderSize = 0; // Making Button Borderless
            // Log Out Button
            logoutbutton.Parent = bgpic;
            logoutbutton.BackColor = Color.Transparent; // Making Label Transparent
            logoutbutton.FlatAppearance.BorderSize = 0; // Making Button Borderless
            // Your Profile Label
            yourprofilelabel.Parent = bgpic;
            yourprofilelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Welcome Label
            welcomelabel.Parent = bgpic; 
            welcomelabel.BackColor = Color.Transparent; // Making Label Transparent
        } 

        private void logoutbutton_Click(object sender, EventArgs e) //Listener Function when log out button is clicked
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
            this.Close(); //Hide Currently Active Window
        }
        
        private void searchbutton_Click(object sender, EventArgs e) //Listener Function when manageflights button is clicked
        {
            search s = new search(); // Declaring new search window
            s.Show(); //Show Search Window
        }

        private void bookticketbutton_Click(object sender, EventArgs e) //Listener Function when Book Ticket button is clicked
        {
            Bookticket bt = new Bookticket(0); // Declaring book ticket window
            bt.Show(); //Show book ticket Window
        }

        private void bookedticketbutton_Click(object sender, EventArgs e) //Listener Function when Booked flights button is clicked
        {
            Booked_flights bf = new Booked_flights(); // Declaring booked flight window
            bf.Show(); // Show booked flight window
        }
        private void editusersbutton_Click(object sender, EventArgs e) //Listener Function when Edit Users button is clicked
        {
            flight_edit fe = new flight_edit(1); // Declaring flight edit window the 1 telling to set it with edit user elements
            fe.Show(); // Show flight edit window setted with edit user elements
        }

        private void editflightbutton_Click(object sender, EventArgs e) //Listener Function when edit flight button is clicked
        {
            flight_edit fe = new flight_edit(0); // Declaring flight edit window
            fe.Show(); // Show flight edit window
        }

        private void Backupdb_Click(object sender, EventArgs e) //Listener Function when backup button is clicked
        {
            backuploclabel.Visible = true; // Making backup database element visible
            backuploctextBox.Visible = true; // Making backup database element visible
            backuploctextBox.Text = null; // Setting value to empty
            makebackupbtn.Visible = true; // Making backup database element visible
            typeofbackup.Visible = true; // Making backup database element visible
            typeofbackup.Text = null; // Setting value to empty
            // Paste Backup Location Label
            backuploclabel.Parent = bgpic; 
            backuploclabel.BackColor = Color.Transparent; // Making Label Transparent
        }
        private void makebackupbtn_Click(object sender, EventArgs e) //Listener Function when make backup button is clicked
        {
            if(string.IsNullOrEmpty(backuploctextBox.Text) || !backuploctextBox.Text.Contains("\\")) // Selection for Invalid backup location
            {
                backuplocerror.Clear(); // Clearing Error
                backuplocerror.SetError(backuploctextBox, "Please enter a valid backup location"); // Setting backuplocerror message
            }
            if (string.IsNullOrEmpty(typeofbackup.Text.ToString())) // Selection for unselected type of backup
            {
                typeofbackuperror.Clear(); // Clearing Error
                typeofbackuperror.SetError(typeofbackup, "Please select a backup type"); // Setting typeofbackuperror message
            }
            else if(!string.IsNullOrEmpty(backuploctextBox.Text) && backuploctextBox.Text.Contains("\\") && !string.IsNullOrEmpty(typeofbackup.Text.ToString()))
            { // Selection for accordingly filled
                backuplocerror.Clear(); // Clearing Error
                typeofbackuperror.Clear(); // Clearing Error
                try // Try block to avoid errors
                {
                    String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                    //Declaring and Assigning Connection String
                    using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                    {
                        SqlCommand cmd = new SqlCommand("backupdb", con);
                        // Sql Command to backup database to desired location
                        cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                         // Using parametrized query to avoid sql injection attack
                        cmd.Parameters.Add("@backuploc", SqlDbType.VarChar, 1000).Value = backuploctextBox.Text; //Defining the command parameter for backup location
                        if (typeofbackup.Text.ToString().Equals("Full Backup")) // Selection for full backup choice
                        {
                            cmd.Parameters.Add("@full", SqlDbType.Int).Value = 1; //Defining the command parameter for fullbackup
                        }
                        else if (typeofbackup.Text.ToString().Equals("Differential Backup")) // Selection for differential backup choice
                        {
                            cmd.Parameters.Add("@full", SqlDbType.Int).Value = 0; //Defining the command parameter for differentialbackup
                        }
                        con.Open(); //Opening Connection
                        cmd.ExecuteNonQuery(); // Executing Query
                        MessageBox.Show("Backup Successful"); // Pop Up Message
                        backuploclabel.Visible = false; // Hiding backup database element
                        backuploctextBox.Visible = false; // Hiding backup database element
                        makebackupbtn.Visible = false; // Hiding backup database element
                        typeofbackup.Visible = false; // Hiding backup database element
                    }
                }
                catch (Exception exc) // Catch block for any errors that can happen
                {
                    MessageBox.Show("Ünable to backup. Please Try Again"); // Pop Up Message
                    backuploclabel.Visible = false; // Hiding backup database element
                    backuploctextBox.Visible = false; // Hiding backup database element
                    makebackupbtn.Visible = false; // Hiding backup database element
                    typeofbackup.Visible = false; // Hiding backup database element
                }
            }
        }
        private void addadminbutton_Click(object sender, EventArgs e) //Listener Function when add admin button is clicked
        {
            add_admin ad = new add_admin(); // Declaring add admin window
            ad.Show(); //Show add admin Window
        }

        private void Editprofile_Click_1(object sender, EventArgs e) //Listener Function when edit profile button is clicked
        {
            changevisible(0); // Calling function to display edit profile elements
            registerstore rs = new registerstore(); // Declaring object of register store
            rs=registerstore.getall(usernameblank.Text); // Retriving value from database
            usrnamebc= rs.registerusername; // Assigning retrived value to filled
            firstnametextbox.Text = rs.registerfirstname; // Assigning retrived value to filled
            lastnametextbox.Text = rs.registerlastname; // Assigning retrived value to filled
            emailtextbox.Text = rs.registeremail; // Assigning retrived value to filled
            phonetextbox.Text = rs.registerphone; // Assigning retrived value to filled
            editpasswordtextbox.Text = rs.registerpassword; // Assigning retrived value to filled
            editusrnametextbox.Text = rs.registerusername; // Assigning retrived value to filled
            if(rs.registergender.Equals("Male")) // Selection for male gender retrived value
            {
                Male.Checked = true; // Checking radio button
                Female.Checked = false; // Unchecking radio button
            }
            else if (rs.registergender.Equals("Female")) // Selection for female gender retrived value
            {
                Female.Checked = true; // Checking radio button
                Male.Checked = false; // Unchecking radio button
            }
            hintqtextbox.Text = rs.question; // Assigning retrived value to filled
            birthdate.Value = rs.registebirthdate; // Assigning retrived value to filled
            hintatextbox.Text = rs.registerhint; // Assigning retrived value to filled
        }
        private void changevisible(int appear) // Function to clear page and display edit profile elements
        {
            if (appear == 0) // Selection for changing display to edit profile
            {
                // Hiding homepage elements
                yourprofilelabel.Visible = false; // Hiding from page
                usernamelabel.Visible = false; // Hiding from page
                usernameblank.Visible = false; // Hiding from page
                Editprofile.Visible = false; // Hiding from page
                manageflightsbutton.Visible = false; // Hiding from page
                bookticketbutton.Visible = false; // Hiding from page
                viewdbbutton.Visible = false; // Hiding from page
                managedbookedbtn.Visible = false;
                Backupdb.Visible = false; // Hiding from page
                if (role == 1) // Selection for sub admin view to hide adding admin
                {
                    addadminbutton.Visible = false; // Hiding from page
                }
                editusersbutton.Visible = false; // Hiding from page
                exitbutton.Visible = false; // Hiding from page

                // filling page with edit profile elements
                welcomelabel.Text = "Your Profile"; // Changing text value
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
                usrnamelabel.Visible = true; // Making Visible
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

                // Username Label
                usrnamelabel.Parent = bgpic;
                usrnamelabel.BackColor = Color.Transparent; // Making Label Transparent
                // Password Label
                editpasswordlabel.Parent = bgpic;
                editpasswordlabel.BackColor = Color.Transparent; // Making Label Transparent
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
                gendergroupbox.Parent = bgpic;
                gendergroupbox.BackColor = Color.Transparent; // Making Label Transparent
                // Hint Label
                hintalabel.Parent = bgpic;
                hintalabel.BackColor = Color.Transparent; // Making Label Transparent
                // Question Label
                hintqlabel.Parent = bgpic;
                hintqlabel.BackColor = Color.Transparent; // Making Label Transparent
            }
            else if (appear==1) // Selection for changing display to homepage
            {
                // filling page with homepage elements
                yourprofilelabel.Visible = true; // Making Visible
                usernamelabel.Visible = true; // Making Visible
                usernameblank.Visible = true; // Making Visible
                Editprofile.Visible = true; // Making Visible
                manageflightsbutton.Visible = true; // Making Visible
                bookticketbutton.Visible = true; // Making Visible
                viewdbbutton.Visible = true; // Making Visible
                Backupdb.Visible = true; // Making Visible
                managedbookedbtn.Visible = true;
                if (role == 1) // Selection for sub admin view to hide adding admin
                {
                    addadminbutton.Visible = true; // Making Visible
                }
                welcomelabel.Text = "Welcome Admin"; // Changing text value
                editusersbutton.Visible = true; // Making Visible
                exitbutton.Visible = true; // Making Visible

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
                usrnamelabel.Visible = false; // Hiding from page
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
            }
        }

        private void changepfpbtn_Click(object sender, EventArgs e) // Listener Function when change button is clicked
        {
            OpenFileDialog open = new OpenFileDialog();  // Creating New Open File Dialog   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // Filter for what type of files to be selected
            if (open.ShowDialog() == DialogResult.OK) // Selection when user finish selecting image
            {
                propicadmin.Image = new Bitmap(open.FileName); //Display image in picture box 
            }
        }

        private void savebutton_Click(object sender, EventArgs e) //Listener Function when save changes button is clicked
        {
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
            if (string.IsNullOrEmpty(editusrnametextbox.Text) || editusrnametextbox.Text.Length < 4 || editusrnametextbox.Text.Length >= 20 || editusrnametextbox.Text.Contains(' ')) // Error of invalid username
            {
                usernameerror.Clear(); // Clearing usernameerror
                usernameerror.SetError(editusrnametextbox, "Please enter a valid user name"); // Setting usernameerror message
            }
            if (string.IsNullOrEmpty(editpasswordtextbox.Text) || editpasswordtextbox.Text.Length < 4 || editpasswordtextbox.Text.Length >= 20 || editpasswordtextbox.Text.Contains(' ')) // Error of invalid password
            {
                passworderror.Clear(); // Clearing passworderror
                passworderror.SetError(editpasswordtextbox, "Please enter a valid password "); // Setting passworderror message
            }
            if (string.IsNullOrEmpty(questiontextbox.Text) || questiontextbox.Text.Length >= 100) // Error of empty hint question
            {
                questionerror.Clear(); // Clearing questionerror
                questionerror.SetError(questiontextbox, "Please enter a valid hint question"); // Setting questionerror message
            }
            if (string.IsNullOrEmpty(hinttextbox.Text) || hinttextbox.Text.Length >= 20) // Error of empty hint answer
            {
                hinterror.Clear(); // Clearing hinterror
                hinterror.SetError(hinttextbox, "Please enter a valid hint answer"); // Setting hinterror message
            }
            if (propicadmin.Image==null) // Error of empty profile
            {
                photoerror.Clear(); // Clearing photo error
                photoerror.SetError(changepfpbtn, "Please select a photo"); // Setting photoerror message
            }
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
                && editpasswordtextbox.Text.Length >= 4 && editpasswordtextbox.Text.Length < 20 && !editusrnametextbox.Text.Contains(' ')
                && !string.IsNullOrEmpty(gender)
                && !string.IsNullOrEmpty(editusrnametextbox.Text)
                && editusrnametextbox.Text.Length >= 4 && editusrnametextbox.Text.Length < 20 && !editpasswordtextbox.Text.Contains(' ')
                && !string.IsNullOrEmpty(hintqtextbox.Text)
                && hintqtextbox.Text.Length < 100) // Selection where all fields are field accordingly
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
                    cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = editusrnametextbox.Text; //Defining the command parameter for usrname
                    cmd.Parameters.Add("@exist", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for exist and setting direction as output
                    con.Open(); //Opening Connection
                    cmd.ExecuteNonQuery(); // Executing Query
                    existance = Convert.ToInt32(cmd.Parameters["@exist"].Value); // Assigning output value of stored procedure by converting to int
                }
                if (existance == 0 || editusrnametextbox.Text.Equals(usrnamebc)) // Selection when username is not taken
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
                        registebirthdate = Convert.ToDateTime(birthdate.Value.ToString("yyyy-MM-dd hh:mm:ss")), // Assigning values to property
                        role = 1, // Assigning values to property
                        question = hintqtextbox.Text, // Assigning values to property
                    };
                    int rowaffected=0; // Declaring Variable
                    if (editusrnametextbox.Text.Equals(usrnamebc)) //Selection if there is no username change
                    {
                        rowaffected = rs.save(0); // Saving Progress on rs object and database registered
                    }
                    if (!editusrnametextbox.Text.Equals(usrnamebc)) //Selection if there is username change
                    {
                        rowaffected = rs.save(1); // Saving Progress on rs object and database registered
                    }
                    if (rowaffected > 0) // Checking of successful database operation
                    {
                        MessageBox.Show("Changes Successfully Saved"); // Pop up window
                        changevisible(1); // Calling function to display home page elements
                    }
                    else // Checking of unsuccessful database operation
                    {
                        MessageBox.Show("Unable to save Changes. Try Again"); // Pop up window
                    }
                }
                else if (existance == 1 && !editusrnametextbox.Text.Equals(usrnamebc)) // Selection when there is username change and username is taken
                {
                    MessageBox.Show("Username already taken. Please Enter another one"); // Pop up window
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
        private void exitbutton_Click(object sender, EventArgs e) //Listener Function when exit button is clicked
        {
            this.Close(); // Close current window
        }

        private void managedbookedbtn_Click(object sender, EventArgs e)
        {
            Bookticket bt = new Bookticket(1); // Declaring book ticket window
            bt.Show(); //Show book ticket Window
        }
    }
}
