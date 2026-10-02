namespace FinanceManagementApp.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            RegisterBtn = new Button();
            TitleLabel = new Label();
            UserLabel = new Label();
            PasswordLabel = new Label();
            TopPanel = new Panel();
            MinimizeBtn = new Button();
            MaximizeBtn = new Button();
            CloseBtn = new Button();
            pictureBox1 = new PictureBox();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.FromArgb(51, 51, 51);
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            UserTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            UserTextBox.Location = new Point(117, 109);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(137, 24);
            UserTextBox.TabIndex = 0;
            UserTextBox.KeyDown += UserTextBox_KeyDown;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(51, 51, 51);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            PasswordTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordTextBox.Location = new Point(117, 155);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(137, 24);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(70, 70, 74);
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.FromArgb(241, 241, 241);
            LoginBtn.Location = new Point(98, 203);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 27);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(70, 70, 74);
            RegisterBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            RegisterBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            RegisterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBtn.ForeColor = Color.FromArgb(241, 241, 241);
            RegisterBtn.Location = new Point(197, 203);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 27);
            RegisterBtn.TabIndex = 3;
            RegisterBtn.Text = "Registrar";
            RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(113, 59);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(99, 23);
            TitleLabel.TabIndex = 4;
            TitleLabel.Text = "Finance App";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            UserLabel.ForeColor = Color.FromArgb(241, 241, 241);
            UserLabel.Location = new Point(50, 111);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(61, 19);
            UserLabel.TabIndex = 5;
            UserLabel.Text = "Usuário:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            PasswordLabel.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordLabel.Location = new Point(60, 157);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(51, 19);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Senha:";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(37, 37, 38);
            TopPanel.Controls.Add(MinimizeBtn);
            TopPanel.Controls.Add(MaximizeBtn);
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(365, 29);
            TopPanel.TabIndex = 7;
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
            MinimizeBtn.Font = new Font("Microsoft Sans Serif", 10F);
            MinimizeBtn.ForeColor = Color.FromArgb(184, 184, 184);
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(281, 0);
            MinimizeBtn.Margin = new Padding(0);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(28, 29);
            MinimizeBtn.TabIndex = 2;
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
            MaximizeBtn.Font = new Font("Microsoft Sans Serif", 10F);
            MaximizeBtn.ForeColor = Color.FromArgb(184, 184, 184);
            MaximizeBtn.Image = (Image)resources.GetObject("MaximizeBtn.Image");
            MaximizeBtn.Location = new Point(309, 0);
            MaximizeBtn.Margin = new Padding(0);
            MaximizeBtn.Name = "MaximizeBtn";
            MaximizeBtn.Size = new Size(28, 29);
            MaximizeBtn.TabIndex = 1;
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
            CloseBtn.Font = new Font("Microsoft Sans Serif", 10F);
            CloseBtn.ForeColor = Color.FromArgb(184, 184, 184);
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(337, 0);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(28, 29);
            CloseBtn.TabIndex = 0;
            CloseBtn.TextAlign = ContentAlignment.MiddleRight;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(365, 266);
            Controls.Add(pictureBox1);
            Controls.Add(TopPanel);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(TitleLabel);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Font = new Font("Microsoft Sans Serif", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
        private Button LoginBtn;
        private Button RegisterBtn;
        private Label TitleLabel;
        private Label UserLabel;
        private Label PasswordLabel;
        private Panel TopPanel;
        private Button CloseBtn;
        private PictureBox pictureBox1;
        private Button MinimizeBtn;
        private Button MaximizeBtn;
    }
}