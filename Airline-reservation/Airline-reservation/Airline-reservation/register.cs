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
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Password Label
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent; // Making Label Transparent
            // First Name Label
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor=Color.Transparent; // Making Label Transparent
            // Last Name Label
            lastnamelabel.Parent= pictureBox1;
            lastnamelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Email Label
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent; // Making Label Transparent
            // Phone Label
            phonelabel.Parent= pictureBox1;
            phonelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Birthdate Label
            birthdatelabel.Parent = pictureBox1;
            birthdatelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Gender Label
            genderlabel.Parent = pictureBox1;
            genderlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Register Label
            registerlabel.Parent = pictureBox1;
            registerlabel.BackColor = Color.Transparent; // Making Label Transparent
            // Profile Picture Label
            profilepicturelabel.Parent = pictureBox1;
            profilepicturelabel.BackColor = Color.Transparent; // Making Label Transparent
            // Logo
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent; // Making Logo Transparent
            // Hint Label
            hintlable.Parent = pictureBox1;
            hintlable.BackColor = Color.Transparent; // Making Label Transparent
            // Login Header Button
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            // Register Header Button
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            registerheaderbutton.FlatAppearance.BorderSize = 1; // Creating Border of Button to show its the current window
            // About us Header Button 
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            aboutheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
            // Contact us Header Button 
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent; // Making Button Transparent
            contactheaderbutton.FlatAppearance.BorderSize = 0; // Removing Border of Button
        }

        private void upload_Click(object sender, EventArgs e) //Listener Function when upload button is clicked
        {
           
            OpenFileDialog open = new OpenFileDialog();  // Creating New Open File Dialog   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; 
            // Filter for what type of files to be selected
            if (open.ShowDialog() == DialogResult.OK) // Selection when user finish selecting image
            {
                profilepicture.Image = new Bitmap(open.FileName); //Display image in picture box 
            }
        }

        private void registerbutton_Click(object sender, EventArgs e) //Listener Function when register button is clicked
        {
            string firstname, lastname, email, hint, phone, username, password; // Declaring Variables
            firstname = firstnametextbox.Text; // Assigning Variables
            lastname = lastnametextbox.Text; // Assigning Variables
            email = emailtextbox.Text; // Assigning Variables
            hint = hinttextbox.Text; // Assigning Variables
            phone = phonetextbox.Text; // Assigning Variables
            username = usernametextbox.Text; // Assigning Variables
            password = passwordtextbox.Text; // Assigning Variables
            registerbutton.BackColor = Color.Silver; // Changing back color of register button
            donebutton.BackColor = Color.Red; // Changing back color of done button
            char gender='M'; // Declaring Gender and setting default value
            if (Male.Checked) // Selection for user selecting male
            {
                gender = 'M'; // Assigning Male
            }
            else if (Female.Checked) // Selection for user selecting female
            {
                gender = 'F'; // Assigning Female
            }
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                String query = "Insert into registered(fname, lname, email, phoneno, birthdate, gender, usrname, passwd, hintQ, hintA, profilepic) values(@fname,@lname,@email,@phone,@birthdate,@gender, @usrname, @passwd, 'Are you?', @hint,@photo);";
                SqlCommand cmd = new SqlCommand(query, con);
                // Sql Command to insert registerd value to databse
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = firstname; //Defining the command parameter for fname
                cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lastname; //Defining the command parameter for lname
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email; //Defining the command parameter for email
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone; //Defining the command parameter for phone
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate.Value.Date; //Defining the command parameter for birthdate
                cmd.Parameters.Add("@gender", SqlDbType.Char).Value = gender; //Defining the command parameter for birthdate
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar).Value = username; //Defining the command parameter for username
                cmd.Parameters.Add("@passwd", SqlDbType.VarChar).Value = password; //Defining the command parameter for password
                cmd.Parameters.Add("@hint", SqlDbType.VarChar).Value = hint; //Defining the command parameter for hint
                conv_photo(cmd); // Calling function conv_photo that converts selected image into byte array and define the sql command parameter
                con.Open(); //Opening Connection
                int rowaffect= cmd.ExecuteNonQuery(); // Executing the Insert Query
                if (rowaffect > 0) // Selection for Successful Insert
                {
                    MessageBox.Show("Register Successful"); // Pop-up Message
                }
                else // Selection for UnSuccessful Insert
                {
                    MessageBox.Show("Register UnSuccessful"); // Pop-up Message
                }
            }
        }
        private void conv_photo(SqlCommand cmd) // Function that converts selected image into byte array and define the sql command parameter
        {
            if (profilepicture.Image != null) // Selection to make sure user selected picture
            {
                MemoryStream ms = new MemoryStream(); // Declaring memory stream
                profilepicture.Image.Save(ms, ImageFormat.Jpeg); // Saving image on to memory stream
                byte[] photo_aray = new byte[ms.Length]; // Declaring byte array with the length of the stored image on memory stream
                ms.Position = 0; // Setting memory stream positon to 0
                ms.Read(photo_aray, 0, photo_aray.Length); // Reading from o up to length
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.AddWithValue("@photo", photo_aray); //Defining the command parameter for photo
            }
        }
        private void loginheaderbutton_Click(object sender, EventArgs e) //Listener Function when login button at the header is clicked
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
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

        private void donebutton_Click(object sender, EventArgs e) //Listener Function when Done button is clicked
        {
            this.Close(); //Close Current Window
        }
    }
}
