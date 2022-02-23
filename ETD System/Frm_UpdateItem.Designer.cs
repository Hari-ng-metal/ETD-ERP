namespace ETD_System
{
    partial class Frm_UpdateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UpdateItem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_buffer = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_prod_id = new System.Windows.Forms.Label();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_category_id = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.tableLayoutPanel1.Controls.Add(this.text_buffer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_desc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_price, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_code, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_category, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_status, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 126);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // text_buffer
            // 
            this.text_buffer.Location = new System.Drawing.Point(179, 87);
            this.text_buffer.Name = "text_buffer";
            this.text_buffer.Size = new System.Drawing.Size(194, 22);
            this.text_buffer.TabIndex = 15;
            this.text_buffer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_buffer_KeyPress);
            // 
            // text_desc
            // 
            this.text_desc.Enabled = false;
            this.text_desc.Location = new System.Drawing.Point(528, 3);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(194, 22);
            this.text_desc.TabIndex = 6;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(179, 45);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(194, 22);
            this.text_price.TabIndex = 7;
            this.text_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_price_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Code:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price:";
            // 
            // text_code
            // 
            this.text_code.Enabled = false;
            this.text_code.Location = new System.Drawing.Point(179, 3);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(194, 22);
            this.text_code.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Descriptio:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buffer:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(528, 45);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(194, 24);
            this.cb_category.TabIndex = 16;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Active",
            "inActive"});
            this.cb_status.Location = new System.Drawing.Point(528, 87);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(194, 24);
            this.cb_status.TabIndex = 17;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3207F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.525034F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Controls.Add(this.label_prod_id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bnt_cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_category_id, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_status, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 60);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label_prod_id
            // 
            this.label_prod_id.AutoSize = true;
            this.label_prod_id.Location = new System.Drawing.Point(3, 0);
            this.label_prod_id.Name = "label_prod_id";
            this.label_prod_id.Size = new System.Drawing.Size(46, 17);
            this.label_prod_id.TabIndex = 8;
            this.label_prod_id.Text = "label6";
            this.label_prod_id.Visible = false;
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
            this.bnt_cancel.Location = new System.Drawing.Point(552, 3);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(118, 54);
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
            this.btn_save.Location = new System.Drawing.Point(419, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 54);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_category_id
            // 
            this.label_category_id.AutoSize = true;
            this.label_category_id.Location = new System.Drawing.Point(676, 0);
            this.label_category_id.Name = "label_category_id";
            this.label_category_id.Size = new System.Drawing.Size(46, 17);
            this.label_category_id.TabIndex = 36;
            this.label_category_id.Text = "label6";
            this.label_category_id.Visible = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(738, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 17);
            this.label_status.TabIndex = 37;
            this.label_status.Text = "label6";
            this.label_status.Visible = false;
            // 
            // Frm_UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_UpdateItem";
            this.Load += new System.EventHandler(this.Frm_UpdateItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox text_buffer;
        public System.Windows.Forms.TextBox text_desc;
        public System.Windows.Forms.TextBox text_price;
        public System.Windows.Forms.TextBox text_code;
        public System.Windows.Forms.ComboBox cb_category;
        public System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label_category_id;
        public System.Windows.Forms.Label label_prod_id;
        private System.Windows.Forms.Label label_status;
    }
}