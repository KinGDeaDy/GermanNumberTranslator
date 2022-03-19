namespace GermanNumberTranslator
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hideButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.translateButton = new Guna.UI2.WinForms.Guna2Button();
            this.translateRoman = new Guna.UI2.WinForms.Guna2Button();
            this.debugBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(12, 74);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(657, 62);
            this.inputBox.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.hideButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowDecoration.BorderRadius = 10;
            this.topPanel.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.topPanel.ShadowDecoration.Depth = 50;
            this.topPanel.ShadowDecoration.Parent = this.topPanel;
            this.topPanel.Size = new System.Drawing.Size(681, 40);
            this.topPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Немецкий транслятор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideButton
            // 
            this.hideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.CheckedState.Parent = this.hideButton;
            this.hideButton.HoverState.Image = global::GermanNumberTranslator.Properties.Resources.minus_active;
            this.hideButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.HoverState.Parent = this.hideButton;
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.hideButton.ImageRotate = 0F;
            this.hideButton.Location = new System.Drawing.Point(619, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.PressedState.Parent = this.hideButton;
            this.hideButton.ShadowDecoration.Parent = this.hideButton;
            this.hideButton.Size = new System.Drawing.Size(16, 16);
            this.hideButton.TabIndex = 2;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.HoverState.Image = global::GermanNumberTranslator.Properties.Resources.cancel_active;
            this.closeButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeButton.ImageRotate = 0F;
            this.closeButton.Location = new System.Drawing.Point(653, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.PressedState.Parent = this.closeButton;
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.TabIndex = 3;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.Animated = true;
            this.translateButton.BorderRadius = 15;
            this.translateButton.CheckedState.Parent = this.translateButton;
            this.translateButton.CustomImages.Parent = this.translateButton;
            this.translateButton.DisabledState.Parent = this.translateButton;
            this.translateButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateButton.ForeColor = System.Drawing.Color.White;
            this.translateButton.HoverState.Parent = this.translateButton;
            this.translateButton.Location = new System.Drawing.Point(339, 149);
            this.translateButton.Name = "translateButton";
            this.translateButton.ShadowDecoration.Parent = this.translateButton;
            this.translateButton.Size = new System.Drawing.Size(330, 48);
            this.translateButton.TabIndex = 10;
            this.translateButton.Text = "Arabian";
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // translateRoman
            // 
            this.translateRoman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.translateRoman.Animated = true;
            this.translateRoman.BorderRadius = 15;
            this.translateRoman.CheckedState.Parent = this.translateRoman;
            this.translateRoman.CustomImages.Parent = this.translateRoman;
            this.translateRoman.DisabledState.Parent = this.translateRoman;
            this.translateRoman.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateRoman.ForeColor = System.Drawing.Color.White;
            this.translateRoman.HoverState.Parent = this.translateRoman;
            this.translateRoman.Location = new System.Drawing.Point(339, 203);
            this.translateRoman.Name = "translateRoman";
            this.translateRoman.ShadowDecoration.Parent = this.translateRoman;
            this.translateRoman.Size = new System.Drawing.Size(330, 48);
            this.translateRoman.TabIndex = 11;
            this.translateRoman.Text = "Roman";
            this.translateRoman.Click += new System.EventHandler(this.translateRoman_Click);
            // 
            // debugBox
            // 
            this.debugBox.Animated = true;
            this.debugBox.BorderRadius = 20;
            this.debugBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.debugBox.DefaultText = "";
            this.debugBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.debugBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.debugBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.debugBox.DisabledState.Parent = this.debugBox;
            this.debugBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.debugBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.debugBox.FocusedState.Parent = this.debugBox;
            this.debugBox.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugBox.ForeColor = System.Drawing.Color.Black;
            this.debugBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.debugBox.HoverState.Parent = this.debugBox;
            this.debugBox.Location = new System.Drawing.Point(12, 149);
            this.debugBox.Margin = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.debugBox.Name = "debugBox";
            this.debugBox.PasswordChar = '\0';
            this.debugBox.PlaceholderText = "";
            this.debugBox.ReadOnly = true;
            this.debugBox.SelectedText = "";
            this.debugBox.ShadowDecoration.Parent = this.debugBox;
            this.debugBox.Size = new System.Drawing.Size(303, 102);
            this.debugBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(681, 269);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.translateRoman);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton hideButton;
        private Guna.UI2.WinForms.Guna2ImageButton closeButton;
        private Guna.UI2.WinForms.Guna2Button translateRoman;
        private Guna.UI2.WinForms.Guna2Button translateButton;
        private Guna.UI2.WinForms.Guna2TextBox debugBox;
    }
}

