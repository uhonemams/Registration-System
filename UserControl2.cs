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

namespace Registration_System
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (useTxt.Text == "")
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (fnameTxt.Text == "")
            {
                MessageBox.Show("Please enter First Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lnameTxt.Text == "")
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (idTxt.Text == "")
            {
                MessageBox.Show("Please enter matching ID number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (phoneTxt.Text == "")
            {
                MessageBox.Show("Please enter matching Phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (courseTxt.Text == "")
            {
                MessageBox.Show("Please select a Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string status = "Applied";
            string gender = "Male";
            if (femaleTxt.Checked)
            {
                gender = "Female";
            }

            string cs = @"Data Source=LAPTOP-HA5U3ATN\SQLEXPRESS;Initial Catalog=DEV2AINST;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into applications (username, first_name, last_name, id_number, phone_number, gender, course, status ) values ('" + useTxt.Text + "', '" + fnameTxt.Text + "', '" + lnameTxt.Text + "', '" +idTxt.Text+ "', '" + phoneTxt.Text + "', '" + gender + "', '" + courseTxt.Text + "', '" + status + "'  )", con);

            con.Open();
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("Application Submitted");
            useTxt.Clear();
            fnameTxt.Clear();
            lnameTxt.Clear();
            idTxt.Clear();
            phoneTxt.Clear();
            courseTxt.Items.Clear();
            

        }

        private void useTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            useTxt.Text = Login.setvalue;
        }

        private void courseTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
