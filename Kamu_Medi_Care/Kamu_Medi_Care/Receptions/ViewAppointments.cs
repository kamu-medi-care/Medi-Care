using Kamu_Medi_Care.Templates;
using Medi_Care.Service;
using System.Windows.Forms;

namespace Kamu_Medi_Care.Appointment
{
    public partial class ViewAppointments : Template
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        ReceptionService receptionService = new ReceptionService();

        private void ViewAppointments_Load(object sender, System.EventArgs e)
        {
            LoadReceptions();
        }

        public void LoadReceptions()
        {
            dgvReception.DataSource = receptionService.GetReception();
            dgvReception.MultiSelect = false;
            dgvReception.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReception.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            var name = txtName.Text;
            var data = receptionService.GetPatientByName(name);
            dgvReception.DataSource = data;

            if (string.IsNullOrEmpty(name))
            {
                var products = receptionService.GetReception();
                dgvReception.DataSource = products;
            }
        }
    }
}
