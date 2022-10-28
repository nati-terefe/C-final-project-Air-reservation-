using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import Statments
namespace Airline_reservation
{
    internal class forgotpasswordstore
    {
        private static List<forgotpasswordstore> fpws = new List<forgotpasswordstore>(); // Declaring List to store updated values of passwords

        public string fpusername { get; set; } // Username Prperty
        public string fppassword { get; set; } // Password Prperty
        public string fphint { get; set; } // Hint Answer Prperty

        public int save() // Function to save data by adding it to the list and database
        {
            int rowaffected; // Variable Declaring
            fpws.Add(this); // Adding Object to list
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd2 = new SqlCommand("setnewpasswd", con);
                // Sql Command to update password of inserted Username on database
                cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@newpasswd", SqlDbType.VarChar).Value = fppassword; //Defining the command parameter for newpasswd
                cmd2.Parameters.Add("@usrname", SqlDbType.VarChar).Value = fpusername; //Defining the command parameter for usrname
                con.Open(); //Opening Connection
                rowaffected = cmd2.ExecuteNonQuery(); // Executing the Update Query
            }
            return rowaffected; // Returning number of rows inserted
        }
        public static List<forgotpasswordstore> getall() // Function to return all data from list
        {
            return fpws; // Returning entire list of objects
        }
    }
}
