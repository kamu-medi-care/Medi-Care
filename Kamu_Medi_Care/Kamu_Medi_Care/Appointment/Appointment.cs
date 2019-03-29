using Kamu_Medi_Care.Templates;

namespace Kamu_Medi_Care.Appointment
{
    public partial class Appointment : Template
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private Medi_Care.Service.Appointment appointment = new Medi_Care.Service.Appointment();

        private void Appointment_Load(object sender, System.EventArgs e)
        {
            var data= appointment.GetMedicine();
            cmbMedicine.DataSource = data;
            cmbMedicine.ValueMember = "Id";
            cmbMedicine.DisplayMember = "MedicineName";

            GetId();
        }

        private void GetId()
        {
            var id = appointment.AppoitmentId();
            LabelId.Text=appointment.ReceptionId(id).ToString();

        }
    }
}
