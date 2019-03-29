using Kamu_Medi_Care.Templates;
using System;

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
            GetPatientFormReception();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            GetId();
            GetPatientFormReception(); 
        }

        private void GetId()
        {
            var id = appointment.AppoitmentId();
            LabelId.Text = id.ToString();
        }

        private void GetPatientFormReception()
        {
            var id = LabelId.Text;
            var data=appointment.ReceptionId(Convert.ToInt32(id));
            txtName.Text = data.PName.ToString();
            txtFatherName.Text = data.FName.ToString();
            txtTemperature.Text = data.Temperature.ToString();
            txtBloodPresure.Text = data.BloodPresure.ToString();
            txtPreVisit.Text = data.DateTime.ToString();
            txtAge.Text = data.Age.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtTemperature.Clear();
            txtBloodPresure.Clear();
            txtPreVisit.Clear();
            txtAge.Clear();
            txtDisease.Clear();
            cmbMedicine.SelectedIndex = -1;
            txtNextVisit.Clear();
        }
    }
}
