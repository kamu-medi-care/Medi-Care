using Kamu_Medi_Care.Templates;
using Medi_Care.Service;
using System.Linq;
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
            string name = null;
            LoadReceptions(name);
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            var name = txtName.Text;
            LoadReceptions(name);
        }


        public void LoadReceptions(string name)
        {
            var data = receptionService.GetReception();
            dgvReception.DataSource = data;
            if (!string.IsNullOrEmpty(name))
            {
                data = data.Where(c => c.PName.ToLower().Contains(name.ToLower())).ToList();
                dgvReception.DataSource = data;
            }
            dgvReception.MultiSelect = false;
            dgvReception.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReception.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
