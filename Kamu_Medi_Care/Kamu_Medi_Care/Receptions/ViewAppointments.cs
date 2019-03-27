using Kamu_Medi_Care.Templates;
using Medi_Care.Service;

namespace Kamu_Medi_Care.Appointment
{
    public partial class ViewAppointments : Template
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        ReceptionService receptionService=new ReceptionService();

        private void ViewAppointments_Load(object sender, System.EventArgs e)
        {
            LoadReceptions();
        }

        public void LoadReceptions()
        {
            receptionService.GetReception();
        }
    }
}
