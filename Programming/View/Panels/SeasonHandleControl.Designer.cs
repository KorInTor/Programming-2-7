
namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            this.GoBotton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GoBotton
            // 
            this.GoBotton.Location = new System.Drawing.Point(262, 56);
            this.GoBotton.Name = "GoBotton";
            this.GoBotton.Size = new System.Drawing.Size(56, 22);
            this.GoBotton.TabIndex = 5;
            this.GoBotton.Text = "Вперёд!";
            this.GoBotton.UseVisualStyleBackColor = true;
            this.GoBotton.Click += new System.EventHandler(this.GoBotton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(34, 41);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(121, 13);
            this.SeasonLabel.TabIndex = 4;
            this.SeasonLabel.Text = "Выберите время года:";
            this.SeasonLabel.Click += new System.EventHandler(this.GoBotton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(37, 57);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(201, 21);
            this.SeasonComboBox.TabIndex = 3;
            this.SeasonComboBox.Click += new System.EventHandler(this.GoBotton_Click);
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoBotton);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonComboBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(342, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBotton;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}
