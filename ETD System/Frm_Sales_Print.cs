using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Frm_Print : Form
    {
        //string Rpt_Path = "";
        string Report = "";
        ReportDocument rpt = new ReportDocument();
        public Frm_Print()
        {
            InitializeComponent();
 
        }

        private void Frm_Sales_Print_Load(object sender, EventArgs e)
        {
            Report = ETD_System.Properties.Settings.Default.report;
            if(Printing.printName == "Sales")
            {
                RptSales();
            }

            if(Printing.printName == "Receive")
            {
                RptReceiving();
            }    
            
        }

        private void RptSales()
        {


            rpt.Load(Report + "\\SalesPrint.rpt");
            //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            rpt.Refresh();
            int ddate = Sales.last_id;
            rpt.SetParameterValue("@last_id", ddate);
         
            crystal_rpt.ReportSource = rpt;
            crystal_rpt.Refresh();
        }

        private void RptReceiving()
        {
            rpt.Load(Report + "\\ReceivingPrint.rpt");
            //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            rpt.Refresh();
            int ddate = Receiving.receiving_last_id;
                //Receiving.receiving_last_id;
            rpt.SetParameterValue("@last_id", ddate);

            crystal_rpt.ReportSource = rpt;
            crystal_rpt.Refresh();
        }
    }
}
