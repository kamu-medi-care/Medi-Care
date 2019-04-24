using Kamu_Medi_Care.Appointment;
using Kamu_Medi_Care.Medicines;
using Kamu_Medi_Care.Models;
using Kamu_Medi_Care.Report;
using Kamu_Medi_Care.Templates;
using Medi_Care.Service;
using System;
using System.Windows.Forms;

namespace Kamu_Medi_Care.Receptions
{
    public partial class Reception : Template
    {
        public Reception()
        {
            InitializeComponent();

            SetId();
        }

        ReceptionService receptionService = new ReceptionService();

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
            try
            {

                var reception = new ReceptionModel()
                {
                    DateTime = DtpDate.Text,
                    DrName = cmbDrName.SelectedItem.ToString(),
                    PName = txtName.Text,
                    FName = txtFatherName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Gender = cmbGender.SelectedItem.ToString(),
                    PhoneNo = txtPhoneNo.Text,
                    Address = txtAddress.Text,
                    Fee = Convert.ToDouble(txtFee.Text),
                    Temperature = txtTemperature.Text,
                    BloodPresure = txtBloodPresure.Text,
                };

                receptionService.ReferPatient(reception);
            }
            catch (Exception )
            {
                MessageBox.Show("Please Enter Data in Correct Formate");
            }

            RefreshReception();
            SetId();
        }

        public void RefreshReception()
        {

            cmbDrName.SelectedIndex = -1;
            txtName.Clear();
            txtFatherName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhoneNo.Clear();
            txtAddress.Clear();
            txtFee.Clear();
            txtTemperature.Clear();
            txtBloodPresure.Clear();
        }

        private void BtnViewReception_Click(object sender, EventArgs e)
        {
            ViewAppointments viewAppointments = new ViewAppointments();
            viewAppointments.Show();
        }

        public void SignedInUser(string Name)
        {
            try
            {

                label.Text = Name.ToUpper();

                if (Name == "reception")
                {
                    BtnAppointment.Enabled = false;
                    BtnMedicine.Enabled = false;
                    btnViewMedicine.Enabled = false;
                    BtnReport.Enabled = false;
                }
            }
            catch (Exception )
            {

            }
        }

        private Medi_Care.Service.Appointment appointment = new Medi_Care.Service.Appointment();

        public void SetId()
        {
            try
            {

                txtId.Text = appointment.ReceptionId().ToString();
            }
            catch (Exception )
            {

            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn.SignIn signIn = new LogIn.SignIn();
            signIn.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Show();
        }
    }
}
