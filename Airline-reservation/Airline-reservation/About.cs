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
            aboutusbodylabel.Parent = pictureBox1;
            aboutusbodylabel.BackColor=Color.Transparent;

            // stopping the textbox from selecting itself when the form starts
            //aboutustextbox.SelectionStart = 0;
            //aboutustextbox.SelectionLength = 0;

            /////making the buttons transparent
            
            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            ////////////// register header button //////////////////
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent;
            registerheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// About us header button //////////////////
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent;
            aboutheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// contact us header button //////////////////
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent;
            contactheaderbutton.FlatAppearance.BorderSize = 0;

            /////making the buttons transparent

            ///////////////////login header button ///////////////////
            loginheaderbutton.Parent = pictureBox1;
            loginheaderbutton.BackColor = Color.Transparent;
            loginheaderbutton.FlatAppearance.BorderSize = 0; // removing the boarder of the button
            ////////////// register header button //////////////////
            registerheaderbutton.Parent = pictureBox1;
            registerheaderbutton.BackColor = Color.Transparent;
            registerheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// About us header button //////////////////
            aboutheaderbutton.Parent = pictureBox1;
            aboutheaderbutton.BackColor = Color.Transparent;
            aboutheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// contact us header button //////////////////
            contactheaderbutton.Parent = pictureBox1;
            contactheaderbutton.BackColor = Color.Transparent;
            contactheaderbutton.FlatAppearance.BorderSize = 0;
            ////////////// faq header button //////////////////
            faqheaderbuttom.Parent = pictureBox1;
            faqheaderbuttom.BackColor = Color.Transparent;
            faqheaderbuttom.FlatAppearance.BorderSize = 0;


        }

        private void aboutustextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginheaderbutton_Click(object sender, EventArgs e)
        {
           
            login l = new login();
           
            l.Show();
            Hide();
        }

        private void registerheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            r.Show();
            Hide();
        }

        private void contactheaderbutton_Click(object sender, EventArgs e)
        {
            register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            c.Show();
            Hide();
        }

        private void aboutheaderbutton_Click(object sender, EventArgs e)
        {
            /*register r = new register();
            login l = new login();
            contact c = new contact();
            About a = new About();
            a.Show();
            Hide(); */
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void faqheaderbuttom_Click(object sender, EventArgs e)
        {
           FAQ a = new FAQ();
            a.Show();
            Hide();
        }
    }
}
