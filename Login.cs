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
    public partial class Login : Form
    {
        HashCode hc = new HashCode();
        public static string setvalue; 
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string username, password;
            username = userTxt.Text;
            password = passwTxt.Text;
            string conn = @"Data Source=LAPTOP-HA5U3ATN\SQLEXPRESS;Initial Catalog=DEV2AINST;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            try
            {
                string querry = "SELECT username, password FROM registration WHERE username = '" + userTxt.Text + "' AND password = '" + hc.PassHash(passwTxt.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = userTxt.Text;
                    password = passwTxt.Text;

                    setvalue = userTxt.Text;
                    //page to be loaded next
                    Profile f2 = new Profile();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userTxt.Clear();
                    passwTxt.Clear();

                    userTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
