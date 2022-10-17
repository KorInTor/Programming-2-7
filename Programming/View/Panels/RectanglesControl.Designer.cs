
namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.components = new System.ComponentModel.Container();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.YcenterLabel = new System.Windows.Forms.Label();
            this.YcenterTextBox = new System.Windows.Forms.TextBox();
            this.XcenterLabel = new System.Windows.Forms.Label();
            this.XcenterTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(181, 229);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(48, 13);
            this.IdLabel.TabIndex = 42;
            this.IdLabel.Text = "Индекс:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(181, 245);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(148, 20);
            this.IdTextBox.TabIndex = 41;
            // 
            // YcenterLabel
            // 
            this.YcenterLabel.AutoSize = true;
            this.YcenterLabel.Location = new System.Drawing.Point(181, 188);
            this.YcenterLabel.Name = "YcenterLabel";
            this.YcenterLabel.Size = new System.Drawing.Size(54, 13);
            this.YcenterLabel.TabIndex = 40;
            this.YcenterLabel.Text = "Центр(Y):";
            // 
            // YcenterTextBox
            // 
            this.YcenterTextBox.Location = new System.Drawing.Point(181, 206);
            this.YcenterTextBox.Name = "YcenterTextBox";
            this.YcenterTextBox.ReadOnly = true;
            this.YcenterTextBox.Size = new System.Drawing.Size(148, 20);
            this.YcenterTextBox.TabIndex = 39;
            // 
            // XcenterLabel
            // 
            this.XcenterLabel.AutoSize = true;
            this.XcenterLabel.Location = new System.Drawing.Point(181, 147);
            this.XcenterLabel.Name = "XcenterLabel";
            this.XcenterLabel.Size = new System.Drawing.Size(54, 13);
            this.XcenterLabel.TabIndex = 38;
            this.XcenterLabel.Text = "Центр(X):";
            // 
            // XcenterTextBox
            // 
            this.XcenterTextBox.Location = new System.Drawing.Point(181, 165);
            this.XcenterTextBox.Name = "XcenterTextBox";
            this.XcenterTextBox.ReadOnly = true;
            this.XcenterTextBox.Size = new System.Drawing.Size(148, 20);
            this.XcenterTextBox.TabIndex = 37;
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(181, 408);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(148, 28);
            this.RectanglesFindButton.TabIndex = 36;
            this.RectanglesFindButton.Text = "Найти";
            this.RectanglesFindButton.UseVisualStyleBackColor = true;
            this.RectanglesFindButton.Click += new System.EventHandler(this.RectanglesFindButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(181, 106);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(35, 13);
            this.ColorLabel.TabIndex = 35;
            this.ColorLabel.Text = "Цвет:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(181, 124);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(148, 20);
            this.ColorTextBox.TabIndex = 34;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(178, 65);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(49, 13);
            this.WidthLabel.TabIndex = 33;
            this.WidthLabel.Text = "Ширина:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(181, 83);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(148, 20);
            this.WidthTextBox.TabIndex = 32;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(14, 24);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(141, 13);
            this.RectanglesLabel.TabIndex = 31;
            this.RectanglesLabel.Text = "Выберите прямоугольник:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(178, 24);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 30;
            this.LengthLabel.Text = "Длина:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(181, 42);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(148, 20);
            this.LengthTextBox.TabIndex = 29;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(17, 42);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(148, 394);
            this.RectanglesListBox.TabIndex = 28;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.YcenterLabel);
            this.Controls.Add(this.YcenterTextBox);
            this.Controls.Add(this.XcenterLabel);
            this.Controls.Add(this.XcenterTextBox);
            this.Controls.Add(this.RectanglesFindButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(342, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label YcenterLabel;
        private System.Windows.Forms.TextBox YcenterTextBox;
        private System.Windows.Forms.Label XcenterLabel;
        private System.Windows.Forms.TextBox XcenterTextBox;
        private System.Windows.Forms.Button RectanglesFindButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
