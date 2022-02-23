namespace ETD_System
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_receiving = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_bell = new System.Windows.Forms.Button();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_burger = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer_calendar = new System.Windows.Forms.Timer(this.components);
            this.panel_side.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_burger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_side.Controls.Add(this.panel1);
            this.panel_side.Controls.Add(this.btn_logout);
            this.panel_side.Controls.Add(this.btn_setting);
            this.panel_side.Controls.Add(this.btn_reports);
            this.panel_side.Controls.Add(this.btn_calendar);
            this.panel_side.Controls.Add(this.btn_supplier);
            this.panel_side.Controls.Add(this.btn_customer);
            this.panel_side.Controls.Add(this.btn_sales);
            this.panel_side.Controls.Add(this.btn_receiving);
            this.panel_side.Controls.Add(this.btn_inventory);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(200, 721);
            this.panel_side.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 125);
            this.panel1.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_name.Location = new System.Drawing.Point(78, 106);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 17);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "User";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ETD_System.Properties.Resources.useraccount;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.pictureBox1.Size = new System.Drawing.Size(194, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 574);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 56);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Enabled = false;
            this.btn_setting.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 518);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(200, 56);
            this.btn_setting.TabIndex = 9;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Enabled = false;
            this.btn_reports.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.Image")));
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(0, 462);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(200, 56);
            this.btn_reports.TabIndex = 8;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_calendar
            // 
            this.btn_calendar.Enabled = false;
            this.btn_calendar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calendar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_calendar.Image = ((System.Drawing.Image)(resources.GetObject("btn_calendar.Image")));
            this.btn_calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calendar.Location = new System.Drawing.Point(0, 406);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(200, 56);
            this.btn_calendar.TabIndex = 7;
            this.btn_calendar.Text = "Schedule";
            this.btn_calendar.UseVisualStyleBackColor = true;
            this.btn_calendar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Enabled = false;
            this.btn_supplier.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplier.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_supplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_supplier.Image")));
            this.btn_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplier.Location = new System.Drawing.Point(0, 350);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(200, 56);
            this.btn_supplier.TabIndex = 12;
            this.btn_supplier.Text = "Supplier";
            this.btn_supplier.UseVisualStyleBackColor = true;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Enabled = false;
            this.btn_customer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.Image")));
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(0, 294);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(200, 56);
            this.btn_customer.TabIndex = 6;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Enabled = false;
            this.btn_sales.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_sales.Image")));
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.Location = new System.Drawing.Point(0, 238);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(200, 56);
            this.btn_sales.TabIndex = 5;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_receiving
            // 
            this.btn_receiving.Enabled = false;
            this.btn_receiving.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_receiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receiving.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_receiving.Image = ((System.Drawing.Image)(resources.GetObject("btn_receiving.Image")));
            this.btn_receiving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_receiving.Location = new System.Drawing.Point(0, 182);
            this.btn_receiving.Name = "btn_receiving";
            this.btn_receiving.Size = new System.Drawing.Size(200, 56);
            this.btn_receiving.TabIndex = 4;
            this.btn_receiving.Text = "Receiving";
            this.btn_receiving.UseVisualStyleBackColor = true;
            this.btn_receiving.Click += new System.EventHandler(this.btn_receiving_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Enabled = false;
            this.btn_inventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(0, 126);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(200, 56);
            this.btn_inventory.TabIndex = 3;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_top.Controls.Add(this.btn_bell);
            this.panel_top.Controls.Add(this.pb_exit);
            this.panel_top.Controls.Add(this.pb_minimize);
            this.panel_top.Controls.Add(this.pb_burger);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(806, 60);
            this.panel_top.TabIndex = 1;
            // 
            // btn_bell
            // 
            this.btn_bell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bell.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_bell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_bell.FlatAppearance.BorderSize = 0;
            this.btn_bell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bell.ForeColor = System.Drawing.Color.Red;
            this.btn_bell.Image = global::ETD_System.Properties.Resources.red_bell;
            this.btn_bell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bell.Location = new System.Drawing.Point(666, 3);
            this.btn_bell.Name = "btn_bell";
            this.btn_bell.Size = new System.Drawing.Size(59, 54);
            this.btn_bell.TabIndex = 42;
            this.btn_bell.TabStop = false;
            this.btn_bell.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_bell.UseVisualStyleBackColor = false;
            this.btn_bell.Click += new System.EventHandler(this.btn_bell_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(766, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(40, 60);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_exit.TabIndex = 5;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(729, 0);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(40, 60);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_minimize.TabIndex = 4;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pb_burger
            // 
            this.pb_burger.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_burger.Image = ((System.Drawing.Image)(resources.GetObject("pb_burger.Image")));
            this.pb_burger.Location = new System.Drawing.Point(0, 0);
            this.pb_burger.Name = "pb_burger";
            this.pb_burger.Size = new System.Drawing.Size(40, 60);
            this.pb_burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_burger.TabIndex = 3;
            this.pb_burger.TabStop = false;
            this.pb_burger.Click += new System.EventHandler(this.pb_burger_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(806, 661);
            this.panel_main.TabIndex = 2;
            // 
            // timer_calendar
            // 
            this.timer_calendar.Interval = 1000;
            this.timer_calendar.Tick += new System.EventHandler(this.timer_calendar_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panel_side.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_burger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_top;
        public System.Windows.Forms.Button btn_logout;
        public System.Windows.Forms.Button btn_setting;
        public System.Windows.Forms.Button btn_reports;
        public System.Windows.Forms.Button btn_calendar;
        public System.Windows.Forms.Button btn_customer;
        public System.Windows.Forms.Button btn_sales;
        public System.Windows.Forms.Button btn_receiving;
        public System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_burger;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label label_name;
        public System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Timer timer_calendar;
        private System.Windows.Forms.Button btn_bell;
    }
}