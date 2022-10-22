namespace Airline_reservation
{
    partial class ticketform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ticket1 = new Airline_reservation.Ticket();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printbutton.Location = new System.Drawing.Point(487, 287);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(120, 35);
            this.printbutton.TabIndex = 30;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = false;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbutton.Location = new System.Drawing.Point(643, 287);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(120, 35);
            this.exitbutton.TabIndex = 31;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ticket1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 280);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // ticket1
            // 
            this.ticket1.date = null;
            this.ticket1.firstname = null;
            this.ticket1.flightclass = null;
            this.ticket1.from = null;
            this.ticket1.lastname = null;
            this.ticket1.Location = new System.Drawing.Point(3, 3);
            this.ticket1.Name = "ticket1";
            this.ticket1.passportnumber = null;
            this.ticket1.Size = new System.Drawing.Size(774, 262);
            this.ticket1.TabIndex = 0;
            this.ticket1.to = null;
            // 
            // ticketform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 322);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.printbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ticketform";
            this.Text = "ticketform";
            this.Load += new System.EventHandler(this.ticketform_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button exitbutton;
        private Ticket ticket1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}