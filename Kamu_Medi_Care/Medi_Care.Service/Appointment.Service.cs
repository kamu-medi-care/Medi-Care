using Kamu_Medi_Care.Models;
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

        public int AppoitmentId()
        {
            using (var context = new MCContext())
            {
                int maxId = context.AppointmentModels.Select(p => p.PatientId)
                    .DefaultIfEmpty(0).Max();

                return maxId + 1;
            }
        }

        public bool IsCheckOut(int id)
        {
            using (var context = new MCContext())
            {
                var receptionId = context.AppointmentModels
                    .Where(c => c.PatientId == id).Any();
                return receptionId;
            }
        }

        public ReceptionModel ReceptionId(int id, string name)
        {
            using (var context = new MCContext())
            {
                var receptionModel = context.ReceptionModels.Where(s => s.PatientId == id && s.DrName.ToLower()==name.ToLower()).SingleOrDefault();

                //int receptId = receptionModel.Id;
                return receptionModel;
            }
        }
        
        public int GetPatientId()
        {
            using (var context = new MCContext())
            {
                int maxId = context.ReceptionModels.Select(p => p.PatientId).DefaultIfEmpty(0).Max();

                return maxId + 1;
            }
        }

        public void SaveAppointment(AppointmentModel appointmentModel)
        {
            using (var context = new MCContext())
            {
                context.AppointmentModels.Add(appointmentModel);
                context.SaveChanges();
            }
        }

        public void SaveMedicine(AppointMedicineModel medicine)
        {
            using (var context = new MCContext())
            {
                context.AppointMedicineModels.Add(medicine);
                context.SaveChanges();
            }
        }

    }

}
