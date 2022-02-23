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
    public partial class Frm_UserAccount : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_UserAccount()
        {
            InitializeComponent();
        }

        private void Frm_UserAccount_Load(object sender, EventArgs e)
        {
            RoleList();
            cb_role.SelectedIndex = -1;
            GetUsers();
        }

        private void InsertUser()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", text_user.Text);
                cmd.Parameters.AddWithValue("@pass", text_pass.Text);
                cmd.Parameters.AddWithValue("@fname", text_fname.Text);
                cmd.Parameters.AddWithValue("@mname", text_mname.Text);
                cmd.Parameters.AddWithValue("@lname", text_lname.Text);
                cmd.Parameters.AddWithValue("@mobile", text_mobile.Text);
                cmd.Parameters.AddWithValue("@status", label_status.Text);
                cmd.Parameters.AddWithValue("@role", label_role_id.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        private void UpdateUser()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_id", label_user_id.Text);
                cmd.Parameters.AddWithValue("@user", text_user.Text);
                cmd.Parameters.AddWithValue("@pass", text_pass.Text);
                cmd.Parameters.AddWithValue("@fname", text_fname.Text);
                cmd.Parameters.AddWithValue("@mname", text_mname.Text);
                cmd.Parameters.AddWithValue("@lname", text_lname.Text);
                cmd.Parameters.AddWithValue("@mobile", text_mobile.Text);
                cmd.Parameters.AddWithValue("@status", label_status.Text);
                cmd.Parameters.AddWithValue("@role", label_role_id.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        public void GetUsers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_user.DataSource = dt;
            con.Close();
        }

        public void RoleList()
        {
            cb_role.SelectedIndex = -1;
            try
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    cb_role.DataSource = db.role_tbl.ToList();
                    cb_role.ValueMember = "role_id";
                    cb_role.DisplayMember = "role_name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_status.SelectedIndex == -1)
            {
                cb_status.Text = null;
            }
            if(cb_status.Text == "Active")
            {
                label_status.Text = "1";
            }
            if(cb_status.Text == "inActive")
            {
                label_status.Text = "0";
            }
        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_role.SelectedIndex == -1)
            {
                label_role_id.Text = null;
            }

            role_tbl obj = cb_role.SelectedItem as role_tbl;
            if (obj != null)
            {
                label_role_id.Text = obj.role_id.ToString();
                //Item.role_id = obj.role_id;
            }
        }

        private void CleartextUser()
        {
            text_fname.Clear();
            text_mname.Clear();
            text_lname.Clear();
            text_user.Clear();
            text_pass.Clear();
            text_mobile.Clear();
            cb_role.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                InsertUser();
                CleartextUser();
                GetUsers();
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }

        private void dt_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_user.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                label_user_id.Text = dt_user.SelectedRows[0].Cells[0].Value + string.Empty;
                //Item.update_prod_id = int.Parse(text_prod_id.Text);
                text_user.Text = dt_user.SelectedRows[0].Cells[1].Value + string.Empty;
                text_pass.Text = dt_user.SelectedRows[0].Cells[2].Value + string.Empty;
                text_fname.Text = dt_user.SelectedRows[0].Cells[3].Value + string.Empty;
                text_mname.Text = dt_user.SelectedRows[0].Cells[4].Value + string.Empty;
                text_lname.Text = dt_user.SelectedRows[0].Cells[5].Value + string.Empty;
                text_mobile.Text = dt_user.SelectedRows[0].Cells[6].Value + string.Empty;
                cb_role.Text = dt_user.SelectedRows[0].Cells[7].Value + string.Empty;
                string x = (dt_user.SelectedRows[0].Cells[8].Value.ToString());
                //MessageBox.Show("" + x);
                if (x == "True")
                {
                    cb_status.Text = "Active";
                }
                //if(x == "")
                //{
                //    text_status.Text = null;
                //}
                else
                {
                    cb_status.Text = "inActive";
                }
                
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                UpdateUser();
                CleartextUser();
                GetUsers();
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
