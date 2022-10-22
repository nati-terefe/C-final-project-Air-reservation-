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

        private void resetbutton_Click(object sender, EventArgs e)
        {

            forgotpasswordstore fp = new forgotpasswordstore
            {
                fpusername = usernametextbox.Text,
                fppassword = newpasswordtextbox.Text,
                fphint= hinttextbox.Text,
            };
            if (string.IsNullOrEmpty(usernametextbox.Text))
            {
                usernameerror.SetError(usernametextbox, "user name can't be left empty");
            }
            if (string.IsNullOrEmpty(newpasswordtextbox.Text))
            {
                passworderror.SetError(newpasswordtextbox, "password can't be left empty");
            }
            if (string.IsNullOrEmpty(hinttextbox.Text))
            {
                hinterror.SetError(hinttextbox, "Hint can't be left empty");
            }
            // login validation 
            if (!string.IsNullOrEmpty(usernametextbox.Text) && !string.IsNullOrEmpty(newpasswordtextbox.Text) && !string.IsNullOrEmpty(hinttextbox.Text))
            {
                registerstore rs = new registerstore();
                string checkusername = usernametextbox.Text;
                string checkhint = hinttextbox.Text;
                string newpassword = newpasswordtextbox.Text;
                ////////////////////
                string mainusername = rs.registerusername;
                string mainhint = rs.registerhint;
                
                // resetting password
                if (checkusername == mainusername && checkhint == mainhint)
                { ////// write update sql statement
                    rs.registerpassword = newpassword;
                    rs.save();
                    MessageBox.Show("password have been resetted");
                }
            }
        }
    }
}
