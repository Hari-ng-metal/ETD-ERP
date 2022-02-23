using S7.Net;
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
    public partial class Frm_Receiving_Item : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");

        Frm_Receiving frm_rec;

        public Frm_Receiving_Item(Frm_Receiving frm_received)
        {
            InitializeComponent();
            this.frm_rec = frm_received;

        }

        private void Frm_Receiving_Item_Load(object sender, EventArgs e)
        {
            if(frm_rec.label_index.Text == "new")
            {
                ProductList();
            }
            else
            {

            }
            //timer_scale.Start();

            //cb_item_code.SelectedIndex = -1;
            //text_desc.Clear();
            //text_quantity.Text = x.ToString();
            //text_price.Text = y.ToString();
            //text_total.Text = z.ToString();
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

        private void text_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateIteme()
        {
            //bool Found = false;
            //if (frm_rec.dt_receiving.Rows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in frm_rec.dt_receiving.Rows)
            //    {
            //        if (Convert.ToString(row.Cells[0].RowIndex) == label_index.Text);
            //        //if(frm_rec.dt_receiving.SelectedRows[0].Index.ToString() == label_index.Text)
            //        {
            //            row.Cells[0].Value = label_product_id.Text;
            //            row.Cells[1].Value = cb_item_code.Text;
            //            row.Cells[2].Value = text_desc.Text;
            //            row.Cells[3].Value = text_quantity.Text;
            //            row.Cells[4].Value = text_price.Text;
            //            row.Cells[5].Value = text_total.Text;
            //            Found = true;
            //            return;
            //        }
            //    }

            //}

            DataGridViewRow row = new DataGridViewRow();
            row = frm_rec.dt_receiving.Rows[int.Parse(label_index.Text)];
            row.Cells[0].Value = label_product_id.Text;
            row.Cells[1].Value = cb_item_code.Text;
            row.Cells[2].Value = text_desc.Text;
            row.Cells[3].Value = text_quantity.Text;
            row.Cells[4].Value = text_price.Text;
            row.Cells[5].Value = text_total.Text;
        }

        private void AddItem()
        {
            if (label_index.Text == "new")
            {
                frm_rec.label_index.Text = "new";
                text_total.Text = (Convert.ToDouble(text_price.Text) * Convert.ToDouble(text_quantity.Text)).ToString();
                frm_rec.dt_receiving.Rows.Add(label_product_id.Text, cb_item_code.Text, text_desc.Text, text_quantity.Text, text_price.Text, text_total.Text);
                frm_rec.Sum();
                this.Close();
            }
            else
            {
                frm_rec.label_index.Text = "new";
                text_total.Text = (Convert.ToDouble(text_price.Text) * Convert.ToDouble(text_quantity.Text)).ToString();
                UpdateIteme();
                frm_rec.Sum();
                this.Close();
            }
            timer_scale.Stop();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            frm_rec.label_index.Text = "new";
            timer_scale.Stop();

            this.Close();
        }

        private void ScaleReading()
        {
            var plc2 = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
            plc2.Open();
            try
            {
                double epi1 = ((uint)plc2.Read("DB231.DBD500")).ConvertToFloat();
                text_quantity.Text = Math.Round(epi1, 2).ToString();
                

                plc2.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void timer_scale_Tick(object sender, EventArgs e)
        {
            //ScaleReading();
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
    }
}
