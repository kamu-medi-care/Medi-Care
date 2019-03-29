using Kamu_Medi_Care.Models;
using Medi_Care.Database;
using System.Collections.Generic;
using System.Linq;

namespace Medi_Care.Service
{
    public class ReceptionService
    {
        public void ReferPatient(ReceptionModel receptionModels)
        {
           using(var context = new MCContext())
           {
               context.ReceptionModels.Add(receptionModels);
               context.SaveChanges();
           };
        }

        public List<ReceptionModel> GetReception()
        {
            using (var context = new MCContext())
            {
                var data= context.ReceptionModels.ToList();
                return data;
            };
        }

        public List<ReceptionModel> GetPatientByName(string name)
        {
            using (var context = new MCContext())
            {
                var data = context.ReceptionModels.Where(c=>c.PName==name).ToList();
                return data;
            };
        }
    }
}
