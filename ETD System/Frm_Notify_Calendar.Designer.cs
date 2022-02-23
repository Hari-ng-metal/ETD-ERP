namespace ETD_System
{
    partial class Frm_Notify_Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notify_Calendar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_appointment_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_client = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.RichTextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_change = new System.Windows.Forms.Label();
            this.label_check = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dt_notify_calendar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_notify_calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 120);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.61421F));
            this.tableLayoutPanel1.Controls.Add(this.text_appointment_id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_day, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_time, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_fname, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_client, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_desc, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_status, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 120);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // text_appointment_id
            // 
            this.text_appointment_id.Enabled = false;
            this.text_appointment_id.Location = new System.Drawing.Point(203, 3);
            this.text_appointment_id.Name = "text_appointment_id";
            this.text_appointment_id.Size = new System.Drawing.Size(181, 22);
            this.text_appointment_id.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Day:";
            // 
            // text_day
            // 
            this.text_day.Enabled = false;
            this.text_day.Location = new System.Drawing.Point(203, 63);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(181, 22);
            this.text_day.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time:";
            // 
            // text_time
            // 
            this.text_time.Enabled = false;
            this.text_time.Location = new System.Drawing.Point(542, 33);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(237, 22);
            this.text_time.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // text_date
            // 
            this.text_date.Enabled = false;
            this.text_date.Location = new System.Drawing.Point(203, 33);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(181, 22);
            this.text_date.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Appointment Id:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personel:";
            // 
            // text_fname
            // 
            this.text_fname.Enabled = false;
            this.text_fname.Location = new System.Drawing.Point(542, 3);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(237, 22);
            this.text_fname.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(150, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Client:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(497, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Title:";
            // 
            // text_client
            // 
            this.text_client.Enabled = false;
            this.text_client.Location = new System.Drawing.Point(203, 93);
            this.text_client.Name = "text_client";
            this.text_client.Size = new System.Drawing.Size(181, 22);
            this.text_client.TabIndex = 24;
            // 
            // text_desc
            // 
            this.text_desc.Enabled = false;
            this.text_desc.Location = new System.Drawing.Point(542, 93);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(237, 24);
            this.text_desc.TabIndex = 25;
            this.text_desc.Text = "";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Closed"});
            this.cb_status.Location = new System.Drawing.Point(542, 63);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(237, 24);
            this.cb_status.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68007F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.bnt_cancel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_change, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_check, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 60);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnt_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnt_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bnt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bnt_cancel.Image = ((System.Drawing.Image)(resources.GetObject("bnt_cancel.Image")));
            this.bnt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_cancel.Location = new System.Drawing.Point(620, 3);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(120, 54);
            this.bnt_cancel.TabIndex = 34;
            this.bnt_cancel.Text = "Cancel";
            this.bnt_cancel.UseVisualStyleBackColor = false;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(490, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 54);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.Location = new System.Drawing.Point(3, 0);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(16, 17);
            this.label_change.TabIndex = 39;
            this.label_change.Text = "0";
            this.label_change.Visible = false;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Location = new System.Drawing.Point(369, 0);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(46, 17);
            this.label_check.TabIndex = 40;
            this.label_check.Text = "label9";
            this.label_check.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dt_notify_calendar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 260);
            this.panel5.TabIndex = 4;
            // 
            // dt_notify_calendar
            // 
            this.dt_notify_calendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_notify_calendar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_notify_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_notify_calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_notify_calendar.Location = new System.Drawing.Point(0, 0);
            this.dt_notify_calendar.Name = "dt_notify_calendar";
            this.dt_notify_calendar.RowHeadersWidth = 51;
            this.dt_notify_calendar.RowTemplate.Height = 24;
            this.dt_notify_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_notify_calendar.Size = new System.Drawing.Size(800, 260);
            this.dt_notify_calendar.TabIndex = 0;
            this.dt_notify_calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_notify_calendar_CellClick);
            // 
            // Frm_Notify_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Notify_Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Today";
            this.Load += new System.EventHandler(this.Frm_Notify_Calendar_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_notify_calendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox text_appointment_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_client;
        private System.Windows.Forms.RichTextBox text_desc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label label_change;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dt_notify_calendar;
        private System.Windows.Forms.Label label_check;
    }
}