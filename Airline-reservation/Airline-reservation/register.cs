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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            // making the labels and the logo transparent 
            usernamelabel.Parent = pictureBox1;
            usernamelabel.BackColor = Color.Transparent;
            passwordlabel.Parent = pictureBox1;
            passwordlabel.BackColor = Color.Transparent;
            firstnamelabel.Parent = pictureBox1;
            firstnamelabel.BackColor=Color.Transparent;
            lastnamelabel.Parent= pictureBox1;
            lastnamelabel.BackColor = Color.Transparent;
            emaillabel.Parent = pictureBox1;
            emaillabel.BackColor = Color.Transparent;
            phonelabel.Parent= pictureBox1;
            phonelabel.BackColor = Color.Transparent;
            birthdatelabel.Parent = pictureBox1;
            birthdatelabel.BackColor = Color.Transparent;
            genderlabel.Parent = pictureBox1;
            genderlabel.BackColor = Color.Transparent;
            registerlabel.Parent = pictureBox1;
            registerlabel.BackColor = Color.Transparent;
            profilepicturelabel.Parent = pictureBox1;
            profilepicturelabel.BackColor = Color.Transparent;
            logo.Parent = pictureBox1;
            logo.BackColor = Color.Transparent;
           

            



        }

        private void upload_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();  // open file dialog   

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {
                
             profilepicture.Image = new Bitmap(open.FileName);// display image in picture box  

             //textBox1.Text = open.FileName;  // image file path  
            }
        }
    }
}
