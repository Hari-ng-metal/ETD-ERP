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
    public partial class Frm_Notify_Calendar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        //Frm_Calendar frm_cal;
        Frm_Main frm_main;

        //public Frm_Notify_Calendar(Frm_Calendar frm_calendar)
        public Frm_Notify_Calendar(Frm_Main frm_calendar)
        {
            InitializeComponent();
            //frm_cal = frm_calendar;
            frm_main = frm_calendar;

        }

        private void Frm_Notify_Calendar_Load(object sender, EventArgs e)
        {
            CheckAppointmentToday();
            if (dt_notify_calendar.SelectedRows.Count == 0)
            {
                cb_status.Enabled = false;
                btn_save.Enabled = false;
            }
            //bool x = dt_notify_calendar.Rows[0].Selected;
            //label_check.Text = x.ToString();
            if(text_appointment_id.Text == string.Empty)
            {
                cb_status.Enabled = false;
                btn_save.Enabled = false;
            }
        }

        public void CheckAppointmentToday()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetAppointmentToday", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_notify_calendar.DataSource = dt;
            con.Close();

            dt_notify_calendar.Columns["user_id"].Visible = false;
            dt_notify_calendar.Columns["date_added"].Visible = false;
        }

        private void dt_notify_calendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_notify_calendar.SelectedRows.Count > 0)
            {
                btn_save.Visible = true;
                text_appointment_id.Text = dt_notify_calendar.SelectedRows[0].Cells["appointment_id"].Value + string.Empty;
                text_fname.Text = dt_notify_calendar.SelectedRows[0].Cells["f_name"].Value + string.Empty;
                text_date.Text = dt_notify_calendar.SelectedRows[0].Cells["date_appointed"].Value + string.Empty;
                text_day.Text = dt_notify_calendar.SelectedRows[0].Cells["day"].Value + string.Empty;
                text_time.Text = dt_notify_calendar.SelectedRows[0].Cells["time"].Value + string.Empty;
                text_client.Text = dt_notify_calendar.SelectedRows[0].Cells["client_name"].Value + string.Empty;
                text_desc.Text = dt_notify_calendar.SelectedRows[0].Cells["description"].Value + string.Empty;
                cb_status.Text = dt_notify_calendar.SelectedRows[0].Cells["status"].Value + string.Empty;

                cb_status.Enabled = true;
                btn_save.Enabled = true;
            }

        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAppointmentStatus()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateAppoitmentStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@appointment_id", text_appointment_id.Text);
                cmd.Parameters.AddWithValue("@status", cb_status.Text);
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
            DialogResult res = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                UpdateAppointmentStatus();
                MessageBox.Show("Transaction is successful!", "Save Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frm_cal.CheckAppointmentToday();
                frm_main.CheckAppointmentToday();
                this.Close();

                //Some task…  
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }
    }
}
