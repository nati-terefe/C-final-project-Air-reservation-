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
    public partial class ticketform : Form
    {
      private  string fn;

       
        /*
        flightinfo fi = new flightinfo();
        public string firstname
        {
            get { return fn; }
            set { fn= value; firstnametextbox.Text = value; }
        }
        */
        public ticketform()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
