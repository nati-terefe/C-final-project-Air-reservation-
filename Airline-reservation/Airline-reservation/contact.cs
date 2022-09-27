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
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void contact_Load(object sender, EventArgs e)
        {
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor = Color.Transparent;
            lastnamelabel.Parent = pictureBox1;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent;
            messagelabel.Parent = pictureBox1;
            messagelabel.BackColor = Color.Transparent;
            //logo.Parent = pictureBox1;
            //logo.BackColor = Color.Transparent;
        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will contact you soon.");
        }
    }
}
