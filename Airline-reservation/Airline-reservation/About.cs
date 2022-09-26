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
            

        }

        private void aboutustextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
