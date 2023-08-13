using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Registration_System
{
    public partial class Registration : Form
    {
        HashCode hc = new HashCode();
        public Registration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool isvalid = regex.IsMatch(emailTxt.Text);
            
            
            if(usernameTxt.Text == "")
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(emailTxt.Text == "")
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(isvalid != true)
            {
                MessageBox.Show("Please enter a valid email!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passTxt.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (repassTxt.Text == "")
            {
                MessageBox.Show("Please enter matching password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ;
            string pas = passTxt.Text;
            string repas = repassTxt.Text;

            if (pas == repas)
            {
                string cs = @"Data Source=LAPTOP-HA5U3ATN\SQLEXPRESS;Initial Catalog=DEV2AINST;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("insert into registration (username, password, email) values ('" + usernameTxt.Text + "', '" + hc.PassHash(passTxt.Text) + "', '" + emailTxt.Text + "' )", con);

                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("Successfully Saved");
                Login f2 = new Login();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
