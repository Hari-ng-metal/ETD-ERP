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
    public partial class Frm_AddRole : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_AddRole()
        {
            InitializeComponent();
        }

        private void Frm_AddRole_Load(object sender, EventArgs e)
        {
            text_addedby.Text = User.fname;
            text_added_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            GetRoles();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool x = true;
            bool y = false;
            if(cb_status.Text == "Active")
            {
                label_status.Text = x.ToString();
            }
            else if(cb_status.Text == "inActive")
            {
                label_status.Text = y.ToString();
            }
        }

        private void InsertRole()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@role", text_role.Text);
                cmd.Parameters.AddWithValue("@status", label_status.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        public void GetRoles()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetRoles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_role.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                InsertRole();
                GetRoles();
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }
    }
}
