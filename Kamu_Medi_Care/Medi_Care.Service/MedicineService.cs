using Medi_Care.Database;
using Medi_Care.Models;

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
    }
}
