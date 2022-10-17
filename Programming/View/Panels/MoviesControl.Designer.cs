
namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.MoviesFindButton = new System.Windows.Forms.Button();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(181, 188);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(51, 13);
            this.RatingLabel.TabIndex = 34;
            this.RatingLabel.Text = "Рейтинг:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(181, 206);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(148, 20);
            this.RatingTextBox.TabIndex = 33;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(181, 147);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 32;
            this.GenreLabel.Text = "Жанр:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(181, 165);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(148, 20);
            this.GenreTextBox.TabIndex = 31;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // MoviesFindButton
            // 
            this.MoviesFindButton.Location = new System.Drawing.Point(181, 408);
            this.MoviesFindButton.Name = "MoviesFindButton";
            this.MoviesFindButton.Size = new System.Drawing.Size(148, 28);
            this.MoviesFindButton.TabIndex = 30;
            this.MoviesFindButton.Text = "Найти";
            this.MoviesFindButton.UseVisualStyleBackColor = true;
            this.MoviesFindButton.Click += new System.EventHandler(this.MoviesFindButton_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(181, 106);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(28, 13);
            this.YearLabel.TabIndex = 29;
            this.YearLabel.Text = "Год:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(181, 124);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(148, 20);
            this.YearTextBox.TabIndex = 28;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(181, 65);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(83, 13);
            this.DurationLabel.TabIndex = 27;
            this.DurationLabel.Text = "Длительность:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(181, 83);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(148, 20);
            this.DurationTextBox.TabIndex = 26;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Location = new System.Drawing.Point(14, 24);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(97, 13);
            this.MoviesLabel.TabIndex = 25;
            this.MoviesLabel.Text = "Выберите фильм:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(181, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 13);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Название:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(181, 42);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 20);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(17, 42);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(148, 394);
            this.MoviesListBox.TabIndex = 22;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.MoviesFindButton);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(342, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Button MoviesFindButton;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
