namespace TripCalculator
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.InputPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Line2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ConsumptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Line1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ConsumptionLabel = new System.Windows.Forms.Label();
            this.LitersLabel = new System.Windows.Forms.Label();
            this.LitersTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            this.BottomPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TravelCostInfoLabel = new System.Windows.Forms.Label();
            this.DistanceInfoLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.TravelCostLabel = new System.Windows.Forms.Label();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CLoseButton = new System.Windows.Forms.Label();
            this.HelpButton = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HelpHoverPanel = new TripCalculator.Controls.SettingsPage();
            this.InputPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.BorderRadius = 20;
            this.ElipseForm.TargetControl = this;
            // 
            // DragControl1
            // 
            this.DragControl1.ContainerControl = this;
            this.DragControl1.TargetControl = this;
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPanel.BackColor = System.Drawing.Color.Transparent;
            this.InputPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.InputPanel.BorderRadius = 20;
            this.InputPanel.BorderThickness = 1;
            this.InputPanel.Controls.Add(this.PriceTextBox);
            this.InputPanel.Controls.Add(this.Line2);
            this.InputPanel.Controls.Add(this.ConsumptionTextBox);
            this.InputPanel.Controls.Add(this.Line1);
            this.InputPanel.Controls.Add(this.PriceLabel);
            this.InputPanel.Controls.Add(this.ConsumptionLabel);
            this.InputPanel.Controls.Add(this.LitersLabel);
            this.InputPanel.Controls.Add(this.LitersTextBox);
            this.InputPanel.FillColor = System.Drawing.Color.White;
            this.InputPanel.Location = new System.Drawing.Point(10, 83);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(1);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.InputPanel.ShadowDecoration.Parent = this.InputPanel;
            this.InputPanel.Size = new System.Drawing.Size(238, 220);
            this.InputPanel.TabIndex = 0;
            this.InputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextBox.Animated = true;
            this.PriceTextBox.BorderRadius = 8;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.DefaultText = "";
            this.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.DisabledState.Parent = this.PriceTextBox;
            this.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.FocusedState.Parent = this.PriceTextBox;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.HoverState.Parent = this.PriceTextBox;
            this.PriceTextBox.Location = new System.Drawing.Point(13, 173);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderText = "";
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.ShadowDecoration.Parent = this.PriceTextBox;
            this.PriceTextBox.Size = new System.Drawing.Size(212, 30);
            this.PriceTextBox.TabIndex = 10;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress_1);
            // 
            // Line2
            // 
            this.Line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.Line2.Location = new System.Drawing.Point(16, 141);
            this.Line2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Line2.Name = "Line2";
            this.Line2.ShadowDecoration.Parent = this.Line2;
            this.Line2.Size = new System.Drawing.Size(209, 1);
            this.Line2.TabIndex = 9;
            // 
            // ConsumptionTextBox
            // 
            this.ConsumptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumptionTextBox.Animated = true;
            this.ConsumptionTextBox.BorderRadius = 8;
            this.ConsumptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConsumptionTextBox.DefaultText = "";
            this.ConsumptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConsumptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConsumptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConsumptionTextBox.DisabledState.Parent = this.ConsumptionTextBox;
            this.ConsumptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConsumptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConsumptionTextBox.FocusedState.Parent = this.ConsumptionTextBox;
            this.ConsumptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsumptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConsumptionTextBox.HoverState.Parent = this.ConsumptionTextBox;
            this.ConsumptionTextBox.Location = new System.Drawing.Point(13, 105);
            this.ConsumptionTextBox.Name = "ConsumptionTextBox";
            this.ConsumptionTextBox.PasswordChar = '\0';
            this.ConsumptionTextBox.PlaceholderText = "";
            this.ConsumptionTextBox.SelectedText = "";
            this.ConsumptionTextBox.ShadowDecoration.Parent = this.ConsumptionTextBox;
            this.ConsumptionTextBox.Size = new System.Drawing.Size(212, 30);
            this.ConsumptionTextBox.TabIndex = 8;
            this.ConsumptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsumptionTextBox_KeyPress);
            // 
            // Line1
            // 
            this.Line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.Line1.Location = new System.Drawing.Point(16, 75);
            this.Line1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Line1.Name = "Line1";
            this.Line1.ShadowDecoration.Parent = this.Line1;
            this.Line1.Size = new System.Drawing.Size(209, 1);
            this.Line1.TabIndex = 6;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.PriceLabel.Location = new System.Drawing.Point(13, 152);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(178, 16);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Стоимость, руб. / литр:";
            // 
            // ConsumptionLabel
            // 
            this.ConsumptionLabel.AutoSize = true;
            this.ConsumptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsumptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.ConsumptionLabel.Location = new System.Drawing.Point(13, 86);
            this.ConsumptionLabel.Name = "ConsumptionLabel";
            this.ConsumptionLabel.Size = new System.Drawing.Size(180, 16);
            this.ConsumptionLabel.TabIndex = 3;
            this.ConsumptionLabel.Text = "Расход литров / 100 км:";
            // 
            // LitersLabel
            // 
            this.LitersLabel.AutoSize = true;
            this.LitersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LitersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.LitersLabel.Location = new System.Drawing.Point(13, 20);
            this.LitersLabel.Name = "LitersLabel";
            this.LitersLabel.Size = new System.Drawing.Size(160, 16);
            this.LitersLabel.TabIndex = 1;
            this.LitersLabel.Text = "Заправлено литров:";
            // 
            // LitersTextBox
            // 
            this.LitersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LitersTextBox.Animated = true;
            this.LitersTextBox.BorderRadius = 8;
            this.LitersTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LitersTextBox.DefaultText = "";
            this.LitersTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LitersTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LitersTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LitersTextBox.DisabledState.Parent = this.LitersTextBox;
            this.LitersTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LitersTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LitersTextBox.FocusedState.Parent = this.LitersTextBox;
            this.LitersTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LitersTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LitersTextBox.HoverState.Parent = this.LitersTextBox;
            this.LitersTextBox.Location = new System.Drawing.Point(13, 39);
            this.LitersTextBox.Name = "LitersTextBox";
            this.LitersTextBox.PasswordChar = '\0';
            this.LitersTextBox.PlaceholderText = "";
            this.LitersTextBox.SelectedText = "";
            this.LitersTextBox.ShadowDecoration.Parent = this.LitersTextBox;
            this.LitersTextBox.Size = new System.Drawing.Size(212, 30);
            this.LitersTextBox.TabIndex = 0;
            this.LitersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LitersTextBox_KeyPress);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.TitleLabel.Location = new System.Drawing.Point(6, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(10);
            this.TitleLabel.Size = new System.Drawing.Size(242, 73);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Калькулятор расхода топлива";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BorderRadius = 10;
            this.CalculateButton.CheckedState.Parent = this.CalculateButton;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.CustomImages.Parent = this.CalculateButton;
            this.CalculateButton.FillColor = System.Drawing.Color.SeaGreen;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.HoverState.Parent = this.CalculateButton;
            this.CalculateButton.Location = new System.Drawing.Point(10, 314);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(10);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.ShadowDecoration.Parent = this.CalculateButton;
            this.CalculateButton.Size = new System.Drawing.Size(134, 42);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Подсчитать";
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomPanel.Controls.Add(this.TravelCostInfoLabel);
            this.BottomPanel.Controls.Add(this.DistanceInfoLabel);
            this.BottomPanel.Controls.Add(this.DistanceLabel);
            this.BottomPanel.Controls.Add(this.TravelCostLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.BottomPanel.Location = new System.Drawing.Point(0, 369);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.ShadowDecoration.Parent = this.BottomPanel;
            this.BottomPanel.Size = new System.Drawing.Size(258, 99);
            this.BottomPanel.TabIndex = 7;
            // 
            // TravelCostInfoLabel
            // 
            this.TravelCostInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelCostInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.TravelCostInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TravelCostInfoLabel.ForeColor = System.Drawing.Color.White;
            this.TravelCostInfoLabel.Location = new System.Drawing.Point(13, 44);
            this.TravelCostInfoLabel.Name = "TravelCostInfoLabel";
            this.TravelCostInfoLabel.Size = new System.Drawing.Size(127, 42);
            this.TravelCostInfoLabel.TabIndex = 11;
            this.TravelCostInfoLabel.Text = "Стоимость поездки:";
            this.TravelCostInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DistanceInfoLabel
            // 
            this.DistanceInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceInfoLabel.AutoSize = true;
            this.DistanceInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.DistanceInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceInfoLabel.ForeColor = System.Drawing.Color.White;
            this.DistanceInfoLabel.Location = new System.Drawing.Point(12, 16);
            this.DistanceInfoLabel.Name = "DistanceInfoLabel";
            this.DistanceInfoLabel.Size = new System.Drawing.Size(133, 16);
            this.DistanceInfoLabel.TabIndex = 10;
            this.DistanceInfoLabel.Text = "Можно проехать:";
            this.DistanceInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceLabel.AutoEllipsis = true;
            this.DistanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.ForeColor = System.Drawing.Color.White;
            this.DistanceLabel.Location = new System.Drawing.Point(146, 16);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(100, 16);
            this.DistanceLabel.TabIndex = 9;
            this.DistanceLabel.Text = "0 км";
            this.DistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TravelCostLabel
            // 
            this.TravelCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelCostLabel.AutoEllipsis = true;
            this.TravelCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.TravelCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TravelCostLabel.ForeColor = System.Drawing.Color.White;
            this.TravelCostLabel.Location = new System.Drawing.Point(146, 62);
            this.TravelCostLabel.Name = "TravelCostLabel";
            this.TravelCostLabel.Size = new System.Drawing.Size(100, 24);
            this.TravelCostLabel.TabIndex = 8;
            this.TravelCostLabel.Text = "0р.";
            this.TravelCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DragControl2
            // 
            this.DragControl2.ContainerControl = this;
            this.DragControl2.TargetControl = this.TitleLabel;
            // 
            // CLoseButton
            // 
            this.CLoseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CLoseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLoseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLoseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CLoseButton.Location = new System.Drawing.Point(227, -1);
            this.CLoseButton.Name = "CLoseButton";
            this.CLoseButton.Size = new System.Drawing.Size(31, 33);
            this.CLoseButton.TabIndex = 8;
            this.CLoseButton.Text = "x";
            this.CLoseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLoseButton.Click += new System.EventHandler(this.CLoseButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.BorderRadius = 10;
            this.HelpButton.CheckedState.Parent = this.HelpButton;
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.CustomImages.Parent = this.HelpButton;
            this.HelpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.HelpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.HoverState.Parent = this.HelpButton;
            this.HelpButton.Location = new System.Drawing.Point(149, 314);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(10);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.ShadowDecoration.Parent = this.HelpButton;
            this.HelpButton.Size = new System.Drawing.Size(99, 42);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Справка";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // DragControl3
            // 
            this.DragControl3.ContainerControl = this;
            this.DragControl3.TargetControl = this.HelpHoverPanel;
            // 
            // HelpHoverPanel
            // 
            this.HelpHoverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.HelpHoverPanel.Location = new System.Drawing.Point(0, -1);
            this.HelpHoverPanel.Name = "HelpHoverPanel";
            this.HelpHoverPanel.Padding = new System.Windows.Forms.Padding(20);
            this.HelpHoverPanel.Size = new System.Drawing.Size(258, 0);
            this.HelpHoverPanel.TabIndex = 10;
            this.HelpHoverPanel.BackColorChanged += new System.EventHandler(this.HelpHoverPanel_BackColorChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(258, 468);
            this.Controls.Add(this.HelpHoverPanel);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.CLoseButton);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseForm;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2Panel InputPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LitersLabel;
        private Guna.UI2.WinForms.Guna2TextBox LitersTextBox;
        private System.Windows.Forms.Label ConsumptionLabel;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private System.Windows.Forms.Label PriceLabel;
        private Guna.UI2.WinForms.Guna2Panel BottomPanel;
        private Guna.UI2.WinForms.Guna2Panel Line1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private System.Windows.Forms.Label TravelCostLabel;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private Guna.UI2.WinForms.Guna2Panel Line2;
        private Guna.UI2.WinForms.Guna2TextBox ConsumptionTextBox;
        private System.Windows.Forms.Label CLoseButton;
        private new Guna.UI2.WinForms.Guna2Button HelpButton;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private Controls.SettingsPage HelpHoverPanel;
        private System.Windows.Forms.Label DistanceInfoLabel;
        private System.Windows.Forms.Label TravelCostInfoLabel;
        private System.Windows.Forms.Label DistanceLabel;
    }
}

