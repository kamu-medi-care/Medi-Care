using Kamu_Medi_Care.Templates;

namespace Kamu_Medi_Care.Receptions
{
    public partial class Reception : Temaplate
    {
        public Reception()
        {
            InitializeComponent();
        }

        private void BtnAppointment_Click(object sender, System.EventArgs e)
        {
            Appointment.Appointment appointment = new Appointment.Appointment();
            appointment.Show();
        }
    }
}
