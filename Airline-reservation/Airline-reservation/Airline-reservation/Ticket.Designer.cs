namespace Airline_reservation
{
    partial class Ticket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fromtextBox = new System.Windows.Forms.TextBox();
            this.totextBox = new System.Windows.Forms.TextBox();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.lastnametextbox = new System.Windows.Forms.TextBox();
            this.passporttextbox = new System.Windows.Forms.TextBox();
            this.flightclasstextbox = new System.Windows.Forms.TextBox();
            this.datetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fromtextBox
            // 
            this.fromtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromtextBox.Location = new System.Drawing.Point(98, 126);
            this.fromtextBox.Multiline = true;
            this.fromtextBox.Name = "fromtextBox";
            this.fromtextBox.Size = new System.Drawing.Size(141, 20);
            this.fromtextBox.TabIndex = 1;
            // 
            // totextBox
            // 
            this.totextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totextBox.Location = new System.Drawing.Point(282, 126);
            this.totextBox.Multiline = true;
            this.totextBox.Name = "totextBox";
            this.totextBox.Size = new System.Drawing.Size(146, 20);
            this.totextBox.TabIndex = 2;
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnametextbox.Location = new System.Drawing.Point(98, 201);
            this.firstnametextbox.Multiline = true;
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(141, 20);
            this.firstnametextbox.TabIndex = 3;
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnametextbox.Location = new System.Drawing.Point(254, 201);
            this.lastnametextbox.Multiline = true;
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(174, 20);
            this.lastnametextbox.TabIndex = 4;
            // 
            // passporttextbox
            // 
            this.passporttextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passporttextbox.Location = new System.Drawing.Point(13, 264);
            this.passporttextbox.Multiline = true;
            this.passporttextbox.Name = "passporttextbox";
            this.passporttextbox.Size = new System.Drawing.Size(180, 20);
            this.passporttextbox.TabIndex = 5;
            // 
            // flightclasstextbox
            // 
            this.flightclasstextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightclasstextbox.Location = new System.Drawing.Point(238, 264);
            this.flightclasstextbox.Multiline = true;
            this.flightclasstextbox.Name = "flightclasstextbox";
            this.flightclasstextbox.Size = new System.Drawing.Size(190, 20);
            this.flightclasstextbox.TabIndex = 6;
            // 
            // datetextbox
            // 
            this.datetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datetextbox.Location = new System.Drawing.Point(583, 102);
            this.datetextbox.Multiline = true;
            this.datetextbox.Name = "datetextbox";
            this.datetextbox.Size = new System.Drawing.Size(187, 20);
            this.datetextbox.TabIndex = 7;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datetextbox);
            this.Controls.Add(this.flightclasstextbox);
            this.Controls.Add(this.passporttextbox);
            this.Controls.Add(this.lastnametextbox);
            this.Controls.Add(this.firstnametextbox);
            this.Controls.Add(this.totextBox);
            this.Controls.Add(this.fromtextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ticket";
            this.Size = new System.Drawing.Size(770, 287);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fromtextBox;
        private System.Windows.Forms.TextBox totextBox;
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.TextBox lastnametextbox;
        private System.Windows.Forms.TextBox passporttextbox;
        private System.Windows.Forms.TextBox flightclasstextbox;
        private System.Windows.Forms.TextBox datetextbox;
       // private System.Windows.Forms.TextBox flgihtid;
    }
}
