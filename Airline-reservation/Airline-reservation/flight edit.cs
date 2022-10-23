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
        { 
            string add = removeaddtextbox.Text;
            string dbstring="F";
            // write insert sql code that will add the new place to the table called destination
            if(add== dbstring)
            {
                MessageBox.Show("the flight already exists");
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            string remove = removeaddtextbox.Text;
            // write delete sql with where=remove that will remove flight destination from the table destination
            string dbstring = "F";
            if (remove != dbstring)
            {
                MessageBox.Show("the flight doesn't exists");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flight_edit_Load(object sender, EventArgs e)
        {
            editflightlabel.Parent = pictureBox1;
            editflightlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;

        }
    }
}
