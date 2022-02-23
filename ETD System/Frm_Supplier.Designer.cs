namespace ETD_System
{
    partial class Frm_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Supplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_sup_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_sup_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_addedby = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_sup_add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_sup_mobile = new System.Windows.Forms.TextBox();
            this.cb_sup_status = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_sup_id = new System.Windows.Forms.Label();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dt_supplier = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.text_sup_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_sup_email, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_addedby, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_sup_add, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_sup_mobile, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_sup_status, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 121);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // text_sup_name
            // 
            this.text_sup_name.Location = new System.Drawing.Point(203, 3);
            this.text_sup_name.Name = "text_sup_name";
            this.text_sup_name.Size = new System.Drawing.Size(283, 22);
            this.text_sup_name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email Address:";
            // 
            // text_sup_email
            // 
            this.text_sup_email.Location = new System.Drawing.Point(203, 83);
            this.text_sup_email.Name = "text_sup_email";
            this.text_sup_email.Size = new System.Drawing.Size(283, 22);
            this.text_sup_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Added By:";
            // 
            // text_addedby
            // 
            this.text_addedby.Location = new System.Drawing.Point(603, 83);
            this.text_addedby.Name = "text_addedby";
            this.text_addedby.Size = new System.Drawing.Size(194, 22);
            this.text_addedby.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier Address:";
            // 
            // text_sup_add
            // 
            this.text_sup_add.Location = new System.Drawing.Point(203, 43);
            this.text_sup_add.Name = "text_sup_add";
            this.text_sup_add.Size = new System.Drawing.Size(283, 22);
            this.text_sup_add.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Supplier Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mobile:";
            // 
            // text_sup_mobile
            // 
            this.text_sup_mobile.Location = new System.Drawing.Point(603, 3);
            this.text_sup_mobile.Name = "text_sup_mobile";
            this.text_sup_mobile.Size = new System.Drawing.Size(194, 22);
            this.text_sup_mobile.TabIndex = 17;
            // 
            // cb_sup_status
            // 
            this.cb_sup_status.FormattingEnabled = true;
            this.cb_sup_status.Items.AddRange(new object[] {
            "Active",
            "inActive"});
            this.cb_sup_status.Location = new System.Drawing.Point(603, 43);
            this.cb_sup_status.Name = "cb_sup_status";
            this.cb_sup_status.Size = new System.Drawing.Size(194, 24);
            this.cb_sup_status.TabIndex = 21;
            this.cb_sup_status.SelectedIndexChanged += new System.EventHandler(this.cb_sup_status_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24178F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75822F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.label_sup_id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bnt_cancel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_new, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_status, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 60);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // label_sup_id
            // 
            this.label_sup_id.AutoSize = true;
            this.label_sup_id.Location = new System.Drawing.Point(3, 0);
            this.label_sup_id.Name = "label_sup_id";
            this.label_sup_id.Size = new System.Drawing.Size(16, 17);
            this.label_sup_id.TabIndex = 34;
            this.label_sup_id.Text = "0";
            this.label_sup_id.Visible = false;
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
            this.bnt_cancel.Location = new System.Drawing.Point(651, 3);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(123, 54);
            this.bnt_cancel.TabIndex = 32;
            this.bnt_cancel.Text = "Cancel";
            this.bnt_cancel.UseVisualStyleBackColor = false;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
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
            this.btn_new.Location = new System.Drawing.Point(521, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(124, 54);
            this.btn_new.TabIndex = 33;
            this.btn_new.Text = "Save";
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
            this.btn_update.Location = new System.Drawing.Point(392, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 54);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(780, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(16, 60);
            this.label_status.TabIndex = 36;
            this.label_status.Text = "label5";
            this.label_status.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 19);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dt_supplier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 250);
            this.panel4.TabIndex = 3;
            // 
            // dt_supplier
            // 
            this.dt_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_supplier.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_supplier.Location = new System.Drawing.Point(0, 0);
            this.dt_supplier.Name = "dt_supplier";
            this.dt_supplier.RowHeadersWidth = 51;
            this.dt_supplier.RowTemplate.Height = 24;
            this.dt_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_supplier.Size = new System.Drawing.Size(800, 250);
            this.dt_supplier.TabIndex = 1;
            this.dt_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_supplier_CellClick);
            // 
            // Frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Frm_Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_supplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox text_sup_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_sup_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_addedby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_sup_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_sup_mobile;
        private System.Windows.Forms.ComboBox cb_sup_status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label_sup_id;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dt_supplier;
    }
}