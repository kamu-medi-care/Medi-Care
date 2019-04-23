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

        MedicineService medicineService = new MedicineService();

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var medicineModel = new MedicineModel
            {

                MedicineName = txtMedicineName.Text

            };

            medicineService.AddMedicine(medicineModel);

            txtMedicineName.Clear();
            LoadMedicine();

        }

        private void Medicine_Load(object sender, System.EventArgs e)
        {
            LoadMedicine();
        }

        public void LoadMedicine()
        {
            var data = medicineService.MedicineTable();
            dgvMedicine.DataSource = data;
        }
    }
}
