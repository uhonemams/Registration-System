namespace Registration_System
{
    partial class Profile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.appliBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 37);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Registration_System.Properties.Resources.close__2_;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(585, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 31);
            this.button4.TabIndex = 0;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.appliBtn);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 450);
            this.panel1.TabIndex = 2;
            // 
            // adminBtn
            // 
            this.adminBtn.BackgroundImage = global::Registration_System.Properties.Resources.unauthorized_person;
            this.adminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.adminBtn.Location = new System.Drawing.Point(3, 232);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(165, 43);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // appliBtn
            // 
            this.appliBtn.BackgroundImage = global::Registration_System.Properties.Resources.apply__1_;
            this.appliBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appliBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appliBtn.FlatAppearance.BorderSize = 0;
            this.appliBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.appliBtn.Location = new System.Drawing.Point(3, 183);
            this.appliBtn.Name = "appliBtn";
            this.appliBtn.Size = new System.Drawing.Size(165, 43);
            this.appliBtn.TabIndex = 2;
            this.appliBtn.Text = "Application Form";
            this.appliBtn.UseVisualStyleBackColor = true;
            this.appliBtn.Click += new System.EventHandler(this.appliBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackgroundImage = global::Registration_System.Properties.Resources.user__2_;
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.profileBtn.Location = new System.Drawing.Point(6, 134);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(165, 43);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 128);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registration_System.Properties.Resources._116252178_padded_logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(171, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 413);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button appliBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}