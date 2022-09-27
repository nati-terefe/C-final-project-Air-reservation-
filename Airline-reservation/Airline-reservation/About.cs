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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            aboutlabel.Parent = pictureBox1;
            aboutlabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            // stopping the textbox from selecting itself when the form starts
            aboutustextbox.SelectionStart = 0;
            aboutustextbox.SelectionLength = 0;

        }

        private void aboutustextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
