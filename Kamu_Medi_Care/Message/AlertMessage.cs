using System.Windows.Forms;

namespace Message
{
    public class AlertMessage
    {
        public void message(string msg,string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            MessageBox.Show(msg,title, button,icon);
        }
    }
}
