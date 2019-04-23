using Kamu_Medi_Care.Models;
using Medi_Care.Database;
using System;
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
