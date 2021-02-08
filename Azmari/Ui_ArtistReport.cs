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


namespace Azmari
{
    public partial class Ui_ArtistReport : Form
    {
        public Ui_ArtistReport()
        {
            InitializeComponent();
        }
        public string Email;
        private void Ui_ArtistReport_Load(object sender, EventArgs e)
        {
            DBService dbs = new DBService();
            DataTable dt = dbs.getInfoForReport(Email);
            CRArtistReport objRpt = new CRArtistReport();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

    }
}

