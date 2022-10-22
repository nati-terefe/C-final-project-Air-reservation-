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
    public partial class flight_edit : Form
    {
        public flight_edit()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void addbuttom_Click(object sender, EventArgs e)
        { string add = removeaddtextbox.Text;
            // write insert sql code that will add the new place to the table called destination
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            string remove = removeaddtextbox.Text;
            // write delete sql with where=remove that will remove flight destination from the table destination
        }
    }
}
