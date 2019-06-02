namespace Medi_Care.Models
{
    public class BillModel
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int MedicineId { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalBill { get; set; }
    }
}
