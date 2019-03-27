using Kamu_Medi_Care.Medicines;
using Kamu_Medi_Care.Models;
using Kamu_Medi_Care.Templates;
using Medi_Care.Service;

namespace Kamu_Medi_Care.Receptions
{
    public partial class Reception : Template
    {
        public Reception()
        {
            InitializeComponent();
        }

        ReceptionService receptionService=new ReceptionService();

        private void BtnAppointment_Click(object sender, System.EventArgs e)
        {
            Appointment.Appointment appointment = new Appointment.Appointment();
            appointment.Show();
        }

        private void BtnMedicine_Click(object sender, System.EventArgs e)
        {
            Medicine medicines = new Medicine();
            medicines.Show();
        }

        private void BtnRefer_Click(object sender, System.EventArgs e)
        {
        }
    }
}
