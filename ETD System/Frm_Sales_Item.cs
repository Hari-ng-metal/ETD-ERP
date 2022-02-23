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
    public partial class Frm_Sales_Item : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");

        Frm_Sales frm_sale;

        double remaining = 0;
        double additional = 0;
        double quantity = 0;
        double total_quantity = 0;
        public Frm_Sales_Item(Frm_Sales frm_sales)
        {
            InitializeComponent();
            this.frm_sale = frm_sales;
        }

        private void Frm_Sales_Item_Load(object sender, EventArgs e)
        {
            if (frm_sale.label_index.Text == "new")
            {
                ProductList();
            }
            else
            {

            }
        }

        public void ProductList()
        {
            cb_item_code.SelectedIndex = -1;
            try
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    cb_item_code.DataSource = db.inventory_tbl.ToList();
                    cb_item_code.ValueMember = "product_id";
                    cb_item_code.DisplayMember = "item_code";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cb_item_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventory_tbl obj = cb_item_code.SelectedItem as inventory_tbl;
            if (obj != null)
            {
                label_product_id.Text = obj.product_id.ToString();
                text_desc.Text = obj.item_description;
                text_price.Text = obj.price.ToString();
                //Item.category_id = obj.category_id;
            }
        }

        private void AddItem()
        {
            if (label_index.Text == "new")
            {
                frm_sale.label_index.Text = "new";
                text_total.Text = (Convert.ToDouble(text_price.Text) * Convert.ToDouble(text_quantity.Text)).ToString();
                frm_sale.dt_sales.Rows.Add(label_product_id.Text, cb_item_code.Text, text_desc.Text, text_quantity.Text, text_price.Text, text_total.Text);
                frm_sale.Sum();
                this.Close();
            }
            else
            {
                frm_sale.label_index.Text = "new";
                text_total.Text = (Convert.ToDouble(text_price.Text) * Convert.ToDouble(text_quantity.Text)).ToString();
                UpdateIteme();
                frm_sale.Sum();
                this.Close();
            }
        }

        private void UpdateIteme()
        {
            DataGridViewRow row = new DataGridViewRow();
            row = frm_sale.dt_sales.Rows[int.Parse(label_index.Text)];
            row.Cells[0].Value = label_product_id.Text;
            row.Cells[1].Value = cb_item_code.Text;
            row.Cells[2].Value = text_desc.Text;
            row.Cells[3].Value = text_quantity.Text;
            row.Cells[4].Value = text_price.Text;
            row.Cells[5].Value = text_total.Text;
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            frm_sale.label_index.Text = "new";

            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateInsert();
            frm_sale.btn_save.Enabled = true;
        }

        private void text_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void SumItemQuantity()
        {
            double Sum_1 = 0;

            foreach (DataGridViewRow row in frm_sale.dt_sales.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    return;
                }
                if (row.Cells[1].Value.ToString() == cb_item_code.Text)
                {
                    Sum_1 += Convert.ToDouble(row.Cells[3].Value);
                    //MessageBox.Show("" + Sum_1);
                    label_sale_qty.Text = Sum_1.ToString();
                    quantity = Double.Parse(label_sale_qty.Text.ToString());
                }
                else
                {
                    return;
                }
            }
        }

        private void GetRemainingStock()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GetRemainingStock", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", cb_item_code.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                label_remaining.Text = (dt.Rows[0][8].ToString());
                remaining = Double.Parse(label_remaining.Text.ToString());
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void ValidateInsert()
        {
            if (text_quantity.Text == string.Empty)
            {
                text_quantity.Focus();
            }
            else
            {
                additional = Double.Parse(text_quantity.Text.ToString());
                SumItemQuantity();
                GetRemainingStock();

                total_quantity = quantity + additional;
                //MessageBox.Show("Total" + total_quantity);
                //MessageBox.Show("Remaining" + remaining);

                if (remaining >= total_quantity)
                {
                    //MessageBox.Show("Meron pa stock");
                    AddItem();

                }
                else
                {
                    MessageBox.Show("No enough stock!", "Inventory Dialog", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_quantity.Clear();
                    text_quantity.Focus();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
