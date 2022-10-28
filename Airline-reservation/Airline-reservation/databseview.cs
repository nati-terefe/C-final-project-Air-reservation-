using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_reservation
{
    public partial class Booked_flights : Form
    {
        public Booked_flights()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Booked_flights_Load(object sender, EventArgs e)
        {
            flightinfo c = new flightinfo();

            datagridview.DataSource = null;
            datagridview.DataSource = bookinginfo.getall();

        }

        private void regusersbutton_Click(object sender, EventArgs e)
        {
            datagridview.Visible = true;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from registered", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                datagridview.DataSource = table;
                datagridview.Columns[0].Width = 20;  // id
                datagridview.Columns[3].Width = 200; // email
                datagridview.Columns[6].Width = 60; // gender
                datagridview.Columns[7].Width = 80; // username
                datagridview.Columns[8].Width = 80; // password
                datagridview.Columns[9].Width = 200; // hint question
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flightslistbutton_Click(object sender, EventArgs e)
        {
            datagridview.Visible = true;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select f.id,f.dep,f.des,f.depdate,f.pilot,f.copilot,f.availseat, f.duration, f.planeref, p.aircraft, p.totseat from flights f join planes p on f.planeref=p.id", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                datagridview.DataSource = table;
                datagridview.Columns[0].Width = 45;  // id
                datagridview.Columns[3].Width = 70; // dep date
                datagridview.Columns[4].Width = 130; // pilot
                datagridview.Columns[5].Width = 130; // copilot
            }
        }

        private void bookedticketsbutton_Click(object sender, EventArgs e)
        {
            datagridview.Visible = true;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from bookedtickets", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                datagridview.DataSource = table;
                datagridview.Columns[0].Width = 20;  // id
                datagridview.Columns[5].Width = 60; // dep date
                datagridview.Columns[5].Width = 50; // gender
            }
        }

        private void loginhistorybtn_Click(object sender, EventArgs e)
        {
            datagridview.Visible = true;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from loginhistory", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                datagridview.DataSource = table;
                datagridview.Columns[1].Width = 20;  // role
            }
        }

        private void messagesbutton_Click(object sender, EventArgs e)
        {
            datagridview.Visible = true;
            String cs = "Data Source=REDIETS-PC\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True";
            //Declaring and Assigning Connection String
            using (SqlConnection con = new SqlConnection(cs)) //Block that auto close SqlConnection
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from contactmessages", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                datagridview.DataSource = table;
                datagridview.Columns[3].Width = 150;  // email
                datagridview.Columns[4].Width = 350;  // suggetion
            }
        }
    }
}
