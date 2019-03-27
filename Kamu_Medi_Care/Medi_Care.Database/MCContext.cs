using Kamu_Medi_Care.Models;
using Medi_Care.Models;
using System.Data.Entity;

namespace Medi_Care.Database
{
    public class MCContext:DbContext
    {
        public MCContext():base("Medi_Care_Connection")
        {
        }

        public DbSet<ReceptionModel> ReceptionModels { get; set; }
        public DbSet<MedicineModel> MedicineModels { get; set; }
        public DbSet<SignIn> SignIns { get; set; }
    }
}
