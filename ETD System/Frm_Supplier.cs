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
    public partial class Frm_Supplier : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Supplier()
        {
            InitializeComponent();
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            GetSupplier();
            text_addedby.Text = User.fname;
        }

        private void ClearText()
        {
            text_sup_name.Clear();
            text_sup_add.Clear();
            text_sup_email.Clear();
            text_sup_mobile.Clear();
            cb_sup_status.SelectedIndex = -1;
        }

        private void InsertSupplier()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sup_name", text_sup_name.Text);
                cmd.Parameters.AddWithValue("@sup_address", text_sup_add.Text);
                cmd.Parameters.AddWithValue("@sup_email", text_sup_email.Text);
                cmd.Parameters.AddWithValue("@sup_mobile", text_sup_mobile.Text);
                cmd.Parameters.AddWithValue("@sup_status", label_status.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id.ToString());
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

        private void UpdateSupplier()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sup_id", label_sup_id.Text);
                cmd.Parameters.AddWithValue("@sup_name", text_sup_name.Text);
                cmd.Parameters.AddWithValue("@sup_address", text_sup_add.Text);
                cmd.Parameters.AddWithValue("@sup_email", text_sup_email.Text);
                cmd.Parameters.AddWithValue("@sup_mobile", text_sup_mobile.Text);
                cmd.Parameters.AddWithValue("@sup_status", label_status.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id.ToString());
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
                //dt_report.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void GetSupplier()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetSupplier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_supplier.DataSource = dt;
            con.Close();
        }

        private void cb_sup_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sup_status.SelectedIndex == -1)
            {
                cb_sup_status.Text = null;
            }
            if (cb_sup_status.Text == "Active")
            {
                label_status.Text = "1";
                Supplier.sup_status = true;
            }
            if (cb_sup_status.Text == "inActive")
            {
                label_status.Text = "0";
                Supplier.sup_status = false;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                InsertSupplier();
                GetSupplier();
                ClearText();
                //Some task…  
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }

        private void dt_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_supplier.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                label_sup_id.Text = dt_supplier.SelectedRows[0].Cells[0].Value + string.Empty;
                text_sup_name.Text = dt_supplier.SelectedRows[0].Cells[1].Value + string.Empty;
                text_sup_add.Text = dt_supplier.SelectedRows[0].Cells[2].Value + string.Empty;
                text_sup_email.Text = dt_supplier.SelectedRows[0].Cells[3].Value + string.Empty;
                text_sup_mobile.Text = dt_supplier.SelectedRows[0].Cells[4].Value + string.Empty;
                string x = (dt_supplier.SelectedRows[0].Cells[5].Value.ToString());
                if (x == "True")
                {
                    cb_sup_status.Text = "Active";
                }
                else
                {
                    cb_sup_status.Text = "inActive";
                }
                text_addedby.Text = dt_supplier.SelectedRows[0].Cells[6].Value + string.Empty;
            }
            else if (dt_supplier.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                UpdateSupplier();
                GetSupplier();
                ClearText();
                con.Close();
                //Some task…  
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
    }
}
