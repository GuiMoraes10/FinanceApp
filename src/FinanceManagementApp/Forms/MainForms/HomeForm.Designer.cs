namespace FinanceManagementApp.Forms
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            TimeLabel = new Label();
            DateLabel = new Label();
            WellcomeLabel = new Label();
            DateTimeTick = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Bahnschrift SemiCondensed", 55F);
            TimeLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TimeLabel.Location = new Point(221, 214);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(273, 89);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "00:00:00";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Bahnschrift SemiCondensed", 20F);
            DateLabel.ForeColor = Color.FromArgb(241, 241, 241);
            DateLabel.Location = new Point(178, 325);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(366, 33);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "domingo, 01 de Dezembro de 2026";
            DateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WellcomeLabel
            // 
            WellcomeLabel.AutoSize = true;
            WellcomeLabel.Font = new Font("Bahnschrift SemiCondensed", 20F);
            WellcomeLabel.ForeColor = Color.FromArgb(241, 241, 241);
            WellcomeLabel.Location = new Point(26, 102);
            WellcomeLabel.Name = "WellcomeLabel";
            WellcomeLabel.Size = new Size(255, 33);
            WellcomeLabel.TabIndex = 8;
            WellcomeLabel.Text = "Bem-vindo, Guilherme!";
            // 
            // DateTimeTick
            // 
            DateTimeTick.Enabled = true;
            DateTimeTick.Tick += DateTimeTick_Tick;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(WellcomeLabel);
            Controls.Add(DateLabel);
            Controls.Add(TimeLabel);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private Label DateLabel;
        private Label WellcomeLabel;
        private System.Windows.Forms.Timer DateTimeTick;
    }
}