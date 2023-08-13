using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            UserControl1 uc1 = new UserControl1();
            addUserControl(uc1);
            
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            addUserControl(uc1);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void appliBtn_Click(object sender, EventArgs e)
        {
            UserControl2 uc2 = new UserControl2();
            addUserControl(uc2);
            
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            UserControl3 uc3 = new UserControl3();
            addUserControl(uc3);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
