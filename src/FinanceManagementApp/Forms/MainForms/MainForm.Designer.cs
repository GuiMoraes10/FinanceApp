namespace FinanceManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            UsernameLabel = new Label();
            UserPb = new PictureBox();
            SettingsBtn = new Button();
            ProjectionsBtn = new Button();
            InvestmentsBtn = new Button();
            CallendarBtn = new Button();
            TransactionsBtn = new Button();
            DashboardBtn = new Button();
            TitleLabel = new Label();
            SwPicturePb = new PictureBox();
            TopPanel = new Panel();
            MinimizeBtn = new Button();
            MaximizeBtn = new Button();
            CloseBtn = new Button();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SwPicturePb).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 37, 37);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(UsernameLabel);
            panel1.Controls.Add(UserPb);
            panel1.Controls.Add(SettingsBtn);
            panel1.Controls.Add(ProjectionsBtn);
            panel1.Controls.Add(InvestmentsBtn);
            panel1.Controls.Add(CallendarBtn);
            panel1.Controls.Add(TransactionsBtn);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(SwPicturePb);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 571);
            panel1.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.FromArgb(241, 241, 241);
            UsernameLabel.Location = new Point(105, 524);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(74, 19);
            UsernameLabel.TabIndex = 11;
            UsernameLabel.Text = "UserName";
            // 
            // UserPb
            // 
            UserPb.Image = (Image)resources.GetObject("UserPb.Image");
            UserPb.Location = new Point(3, 503);
            UserPb.Name = "UserPb";
            UserPb.Size = new Size(75, 65);
            UserPb.SizeMode = PictureBoxSizeMode.CenterImage;
            UserPb.TabIndex = 2;
            UserPb.TabStop = false;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.FromArgb(45, 45, 45);
            SettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            SettingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            SettingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Bahnschrift", 12F);
            SettingsBtn.ForeColor = Color.FromArgb(184, 184, 184);
            SettingsBtn.Image = (Image)resources.GetObject("SettingsBtn.Image");
            SettingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.Location = new Point(0, 381);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(209, 52);
            SettingsBtn.TabIndex = 10;
            SettingsBtn.Text = "           Configurações";
            SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // ProjectionsBtn
            // 
            ProjectionsBtn.BackColor = Color.FromArgb(45, 45, 45);
            ProjectionsBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            ProjectionsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            ProjectionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            ProjectionsBtn.FlatStyle = FlatStyle.Flat;
            ProjectionsBtn.Font = new Font("Bahnschrift", 12F);
            ProjectionsBtn.ForeColor = Color.FromArgb(184, 184, 184);
            ProjectionsBtn.Image = (Image)resources.GetObject("ProjectionsBtn.Image");
            ProjectionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProjectionsBtn.Location = new Point(0, 327);
            ProjectionsBtn.Name = "ProjectionsBtn";
            ProjectionsBtn.Size = new Size(209, 52);
            ProjectionsBtn.TabIndex = 9;
            ProjectionsBtn.Text = "        Projeções";
            ProjectionsBtn.UseVisualStyleBackColor = false;
            // 
            // InvestmentsBtn
            // 
            InvestmentsBtn.BackColor = Color.FromArgb(45, 45, 45);
            InvestmentsBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            InvestmentsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            InvestmentsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            InvestmentsBtn.FlatStyle = FlatStyle.Flat;
            InvestmentsBtn.Font = new Font("Bahnschrift", 12F);
            InvestmentsBtn.ForeColor = Color.FromArgb(184, 184, 184);
            InvestmentsBtn.Image = (Image)resources.GetObject("InvestmentsBtn.Image");
            InvestmentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            InvestmentsBtn.Location = new Point(0, 273);
            InvestmentsBtn.Name = "InvestmentsBtn";
            InvestmentsBtn.Size = new Size(209, 52);
            InvestmentsBtn.TabIndex = 8;
            InvestmentsBtn.Text = "          Investimentos";
            InvestmentsBtn.UseVisualStyleBackColor = false;
            // 
            // CallendarBtn
            // 
            CallendarBtn.BackColor = Color.FromArgb(45, 45, 45);
            CallendarBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            CallendarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            CallendarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            CallendarBtn.FlatStyle = FlatStyle.Flat;
            CallendarBtn.Font = new Font("Bahnschrift", 12F);
            CallendarBtn.ForeColor = Color.FromArgb(184, 184, 184);
            CallendarBtn.Image = (Image)resources.GetObject("CallendarBtn.Image");
            CallendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CallendarBtn.Location = new Point(0, 219);
            CallendarBtn.Name = "CallendarBtn";
            CallendarBtn.Size = new Size(209, 52);
            CallendarBtn.TabIndex = 7;
            CallendarBtn.Text = "          Agendamentos";
            CallendarBtn.UseVisualStyleBackColor = false;
            // 
            // TransactionsBtn
            // 
            TransactionsBtn.BackColor = Color.FromArgb(45, 45, 45);
            TransactionsBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            TransactionsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            TransactionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            TransactionsBtn.FlatStyle = FlatStyle.Flat;
            TransactionsBtn.Font = new Font("Bahnschrift", 12F);
            TransactionsBtn.ForeColor = Color.FromArgb(184, 184, 184);
            TransactionsBtn.Image = (Image)resources.GetObject("TransactionsBtn.Image");
            TransactionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TransactionsBtn.Location = new Point(0, 165);
            TransactionsBtn.Name = "TransactionsBtn";
            TransactionsBtn.Size = new Size(209, 52);
            TransactionsBtn.TabIndex = 6;
            TransactionsBtn.Text = "         Transações";
            TransactionsBtn.UseVisualStyleBackColor = false;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.FromArgb(45, 45, 45);
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            DashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 58);
            DashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Bahnschrift", 12F);
            DashboardBtn.ForeColor = Color.FromArgb(184, 184, 184);
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(0, 111);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(209, 52);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "          Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(56, 74);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(99, 23);
            TitleLabel.TabIndex = 5;
            TitleLabel.Text = "Finance App";
            // 
            // SwPicturePb
            // 
            SwPicturePb.BackColor = Color.Transparent;
            SwPicturePb.Dock = DockStyle.Top;
            SwPicturePb.Image = (Image)resources.GetObject("SwPicturePb.Image");
            SwPicturePb.Location = new Point(0, 0);
            SwPicturePb.Name = "SwPicturePb";
            SwPicturePb.Size = new Size(207, 70);
            SwPicturePb.SizeMode = PictureBoxSizeMode.CenterImage;
            SwPicturePb.TabIndex = 2;
            SwPicturePb.TabStop = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(37, 37, 38);
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Controls.Add(MinimizeBtn);
            TopPanel.Controls.Add(MaximizeBtn);
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(209, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(719, 32);
            TopPanel.TabIndex = 1;
            TopPanel.MouseDown += TopPanel_MouseDown;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackColor = Color.FromArgb(45, 45, 48);
            MinimizeBtn.Dock = DockStyle.Right;
            MinimizeBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            MinimizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 50, 50);
            MinimizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 60, 60);
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            MinimizeBtn.ForeColor = Color.FromArgb(184, 184, 184);
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(621, 0);
            MinimizeBtn.Margin = new Padding(0);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(32, 30);
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.TextAlign = ContentAlignment.MiddleRight;
            MinimizeBtn.UseVisualStyleBackColor = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // MaximizeBtn
            // 
            MaximizeBtn.BackColor = Color.FromArgb(45, 45, 48);
            MaximizeBtn.Dock = DockStyle.Right;
            MaximizeBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            MaximizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 50, 50);
            MaximizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 60, 60);
            MaximizeBtn.FlatStyle = FlatStyle.Flat;
            MaximizeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            MaximizeBtn.ForeColor = Color.FromArgb(184, 184, 184);
            MaximizeBtn.Image = (Image)resources.GetObject("MaximizeBtn.Image");
            MaximizeBtn.Location = new Point(653, 0);
            MaximizeBtn.Margin = new Padding(0);
            MaximizeBtn.Name = "MaximizeBtn";
            MaximizeBtn.Size = new Size(32, 30);
            MaximizeBtn.TabIndex = 2;
            MaximizeBtn.TextAlign = ContentAlignment.MiddleRight;
            MaximizeBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(45, 45, 48);
            CloseBtn.Dock = DockStyle.Right;
            CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 50, 50);
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 60, 60);
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 12F);
            CloseBtn.ForeColor = Color.FromArgb(184, 184, 184);
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(685, 0);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(32, 30);
            CloseBtn.TabIndex = 1;
            CloseBtn.TextAlign = ContentAlignment.MiddleRight;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(209, 32);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(719, 539);
            MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(928, 571);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceApp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)SwPicturePb).EndInit();
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel TopPanel;
        private Button CloseBtn;
        private PictureBox SwPicturePb;
        private Label TitleLabel;
        private Button DashboardBtn;
        private Button TransactionsBtn;
        private Button SettingsBtn;
        private Button ProjectionsBtn;
        private Button InvestmentsBtn;
        private Button CallendarBtn;
        private Label UsernameLabel;
        private PictureBox UserPb;
        private Panel MainPanel;
        private Button MinimizeBtn;
        private Button MaximizeBtn;
    }
}
