using Medi_Care.Database;
using Medi_Care.Models;
using System.Linq;

namespace Medi_Care.Service
{
    public class SignInService
    {
        public bool GetUser(SignIn signIn/*string name,string password*/)
        {
            using (var context = new MCContext())
            {
                var exist = context.SignIns.Where(
                    c=>c.Name==signIn.Name && c.Password==signIn.Password).Any();
                return exist;
            };
        }
    }
}
