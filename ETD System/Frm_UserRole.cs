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
    public partial class Frm_UserRole : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_UserRole()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_AddRole frm = new Frm_AddRole();
            frm.ShowDialog();
        }

        public void RoleList()
        {
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

        private void Frm_UserRole_Load(object sender, EventArgs e)
        {
            RoleList();
            cb_role.SelectedIndex = -1;
            text_role_id.Clear();
            GetModules();
            //dt_modules.Columns["module_id"].Visible = false;
            //dt_modules.Columns["fname"].Visible = false;
            //dt_modules.Columns["date_added"].Visible = false;
            //dt_modules.Columns["module_code"].Visible = false;
            dt_user_role.Columns["user_role_id"].Visible = false;
            dt_user_role.DataSource = null;
        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            role_tbl obj = cb_role.SelectedItem as role_tbl;
            if (obj != null)
            {
                text_role_id.Text = obj.role_id.ToString();
            }

            GetUserRole();
            GetModules();
        }

        public void GetModules()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetAvailableModules", con);
            cmd.Parameters.AddWithValue("@role_id", text_role_id.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_modules.DataSource = dt;
            con.Close();
        }

        private void dt_modules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_modules.SelectedRows.Count > 0)
            {
                btn_add.Enabled = true;
                //MessageBox.Show(""+ dt_modules.SelectedRows[0].Cells["module_id"].Value);
                label_add_module_id.Text = dt_modules.SelectedRows[0].Cells["module_id"].Value + string.Empty;
            }
            else if (dt_modules.SelectedRows.Count < 0)
            {
                btn_add.Enabled = false;
            }
        }

        private void InsertUserRole()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertUserRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@role", text_role_id.Text);
                cmd.Parameters.AddWithValue("@module", label_add_module_id.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_user_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        private void GetUserRole()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GetUserRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@role", text_role_id.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_user_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (text_role_id.Text == string.Empty)
            {
                MessageBox.Show("Please Select Role");
                cb_role.Focus();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //Some task…
                    CheckRoleExist();
                }
                if (res == DialogResult.No)
                {
                    //Some task…  
                }
            }
        }

        private void dt_user_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_user_role.SelectedRows.Count > 0)
            {
                btn_remove.Enabled = true;
                label_remove_module_id.Text = dt_user_role.SelectedRows[0].Cells["user_role_id"].Value + string.Empty;
            }
            else if (dt_modules.SelectedRows.Count < 0)
            {
                btn_remove.Enabled = false;
            }
        }

        private void ClearText()
        {

        }

        private void CheckRoleExist()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CheckRoleExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@role", int.Parse(label_add_module_id.Text));
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                con.Close();
                if (dt.Rows.Count >= 1)
                {
                    try
                    {
                        MessageBox.Show("Role is already exist!", "Insert Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
                else
                {
                    InsertUserRole();
                    GetUserRole();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DeleteUserRole()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_DeleteUserRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_role", int.Parse(label_remove_module_id.Text));
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_user_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (text_role_id.Text == string.Empty)
            {
                MessageBox.Show("Please Select Role");
                cb_role.Focus();
            }

            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to remove?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //Some task…
                    DeleteUserRole();
                    GetUserRole();
                }
                if (res == DialogResult.No)
                {
                    //Some task…  
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
