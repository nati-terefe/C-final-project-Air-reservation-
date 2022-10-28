using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.IO;

namespace Airline_reservation
{
    internal class registerstore
    {
        private static List<registerstore> rs= new List<registerstore>(); // List to store registry

        public string registerfirstname { get; set; } // First name Prperty
        public string registerlastname { get; set; } // Last name Prperty
        public string registerusername { get; set; } // Username Prperty
        public string registerpassword { get; set; } // password Prperty
        public DateTime registebirthdate { get; set; } // birthdate Prperty
        public string registergender { get; set; } // gender Prperty
        public string registerhint { get; set; } // hint Prperty
        public string registerphone { get; set; } // phone Prperty
        public string registeremail { get; set; } // email Prperty
        public Image registerprofilepic { get; set; } // profile picture Prperty
        public int role { get; set; } // Role Prperty
        public string question { get; set; } // Hint Question Prperty


        public int save() // Function to save data by adding it to the list and database
        {
            int rowaffected; // Declaring Variable
            rs.Add(this); // Adding Object to list
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("addregistry", con);
                // Sql Command to add new registry on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 20).Value = registerfirstname; //Defining the command parameter for first name
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20).Value = registerlastname; //Defining the command parameter for last name
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = registeremail; //Defining the command parameter for email
                cmd.Parameters.Add("@phoneno", SqlDbType.VarChar, 15).Value = registerphone; //Defining the command parameter for phone
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = registebirthdate; //Defining the command parameter for birthdate
                cmd.Parameters.Add("@gender", SqlDbType.VarChar, 10).Value = registergender; //Defining the command parameter for gender
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = registerusername; //Defining the command parameter for usrname
                cmd.Parameters.Add("@passwd", SqlDbType.VarChar, 20).Value = registerpassword; //Defining the command parameter for passwd
                cmd.Parameters.Add("@hintq", SqlDbType.VarChar, 100).Value = question; //Defining the command parameter for hint quetion
                cmd.Parameters.Add("@hinta", SqlDbType.VarChar, 20).Value = registerhint; //Defining the command parameter for hint answer
                conv_photo(cmd); // Calling function conv_photo that converts selected image into byte array and define the sql command parameter
                con.Open(); //Opening Connection
                rowaffected=cmd.ExecuteNonQuery(); // Executing Query
                SqlCommand cmd2 = new SqlCommand("registrylogin", con);
                // Sql Command to create login for register
                cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = registerusername; //Defining the command parameter for usrname
                cmd2.Parameters.Add("@passwd", SqlDbType.VarChar, 20).Value = registerpassword; //Defining the command parameter for passwd
                cmd2.Parameters.Add("@rol", SqlDbType.Int).Value = 3; //Defining the command parameter for role as user
                cmd2.Parameters.Add("@hintQ", SqlDbType.VarChar, 100).Value = question; //Defining the command parameter for hint quetion
                cmd2.Parameters.Add("@hintA", SqlDbType.VarChar, 20).Value = registerhint; //Defining the command parameter for hint answer
                rowaffected += cmd2.ExecuteNonQuery(); // Executing Query
            }
            if (rowaffected > 1) // Selection for both database insertions where done
            {
                return rowaffected; 
            }
            else // Selection for both or either database insertions where not done
                return 0;
        }
        private void conv_photo(SqlCommand cmd) // Function that converts selected image into byte array and define the sql command parameter
        {
            if (registerprofilepic != null) // Selection to make sure user selected picture
            {
                MemoryStream ms = new MemoryStream(); // Declaring memory stream
                registerprofilepic.Save(ms, ImageFormat.Jpeg); // Saving image on to memory stream
                byte[] photo_aray = new byte[ms.Length]; // Declaring byte array with the length of the stored image on memory stream
                ms.Position = 0; // Setting memory stream positon to 0
                ms.Read(photo_aray, 0, photo_aray.Length); // Reading from o up to length
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.AddWithValue("@profilepic", photo_aray); //Defining the command parameter for photo
            }
        }
        public static List<registerstore> getall() // Function to return all data from list
        {
            return rs; // Returning entire list of objects
        }
    } 
    
}
