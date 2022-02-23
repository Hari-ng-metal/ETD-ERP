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
    public partial class Frm_UpdateItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");

        Frm_Item frm_inv;
        public Frm_UpdateItem(Frm_Item frm_inventory)
        {
            InitializeComponent();
            this.frm_inv = frm_inventory;
        }

        private void Frm_UpdateItem_Load(object sender, EventArgs e)
        {
            //label_prod_id.Text = Item.update_prod_id.ToString();
            CategoryList();
        }

        public void CategoryList()
        {
            cb_category.SelectedIndex = -1;
            try
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    cb_category.DataSource = db.category_tbl.ToList();
                    cb_category.ValueMember = "category_id";
                    cb_category.DisplayMember = "category_name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            category_tbl obj = cb_category.SelectedItem as category_tbl;
            if (obj != null)
            {
                label_category_id.Text = obj.category_id.ToString();
                Item.category_id = obj.category_id;
            }
        }

        private void UpdateItem()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateItems", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@product_id", label_prod_id.Text);
                cmd.Parameters.AddWithValue("@code", text_code.Text);
                cmd.Parameters.AddWithValue("@desc", text_desc.Text);
                cmd.Parameters.AddWithValue("@category", label_category_id.Text);
                cmd.Parameters.AddWithValue("@price", text_price.Text);
                cmd.Parameters.AddWithValue("@buffer", text_buffer.Text);
                cmd.Parameters.AddWithValue("@status", label_status.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                UpdateItem();
                frm_inv.GetItems();
                this.Close();

                //Some task…  
            }
            if (res == DialogResult.No)
            {

                //Some task…  
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.Text == "Active")
            {
                Item.item_status = true;
                label_status.Text = Item.item_status.ToString();
            }
            if (cb_status.Text == "inActive")
            {
                Item.item_status = false;
                label_status.Text = Item.item_status.ToString();
            }
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void text_buffer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
