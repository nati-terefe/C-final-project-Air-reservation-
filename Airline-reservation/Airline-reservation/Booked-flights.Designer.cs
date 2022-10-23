namespace Airline_reservation
{
    partial class Booked_flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booked_flights));
            this.flightinfodgf = new System.Windows.Forms.DataGridView();
            this.bookedflightlabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flightinfodgf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // flightinfodgf
            // 
            this.flightinfodgf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightinfodgf.Location = new System.Drawing.Point(-1, 96);
            this.flightinfodgf.Name = "flightinfodgf";
            this.flightinfodgf.Size = new System.Drawing.Size(803, 352);
            this.flightinfodgf.TabIndex = 0;
            this.flightinfodgf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookedflightlabel
            // 
            this.bookedflightlabel.AutoSize = true;
            this.bookedflightlabel.Font = new System.Drawing.Font("Yu Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookedflightlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookedflightlabel.Location = new System.Drawing.Point(255, 9);
            this.bookedflightlabel.Name = "bookedflightlabel";
            this.bookedflightlabel.Size = new System.Drawing.Size(282, 48);
            this.bookedflightlabel.TabIndex = 87;
            this.bookedflightlabel.Text = "Booked flights";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, -2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 92);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 88;
            this.logo.TabStop = false;
            // 
            // Booked_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bookedflightlabel);
            this.Controls.Add(this.flightinfodgf);
            this.Name = "Booked_flights";
            this.Text = "Booked_flights";
            this.Load += new System.EventHandler(this.Booked_flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightinfodgf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flightinfodgf;
        private System.Windows.Forms.Label bookedflightlabel;
        private System.Windows.Forms.PictureBox logo;
    }
}