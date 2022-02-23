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

namespace ETD_System
{
    public partial class Frm_Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetLoginUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", text_user.Text);
            cmd.Parameters.AddWithValue("@pass", text_password.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            //dt_report.DataSource = dt;
            if (dt.Rows.Count == 1)
            {
                try
                {
                    User.user_id = Convert.ToInt32(dt.Rows[0]["user_id"].ToString());
                    User.fname = dt.Rows[0]["fname"].ToString();
                    User.role_id = int.Parse(dt.Rows[0]["role"].ToString());


                    Frm_Main main = new Frm_Main();
                    main.Show();

                    //this.Close();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or passwprd", "Login Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void text_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.facebook.com/etdsolar/");
        }
    }
}
