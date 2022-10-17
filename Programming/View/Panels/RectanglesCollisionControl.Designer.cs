
namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectanglesCollisionPanel = new System.Windows.Forms.Panel();
            this.SelectedRectangleXLabel = new System.Windows.Forms.Label();
            this.RectanglesCollisionDeleteButton = new System.Windows.Forms.Button();
            this.RectanglesCollisionAddButton = new System.Windows.Forms.Button();
            this.SelectedRectangleHeightLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleWidthLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleYLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleYTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleIdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleXTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesCollisionListBox = new System.Windows.Forms.ListBox();
            this.RectanglesCollisionLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RectanglesCollisionPanel
            // 
            this.RectanglesCollisionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesCollisionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesCollisionPanel.Location = new System.Drawing.Point(295, 16);
            this.RectanglesCollisionPanel.Name = "RectanglesCollisionPanel";
            this.RectanglesCollisionPanel.Size = new System.Drawing.Size(418, 464);
            this.RectanglesCollisionPanel.TabIndex = 51;
            // 
            // SelectedRectangleXLabel
            // 
            this.SelectedRectangleXLabel.AutoSize = true;
            this.SelectedRectangleXLabel.Location = new System.Drawing.Point(51, 300);
            this.SelectedRectangleXLabel.Name = "SelectedRectangleXLabel";
            this.SelectedRectangleXLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleXLabel.TabIndex = 50;
            this.SelectedRectangleXLabel.Text = "X:";
            // 
            // RectanglesCollisionDeleteButton
            // 
            this.RectanglesCollisionDeleteButton.FlatAppearance.BorderSize = 0;
            this.RectanglesCollisionDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectanglesCollisionDeleteButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RectanglesCollisionDeleteButton.Location = new System.Drawing.Point(104, 195);
            this.RectanglesCollisionDeleteButton.Name = "RectanglesCollisionDeleteButton";
            this.RectanglesCollisionDeleteButton.Size = new System.Drawing.Size(75, 30);
            this.RectanglesCollisionDeleteButton.TabIndex = 49;
            this.RectanglesCollisionDeleteButton.UseVisualStyleBackColor = true;
            this.RectanglesCollisionDeleteButton.Click += new System.EventHandler(this.RectanglesCollisionDeleteButton_Click);
            this.RectanglesCollisionDeleteButton.MouseEnter += new System.EventHandler(this.RectanglesCollisionDeleteButton_MouseEnter);
            this.RectanglesCollisionDeleteButton.MouseLeave += new System.EventHandler(this.RectanglesCollisionDeleteButton_MouseLeave);
            // 
            // RectanglesCollisionAddButton
            // 
            this.RectanglesCollisionAddButton.FlatAppearance.BorderSize = 0;
            this.RectanglesCollisionAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectanglesCollisionAddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.RectanglesCollisionAddButton.Location = new System.Drawing.Point(23, 195);
            this.RectanglesCollisionAddButton.Name = "RectanglesCollisionAddButton";
            this.RectanglesCollisionAddButton.Size = new System.Drawing.Size(75, 30);
            this.RectanglesCollisionAddButton.TabIndex = 48;
            this.RectanglesCollisionAddButton.UseVisualStyleBackColor = true;
            this.RectanglesCollisionAddButton.Click += new System.EventHandler(this.RectanglesCollisionAddButton_Click);
            this.RectanglesCollisionAddButton.MouseEnter += new System.EventHandler(this.RectanglesCollisionAddButton_MouseEnter);
            this.RectanglesCollisionAddButton.MouseLeave += new System.EventHandler(this.RectanglesCollisionAddButton_MouseLeave);
            // 
            // SelectedRectangleHeightLabel
            // 
            this.SelectedRectangleHeightLabel.AutoSize = true;
            this.SelectedRectangleHeightLabel.Location = new System.Drawing.Point(20, 378);
            this.SelectedRectangleHeightLabel.Name = "SelectedRectangleHeightLabel";
            this.SelectedRectangleHeightLabel.Size = new System.Drawing.Size(48, 13);
            this.SelectedRectangleHeightLabel.TabIndex = 47;
            this.SelectedRectangleHeightLabel.Text = "Высота:";
            // 
            // SelectedRectangleHeightTextBox
            // 
            this.SelectedRectangleHeightTextBox.Location = new System.Drawing.Point(70, 375);
            this.SelectedRectangleHeightTextBox.Name = "SelectedRectangleHeightTextBox";
            this.SelectedRectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleHeightTextBox.TabIndex = 46;
            this.SelectedRectangleHeightTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleHeightTextBox_TextChanged);
            // 
            // SelectedRectangleWidthLabel
            // 
            this.SelectedRectangleWidthLabel.AutoSize = true;
            this.SelectedRectangleWidthLabel.Location = new System.Drawing.Point(19, 352);
            this.SelectedRectangleWidthLabel.Name = "SelectedRectangleWidthLabel";
            this.SelectedRectangleWidthLabel.Size = new System.Drawing.Size(49, 13);
            this.SelectedRectangleWidthLabel.TabIndex = 45;
            this.SelectedRectangleWidthLabel.Text = "Ширина:";
            // 
            // SelectedRectangleWidthTextBox
            // 
            this.SelectedRectangleWidthTextBox.Location = new System.Drawing.Point(70, 349);
            this.SelectedRectangleWidthTextBox.Name = "SelectedRectangleWidthTextBox";
            this.SelectedRectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleWidthTextBox.TabIndex = 44;
            this.SelectedRectangleWidthTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleWidthTextBox_TextChanged);
            // 
            // SelectedRectangleYLabel
            // 
            this.SelectedRectangleYLabel.AutoSize = true;
            this.SelectedRectangleYLabel.Location = new System.Drawing.Point(51, 326);
            this.SelectedRectangleYLabel.Name = "SelectedRectangleYLabel";
            this.SelectedRectangleYLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleYLabel.TabIndex = 43;
            this.SelectedRectangleYLabel.Text = "Y:";
            // 
            // SelectedRectangleYTextBox
            // 
            this.SelectedRectangleYTextBox.Location = new System.Drawing.Point(70, 323);
            this.SelectedRectangleYTextBox.Name = "SelectedRectangleYTextBox";
            this.SelectedRectangleYTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleYTextBox.TabIndex = 42;
            this.SelectedRectangleYTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleYTextBox_TextChanged);
            // 
            // SelectedRectangleIdLabel
            // 
            this.SelectedRectangleIdLabel.AutoSize = true;
            this.SelectedRectangleIdLabel.Location = new System.Drawing.Point(20, 274);
            this.SelectedRectangleIdLabel.Name = "SelectedRectangleIdLabel";
            this.SelectedRectangleIdLabel.Size = new System.Drawing.Size(48, 13);
            this.SelectedRectangleIdLabel.TabIndex = 41;
            this.SelectedRectangleIdLabel.Text = "Индекс:";
            // 
            // SelectedRectangleXTextBox
            // 
            this.SelectedRectangleXTextBox.Location = new System.Drawing.Point(70, 297);
            this.SelectedRectangleXTextBox.Name = "SelectedRectangleXTextBox";
            this.SelectedRectangleXTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleXTextBox.TabIndex = 40;
            this.SelectedRectangleXTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleXTextBox_TextChanged);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(17, 242);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(150, 13);
            this.SelectedRectangleLabel.TabIndex = 39;
            this.SelectedRectangleLabel.Text = "Выбранный прямоугольник:";
            // 
            // SelectedRectangleIdTextBox
            // 
            this.SelectedRectangleIdTextBox.Location = new System.Drawing.Point(70, 271);
            this.SelectedRectangleIdTextBox.Name = "SelectedRectangleIdTextBox";
            this.SelectedRectangleIdTextBox.ReadOnly = true;
            this.SelectedRectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleIdTextBox.TabIndex = 38;
            // 
            // RectanglesCollisionListBox
            // 
            this.RectanglesCollisionListBox.FormattingEnabled = true;
            this.RectanglesCollisionListBox.Location = new System.Drawing.Point(20, 31);
            this.RectanglesCollisionListBox.Name = "RectanglesCollisionListBox";
            this.RectanglesCollisionListBox.Size = new System.Drawing.Size(250, 147);
            this.RectanglesCollisionListBox.TabIndex = 37;
            this.RectanglesCollisionListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesCollisionListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionLabel
            // 
            this.RectanglesCollisionLabel.AutoSize = true;
            this.RectanglesCollisionLabel.Location = new System.Drawing.Point(17, 15);
            this.RectanglesCollisionLabel.Name = "RectanglesCollisionLabel";
            this.RectanglesCollisionLabel.Size = new System.Drawing.Size(96, 13);
            this.RectanglesCollisionLabel.TabIndex = 36;
            this.RectanglesCollisionLabel.Text = "Прямоугольники:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesCollisionPanel);
            this.Controls.Add(this.SelectedRectangleXLabel);
            this.Controls.Add(this.RectanglesCollisionDeleteButton);
            this.Controls.Add(this.RectanglesCollisionAddButton);
            this.Controls.Add(this.SelectedRectangleHeightLabel);
            this.Controls.Add(this.SelectedRectangleHeightTextBox);
            this.Controls.Add(this.SelectedRectangleWidthLabel);
            this.Controls.Add(this.SelectedRectangleWidthTextBox);
            this.Controls.Add(this.SelectedRectangleYLabel);
            this.Controls.Add(this.SelectedRectangleYTextBox);
            this.Controls.Add(this.SelectedRectangleIdLabel);
            this.Controls.Add(this.SelectedRectangleXTextBox);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.SelectedRectangleIdTextBox);
            this.Controls.Add(this.RectanglesCollisionListBox);
            this.Controls.Add(this.RectanglesCollisionLabel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(731, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RectanglesCollisionPanel;
        private System.Windows.Forms.Label SelectedRectangleXLabel;
        private System.Windows.Forms.Button RectanglesCollisionDeleteButton;
        private System.Windows.Forms.Button RectanglesCollisionAddButton;
        private System.Windows.Forms.Label SelectedRectangleHeightLabel;
        private System.Windows.Forms.TextBox SelectedRectangleHeightTextBox;
        private System.Windows.Forms.Label SelectedRectangleWidthLabel;
        private System.Windows.Forms.TextBox SelectedRectangleWidthTextBox;
        private System.Windows.Forms.Label SelectedRectangleYLabel;
        private System.Windows.Forms.TextBox SelectedRectangleYTextBox;
        private System.Windows.Forms.Label SelectedRectangleIdLabel;
        private System.Windows.Forms.TextBox SelectedRectangleXTextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.TextBox SelectedRectangleIdTextBox;
        private System.Windows.Forms.ListBox RectanglesCollisionListBox;
        private System.Windows.Forms.Label RectanglesCollisionLabel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
