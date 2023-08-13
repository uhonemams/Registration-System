namespace Registration_System
{
    partial class UserControl1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Profile";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = global::Registration_System.Properties.Resources.hacker__1_;
            this.pictureBox2.Location = new System.Drawing.Point(232, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 129);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Application Status: ";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(218, 213);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(0, 18);
            this.userlbl.TabIndex = 12;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(237, 245);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 15);
            this.emaillbl.TabIndex = 13;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(272, 275);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(103, 18);
            this.statuslbl.TabIndex = 14;
            this.statuslbl.Text = "No Application";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(629, 410);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label statuslbl;
    }
}
