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
    public partial class Frm_Modules : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Modules()
        {
            InitializeComponent();
        }

        private void Frm_Modules_Load(object sender, EventArgs e)
        {
            text_addedby.Text = User.fname;
            text_added_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            label_user_id.Text = User.user_id.ToString();
            GetModules();
        }

        private void InsertUser()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertModule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", text_module_code.Text);
                cmd.Parameters.AddWithValue("@module_name", text_module_name.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_module.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            con.Close();
        }

        public void GetModules()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetModules", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_module.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                InsertUser();
                GetModules();
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
            
        }
    }
}
