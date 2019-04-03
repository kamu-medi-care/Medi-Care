using Kamu_Medi_Care.Models;
using Medi_Care.Database;

namespace Medi_Care.Models
{
    public class ReportService
    {
        public ReceptionModel GetReport(ReportModel reportModel)
        {
            using (var context = new MCContext())
            {
                //var report = context.ReceptionModels.Where(c => c.DateTime== "BETWEEN" +
                //reportModel.StartDate + "AND" +  reportModel.StartDate).ToList();
                return null;
            }
        }
    }
}
