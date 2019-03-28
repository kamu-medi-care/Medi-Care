using Kamu_Medi_Care.Receptions;
using Kamu_Medi_Care.Templates;
using Medi_Care.Service;

namespace Kamu_Medi_Care.LogIn
{
    public partial class SignIn : Template
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private SignInService signInService = new SignInService();

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            Reception reception=new Reception();
            reception.Show();
        }

        private void IsValid()
        {
            Medi_Care.Models.SignIn signIn = new Medi_Care.Models.SignIn();
            signIn.Name = txtUserName.Text;
            //signInService.GetUser(signIn);
        }
    }
}
