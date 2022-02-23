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
    public partial class Frm_Add_Calendar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");

        Frm_Calendar frm_cal;
        public Frm_Add_Calendar(Frm_Calendar frm_calendar)
        {
            InitializeComponent();
            this.frm_cal = frm_calendar;
        }

        private void Frm_Add_Calendar_Load(object sender, EventArgs e)
        {
            time();
            DateFormat();
            Day();
            text_user.Text = User.fname;
            label_user_id.Text = User.user_id.ToString();
            text_status.Text = "Open";
            CheckNumber();
        }

        private void time()
        {
            var item = DateTime.Today.AddHours(1); // 14:00:00
            while (item <= DateTime.Today.AddHours(24)) // 16:00:00
            {
                cb_time.Items.Add(item.ToString("hh:mm:ss tt"));
                item = item.AddMinutes(20);
            }
        }

        private void DateFormat()
        {
            dp_date.Format = DateTimePickerFormat.Custom;
            dp_date.Format = DateTimePickerFormat.Custom;
            dp_date.CustomFormat = "MM/dd/yyyy";
            dp_date.CustomFormat = "MM/dd/yyyy";
        }

        private void Day()
        {
            //System.DateTime.(dp_date.Text.ToString("dddd");

            text_day.Text = (DateTime.Parse((dp_date.Text).ToString())).DayOfWeek.ToString();
        }

        private void dp_date_ValueChanged(object sender, EventArgs e)
        {
            Day();
        }

        private void CheckNumber()
        {
            int x = 1;
            int y;
            string query = "SELECT ISNULL(MAX(appointment_id),0) FROM calendar_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                y = Convert.ToInt32(dtbl.Rows[0][0]);
                text_appointment_id.Text = (x + y).ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                CheckNumber();
                InsertAppointment();
                frm_cal.GetAppointment();
                frm_cal.CheckAppointmentToday();
                frm_cal.label_change.Text = "1";
                MessageBox.Show("Transaction is successful!", "Save Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //Some task…  
            }
            if (res == DialogResult.No)
            {
                //Some task…  
            }
        }

        private void InsertAppointment()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertAppointment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", User.user_id);
                cmd.Parameters.AddWithValue("@fname", User.fname.ToString());
                cmd.Parameters.AddWithValue("@date", dp_date.Text);
                cmd.Parameters.AddWithValue("@day", text_day.Text);
                cmd.Parameters.AddWithValue("@time", cb_time.Text);
                cmd.Parameters.AddWithValue("@client", text_client.Text);
                cmd.Parameters.AddWithValue("@description", text_description.Text);
                cmd.Parameters.AddWithValue("@status", text_status.Text);
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

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            frm_cal.label_change.Text = "3";
            this.Close();
        }
    }
}
