using Kamu_Medi_Care.Templates;
using Medi_Care.Models;
using Message;
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

        AlertMessage message = new AlertMessage();

        public void SignedInUser(string name)
        {
            DrNameLabel.Text = name.ToUpper();
        }

        private Medi_Care.Service.Appointment appointment = new Medi_Care.Service.Appointment();
        DataTable dataTable = new DataTable();

        private void Appointment_Load(object sender, System.EventArgs e)
        {
            try
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
            }catch(Exception )
            {

            }
        }

        private void GetId()
        {
            try
            {
                //var id = appointment.AppoitmentId();
               // TextBoxId.Text = id.ToString();
                //Is Check out ???
                var startId = Convert.ToInt32(LabelId.Text);
                var response = appointment.IsCheckOut(startId);
                for (int i = 1; response != false; i++)
                {
                    startId = startId + 1;
                    response = appointment.IsCheckOut(startId);
                }

                TextBoxId.Text = startId.ToString();

            }catch(Exception )
            {

            }
            
        }

        private void GetPatientFormReception()
        {
            try
            {
                var id = Convert.ToInt32(TextBoxId.Text);
                var name = DrNameLabel.Text;

                var data = appointment.ReceptionId(id,name);
                for (int i = 1; data==null; i++)
                {
                    if (i < 100)
                    {
                        id = id + 1;
                        data = appointment.ReceptionId(id, name);
                    }
                    else
                    {
                        string msge = "No more patient exist";
                        string title = "Warning";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;

                        message.message(msge, title, buttons, icon);
                        //Appointment appointment = new Appointment();
                        this.Hide();
                        break;
                    }
                    
                }
                
                TextBoxId.Text = data.PatientId.ToString();
                txtName.Text = data.PName.ToString();
                txtFatherName.Text = data.FName.ToString();
                txtAge.Text = data.Age.ToString();
                txtGender.Text = data.Gender;
                txtTemperature.Text = data.Temperature.ToString();
                txtBloodPresure.Text = data.BloodPresure.ToString();
                txtPreVisit.Text = data.DateTime.ToString();
               
            }catch(Exception )
            {

            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SaveAppointment();
            SaveMedicine();
            PrintDocument();
            GetId();
            GetPatientFormReception();


        }

        private void SaveAppointment()
        {
            try
            {
                AppointmentModel appointmentModel = new AppointmentModel
                {
                    PatientId = Convert.ToInt32(TextBoxId.Text),
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
            }catch(Exception )
            {

            }
        }

        private void SaveMedicine()
        {
            try
            {
                for (int i = 0; i < DgvMedicine.Rows.Count - 1; i++)
                {
                    AppointMedicineModel medicineModel = new AppointMedicineModel
                    {
                        PatientId = Convert.ToInt32(TextBoxId.Text),
                        Name = DgvMedicine.Rows[i].Cells[0].Value.ToString(),
                        InaDay = DgvMedicine.Rows[i].Cells[1].Value.ToString(),
                    };
                    appointment.SaveMedicine(medicineModel);
                }
            }catch(Exception)
            {

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

        public void PrintMedicine()
        {
            int hieght = DgvMedicine.Height;
            DgvMedicine.Height = DgvMedicine.RowCount * DgvMedicine.RowTemplate.Height * 2;
            bmp = new Bitmap(DgvMedicine.Width, DgvMedicine.Height);
            DgvMedicine.DrawToBitmap(bmp, new Rectangle(0, 0, DgvMedicine.Width, DgvMedicine.Height));
            DgvMedicine.Height = hieght;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                
                e.Graphics.DrawString("Medical Clinic", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, 25));
                e.Graphics.DrawString(TextBoxId.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 50));
                e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(750, 50));

                e.Graphics.DrawString("Patient Name", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 150));
                e.Graphics.DrawString(" : " + txtName.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 150));
                e.Graphics.DrawString("Father Name", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 150));
                e.Graphics.DrawString(" : " + txtFatherName.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 150));
                e.Graphics.DrawString("Age", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 200));
                e.Graphics.DrawString(" : " + txtAge.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 200));
                e.Graphics.DrawString("Gender", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 200));
                e.Graphics.DrawString(" : "+txtGender.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 200));
                e.Graphics.DrawString("Previous Visit", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 250));
                e.Graphics.DrawString(" : " + txtPreVisit.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 250));
                e.Graphics.DrawString("Next Visit", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 250));
                e.Graphics.DrawString(" : " + nextVistDateTimePicker.Value.ToShortDateString().ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 250));
                e.Graphics.DrawString("Temperature", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 300));
                e.Graphics.DrawString(" : " + txtTemperature.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 300));
                e.Graphics.DrawString("Blood Pressure", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 300));
                e.Graphics.DrawString(" : " + txtBloodPresure.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 300));
                e.Graphics.DrawString("Diseases", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(25, 350));
                e.Graphics.DrawString(" : " + txtDisease.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(150, 350));

                PrintMedicine();
                e.Graphics.DrawImage(bmp, 25, 450);
            }catch(Exception )
            {

            }
        }
    }
}
