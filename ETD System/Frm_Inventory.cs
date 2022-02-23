using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETD_System
{
    public partial class Frm_Inventory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Inventory()
        {
            InitializeComponent();
        }


        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GetItems()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetItems", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_inventory.DataSource = dt;
            con.Close();
        }

        private void panel_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Inventory_Load(object sender, EventArgs e)
        {
            GetItems();
            btn_update.Visible = false;
        }


        private void btn_update_Click_1(object sender, EventArgs e)
        {
            //Frm_UpdateItem frm = new Frm_UpdateItem(this);
            //frm.label_prod_id.Text = text_prod_id.Text;
            //frm.text_code.Text = text_code.Text;
            //frm.text_desc.Text = text_desc.Text;
            //frm.text_price.Text = text_price.Text;
            //frm.text_buffer.Text = text_buffer.Text;
            //frm.cb_category.Text = text_cat.Text;
            //frm.cb_status.Text = text_status.Text;
            //label_change.Text = "0";
            //frm.ShowDialog();
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            label_change.Text = "0";
            //Frm_AddItem1 frm = new Frm_AddItem1(this);
            //frm.ShowDialog();
        }

        private void bnt_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_inventory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_inventory.SelectedRows.Count > 0)
            {
                btn_update.Visible = true;
                text_prod_id.Text = dt_inventory.SelectedRows[0].Cells[0].Value + string.Empty;
                Item.update_prod_id = int.Parse(text_prod_id.Text);
                text_code.Text = dt_inventory.SelectedRows[0].Cells[1].Value + string.Empty;
                text_desc.Text = dt_inventory.SelectedRows[0].Cells[2].Value + string.Empty;
                text_cat.Text = dt_inventory.SelectedRows[0].Cells[3].Value + string.Empty;
                text_price.Text = dt_inventory.SelectedRows[0].Cells[4].Value + string.Empty;
                text_buffer.Text = dt_inventory.SelectedRows[0].Cells[5].Value + string.Empty;
                string x = (dt_inventory.SelectedRows[0].Cells[6].Value.ToString());
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
                text_added_by.Text = dt_inventory.SelectedRows[0].Cells[7].Value + string.Empty;
            }
            else if (dt_inventory.SelectedRows.Count < 0)
            {
                btn_update.Visible = false;
            }
        }

        private void label_change_TextChanged_1(object sender, EventArgs e)
        {
            GetItems();
        }
    }
}
