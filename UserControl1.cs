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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            userlbl.Text = Login.setvalue;
            string conn = @"Data Source=LAPTOP-HA5U3ATN\SQLEXPRESS;Initial Catalog=DEV2AINST;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            string querry = "SELECT email FROM registration WHERE username = '" + userlbl.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();

            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    emaillbl.Text = reader["email"].ToString();
                }
            }
            con.Close();

            string querry2 = "SELECT status FROM applications WHERE username = '" + userlbl.Text + "'";
            SqlCommand cmd2 = new SqlCommand(querry2, con);
            con.Open();

            using (SqlDataReader reader2 = cmd2.ExecuteReader())
            {
                if (reader2.Read())
                {
                    statuslbl.Text = "";
                    statuslbl.Text = reader2["status"].ToString();
                }
            }
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
