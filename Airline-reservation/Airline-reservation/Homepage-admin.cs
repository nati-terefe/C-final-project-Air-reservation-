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
    public partial class Homepage_admin : Form
    {
        public Homepage_admin()
        {
            InitializeComponent();
        }

        private void addadminbutton_Click(object sender, EventArgs e)
        {
            add_admin ad = new add_admin();
            ad.Show();
        }

        private void bookticketbutton_Click(object sender, EventArgs e)
        {
        
            Bookticket_admin bt = new Bookticket_admin();
            bt.Show();

        }

        private void bookedticketbutton_Click(object sender, EventArgs e)
        {
          Booked_flights bf = new Booked_flights();
            bf.Show();
        }

        private void saveandexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Homepage_admin_Load(object sender, EventArgs e)
        {  // making the edit profile transparent
            Editprofile.Parent = bgpic;
            Editprofile.BackColor = Color.Transparent;
            Editprofile.FlatAppearance.BorderSize = 0;
            // making the labels and the logo transparent 
            usernamelabel.Parent = bgpic;
            usernamelabel.BackColor = Color.Transparent;

            firstnamelabel.Parent = bgpic;
            firstnamelabel.BackColor = Color.Transparent;
            lastnamelabel.Parent = bgpic;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = bgpic;
            emaillabel.BackColor = Color.Transparent;
            phonelabel.Parent = bgpic;
            phonelabel.BackColor = Color.Transparent;
            birthdatelabel.Parent = bgpic;
            birthdatelabel.BackColor = Color.Transparent;
            genderlabel.Parent = bgpic;
            genderlabel.BackColor = Color.Transparent;

            logo.Parent = bgpic;
            logo.BackColor = Color.Transparent;
            // making save button invisible
            this.savebutton.Visible = false;
        }

        private void Editprofile_Click(object sender, EventArgs e)
        {
            
        }

        private void Editprofile_Click_1(object sender, EventArgs e)
        {
            this.usernameblank.ReadOnly = false;
            this.lastnameblank.ReadOnly = false;
            this.birthdateblank.ReadOnly = false;
            this.genderblank.ReadOnly = false;
            this.emailblank.ReadOnly = false;
            this.phoneblank.ReadOnly = false;
            this.firstnameblank.ReadOnly = false;
            // making save button visible when edit profile button is clicked
            this.savebutton.Visible = true;
        }
    }
}
