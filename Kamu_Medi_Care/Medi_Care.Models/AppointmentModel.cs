namespace Medi_Care.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string Temperature { get; set; }
        public string BloodPresure { get; set; }
        public string PrevDate { get; set; }
        public string Disease { get; set; }
        //public string Medicine { get; set; }
        public int Age { get; set; }
        public string NextDate { get; set; }
    }
}
