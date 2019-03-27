using Kamu_Medi_Care.Templates;
using Medi_Care.Models;
using Medi_Care.Service;

namespace Kamu_Medi_Care.Medicines
{
    public partial class Medicine : Template
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {

            var medicineModel = new MedicineModel {

                MedicineName = txtMedicineName.Text


                   };
            

            MedicineService medicineService = new MedicineService();
            medicineService.AddMedicine(medicineModel);

            txtMedicineName.Clear();
            
        }
    }
}
