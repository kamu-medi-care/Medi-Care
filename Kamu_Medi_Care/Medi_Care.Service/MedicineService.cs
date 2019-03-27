using Medi_Care.Database;
using Medi_Care.Models;
using System.Collections.Generic;
using System.Linq;

namespace Medi_Care.Service
{
    public class MedicineService
    {
        public void AddMedicine(MedicineModel MedicineModel)
        {
            using (var context = new MCContext())
            {
                context.MedicineModels.Add(MedicineModel);

                context.SaveChanges();
            };
        }

        public List<MedicineModel> MedicineTable()
        {
            using (var context = new MCContext())
            {
                var medicine=context.MedicineModels.ToList();
                return medicine;
            }
        }
    }
}
