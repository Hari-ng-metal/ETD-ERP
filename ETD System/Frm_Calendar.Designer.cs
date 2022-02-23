namespace ETD_System
{
    partial class Frm_Calendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calendar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_bell = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.text_status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_client = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label_change = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dt_calendar = new System.Windows.Forms.DataGridView();
            this.timer_calendar = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bell)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 120);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.61421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.text_id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_day, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pb_bell, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_time, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_fname, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_status, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_client, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_desc, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 120);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(188, 3);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(179, 22);
            this.text_id.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Day:";
            // 
            // text_day
            // 
            this.text_day.Enabled = false;
            this.text_day.Location = new System.Drawing.Point(188, 63);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(179, 22);
            this.text_day.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status:";
            // 
            // pb_bell
            // 
            this.pb_bell.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_bell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_bell.Image = global::ETD_System.Properties.Resources.red_bell;
            this.pb_bell.Location = new System.Drawing.Point(744, 3);
            this.pb_bell.Name = "pb_bell";
            this.pb_bell.Size = new System.Drawing.Size(41, 24);
            this.pb_bell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_bell.TabIndex = 40;
            this.pb_bell.TabStop = false;
            this.pb_bell.Click += new System.EventHandler(this.pb_bell_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time:";
            // 
            // text_time
            // 
            this.text_time.Enabled = false;
            this.text_time.Location = new System.Drawing.Point(502, 33);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(236, 22);
            this.text_time.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // text_date
            // 
            this.text_date.Enabled = false;
            this.text_date.Location = new System.Drawing.Point(188, 33);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(179, 22);
            this.text_date.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Appointment Id:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personel:";
            // 
            // text_fname
            // 
            this.text_fname.Enabled = false;
            this.text_fname.Location = new System.Drawing.Point(502, 3);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(236, 22);
            this.text_fname.TabIndex = 17;
            // 
            // text_status
            // 
            this.text_status.Enabled = false;
            this.text_status.Location = new System.Drawing.Point(502, 63);
            this.text_status.Name = "text_status";
            this.text_status.Size = new System.Drawing.Size(236, 22);
            this.text_status.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(135, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Client:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(457, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Title:";
            // 
            // text_client
            // 
            this.text_client.Enabled = false;
            this.text_client.Location = new System.Drawing.Point(188, 93);
            this.text_client.Name = "text_client";
            this.text_client.Size = new System.Drawing.Size(179, 22);
            this.text_client.TabIndex = 24;
            // 
            // text_desc
            // 
            this.text_desc.Enabled = false;
            this.text_desc.Location = new System.Drawing.Point(502, 93);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(236, 24);
            this.text_desc.TabIndex = 25;
            this.text_desc.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68007F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Controls.Add(this.bnt_cancel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_new, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_change, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanel2.TabIndex = 41;
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
            this.bnt_cancel.Location = new System.Drawing.Point(607, 3);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(120, 54);
            this.bnt_cancel.TabIndex = 34;
            this.bnt_cancel.Text = "Cancel";
            this.bnt_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_new.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(477, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(124, 54);
            this.btn_new.TabIndex = 35;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(359, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 54);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 60);
            this.panel2.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dt_calendar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 424);
            this.panel4.TabIndex = 44;
            // 
            // dt_calendar
            // 
            this.dt_calendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_calendar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_calendar.Location = new System.Drawing.Point(0, 0);
            this.dt_calendar.Name = "dt_calendar";
            this.dt_calendar.RowHeadersWidth = 51;
            this.dt_calendar.RowTemplate.Height = 24;
            this.dt_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_calendar.Size = new System.Drawing.Size(788, 424);
            this.dt_calendar.TabIndex = 0;
            this.dt_calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_calendar_CellClick);
            // 
            // timer_calendar
            // 
            this.timer_calendar.Interval = 1000;
            this.timer_calendar.Tick += new System.EventHandler(this.timer_calendar_Tick);
            // 
            // Frm_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(788, 614);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Frm_Calendar_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bell)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_calendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox text_id;
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
        private System.Windows.Forms.TextBox text_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Label label_change;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_client;
        private System.Windows.Forms.RichTextBox text_desc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dt_calendar;
        private System.Windows.Forms.PictureBox pb_bell;
        private System.Windows.Forms.Timer timer_calendar;
    }
}