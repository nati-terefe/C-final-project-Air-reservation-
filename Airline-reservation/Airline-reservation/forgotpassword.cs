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
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }

        private void forgotpassword_Load(object sender, EventArgs e)
        {
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent;
            newpasswordlabel.Parent = pictureBox1;
            newpasswordlabel.BackColor = Color.Transparent;
            hintlable.Parent = pictureBox1;
            hintlable.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
