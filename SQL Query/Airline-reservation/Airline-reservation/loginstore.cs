using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import Statments
namespace Airline_reservation
{
    internal class loginstore
    {
        private static List<loginstore> ls=new List<loginstore>(); // List to store loginners
        public string loginusername { get; set; } // Username Prperty
        public string loginpassword { get; set; } // Password Property
        public int loginrole { get; set; } // Role Property
        public int save() // Function to save data by adding it to the list and database
        {
            int rowaffected; // Variable Declaring
            ls.Add(this); // Adding Object to list
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd2 = new SqlCommand("addloginhistory", con);
                // Sql Command stored procedure to insert successful Login into Login History on database
                con.Open(); // Opening Connection
                cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@usrname", SqlDbType.VarChar).Value = loginusername; //Defining the command parameter for usrname
                cmd2.Parameters.Add("@role", SqlDbType.Int).Value = loginrole; //Defining the command parameter for role
                rowaffected = cmd2.ExecuteNonQuery(); // Executing the Insert Query
            }
            return rowaffected; // Returning number of rows inserted
        }
        public static List<loginstore> getall() // Function to return all data from list
        {
            return ls; // Returning entire list of objects
        }
    }
}
