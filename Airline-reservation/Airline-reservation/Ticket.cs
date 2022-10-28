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
    public partial class Ticket : UserControl
    {


        private string fn;



        bookinginfo binfo = new bookinginfo();
        public string firstname
        {
            get { return fn; }
            set { fn = value; firstnametextbox.Text = value; }
        }

        private string ln;
        public string lastname
        {
            get { return ln; }
            set { ln= value; lastnametextbox.Text = value; }
        }
        private string f;
        public string from
        {
            get { return f; }
            set { f = value; fromtextBox.Text = value; }
        }
        private string t;
        public string to
        {
            get { return t; }
            set { t = value; totextBox.Text = value; }
        }
        private string d;
        public string date
        {
            get { return d; }
            set { d = value; datetextbox.Text = value; }
        }
        private string fc;
        public string flightclass
        {
            get { return fc; }
            set { fc= value; flightclasstextbox.Text = value; }
        }
        private string pn;
        public string passportnumber
        {
            get { return pn; }
            set { pn = value; passporttextbox.Text = value; }
        }
        private int tid;
        public int ticketid
        {
            get { return tid; }
            set { tid = value; ticketidtextbox.Text = value.ToString(); }
        }
        
        /*private string fid;
        public string flgihtid
        {
            get { return fid; }
            set { fid = value; }
        }*/
        

        public Ticket()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
