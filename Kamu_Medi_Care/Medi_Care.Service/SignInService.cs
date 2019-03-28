using Medi_Care.Database;
using Medi_Care.Models;

namespace Medi_Care.Service
{
    public class SignInService
    {
        public SignIn GetUser(int id)
        {
            using (var context = new MCContext())
            {
                var user = context.SignIns.Find(id);
                return user;
            };
        }
    }
}
