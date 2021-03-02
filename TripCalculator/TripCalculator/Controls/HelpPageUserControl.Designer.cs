namespace TripCalculator.Controls
{
    partial class SettingsPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoLabel = new System.Windows.Forms.Label();
            this.HideButton = new Guna.UI2.WinForms.Guna2Button();
            this.ThemePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.ColorPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.ColorPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.LinePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ColorPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ThemePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(23, 20);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(212, 145);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Калькулятор расхода топлива позволяет  расчитывать стоимость поездки и расстояние" +
    ", которое можно пройти при определённом количестве заправленного топлива.";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HideButton
            // 
            this.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HideButton.BorderRadius = 10;
            this.HideButton.CheckedState.Parent = this.HideButton;
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.CustomImages.Parent = this.HideButton;
            this.HideButton.FillColor = System.Drawing.Color.White;
            this.HideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.HideButton.HoverState.Parent = this.HideButton;
            this.HideButton.Location = new System.Drawing.Point(64, 413);
            this.HideButton.Margin = new System.Windows.Forms.Padding(10);
            this.HideButton.Name = "HideButton";
            this.HideButton.ShadowDecoration.Parent = this.HideButton;
            this.HideButton.Size = new System.Drawing.Size(129, 40);
            this.HideButton.TabIndex = 7;
            this.HideButton.Text = "На главную";
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ThemePanel
            // 
            this.ThemePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemePanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.ThemePanel.BorderRadius = 20;
            this.ThemePanel.Controls.Add(this.guna2Panel5);
            this.ThemePanel.Controls.Add(this.guna2Panel8);
            this.ThemePanel.Controls.Add(this.guna2Panel6);
            this.ThemePanel.Controls.Add(this.guna2Panel9);
            this.ThemePanel.Controls.Add(this.guna2Panel7);
            this.ThemePanel.Controls.Add(this.guna2Panel2);
            this.ThemePanel.Controls.Add(this.guna2Panel10);
            this.ThemePanel.Controls.Add(this.ColorPanel2);
            this.ThemePanel.Controls.Add(this.guna2Panel3);
            this.ThemePanel.Controls.Add(this.ColorPanel1);
            this.ThemePanel.Controls.Add(this.guna2Panel4);
            this.ThemePanel.Controls.Add(this.ThemeLabel);
            this.ThemePanel.Controls.Add(this.LinePanel);
            this.ThemePanel.Controls.Add(this.ColorPanel);
            this.ThemePanel.FillColor = System.Drawing.Color.White;
            this.ThemePanel.Location = new System.Drawing.Point(21, 179);
            this.ThemePanel.Margin = new System.Windows.Forms.Padding(1);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.ThemePanel.ShadowDecoration.Parent = this.ThemePanel;
            this.ThemePanel.Size = new System.Drawing.Size(216, 206);
            this.ThemePanel.TabIndex = 9;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.White;
            this.guna2Panel5.BorderRadius = 16;
            this.guna2Panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(127)))), ((int)(((byte)(47)))));
            this.guna2Panel5.Location = new System.Drawing.Point(111, 148);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel5.ShadowDecoration.Depth = 20;
            this.guna2Panel5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel5.TabIndex = 17;
            this.guna2Panel5.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BorderColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderRadius = 16;
            this.guna2Panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.guna2Panel8.Location = new System.Drawing.Point(156, 148);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel8.ShadowDecoration.Depth = 20;
            this.guna2Panel8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel8.TabIndex = 14;
            this.guna2Panel8.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.White;
            this.guna2Panel6.BorderRadius = 16;
            this.guna2Panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel6.FillColor = System.Drawing.Color.Teal;
            this.guna2Panel6.Location = new System.Drawing.Point(110, 104);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel6.ShadowDecoration.Depth = 20;
            this.guna2Panel6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel6.TabIndex = 16;
            this.guna2Panel6.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel9.BorderColor = System.Drawing.Color.White;
            this.guna2Panel9.BorderRadius = 16;
            this.guna2Panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(113)))));
            this.guna2Panel9.Location = new System.Drawing.Point(155, 104);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel9.ShadowDecoration.Depth = 20;
            this.guna2Panel9.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel9.ShadowDecoration.Parent = this.guna2Panel9;
            this.guna2Panel9.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel9.TabIndex = 13;
            this.guna2Panel9.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.White;
            this.guna2Panel7.BorderRadius = 16;
            this.guna2Panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel7.FillColor = System.Drawing.Color.Gray;
            this.guna2Panel7.Location = new System.Drawing.Point(110, 60);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel7.ShadowDecoration.Depth = 20;
            this.guna2Panel7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel7.TabIndex = 15;
            this.guna2Panel7.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(156)))));
            this.guna2Panel2.Location = new System.Drawing.Point(66, 148);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel2.ShadowDecoration.Depth = 20;
            this.guna2Panel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel2.TabIndex = 14;
            this.guna2Panel2.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BorderColor = System.Drawing.Color.White;
            this.guna2Panel10.BorderRadius = 16;
            this.guna2Panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(79)))), ((int)(((byte)(4)))));
            this.guna2Panel10.Location = new System.Drawing.Point(155, 60);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel10.ShadowDecoration.Depth = 20;
            this.guna2Panel10.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel10.ShadowDecoration.Parent = this.guna2Panel10;
            this.guna2Panel10.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel10.TabIndex = 12;
            this.guna2Panel10.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // ColorPanel2
            // 
            this.ColorPanel2.BorderColor = System.Drawing.Color.White;
            this.ColorPanel2.BorderRadius = 16;
            this.ColorPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPanel2.FillColor = System.Drawing.Color.MediumOrchid;
            this.ColorPanel2.Location = new System.Drawing.Point(21, 148);
            this.ColorPanel2.Name = "ColorPanel2";
            this.ColorPanel2.ShadowDecoration.BorderRadius = 20;
            this.ColorPanel2.ShadowDecoration.Depth = 20;
            this.ColorPanel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ColorPanel2.ShadowDecoration.Parent = this.ColorPanel2;
            this.ColorPanel2.Size = new System.Drawing.Size(38, 38);
            this.ColorPanel2.TabIndex = 11;
            this.ColorPanel2.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 16;
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(237)))));
            this.guna2Panel3.Location = new System.Drawing.Point(65, 104);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel3.ShadowDecoration.Depth = 20;
            this.guna2Panel3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel3.TabIndex = 13;
            this.guna2Panel3.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // ColorPanel1
            // 
            this.ColorPanel1.BorderColor = System.Drawing.Color.White;
            this.ColorPanel1.BorderRadius = 16;
            this.ColorPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.ColorPanel1.Location = new System.Drawing.Point(20, 104);
            this.ColorPanel1.Name = "ColorPanel1";
            this.ColorPanel1.ShadowDecoration.BorderRadius = 20;
            this.ColorPanel1.ShadowDecoration.Depth = 20;
            this.ColorPanel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ColorPanel1.ShadowDecoration.Parent = this.ColorPanel1;
            this.ColorPanel1.Size = new System.Drawing.Size(38, 38);
            this.ColorPanel1.TabIndex = 10;
            this.ColorPanel1.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 16;
            this.guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel4.FillColor = System.Drawing.Color.Black;
            this.guna2Panel4.Location = new System.Drawing.Point(65, 60);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel4.ShadowDecoration.Depth = 20;
            this.guna2Panel4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(38, 38);
            this.guna2Panel4.TabIndex = 12;
            this.guna2Panel4.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.ThemeLabel.Location = new System.Drawing.Point(13, 13);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(191, 30);
            this.ThemeLabel.TabIndex = 12;
            this.ThemeLabel.Text = "Выбор темы";
            this.ThemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinePanel
            // 
            this.LinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.LinePanel.Location = new System.Drawing.Point(13, 46);
            this.LinePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.ShadowDecoration.Parent = this.LinePanel;
            this.LinePanel.Size = new System.Drawing.Size(190, 1);
            this.LinePanel.TabIndex = 6;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderColor = System.Drawing.Color.White;
            this.ColorPanel.BorderRadius = 15;
            this.ColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPanel.FillColor = System.Drawing.Color.IndianRed;
            this.ColorPanel.Location = new System.Drawing.Point(20, 60);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.ShadowDecoration.BorderRadius = 20;
            this.ColorPanel.ShadowDecoration.Depth = 20;
            this.ColorPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ColorPanel.ShadowDecoration.Parent = this.ColorPanel;
            this.ColorPanel.Size = new System.Drawing.Size(38, 38);
            this.ColorPanel.TabIndex = 9;
            this.ColorPanel.UseTransparentBackground = true;
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ThemePanel);
            this.Name = "SettingsPage";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(258, 468);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.ThemePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private Guna.UI2.WinForms.Guna2Button HideButton;
        private Guna.UI2.WinForms.Guna2Panel ThemePanel;
        private Guna.UI2.WinForms.Guna2Panel LinePanel;
        private Guna.UI2.WinForms.Guna2Panel ColorPanel;
        private System.Windows.Forms.Label ThemeLabel;
        private Guna.UI2.WinForms.Guna2Panel ColorPanel1;
        private Guna.UI2.WinForms.Guna2Panel ColorPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
    }
}
