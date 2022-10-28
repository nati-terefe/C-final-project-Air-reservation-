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
using System.Windows.Forms;

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

        public string initialusrname { get; set; } // In case of update to hold initial username Prperty


        public int save(int full) // Function to save data by adding it to the list and database
        {
            int rowaffected=0; // Declaring Variable
            rs.Add(this); // Adding Object to list
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            { 
                if(full==1) // Selection is its a new registry
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
                    rowaffected = cmd.ExecuteNonQuery(); // Executing Query
                    SqlCommand cmd2 = new SqlCommand("registrylogin", con);
                    // Sql Command to create login for register
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                                // Using parametrized query to avoid sql injection attack
                    cmd2.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = registerusername; //Defining the command parameter for usrname
                    cmd2.Parameters.Add("@passwd", SqlDbType.VarChar, 20).Value = registerpassword; //Defining the command parameter for passwd
                    cmd2.Parameters.Add("@rol", SqlDbType.Int).Value = role; //Defining the command parameter for role as user
                    cmd2.Parameters.Add("@hintQ", SqlDbType.VarChar, 100).Value = question; //Defining the command parameter for hint quetion
                    cmd2.Parameters.Add("@hintA", SqlDbType.VarChar, 20).Value = registerhint; //Defining the command parameter for hint answer
                    rowaffected += cmd2.ExecuteNonQuery(); // Executing Query
                }
                else if (full == 0) // Selection is its a change in Edit profile
                {
                    //update registered
                    SqlCommand cmd = new SqlCommand("updateregistry", con);
                    // Sql Command to update registry on database
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                    // Using parametrized query to avoid sql injection attack
                    cmd.Parameters.Add("@initialusrname", SqlDbType.VarChar, 20).Value = initialusrname; //Defining the command parameter for first name

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
                    rowaffected = cmd.ExecuteNonQuery(); // Executing Query
                    SqlCommand cmd2 = new SqlCommand("setnewpasswd", con);
                    // Sql Command to update password of inserted Username on database
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                                // Using parametrized query to avoid sql injection attack
                    cmd2.Parameters.Add("@newpasswd", SqlDbType.VarChar).Value = registerpassword; //Defining the command parameter for newpasswd
                    cmd2.Parameters.Add("@usrname", SqlDbType.VarChar).Value = registerusername; //Defining the command parameter for usrname
                    rowaffected = cmd2.ExecuteNonQuery(); // Executing the Update Query
                }
            }
            if (rowaffected > 1 || full==0) // Selection for both database insertions where done
            {
                return rowaffected; 
            }
            else
            {
                return 0;
            }
            
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
        public static registerstore getall(string usrname) // Function to return all column valus of a certain username
        {
            registerstore rs=new registerstore();
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("fullinfo", con);
                // Sql Command to add new registry on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = usrname; //Defining the command parameter for usrname

                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for fname and setting direction as output
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 80).Direction = ParameterDirection.Output; //Defining the parameter for email and setting direction as output
                cmd.Parameters.Add("@phoneno", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output; //Defining the parameter for phoneno and setting direction as output
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Direction = ParameterDirection.Output; //Defining the parameter for birthdate and setting direction as output
                cmd.Parameters.Add("@gender", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output; //Defining the parameter for gender and setting direction as output
                cmd.Parameters.Add("@passwd", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for passwd and setting direction as output
                cmd.Parameters.Add("@hintq", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output; //Defining the parameter for hintq and setting direction as output
                cmd.Parameters.Add("@hinta", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for hinta and setting direction as output
                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                rs.registerfirstname=Convert.ToString(cmd.Parameters["@fname"].Value); // Assigning output value of stored procedure by converting to String
                rs.registerlastname = Convert.ToString(cmd.Parameters["@lname"].Value); // Assigning output value of stored procedure by converting to String
                rs.registeremail = Convert.ToString(cmd.Parameters["@email"].Value); // Assigning output value of stored procedure by converting to String
                rs.registerphone = Convert.ToString(cmd.Parameters["@phoneno"].Value); // Assigning output value of stored procedure by converting to String
                rs.registebirthdate = Convert.ToDateTime(cmd.Parameters["@birthdate"].Value); // Assigning output value of stored procedure by converting to String
                rs.registergender = Convert.ToString(cmd.Parameters["@gender"].Value); // Assigning output value of stored procedure by converting to String
                rs.registerpassword = Convert.ToString(cmd.Parameters["@passwd"].Value); // Assigning output value of stored procedure by converting to String
                rs.question = Convert.ToString(cmd.Parameters["@hintq"].Value); // Assigning output value of stored procedure by converting to String
                rs.registerhint = Convert.ToString(cmd.Parameters["@hinta"].Value); // Assigning output value of stored procedure by converting to String
                rs.registerusername = usrname;
            }
            return rs;
        }
    } 
    
}
