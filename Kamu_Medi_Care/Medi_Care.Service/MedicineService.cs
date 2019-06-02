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

        public List<MedicineModel> GetMedicine()
        {
            using (var context = new MCContext())
            {
                var medicine=context.MedicineModels.ToList();
                return medicine;
            }
        }

        public void UpdateMedicine(MedicineModel model)
        {
            using (var context = new MCContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<MedicineModel> GetMedicineList()
        {
            using (var context = new MCContext())
            {
                var medicines=context.MedicineModels.ToList();
                return medicines;
            }
        }

        public MedicineModel GetMedicine(int id)
        {
            using (var context = new MCContext())
            {
                var medicines = context.MedicineModels.Find(id);
                return medicines;
            }
        }

        public MedicineModel GetQty(int id)
        {
            using (var context = new MCContext())
            {
                var medicines = context.MedicineModels.Find(id);

                return medicines;
            }
        }

        public void UpdateQty(MedicineModel model)
        {
            using (var context = new MCContext())
            {
                context.Entry(model).State = System.Data
                    .Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public int GetBillId()
        {
            using (var context = new MCContext())
            {
                var billId=context.BillModels.Select(c => c.BillId).DefaultIfEmpty(0).Max();
                return billId + 1;
            }
        }

        public void SaveBill(BillModel model)
        {
            using (var context = new MCContext())
            {
                context.BillModels.Add(model);
                context.SaveChanges();
            }
        }
    }
}
