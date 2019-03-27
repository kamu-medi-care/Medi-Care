using Kamu_Medi_Care.Receptions;
using Kamu_Medi_Care.Templates;

namespace Kamu_Medi_Care.LogIn
{
    public partial class SignIn : Template
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Reception reception=new Reception();
            reception.Show();
        }
    }
}
