using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Airline_reservation
{
    internal class flightinfo
    {
        private static List<flightinfo> fi = new List<flightinfo>(); // List to store loginners

        public int flightid { get; set; }
        public string departure{ get; set; }
        public string destination { get; set; }

        public string pilot { get; set; }

        public string copilot { get; set; }

        public int availseat { get; set; }

        public int planeid { get; set; }

        public int duration { get; set; }
        public DateTime departuretime { get; set; }

        
        public int save(int full) // Function to save data by adding it to the list and database
        {
            int rowaffected=0; // Variable Declaring
            fi.Add(this); // Adding Object to list
            if(full == 0)
            {
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("updateflight", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    con.Open(); // Opening Connection
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                    cmd.Parameters.Add("@flightid", SqlDbType.Int).Value = flightid; //Defining the command parameter for usrname                                                  
                    cmd.Parameters.Add("@dep", SqlDbType.VarChar, 30).Value = departure;
                    cmd.Parameters.Add("@des", SqlDbType.VarChar, 30).Value = destination;
                    cmd.Parameters.Add("@depdate", SqlDbType.Date).Value = departuretime;
                    cmd.Parameters.Add("@pilot", SqlDbType.VarChar, 70).Value =pilot;
                    cmd.Parameters.Add("@copilot", SqlDbType.VarChar, 70).Value = copilot;
                    cmd.Parameters.Add("@availseat", SqlDbType.Int).Value = availseat;
                    cmd.Parameters.Add("@duration", SqlDbType.Int).Value = duration;
                    cmd.Parameters.Add("@planeref", SqlDbType.Int).Value = planeid;
                    rowaffected = cmd.ExecuteNonQuery();
                }
                
            }
            else if (full == 1)
            {
                String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
                //Declaring and Assigning Connection String
                using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
                {
                    SqlCommand cmd = new SqlCommand("addflight", con);
                    // Sql Command stored procedure to insert successful Login into Login History on database
                    con.Open(); // Opening Connection
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                    cmd.Parameters.Add("@dep", SqlDbType.VarChar, 30).Value = departure;
                    cmd.Parameters.Add("@des", SqlDbType.VarChar, 30).Value = destination;
                    cmd.Parameters.Add("@depdate", SqlDbType.Date).Value = departuretime;
                    cmd.Parameters.Add("@pilot", SqlDbType.VarChar, 70).Value = pilot;
                    cmd.Parameters.Add("@copilot", SqlDbType.VarChar, 70).Value = copilot;
                    cmd.Parameters.Add("@availseat", SqlDbType.Int).Value = availseat;
                    cmd.Parameters.Add("@duration", SqlDbType.Int).Value = duration;
                    cmd.Parameters.Add("@planeref", SqlDbType.Int).Value = planeid;
                    rowaffected = cmd.ExecuteNonQuery();
                }

            }
            return rowaffected; // Returning number of rows inserted
        }
        public static flightinfo getall(string flightid) // Function to return all data from list
        {
            flightinfo fi = new flightinfo();
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            int id=Convert.ToInt32(flightid);
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("fullflightinfo", con);
                // Sql Command to return full info of certain username from database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@flightid", SqlDbType.VarChar, 20).Value = id; //Defining the command parameter for usrname
                // Output parameters
                cmd.Parameters.Add("@dep", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output; //Defining the parameter for fname and setting direction as output
                cmd.Parameters.Add("@des", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@depdate", SqlDbType.Date).Direction = ParameterDirection.Output; //Defining the parameter for email and setting direction as output
                cmd.Parameters.Add("@pilot", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output; //Defining the parameter for phoneno and setting direction as output
                cmd.Parameters.Add("@copilot", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output; //Defining the parameter for birthdate and setting direction as output
                cmd.Parameters.Add("@availseat", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for gender and setting direction as output
                cmd.Parameters.Add("@duration", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for passwd and setting direction as output
                cmd.Parameters.Add("@planeref", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for passwd and setting direction as output
                
                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                fi.flightid = Convert.ToInt32(id);
                fi.departure = Convert.ToString(cmd.Parameters["@dep"].Value); // Assigning output value of stored procedure by converting to String
                fi.destination = Convert.ToString(cmd.Parameters["@des"].Value); // Assigning output value of stored procedure by converting to String
                fi.departuretime = Convert.ToDateTime(cmd.Parameters["@depdate"].Value); // Assigning output value of stored procedure by converting to String
                fi.pilot = Convert.ToString(cmd.Parameters["@pilot"].Value); // Assigning output value of stored procedure by converting to String
                fi.copilot = Convert.ToString(cmd.Parameters["@copilot"].Value); // Assigning output value of stored procedure by converting to Date
                fi.availseat = Convert.ToInt32(cmd.Parameters["@availseat"].Value); // Assigning output value of stored procedure by converting to String
                fi.duration = Convert.ToInt32(cmd.Parameters["@duration"].Value); // Assigning output value of stored procedure by converting to String
                fi.planeid = Convert.ToInt32(cmd.Parameters["@planeref"].Value); // Assigning output value of stored procedure by converting to String
                
            }
            return fi; // Returning entire list of objects
        }

    }
}
