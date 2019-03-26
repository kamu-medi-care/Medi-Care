using Kamu_Medi_Care.Models;
using Medi_Care.Database;

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
    }
}
