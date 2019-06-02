using Kamu_Medi_Care.Templates;
using Medi_Care.Models;
using Medi_Care.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kamu_Medi_Care.Medicines

{
    public partial class MediStore : Template
    {
        public MediStore()
        {
            InitializeComponent();
        }

        MedicineService service=new MedicineService();
        DataTable dataTable=new DataTable();

        private void MediStore_Load(object sender, System.EventArgs e)
        {
            var medicines=service.GetMedicineList();

            CmdMedicineName.DataSource = medicines;
            CmdMedicineName.DisplayMember = "MedicineName";
            CmdMedicineName.ValueMember = "Id";
            CmdMedicineName.SelectedIndex = -1;

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Medicine Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Qty", typeof(int));
            dataTable.Columns.Add("Total", typeof(decimal));

            DgvMediStore.DataSource = dataTable;

            BillId();
        }

        private void BillId()
        {
            try
            {
                lbBillId.Text = service.GetBillId().ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnNext_Click(object sender, System.EventArgs e)
        {
            try
            {
                dataTable.Rows.Add(CmdMedicineName.SelectedValue, CmdMedicineName.Text, txtPrice.Text, TxtQty.Text, txtTotal.Text);

                DgvMediStore.DataSource = dataTable;

                ClearFields();

                TotalBill();
            }
            catch (Exception)
            {

            }
        }

        private void DgvMediStore_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CmdMedicineName.Text = this.DgvMediStore.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = this.DgvMediStore.CurrentRow.Cells[2].Value.ToString();
                TxtQty.Text = this.DgvMediStore.CurrentRow.Cells[3].Value.ToString();
                txtTotal.Text = this.DgvMediStore.CurrentRow.Cells[4].Value.ToString();

                MoveRow();
            }
            catch (Exception)
            {

            }
            
        }

        private void MoveRow()
        {
            int rowIndex = DgvMediStore.CurrentCell.RowIndex;
            DgvMediStore.Rows.RemoveAt(rowIndex);
        }

        private void CmdMedicineName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var id = Convert.ToInt32(CmdMedicineName.SelectedValue);
                    var data = service.GetMedicine(id);
                    txtPrice.Text = (data.Price.ToString());
                    txtAvailableQty.Text = data.Qty.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void ClearFields()
        {
            CmdMedicineName.SelectedIndex = -1;
            txtAvailableQty.Clear();
            txtPrice.Clear();
            TxtQty.Clear();
            txtTotal.Clear();
        }

        private void TotalBill()
        {
            try
            {
                decimal sum = 0;
                foreach (DataRow dr in dataTable.Rows)
                {
                    sum += Convert.ToDecimal(dr["Total"]);
                    txtTotalBill.Text = sum.ToString();
                }
            }
            catch (Exception)
            {

            }

        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Convert.ToInt32(txtAvailableQty.Text) >= Convert.ToInt32(TxtQty.Text))
                    {
                        var price = (txtPrice.Text);
                        var qty = (TxtQty.Text);
                        var product = Convert.ToDecimal(price) * Convert.ToInt32(qty);
                        txtTotal.Text = product.ToString();
                        TxtQty.Text = qty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Available Quantity is " + txtAvailableQty.Text, "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtQty.Clear();
                    }
                }
            }
            catch (Exception)
            {

            }

            //MessageBox.Show("Data has update successfully!", "Success",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            GetTotalBill();
            SaveBill();
            ClearForm();
        }

        private void GetTotalBill()
        {
            try
            {
                foreach (DataRow tableData in dataTable.Rows)
                {
                    var id = Convert.ToInt32(tableData["Id"]);
                    var qty = Convert.ToInt32(tableData["Qty"]);
                    var data = service.GetQty(id);

                    var updatedQty = Convert.ToInt32(data.Qty) - Convert.ToInt32(qty);

                    var model = new MedicineModel
                    {
                        Id = id,
                        MedicineName = Convert.ToString(tableData["Medicine Name"]),
                        Price = Convert.ToDecimal(tableData["Price"]),
                        Qty = updatedQty,
                    };

                    service.UpdateQty(model);
                }
            }
            catch (Exception)
            {

            }
        }

        private void SaveBill()
        {
            try
            {
                for (int i = 0; i < DgvMediStore.RowCount - 1; i++)
                {
                    var model = new BillModel();

                    model.BillId = Convert.ToInt32(lbBillId.Text);
                    model.MedicineId = Convert.ToInt32(DgvMediStore.Rows[i].Cells[0].Value);
                    model.Price = Convert.ToDecimal(DgvMediStore.Rows[i].Cells[2].Value);
                    model.Qty = Convert.ToInt32(DgvMediStore.Rows[i].Cells[3].Value);
                    model.TotalPrice = Convert.ToDecimal(DgvMediStore.Rows[i].Cells[4].Value);
                    model.TotalBill = Convert.ToDecimal(txtTotalBill.Text);

                    service.SaveBill(model);
                }
            }
            catch (Exception)
            {

            }
        }

        private void ClearForm()
        {
            DgvMediStore.DataSource = null;
            txtTotalBill.Clear();
        }
    }
}

