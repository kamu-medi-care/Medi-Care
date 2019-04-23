using Kamu_Medi_Care.Templates;
using Medi_Care.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kamu_Medi_Care.Appointment
{
    public partial class Appointment : Template
    {
        public Appointment()
        {
            InitializeComponent();
            
            
        }

        private Medi_Care.Service.Appointment appointment = new Medi_Care.Service.Appointment();
        DataTable dataTable = new DataTable();



        private void Appointment_Load(object sender, System.EventArgs e)
        {

            var data = appointment.GetMedicine();
            CmbMedicine.DataSource = data;
            CmbMedicine.ValueMember = "Id";
            CmbMedicine.DisplayMember = "MedicineName";
            CmbMedicine.SelectedIndex = -1;

            GetId();
            GetPatientFormReception();

            dataTable.Columns.Add("Medicine", typeof(string));
            dataTable.Columns.Add("In a Day", typeof(string));

            DgvMedicine.DataSource = dataTable;
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
            var data = appointment.ReceptionId(Convert.ToInt32(id));
            txtName.Text = data.PName.ToString();
            txtFatherName.Text = data.FName.ToString();
            txtTemperature.Text = data.Temperature.ToString();
            txtBloodPresure.Text = data.BloodPresure.ToString();
            txtPreVisit.Text = data.DateTime.ToString();
            txtAge.Text = data.Age.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SaveAppointment();
            SaveMedicine();
            PrintDocument();



        }

        private void SaveAppointment()
        {
            AppointmentModel appointmentModel = new AppointmentModel
            {
                Name = txtName.Text,
                FName = txtFatherName.Text,
                Temperature = txtTemperature.Text,
                BloodPresure = txtBloodPresure.Text,
                PrevDate = txtPreVisit.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Disease = txtDisease.Text,
                NextDate = nextVistDateTimePicker.Text,
            };
            appointment.SaveAppointment(appointmentModel);
        }

        private void SaveMedicine()
        {
            for (int i = 0; i < DgvMedicine.Rows.Count - 1; i++)
            {
                AppointMedicineModel medicineModel = new AppointMedicineModel
                {
                    PatientId = LabelId.Text,
                    Name = DgvMedicine.Rows[i].Cells[0].Value.ToString(),
                    InaDay = DgvMedicine.Rows[i].Cells[1].Value.ToString(),
                };
                appointment.SaveMedicine(medicineModel);
            }
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
            CmbMedicine.SelectedIndex = -1;
            dataTable.Clear();
        }

        private void CmbMedicine_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dataTable.Rows.Add(CmbMedicine.Text);
                DgvMedicine.DataSource = dataTable;
            }
        }

        private void PrintDocument()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            RefreshForm();
        }
        Bitmap bmp;

        public void printMedicine()
        {
            int hieght = DgvMedicine.Height;
            DgvMedicine.Height = DgvMedicine.RowCount * DgvMedicine.RowTemplate.Height * 2;
            bmp = new Bitmap(DgvMedicine.Width, DgvMedicine.Height);
            DgvMedicine.DrawToBitmap(bmp, new Rectangle(0, 0, DgvMedicine.Width, DgvMedicine.Height));
            DgvMedicine.Height = hieght;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Medical Clinic", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, 25));
            e.Graphics.DrawString("id", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(750, 35));

            e.Graphics.DrawString("Patient Name", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 150));
            e.Graphics.DrawString("Father Name", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 150));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 150));
            e.Graphics.DrawString("Age", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 200));
            e.Graphics.DrawString("Gender", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 200));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 200));
            e.Graphics.DrawString("Previous Visit", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawString("Next Visit", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 250));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 250));
            e.Graphics.DrawString("Temperature", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 300));
            e.Graphics.DrawString("Blood Pressure", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 300));
            e.Graphics.DrawString("Diseases", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString(" : ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 350));
           
            printMedicine();
            e.Graphics.DrawImage(bmp,25,450);
        }
    }
}
