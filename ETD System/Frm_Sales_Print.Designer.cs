namespace ETD_System
{
    partial class Frm_Print
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
            this.crystal_sales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SalesPrint1 = new ETD_System.SalesPrint();
            this.crystal_rpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystal_sales
            // 
            this.crystal_sales.ActiveViewIndex = 0;
            this.crystal_sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_sales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_sales.Location = new System.Drawing.Point(0, 0);
            this.crystal_sales.Name = "crystal_sales";
            this.crystal_sales.ReportSource = this.SalesPrint1;
            this.crystal_sales.Size = new System.Drawing.Size(800, 450);
            this.crystal_sales.TabIndex = 0;
            // 
            // crystal_rpt
            // 
            this.crystal_rpt.ActiveViewIndex = -1;
            this.crystal_rpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_rpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_rpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_rpt.Location = new System.Drawing.Point(0, 0);
            this.crystal_rpt.Name = "crystal_rpt";
            this.crystal_rpt.Size = new System.Drawing.Size(800, 450);
            this.crystal_rpt.TabIndex = 1;
            // 
            // Frm_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystal_rpt);
            this.Controls.Add(this.crystal_sales);
            this.Name = "Frm_Print";
            this.Text = "Printing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sales_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_sales;
        private SalesPrint SalesPrint1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_rpt;
    }
}