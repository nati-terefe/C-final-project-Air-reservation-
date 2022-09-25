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
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {  // making the labels transparent 
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent;
            
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
