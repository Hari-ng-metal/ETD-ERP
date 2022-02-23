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
    public partial class Frm_Calendar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Calendar()
        {
            InitializeComponent();
        }

        private void Frm_Calendar_Load(object sender, EventArgs e)
        {
            GetAppointment();
            pb_bell.Visible = false;
            CheckAppointmentToday();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            label_change.Text = "0";
            Frm_Add_Calendar frm = new Frm_Add_Calendar(this);
            frm.ShowDialog();

            //Frm_Add_Calendar frm = new Frm_Add_Calendar();
            //frm.ShowDialog();
        }

        public void GetAppointment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetAppointment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dt_calendar.DataSource = dt;
            con.Close();

            dt_calendar.Columns["user_id"].Visible = false;
            dt_calendar.Columns["date_added"].Visible = false;
        }

        public void CheckAppointmentToday()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetAppointmentToday", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //dt_calendar.DataSource = dt;
            con.Close();

            if(dt.Rows.Count > 0)
            {
                //pb_bell.Visible = true;
                timer_calendar.Start();
            }
            else
            {
                pb_bell.Visible = false;
            }
        }

        private void timer_calendar_Tick(object sender, EventArgs e)
        {
            //pb_bell.Visible = !pb_bell.Visible;
        }

        private void pb_bell_Click(object sender, EventArgs e)
        {
            //timer_calendar.Stop();
            //Frm_Notify_Calendar frm = new Frm_Notify_Calendar(this);
            //frm.ShowDialog();
        }

        private void dt_calendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_calendar.SelectedRows.Count > 0)
            {
                text_id.Text = dt_calendar.SelectedRows[0].Cells["appointment_id"].Value + string.Empty;
                text_fname.Text = dt_calendar.SelectedRows[0].Cells["f_name"].Value + string.Empty;
                text_date.Text = dt_calendar.SelectedRows[0].Cells["date_appointed"].Value + string.Empty;
                text_day.Text = dt_calendar.SelectedRows[0].Cells["day"].Value + string.Empty;
                text_time.Text = dt_calendar.SelectedRows[0].Cells["time"].Value + string.Empty;
                text_client.Text = dt_calendar.SelectedRows[0].Cells["client_name"].Value + string.Empty;
                text_desc.Text = dt_calendar.SelectedRows[0].Cells["description"].Value + string.Empty;
                text_status.Text = dt_calendar.SelectedRows[0].Cells["status"].Value + string.Empty;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
