using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Airline_reservation
{
    internal class contactstore
    {
        private static List<contactstore> cs = new List<contactstore>(); // List to store messages

        public string contactfirstname { get; set; } // First name Prperty
        public string contactlastname { get; set; } // Last name Prperty
        public string contactemail { get; set; } // Email Prperty
        public string contactmessage { get; set; } // Message Prperty

        public int save() // Function to save data by adding it to the list and database
        {
            int rowaffected; // Declaring Variable
            cs.Add(this); // Adding Object to list
            String cons = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cons)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("addmessage", con);
                // Sql Command to add new registry on database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 20).Value = contactfirstname; //Defining the command parameter for first name
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20).Value = contactlastname; //Defining the command parameter for last name
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = contactemail; //Defining the command parameter for email
                cmd.Parameters.Add("@suggetion", SqlDbType.VarChar, 1000).Value = contactmessage; //Defining the command parameter for message
                con.Open(); //Opening Connection
                rowaffected = cmd.ExecuteNonQuery(); // Executing Query
            }
            if (rowaffected > 0) // Selection for both database insertions where done
            {
                return rowaffected;
            }
            else // Selection for both or either database insertions where not done
                return 0;
        }
        public static List<contactstore> getall() // Function to return all data from list
        {
            return cs; // Returning entire list of objects
        }
    }
}
