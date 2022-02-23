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
    public partial class Frm_Customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Customer()
        {
            InitializeComponent();
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            text_addedby.Text = User.fname.ToString();
            GetCustomer();
            label_user.Text = User.user_id.ToString();
        }

        private void InsertCustomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_name", text_cname.Text);
                cmd.Parameters.AddWithValue("@c_address", text_cadderss.Text);
                cmd.Parameters.AddWithValue("@c_email", text_eaddress.Text);
                cmd.Parameters.AddWithValue("@c_mobile", text_cmobile.Text);
                cmd.Parameters.AddWithValue("@c_status", label_status.Text);
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

        private void UpdateCustomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_id", label_customer_id.Text);
                cmd.Parameters.AddWithValue("@c_name", text_cname.Text);
                cmd.Parameters.AddWithValue("@c_address", text_cadderss.Text);
                cmd.Parameters.AddWithValue("@c_email", text_eaddress.Text);
                cmd.Parameters.AddWithValue("@c_mobile", text_cmobile.Text);
                cmd.Parameters.AddWithValue("@c_status", label_status.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
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

        public void GetCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_customer.DataSource = dt;
            con.Close();
        }

        private void cb_cstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cstatus.SelectedIndex == -1)
            {
                cb_cstatus.Text = null;
            }
            if (cb_cstatus.Text == "Active")
            {
                label_status.Text = "1";
            }
            if (cb_cstatus.Text == "inActive")
            {
                label_status.Text = "0";
            }
        }

        private void ClearText()
        {
            text_cname.Clear();
            text_cadderss.Clear();
            text_eaddress.Clear();
            text_cmobile.Clear();
            cb_cstatus.SelectedIndex = -1;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                InsertCustomer();
                GetCustomer();
                ClearText();
                //Some task…  
            }
            if (res == DialogResult.No)
            {

                //Some task…  
            }
        }

        private void dt_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_customer.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                label_customer_id.Text = dt_customer.SelectedRows[0].Cells[0].Value + string.Empty;
                text_cname.Text = dt_customer.SelectedRows[0].Cells[1].Value + string.Empty;
                text_cadderss.Text = dt_customer.SelectedRows[0].Cells[2].Value + string.Empty;
                text_eaddress.Text = dt_customer.SelectedRows[0].Cells[3].Value + string.Empty;
                text_cmobile.Text = dt_customer.SelectedRows[0].Cells[4].Value + string.Empty;
                string x = (dt_customer.SelectedRows[0].Cells[5].Value.ToString());
                //MessageBox.Show("" + x);
                if (x == "True")
                {
                    cb_cstatus.Text = "Active";
                }
                //if(x == "")
                //{
                //    text_status.Text = null;
                //}
                else
                {
                    cb_cstatus.Text = "inActive";
                }
                text_addedby.Text = dt_customer.SelectedRows[0].Cells[6].Value + string.Empty;
            }
            else if (dt_customer.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                UpdateCustomer();
                GetCustomer();
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
