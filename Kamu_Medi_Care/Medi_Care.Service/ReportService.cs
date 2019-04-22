using Kamu_Medi_Care.Models;
using Medi_Care.Database;
using System.Collections.Generic;
using System.Linq;

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

            }
        }
    }
}
