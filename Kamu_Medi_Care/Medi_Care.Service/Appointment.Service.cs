using Medi_Care.Database;
using Medi_Care.Models;
using System.Collections.Generic;
using System.Linq;

namespace Medi_Care.Service
{
    public class Appointment
    {
        public List<MedicineModel> GetMedicine()
        {
            using (var context = new MCContext())
            {
                var data = context.MedicineModels.ToList();
                return data;
            }
        }
    }
}
