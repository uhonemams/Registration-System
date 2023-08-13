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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

            string cs = @"Data Source=LAPTOP-HA5U3ATN\SQLEXPRESS;Initial Catalog=DEV2AINST;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM applications", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
