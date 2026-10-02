using FinanceManagementApp.Forms;
using System.Runtime.InteropServices;

namespace FinanceManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            OpenFormInPanel(new HomeForm("Guilherme"));
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private Form? _currentForm;

        private void OpenFormInPanel(Form childForm)
        {
            _currentForm?.Close();
            _currentForm?.Dispose();

            _currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;

            childForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void SwPicturePb_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new HomeForm("Guilherme"));
        }
    }
}
