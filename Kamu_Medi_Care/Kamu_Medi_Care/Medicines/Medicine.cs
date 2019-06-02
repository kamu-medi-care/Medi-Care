using Kamu_Medi_Care.Templates;
using Medi_Care.Models;
using Medi_Care.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kamu_Medi_Care.Medicines
{
    public partial class Medicine : Template
    {
        public Medicine()
        {
            InitializeComponent();
        }

        MedicineService medicineService = new MedicineService();
        DataTable dataTable=new DataTable();

        private void Medicine_Load(object sender, System.EventArgs e)
        {
            dataTable.Columns.Add("Medicine Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Qty", typeof(int));

            dgvMedicine.DataSource = dataTable;

            LoadMedicine();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable.Rows.Add(txtMedicineName.Text, txtPrice.Text, txtQty.Text);

                dgvMedicine.DataSource = dataTable;
            }
            catch (Exception)
            {

            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvMedicine.RowCount-1; i++)
                {
                    var model = new MedicineModel
                    {
                        MedicineName = Convert.ToString(dgvMedicine.Rows[i].Cells[0].Value),
                        Price = Convert.ToDecimal(dgvMedicine.Rows[i].Cells[1].Value),
                        Qty = Convert.ToInt32(dgvMedicine.Rows[i].Cells[2].Value)
                    };

                    medicineService.AddMedicine(model);

                    MessageBox.Show("Data has saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadMedicine();
                }
                
            }
            catch (Exception)
            {

            }
        }

        private void ClearFields()
        {
            txtMedicineName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            dgvMedicine.DataSource = null;
        }

        private void DgvSavedMedicine_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                txtIdU.Text = this.DgvSavedMedicine.CurrentRow.Cells[0].Value.ToString();
                txtMedicineNameU.Text = this.DgvSavedMedicine.CurrentRow.Cells[1].Value.ToString();
                txtPriceU.Text = this.DgvSavedMedicine.CurrentRow.Cells[2].Value.ToString();
                txtQtyU.Text = this.DgvSavedMedicine.CurrentRow.Cells[3].Value.ToString();

                BtnUpdate.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new MedicineModel
                {
                    Id = Convert.ToInt32(txtIdU.Text),
                    MedicineName = txtMedicineNameU.Text.ToString(),
                    Price = Convert.ToDecimal(txtPriceU.Text),
                    Qty = Convert.ToInt32(txtQtyU.Text)
                };
                medicineService.UpdateMedicine(model);

                MessageBox.Show("Data has update successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearUpdateFields();
                LoadMedicine();
            }
            catch (Exception)
            {

            }

        }

        private void ClearUpdateFields()
        {
            txtIdU.Clear();
            txtMedicineNameU.Clear();
            txtPriceU.Clear();
            txtQtyU.Clear();
            DgvSavedMedicine.DataSource = null;
        }


        public void LoadMedicine()
        {
            try
            {
                var data = medicineService.GetMedicine();
                DgvSavedMedicine.DataSource = data;

            }
            catch (Exception)
            {

            }
        }
    }
}
