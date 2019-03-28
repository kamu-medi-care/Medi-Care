using Kamu_Medi_Care.Receptions;
using Kamu_Medi_Care.Templates;
using Medi_Care.Service;
using Message;
using System.Windows.Forms;

namespace Kamu_Medi_Care.LogIn
{
    public partial class SignIn : Template
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private SignInService signInService = new SignInService();
        AlertMessage message = new AlertMessage();

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            IsValid();
        }

        private void IsValid()
        {
            var signIn = new Medi_Care.Models.SignIn
            {
                Name = txtUserName.Text,
                Password = txtPassword.Text
            };

            var exist=signInService.GetUser(signIn);

            if (exist)
            {
                Reception reception = new Reception();
                reception.SignedInUser(signIn.Name.ToLower());
                reception.Show();
                this.Hide();

                string msge = "Log In Successfull!";
                string title = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                
                message.message(msge, title, buttons, icon);
            }
            else
            {
                string msge = "Incorrect User Name or Password.";
                string title = "Sign In Fail";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                
                message.message(msge,title,buttons,icon);
                RefreshForm();
            }

        }

        private void RefreshForm()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
