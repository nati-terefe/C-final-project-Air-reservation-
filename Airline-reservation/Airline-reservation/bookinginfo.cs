using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class bookinginfo
    {
        private static List<bookinginfo> bi = new List<bookinginfo>();
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime departuredate { get; set; }
        public string bigender { get; set; }
        public string passportnumber { get; set; }
        public string email { get; set; }
        public string from { get; set; }
        public string to{ get; set; }
        public string age { get; set; }
        public string flightclass { get; set; }
        public string flighttype { get; set; }
        public int flightid { get; set; }
        public double bookingprice { get; set; }

        public int save()
        {
            int rowaffected = 0;
            bi.Add(this);
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.whatflightid(@dest, @deptime)", con);
                // Sql Command to add new registry on database
                con.Open(); //Opening Connection
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = to; //Defining the command parameter for usrname

                cmd.Parameters.Add("@deptime", SqlDbType.DateTime).Value = departuredate;// Using parametrized query to avoid sql injection attack
                flightid = Convert.ToInt32(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int
                SqlCommand cmd2 = new SqlCommand("addbooking", con);
                // Sql Command to add new registry on database
                cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                            // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Value = username; //Defining the command parameter for first name
                cmd2.Parameters.Add("@fname", SqlDbType.VarChar, 20).Value = firstname; //Defining the command parameter for first name
                cmd2.Parameters.Add("@lname", SqlDbType.VarChar, 20).Value = lastname; //Defining the command parameter for last name
                cmd2.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = email; //Defining the command parameter for email
                cmd2.Parameters.Add("@passport", SqlDbType.VarChar, 20).Value = passportnumber; //Defining the command parameter for phone
                cmd2.Parameters.Add("@depdate", SqlDbType.DateTime).Value = departuredate; //Defining the command parameter for birthdate
                cmd2.Parameters.Add("@gender", SqlDbType.VarChar, 10).Value = bigender; //Defining the command parameter for gender
                cmd2.Parameters.Add("@dep", SqlDbType.VarChar, 30).Value = from; //Defining the command parameter for gender
                cmd2.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = to; //Defining the command parameter for usrname
                cmd2.Parameters.Add("@fidref", SqlDbType.Int).Value = flightid; //Defining the command parameter for passwd
                cmd2.Parameters.Add("@fclass", SqlDbType.VarChar, 20).Value = flightclass; //Defining the command parameter for hint quetion
                cmd2.Parameters.Add("@ftype", SqlDbType.VarChar, 20).Value = flighttype; //Defining the command parameter for hint answer
                cmd2.Parameters.Add("@age", SqlDbType.VarChar, 10).Value = age; //Defining the command parameter for hint answer
                cmd2.Parameters.Add("@price", SqlDbType.Money).Value = bookingprice; //Defining the command parameter for hint answer
                rowaffected = cmd2.ExecuteNonQuery(); // Executing Query and returning number of rows affected
            }
            return rowaffected;
        }

        public int save(double totprice, int ticketid)
        {
            int rowaffected = 0;
            bi.Add(this);
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("select dbo.whatflightid(@dest, @deptime)", con);
                // Sql Command to add new registry on database
                con.Open(); //Opening Connection
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = to; //Defining the command parameter for usrname

                cmd.Parameters.Add("@deptime", SqlDbType.DateTime).Value = departuredate;// Using parametrized query to avoid sql injection attack
                flightid = Convert.ToInt32(cmd.ExecuteScalar()); // Assigning output value of stored procedure by converting to int

                SqlCommand cmd2 = new SqlCommand("updatebooking", con);
                // Sql Command to add new registry on database
                cmd2.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                                                                            // Using parametrized query to avoid sql injection attack
                cmd2.Parameters.Add("@ticketid", SqlDbType.Int).Value = ticketid; //Defining the command parameter for first name
                cmd2.Parameters.Add("@fname", SqlDbType.VarChar, 20).Value = firstname; //Defining the command parameter for first name
                cmd2.Parameters.Add("@lname", SqlDbType.VarChar, 20).Value = lastname; //Defining the command parameter for last name
                cmd2.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = email; //Defining the command parameter for email
                cmd2.Parameters.Add("@passport", SqlDbType.VarChar, 20).Value = passportnumber; //Defining the command parameter for phone
                cmd2.Parameters.Add("@depdate", SqlDbType.DateTime).Value = departuredate; //Defining the command parameter for birthdate
                cmd2.Parameters.Add("@gender", SqlDbType.VarChar, 10).Value = bigender; //Defining the command parameter for gender
                cmd2.Parameters.Add("@dep", SqlDbType.VarChar, 30).Value = from; //Defining the command parameter for gender
                cmd2.Parameters.Add("@dest", SqlDbType.VarChar, 30).Value = to; //Defining the command parameter for usrname
                cmd2.Parameters.Add("@fidref", SqlDbType.Int).Value = flightid; //Defining the command parameter for passwd
                cmd2.Parameters.Add("@fclass", SqlDbType.VarChar, 20).Value = flightclass; //Defining the command parameter for hint quetion
                cmd2.Parameters.Add("@ftype", SqlDbType.VarChar, 20).Value = flighttype; //Defining the command parameter for hint answer
                cmd2.Parameters.Add("@age", SqlDbType.VarChar, 10).Value = age; //Defining the command parameter for hint answer
                cmd2.Parameters.Add("@price", SqlDbType.Money).Value = totprice; //Defining the command parameter for hint answer
                rowaffected = cmd2.ExecuteNonQuery(); // Executing Query and returning number of rows affected
            }
            return rowaffected;
        }
        public static bookinginfo getall(int ticketid)
        {
            bookinginfo bi = new bookinginfo();
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlCommand cmd = new SqlCommand("fullbookinginfo", con);
                // Sql Command to return full info of certain username from database
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Defining command type as stored procedure
                // Using parametrized query to avoid sql injection attack
                cmd.Parameters.Add("@ticketid", SqlDbType.Int).Value = ticketid; //Defining the command parameter for usrname

                cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for fname and setting direction as output
                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@age", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@gender", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 80).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@passport", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@dep", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@dest", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output; //Defining the parameter for lname and setting direction as output
                cmd.Parameters.Add("@depdate", SqlDbType.DateTime).Direction = ParameterDirection.Output; //Defining the parameter for email and setting direction as output
                cmd.Parameters.Add("@fclass", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for phoneno and setting direction as output
                cmd.Parameters.Add("@ftype", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output; //Defining the parameter for birthdate and setting direction as output
                cmd.Parameters.Add("@price", SqlDbType.Money).Direction = ParameterDirection.Output; //Defining the parameter for gender and setting direction as output
                cmd.Parameters.Add("@fidref", SqlDbType.Int).Direction = ParameterDirection.Output; //Defining the parameter for passwd and setting direction as output

                con.Open(); //Opening Connection
                cmd.ExecuteNonQuery(); // Executing Query
                bi.username = Convert.ToString(cmd.Parameters["@usrname"].Value); // Assigning output value of stored procedure by converting to String
                bi.firstname = Convert.ToString(cmd.Parameters["@fname"].Value); // Assigning output value of stored procedure by converting to String
                bi.lastname = Convert.ToString(cmd.Parameters["@lname"].Value); // Assigning output value of stored procedure by converting to String
                bi.age = Convert.ToString(cmd.Parameters["@age"].Value); // Assigning output value of stored procedure by converting to String
                bi.bigender = Convert.ToString(cmd.Parameters["@gender"].Value); // Assigning output value of stored procedure by converting to String
                bi.email = Convert.ToString(cmd.Parameters["@email"].Value); // Assigning output value of stored procedure by converting to String
                bi.passportnumber = Convert.ToString(cmd.Parameters["@passport"].Value); // Assigning output value of stored procedure by converting to String
                bi.departuredate = Convert.ToDateTime(cmd.Parameters["@depdate"].Value); // Assigning output value of stored procedure by converting to String
                bi.flightclass = Convert.ToString(cmd.Parameters["@fclass"].Value); // Assigning output value of stored procedure by converting to String
                bi.flighttype = Convert.ToString(cmd.Parameters["@ftype"].Value); // Assigning output value of stored procedure by converting to Date
                bi.bookingprice = Convert.ToDouble(cmd.Parameters["@price"].Value); // Assigning output value of stored procedure by converting to String
                bi.flightid = Convert.ToInt32(cmd.Parameters["@fidref"].Value); // Assigning output value of stored procedure by converting to String
                bi.to = Convert.ToString(cmd.Parameters["@dest"].Value); // Assigning output value of stored procedure by converting to String
                bi.from = Convert.ToString(cmd.Parameters["@dep"].Value); // Assigning output value of stored procedure by converting to String

            }
            return bi;
        }
        public static List<bookinginfo> getall()
        {
            return bi;
        }
    }
}
