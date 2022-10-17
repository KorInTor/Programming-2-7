
namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.WeekdayAnswerLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WeekdayAnswerLabel
            // 
            this.WeekdayAnswerLabel.AutoSize = true;
            this.WeekdayAnswerLabel.Location = new System.Drawing.Point(36, 77);
            this.WeekdayAnswerLabel.Name = "WeekdayAnswerLabel";
            this.WeekdayAnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.WeekdayAnswerLabel.TabIndex = 7;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(248, 44);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(70, 21);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Обработка";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(36, 29);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(188, 13);
            this.WeekdayLabel.TabIndex = 5;
            this.WeekdayLabel.Text = "Напишите значение для обработки:";
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(39, 45);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(185, 20);
            this.ParseTextBox.TabIndex = 4;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayAnswerLabel);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.WeekdayLabel);
            this.Controls.Add(this.ParseTextBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(342, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekdayAnswerLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.TextBox ParseTextBox;
    }
}
