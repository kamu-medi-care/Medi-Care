using Kamu_Medi_Care.Models;
using Medi_Care.Database;

namespace Medi_Care.Models
{
    public class ReportService
    {
        public List<ReceptionModel> GetReport(ReportModel reportModel)
        {
            using (var context = new MCContext())
            {
                //var report = context.ReceptionModels.Where(c => c.DateTime.Equals( "BETWEEN" +
                //reportModel.StartDate + "AND" + reportModel.StartDate)).ToList();

                //var query = context.ReceptionModels.Where(c=>c.DateTime >= reportModel.StartDate && c=>c.DateTime <= reportModel.EndDate).ToList();
                var data = context.ReceptionModels.Where(c =>( c.DateTime.Equals(reportModel.StartDate)|| c.DateTime.Equals(reportModel.EndDate))).ToList();
                
                return data;

                //var from = Convert.ToInt32(reportModel.StartDate);
                //var to = Convert.ToInt32(reportModel.EndDate);
                //var report = context.ReceptionModels.AsEnumerable().Skip(from)
                //    .Take(to).ToList();
                //var report = context.ReceptionModels.Where(c => c.DateTime== "BETWEEN" +
                //reportModel.StartDate + "AND" +  reportModel.StartDate).ToList();
                return null;
            }
        }
    }
}
