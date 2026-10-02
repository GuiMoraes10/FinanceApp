namespace FinanceManagementApp.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm(string userName)
        {
            InitializeComponent();

            if (userName is not null)
            {
                WellcomeLabel.Text = "Bem-vindo, " + userName + "!";
            }
            else
            {
                WellcomeLabel.Text = "Bem-vindo, Usuário!";
            }
        }

        private void DateTimeTick_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
