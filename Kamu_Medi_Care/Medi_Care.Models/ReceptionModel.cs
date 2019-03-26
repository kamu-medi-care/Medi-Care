using System;

namespace Kamu_Medi_Care.Models
{
    public class ReceptionModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string DrName { get; set; }
        public string PName { get; set; }
        public string FName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public double Fee { get; set; }
        public string Temperature { get; set; }
        public string BloodPresure { get; set; }

    }
}
