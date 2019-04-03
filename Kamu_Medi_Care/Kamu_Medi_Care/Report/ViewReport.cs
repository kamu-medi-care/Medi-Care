using Kamu_Medi_Care.Templates;
using Medi_Care.Models;

namespace Kamu_Medi_Care.Report
{
    public partial class ViewReport : Template
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        ReportService reportService=new ReportService();

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            ReportModel report = new ReportModel
            {
                StartDate = dtpFrom.Text,
                EndDate = dtpTo.Text
            };

            var data=reportService.GetReport(report);
            dgvReport.DataSource = data;
        }

        private void Report()
        {
            
        }
    }
}
