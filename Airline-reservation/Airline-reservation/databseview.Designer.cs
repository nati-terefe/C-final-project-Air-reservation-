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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.bookedflightlabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.regusersbutton = new System.Windows.Forms.Button();
            this.flightslistbutton = new System.Windows.Forms.Button();
            this.bookedticketsbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.loginhistorybtn = new System.Windows.Forms.Button();
            this.messagesbutton = new System.Windows.Forms.Button();
            this.pilotsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(235, 113);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.Size = new System.Drawing.Size(1179, 385);
            this.datagridview.TabIndex = 0;
            this.datagridview.Visible = false;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookedflightlabel
            // 
            this.bookedflightlabel.AutoSize = true;
            this.bookedflightlabel.Font = new System.Drawing.Font("Yu Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookedflightlabel.ForeColor = System.Drawing.Color.Teal;
            this.bookedflightlabel.Location = new System.Drawing.Point(572, 33);
            this.bookedflightlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookedflightlabel.Name = "bookedflightlabel";
            this.bookedflightlabel.Size = new System.Drawing.Size(367, 60);
            this.bookedflightlabel.TabIndex = 87;
            this.bookedflightlabel.Text = "Database View";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, -2);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(228, 113);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 88;
            this.logo.TabStop = false;
            // 
            // regusersbutton
            // 
            this.regusersbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.regusersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regusersbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regusersbutton.Location = new System.Drawing.Point(38, 137);
            this.regusersbutton.Margin = new System.Windows.Forms.Padding(4);
            this.regusersbutton.Name = "regusersbutton";
            this.regusersbutton.Size = new System.Drawing.Size(160, 43);
            this.regusersbutton.TabIndex = 89;
            this.regusersbutton.Text = "Registered Users";
            this.regusersbutton.UseVisualStyleBackColor = false;
            this.regusersbutton.Click += new System.EventHandler(this.regusersbutton_Click);
            // 
            // flightslistbutton
            // 
            this.flightslistbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.flightslistbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightslistbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightslistbutton.Location = new System.Drawing.Point(38, 269);
            this.flightslistbutton.Margin = new System.Windows.Forms.Padding(4);
            this.flightslistbutton.Name = "flightslistbutton";
            this.flightslistbutton.Size = new System.Drawing.Size(160, 43);
            this.flightslistbutton.TabIndex = 90;
            this.flightslistbutton.Text = "Flights List";
            this.flightslistbutton.UseVisualStyleBackColor = false;
            this.flightslistbutton.Click += new System.EventHandler(this.flightslistbutton_Click);
            // 
            // bookedticketsbutton
            // 
            this.bookedticketsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.bookedticketsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookedticketsbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookedticketsbutton.Location = new System.Drawing.Point(38, 204);
            this.bookedticketsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.bookedticketsbutton.Name = "bookedticketsbutton";
            this.bookedticketsbutton.Size = new System.Drawing.Size(160, 43);
            this.bookedticketsbutton.TabIndex = 91;
            this.bookedticketsbutton.Text = "Booked Tickets";
            this.bookedticketsbutton.UseVisualStyleBackColor = false;
            this.bookedticketsbutton.Click += new System.EventHandler(this.bookedticketsbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backbutton.Location = new System.Drawing.Point(1215, 506);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(160, 43);
            this.backbutton.TabIndex = 92;
            this.backbutton.Text = "Go Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // loginhistorybtn
            // 
            this.loginhistorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.loginhistorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginhistorybtn.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginhistorybtn.Location = new System.Drawing.Point(38, 396);
            this.loginhistorybtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginhistorybtn.Name = "loginhistorybtn";
            this.loginhistorybtn.Size = new System.Drawing.Size(160, 43);
            this.loginhistorybtn.TabIndex = 93;
            this.loginhistorybtn.Text = "Login History";
            this.loginhistorybtn.UseVisualStyleBackColor = false;
            this.loginhistorybtn.Click += new System.EventHandler(this.loginhistorybtn_Click);
            // 
            // messagesbutton
            // 
            this.messagesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.messagesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messagesbutton.Location = new System.Drawing.Point(38, 455);
            this.messagesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.messagesbutton.Name = "messagesbutton";
            this.messagesbutton.Size = new System.Drawing.Size(160, 43);
            this.messagesbutton.TabIndex = 94;
            this.messagesbutton.Text = "Messages";
            this.messagesbutton.UseVisualStyleBackColor = false;
            this.messagesbutton.Click += new System.EventHandler(this.messagesbutton_Click);
            // 
            // pilotsbtn
            // 
            this.pilotsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.pilotsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pilotsbtn.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pilotsbtn.Location = new System.Drawing.Point(38, 333);
            this.pilotsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pilotsbtn.Name = "pilotsbtn";
            this.pilotsbtn.Size = new System.Drawing.Size(160, 43);
            this.pilotsbtn.TabIndex = 95;
            this.pilotsbtn.Text = "Pilots";
            this.pilotsbtn.UseVisualStyleBackColor = false;
            this.pilotsbtn.Click += new System.EventHandler(this.pilotsbtn_Click);
            // 
            // Booked_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1412, 554);
            this.Controls.Add(this.pilotsbtn);
            this.Controls.Add(this.messagesbutton);
            this.Controls.Add(this.loginhistorybtn);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.bookedticketsbutton);
            this.Controls.Add(this.flightslistbutton);
            this.Controls.Add(this.regusersbutton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bookedflightlabel);
            this.Controls.Add(this.datagridview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booked_flights";
            this.Text = "Booked_flights";
            this.Load += new System.EventHandler(this.Booked_flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label bookedflightlabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button regusersbutton;
        private System.Windows.Forms.Button flightslistbutton;
        private System.Windows.Forms.Button bookedticketsbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button loginhistorybtn;
        private System.Windows.Forms.Button messagesbutton;
        private System.Windows.Forms.Button pilotsbtn;
    }
}