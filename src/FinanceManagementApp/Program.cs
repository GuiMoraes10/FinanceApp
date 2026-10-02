using FinanceManagementApp.Forms;

namespace FinanceManagementApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using LoginForm loginForm = new();

            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}