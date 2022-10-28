using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            flightinfodgf.DataSource = null;
            flightinfodgf.DataSource = bookinginfo.getall();

        }
    }
}
