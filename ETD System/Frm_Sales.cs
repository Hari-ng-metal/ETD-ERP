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
    public partial class Frm_Sales : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Sales()
        {
            InitializeComponent();
        }

        int SelectedRowIndex;
        int last_id;

        private void Frm_Sales_Load(object sender, EventArgs e)
        {
            DtColor();
            CustomerList();
            ClearCustomerDetails();
            CheckNumber();
            btn_save.Enabled = false;
        }

        public void CustomerList()
        {  
            try
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    cb_customer.DataSource = db.customer_tbl.ToList();
                    cb_customer.ValueMember = "customer_id";
                    cb_customer.DisplayMember = "customer_name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            cb_customer.SelectedIndex = -1;
        }

        private void cb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer_tbl obj = cb_customer.SelectedItem as customer_tbl;
            if (obj != null)
            {
                label_customer_id.Text = obj.customer_id.ToString();
                Sales.customer_id = obj.customer_id;
                text_address.Text = obj.customer_address;
                text_email.Text = obj.customer_address;
                text_mobile.Text = obj.customer_mobile;
            }
        }

        private void ClearCustomerDetails()
        {
            cb_customer.SelectedIndex = -1;
            text_transaction_description.Clear();
            text_address.Clear();
            text_mobile.Clear();
            text_email.Clear();
            dt_sales.Rows.Clear();
        }

        private void DtColor()
        {
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dt_sales.Columns["remove"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.Navy;
            c.DefaultCellStyle.BackColor = Color.White;
        }

        public void CheckNumber()
        {
            int x = 1;
            int y;
            string query = "SELECT ISNULL(MAX(sales_id),0) FROM sales_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                y = Convert.ToInt32(dtbl.Rows[0][0]);
                text_sales_id.Text = (x + y).ToString();
            }
        }

        public void Sum()
        {
            double sum = 0;
            for (int i = 0; i < dt_sales.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dt_sales.Rows[i].Cells[5].Value);
            }
            label_subtotal.Text = sum.ToString();
        }

        private void dt_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_sales.Columns[e.ColumnIndex].Name == "remove")
            {
                dt_sales.Rows.Remove(dt_sales.Rows[e.RowIndex]);
                Sum();
            }
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Please input required field!", "Sales Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            label_index.Text = "new";
            if (cb_customer.Text == string.Empty || text_transaction_description.Text == string.Empty)
            {
                ErrorMessage();
            }
            else
            {
                label_change.Text = "0";
                Frm_Sales_Item frm = new Frm_Sales_Item(this);
                frm.ShowDialog();
            }
            CheckNumber();
        }

        private void dt_sales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_row_count.Text = dt_sales.RowCount.ToString();
            SelectedRowIndex = e.RowIndex;
            label_index.Text = SelectedRowIndex.ToString();
            if (dt_sales.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                label_product_id.Text = dt_sales.SelectedRows[0].Cells[0].Value + string.Empty;
                text_item_code.Text = dt_sales.SelectedRows[0].Cells[1].Value + string.Empty;
                text_desc.Text = dt_sales.SelectedRows[0].Cells[2].Value + string.Empty;
                text_quantity.Text = dt_sales.SelectedRows[0].Cells[3].Value + string.Empty;
                text_price.Text = dt_sales.SelectedRows[0].Cells[4].Value + string.Empty;
            }
            else if (dt_sales.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void UpdateValue()
        {
            Frm_Sales_Item frm = new Frm_Sales_Item(this);
            frm.label_index.Text = SelectedRowIndex.ToString();
            frm.label_product_id.Text = label_product_id.Text;
            frm.cb_item_code.Text = text_item_code.Text;
            frm.text_desc.Text = text_desc.Text;
            frm.text_quantity.Text = text_quantity.Text;
            frm.text_price.Text = text_price.Text;
            frm.text_total.Text = dt_sales.SelectedRows[0].Cells[5].Value + string.Empty;
            //frm.label_index.Text = dt_receiving.SelectedRows[0].Index.ToString();
            frm.Show();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void InsertSalesId()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertSalesID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", label_customer_id.Text);
                cmd.Parameters.AddWithValue("@description", text_transaction_description.Text);
                cmd.Parameters.AddWithValue("@total_amount", label_subtotal.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                last_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                label_last_id.Text = last_id.ToString();
                Sales.last_id = int.Parse(last_id.ToString());
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void SaveSalesItems()
        {
            int p_id;
            string pcode;
            string pdesc;
            double pprice = 0;
            double pqty = 0;
            double tot = 0;

            for (int row = 0; row < dt_sales.Rows.Count; row++)
            {
                if (dt_sales.Rows[row].Cells[0].Value == null)
                {
                    return;
                }
                else
                {
                    p_id = Convert.ToInt32(dt_sales.Rows[row].Cells[0].Value);
                    pcode = dt_sales.Rows[row].Cells[1].Value.ToString();
                    pdesc = dt_sales.Rows[row].Cells[2].Value.ToString();
                    pqty = Convert.ToDouble(Convert.ToDouble(dt_sales.Rows[row].Cells[3].Value));
                    pprice = Convert.ToDouble(Convert.ToDouble(dt_sales.Rows[row].Cells[4].Value));
                    tot = Convert.ToDouble(Convert.ToDouble(dt_sales.Rows[row].Cells[5].Value));

                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_InsertSalesItem", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sales_id", last_id);
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(p_id.ToString()));
                        cmd.Parameters.AddWithValue("@code", pcode.ToString());
                        cmd.Parameters.AddWithValue("@desc", pdesc.ToString());
                        cmd.Parameters.AddWithValue("@quantity", pqty);
                        cmd.Parameters.AddWithValue("@price", pprice);
                        cmd.Parameters.AddWithValue("@total", tot);
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        //dt_report.DataSource = dt;
                        con.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        throw;
                    }
                }
            }
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                InsertSalesId();
                SaveSalesItems();
                ClearCustomerDetails();
                MessageBox.Show("Transaction is successful!", "Save Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CallPrintOut();
                CheckNumber();
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

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void CallPrintOut()
        {
            Printing.printName = "Sales";

            Frm_Print frm = new Frm_Print();
            frm.ShowDialog();
        }


        private void label_subtotal_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if(label_subtotal.Text == x.ToString())
            {
                btn_save.Enabled = false;
            }
        }
    }
}
