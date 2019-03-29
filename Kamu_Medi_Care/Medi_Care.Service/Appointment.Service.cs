using Medi_Care.Database;
using Medi_Care.Models;
using System;
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

        public int AppoitmentId()
        {
            using (var context = new MCContext())
            {
                int maxId = context.AppointmentModels.Select(p => p.Id).DefaultIfEmpty(0).Max();

                return maxId + 1;
            }
        }

        public int ReceptionId(int id)
        {
            using (var context = new MCContext())
            {
                var receptionModel = context.ReceptionModels.Where(s => s.Id == id).SingleOrDefault();

                int receptId = receptionModel.Id;
                return receptId;
            }
        }

    }

}
