using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETD_System
{
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel_mainuser.Controls.Add(user_control_adduser);
            //user_control_adduser.Show();
            //user_control_adduser.BringToFront();

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "User Account")
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
                Frm_UserRole frm_role = new Frm_UserRole();
                frm_role.Hide();


                Frm_UserAccount frm_in = new Frm_UserAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_mainuser.Controls.Add(frm_in);
                frm_in.Show();


                //var form2 = new Frm_UserRole();
                //form2.Hide();
                //form2.Closed += (s, args) => form2.Close();
                //form2.Show();



                frm_role.Close();

            }
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Module")
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
                Frm_Modules frm_in = new Frm_Modules() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_mainuser.Controls.Add(frm_in);
                frm_in.Show();
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "User Role")
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
                Frm_UserRole frm_in = new Frm_UserRole() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_mainuser.Controls.Add(frm_in);
                frm_in.Show();
            }
        }
    }
}
