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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {
            searchlabel.Parent = pictureBox1;
            searchlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
        }

        private void Editinfo_Click(object sender, EventArgs e)
        {
           
            this.lntextbox.ReadOnly = false;
            this.fromtextbox.ReadOnly = false;
            this.totextbox.ReadOnly = false;
            this.gendertextbox.ReadOnly = false;
            this.emailtextbox.ReadOnly = false;
            this.passportnumbertextbox.ReadOnly = false;
            this.fntextbox.ReadOnly = false;
            this.departuretextbox.ReadOnly = false;
            this.agetextbox.ReadOnly = false;
            this.flightclasstextbox.ReadOnly = false;
            this.flighttypetextbox.ReadOnly = false;
            // making save button visible when edit profile button is clicked
            this.savebutton.Visible = true;
        }

        private void deleteflightbutton_Click(object sender, EventArgs e)
        {
            //write delete sql code that will take the flight id at the where statement
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            // write select sql code that will take flight id as where and then load it to the text box's
            fntextbox.Text = "nati"; 
        }
    }
}
