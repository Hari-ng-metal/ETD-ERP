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
    public partial class Frm_Item : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Item()
        {
            InitializeComponent();
        }

        private void Frm_Item_Load(object sender, EventArgs e)
        {
            GetItems();
            btn_update.Visible = false;
        }

        public void GetItems()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetItems", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_item.DataSource = dt;
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Frm_UpdateItem frm = new Frm_UpdateItem(this);
            frm.label_prod_id.Text = text_prod_id.Text;
            frm.text_code.Text = text_code.Text;
            frm.text_desc.Text = text_desc.Text;
            frm.text_price.Text = text_price.Text;
            frm.text_buffer.Text = text_buffer.Text;
            frm.cb_category.Text = text_cat.Text;
            frm.cb_status.Text = text_status.Text;
            frm.ShowDialog();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Frm_AddItem1 frm = new Frm_AddItem1(this);
            frm.ShowDialog();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_item.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                text_prod_id.Text = dt_item.SelectedRows[0].Cells[0].Value + string.Empty;
                Item.update_prod_id = int.Parse(text_prod_id.Text);
                text_code.Text = dt_item.SelectedRows[0].Cells[1].Value + string.Empty;
                text_desc.Text = dt_item.SelectedRows[0].Cells[2].Value + string.Empty;
                text_cat.Text = dt_item.SelectedRows[0].Cells[3].Value + string.Empty;
                text_price.Text = dt_item.SelectedRows[0].Cells[4].Value + string.Empty;
                text_buffer.Text = dt_item.SelectedRows[0].Cells["buffer"].Value + string.Empty;
                string x = (dt_item.SelectedRows[0].Cells["status"].Value.ToString());
                //MessageBox.Show("" + x);
                if (x == "True")
                {
                    text_status.Text = "Active";
                }
                //if(x == "")
                //{
                //    text_status.Text = null;
                //}
                else
                {
                    text_status.Text = "inActive";
                }
                text_added_by.Text = dt_item.SelectedRows[0].Cells[7].Value + string.Empty;
            }
            else if (dt_item.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void label_change_TextChanged(object sender, EventArgs e)
        {
            GetItems();
        }

        private void dt_item_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow Myrow in dt_item.Rows)
            {//Here 2 cell is target value and 1 cell is Volume
             if (Convert.ToInt32(Myrow.Cells[7].Value) > Convert.ToInt32(Myrow.Cells[8].Value))
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                        //Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
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
