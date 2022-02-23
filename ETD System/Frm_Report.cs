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
    public partial class Frm_Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Report()
        {
            InitializeComponent();
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DateFormat()
        {
            dp_start.Format = DateTimePickerFormat.Custom;
            dp_end.Format = DateTimePickerFormat.Custom;
            dp_start.CustomFormat = "MM/dd/yyyy";
            dp_end.CustomFormat = "MM/dd/yyyy";
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            DateFormat();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if(cb_report_name.Text == string.Empty)
            {
                MessageBox.Show("Please select a report name!", "Report Dialog", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(cb_report_name.Text == "Transaction History")
            {
                TransactionHistory();
            }
            if(cb_report_name.Text == "Sales Report")
            {
                SalesTransaction();
            }
            if (cb_report_name.Text == "Receiving Report")
            {
                ReceivingTransaction();
            }

        }
        private void TransactionHistory()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GetInventoryTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date_start", dp_start.Text);
                cmd.Parameters.AddWithValue("@date_end", dp_end.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_report.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

            private void SalesTransaction()
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_GetSalesTransaction", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date_start", dp_start.Text);
                    cmd.Parameters.AddWithValue("@date_end", dp_end.Text);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dt_report.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

        private void ReceivingTransaction()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GetReceivingTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date_start", dp_start.Text);
                cmd.Parameters.AddWithValue("@date_end", dp_end.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dt_report.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ExportReport()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dt_report.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dt_report.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dt_report.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dt_report.Columns.Count; j++)
                {
                    if (dt_report.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt_report.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to export?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //Some task…  
                ExportReport();
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }
    }
}
