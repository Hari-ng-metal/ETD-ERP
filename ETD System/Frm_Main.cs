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
    public partial class Frm_Main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ERP;Integrated Security=True");
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void pb_burger_Click(object sender, EventArgs e)
        {
            if (panel_side.Width == 40)
            {
                panel_side.Width = 200;
            }
            else
            {
                panel_side.Width = 40;
            }
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Frm_Login login = new Frm_Login();
                login.Show();
            }
            if (res == DialogResult.No)
            {

            }
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "Inventory")
            //    {
            //        IsOpen = true;
            //        //f.BringToFront();
            //        f.Close();
            //        //MessageBox.Show("Already Open");
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    Frm_Inventory frm_in = new Frm_Inventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //    this.panel_main.Controls.Add(frm_in);
            //    frm_in.Show();
            //    frm_in.BringToFront();
            //}

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Item")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Item frm_in = new Frm_Item() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Frm_Login login = new Frm_Login();
                login.Show();

                this.Hide();
            }
            if (res == DialogResult.No)
            {

            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            label_name.Text = User.fname;
            btn_bell.Visible = false;
            CheckAppointmentToday();
            UserAccess();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Setting")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Setting frm_in = new Frm_Setting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Customer")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Customer frm_in = new Frm_Customer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Supplier")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Supplier frm_in = new Frm_Supplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
        }

        private void btn_receiving_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Receiving")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Receiving frm_in = new Frm_Receiving() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Sales")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Sales frm_in = new Frm_Sales() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Reports")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Report frm_in = new Frm_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Calendar")
                {
                    IsOpen = true;
                    //f.BringToFront();
                    f.Close();
                    //MessageBox.Show("Already Open");
                    break;
                }
            }
            if (IsOpen == false)
            {
                Frm_Calendar frm_in = new Frm_Calendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_main.Controls.Add(frm_in);
                frm_in.Show();
                frm_in.BringToFront();
            }
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

            if (dt.Rows.Count > 0)
            {
                timer_calendar.Start();
                btn_bell.Text = dt.Rows.Count.ToString();
            }
            else
            {
                btn_bell.Visible = false;
            }
        }

        private void timer_calendar_Tick(object sender, EventArgs e)
        {
            btn_bell.Visible = !btn_bell.Visible;
        }

        private void UserAccess()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_GetUserAccess", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", User.user_id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //dt_user_role.DataSource = dt;
            con.Close();

            foreach (DataRow row in dt.Rows)
            {
                string mod_name = row[2].ToString();
                //MessageBox.Show("" + mod_name);

                if (mod_name == "btn_inventory")
                {
                    btn_inventory.Enabled = true;
                }

                if (mod_name == "btn_receiving")
                {
                    btn_receiving.Enabled = true;
                }

                if (mod_name == "btn_sales")
                {
                    btn_sales.Enabled = true;
                }

                if (mod_name == "btn_customer")
                {
                    btn_customer.Enabled = true;
                }

                if (mod_name == "btn_supplier")
                {
                    btn_supplier.Enabled = true;
                }

                if (mod_name == "btn_calendar")
                {
                    btn_calendar.Enabled = true;
                }

                if (mod_name == "btn_reports")
                {
                    btn_reports.Enabled = true;
                }

                if (mod_name == "btn_setting")
                {
                    btn_setting.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_bell_Click(object sender, EventArgs e)
        {
            timer_calendar.Stop();
            Frm_Notify_Calendar frm = new Frm_Notify_Calendar(this);
            frm.ShowDialog();
        }
    }
}
