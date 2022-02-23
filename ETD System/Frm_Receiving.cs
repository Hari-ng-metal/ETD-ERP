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
    public partial class Frm_Receiving : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Receiving()
        {
            InitializeComponent();
        }
        int SelectedRowIndex;
        int last_id;

        private void Frm_Receiving_Load(object sender, EventArgs e)
        {
            DtColor();
            SupplierList();
            ClearSupplierDetails();
            Sum();
            //CheckNumber();
            timer_receiving_id.Start();
            text_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        public void SupplierList()
        {
            cb_supplier.SelectedIndex = -1;
            try
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    cb_supplier.DataSource = db.supplier_tbl.ToList();
                    cb_supplier.ValueMember = "supplier_id";
                    cb_supplier.DisplayMember = "supplier_name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ClearSupplierDetails()
        {
            cb_supplier.SelectedIndex = -1;
            text_transaction_description.Clear();
            text_address.Clear();
            text_mobile.Clear();
            text_email.Clear();
            dt_receiving.Rows.Clear();
        }

        private void cb_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier_tbl obj = cb_supplier.SelectedItem as supplier_tbl;
            if (obj != null)
            {
                label_supplier_id.Text = obj.supplier_id.ToString();
                Receiving.supplier_id = obj.supplier_id;
                text_address.Text = obj.supplier_address;
                text_email.Text = obj.supplier_email;
                text_mobile.Text = obj.supplier_mobile;
            }
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Please input required field!", "Receiving Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            label_index.Text = "new";
            if(cb_supplier.Text == string.Empty || text_transaction_description.Text == string.Empty)
            {
                ErrorMessage();
            }
            else
            {
                label_change.Text = "0";
                Frm_Receiving_Item frm = new Frm_Receiving_Item(this);
                frm.ShowDialog();
            }
            CheckNumber();

        }

        public void Sum()
        {
            double sum = 0;
            for (int i = 0; i < dt_receiving.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dt_receiving.Rows[i].Cells[5].Value);
            }
            label_subtotal.Text = sum.ToString();
        }

        private void dt_receiving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_row_count.Text =  dt_receiving.RowCount.ToString();
            SelectedRowIndex = e.RowIndex;
            label_index.Text = SelectedRowIndex.ToString();
            if (dt_receiving.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                label_product_id.Text = dt_receiving.SelectedRows[0].Cells[0].Value + string.Empty;
                text_item_code.Text = dt_receiving.SelectedRows[0].Cells[1].Value + string.Empty;
                text_desc.Text = dt_receiving.SelectedRows[0].Cells[2].Value + string.Empty;
                text_quantity.Text = dt_receiving.SelectedRows[0].Cells[3].Value + string.Empty;
                text_price.Text = dt_receiving.SelectedRows[0].Cells[4].Value + string.Empty;
            }
            else if (dt_receiving.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void UpdateValue()
        {
            Frm_Receiving_Item frm = new Frm_Receiving_Item(this);
            frm.label_index.Text = SelectedRowIndex.ToString();
            frm.label_product_id.Text = label_product_id.Text;
            frm.cb_item_code.Text = text_item_code.Text;
            frm.text_desc.Text = text_desc.Text;
            frm.text_quantity.Text = text_quantity.Text;
            frm.text_price.Text = text_price.Text;
            frm.text_total.Text = dt_receiving.SelectedRows[0].Cells[5].Value + string.Empty;
            //frm.label_index.Text = dt_receiving.SelectedRows[0].Index.ToString();
            frm.Show();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void dt_receiving_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dt_receiving.Columns[e.ColumnIndex].Name == "remove")
            {
                dt_receiving.Rows.Remove(dt_receiving.Rows[e.RowIndex]);
                Sum();
            }
        }

        private void DtColor()
        {
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dt_receiving.Columns["remove"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.Navy;
            c.DefaultCellStyle.BackColor = Color.White;
        }

        private void CheckNumber()
        {
            int x = 1;
            int y;
            string query = "SELECT ISNULL(MAX(receiving_id),0) FROM receiving_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                 y = Convert.ToInt32(dtbl.Rows[0][0]);
                text_receiving_id.Text = (x + y).ToString();
            }
        }

        private void timer_receiving_id_Tick(object sender, EventArgs e)
        {
            CheckNumber();
        }

        private void InsertReceiveId()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertReceivingID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@supplier_id", label_supplier_id.Text);
                cmd.Parameters.AddWithValue("@description", text_transaction_description.Text);
                cmd.Parameters.AddWithValue("@total_amount", label_subtotal.Text);
                cmd.Parameters.AddWithValue("@user", User.user_id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt_report.DataSource = dt;
                last_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                label_last_id.Text = last_id.ToString();
                Receiving.receiving_last_id = last_id;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void SaveReceivingItems()
        {
            int p_id;
            string pcode;
            string pdesc;
            double pprice = 0;
            double pqty = 0;
            double tot = 0;

            for (int row = 0; row < dt_receiving.Rows.Count; row++)
            {
                if (dt_receiving.Rows[row].Cells[0].Value == null)
                {
                    return;
                }
                else
                {
                    p_id = Convert.ToInt32(dt_receiving.Rows[row].Cells[0].Value);
                    pcode = dt_receiving.Rows[row].Cells[1].Value.ToString();
                    pdesc = dt_receiving.Rows[row].Cells[2].Value.ToString();
                    pqty = Convert.ToDouble(Convert.ToDouble(dt_receiving.Rows[row].Cells[3].Value));
                    pprice = Convert.ToDouble(Convert.ToDouble(dt_receiving.Rows[row].Cells[4].Value));
                    tot = Convert.ToDouble(Convert.ToDouble(dt_receiving.Rows[row].Cells[5].Value));

                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_InsertReceiveItem", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@receiving_id", last_id);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                InsertReceiveId();
                SaveReceivingItems();
                ClearSupplierDetails();
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
        private void CallPrintOut()
        {
            Printing.printName = "Receive";
            Frm_Print frm = new Frm_Print();
            frm.ShowDialog();
            
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
