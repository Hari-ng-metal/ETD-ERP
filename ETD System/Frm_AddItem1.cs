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
    public partial class Frm_AddItem1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");

        Frm_Item frm_inv;
        public Frm_AddItem1(Frm_Item frm_inventory)
        {
            InitializeComponent();
            this.frm_inv = frm_inventory;
        }
        

        public void GetCategoryList() //list of category
        {

            string query = "Select category_name, category_id from category_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string cat = myreader.GetString(1);
                    cb_category.Items.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Frm_AddItem1_Load(object sender, EventArgs e)
        {
            text_code.Focus();
            CategoryList();
            cb_category.Text = "";
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_status.Text == "Active")
            {
                Item.item_status = true;
                label_status.Text = Item.item_status.ToString();
            }
            if(cb_status.Text == "inActive")
            {
                Item.item_status = false;
                label_status.Text = Item.item_status.ToString();
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ProductIndex = cb_category.SelectedIndex;
            //string productName = cb_category.Items[ProductIndex].ToString();
            //label_category_name.Text = ProductIndex.ToString();

            category_tbl obj = cb_category.SelectedItem as category_tbl;
            if(obj != null)
            {
                label_category_id.Text = obj.category_id.ToString();
                Item.category_id = obj.category_id;
            }
        }

        private void InsertItem()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertItems", con);
                cmd.CommandType = CommandType.StoredProcedure;
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

        private void CheckItemExist()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CheckItemExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", text_price.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                con.Close();
                if (dt.Rows.Count >= 1)
                {
                    try
                    {
                        MessageBox.Show("Item is already exist!", "Insert Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
                else
                {
                    InsertItem();
                    ClearText();
                    frm_inv.GetItems();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ClearText()
        {
            text_price.Clear();
            text_desc.Clear();
            text_buffer.Clear();
            text_code.Clear();
            cb_category.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                CheckItemExist();
                frm_inv.GetItems();
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

        private void label_category_id_Click(object sender, EventArgs e)
        {

        }

        private void text_price_KeyDown(object sender, KeyEventArgs e)
        {

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
