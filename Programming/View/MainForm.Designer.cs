
namespace Programming.View
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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleControl = new Programming.View.Panels.SeasonHandleControl();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingControl = new Programming.View.Panels.WeekdayParsingControl();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsControl = new Programming.View.Panels.EnumerationsControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesControl = new Programming.View.Panels.MoviesControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesControl = new Programming.View.Panels.RectanglesControl();
            this.RectanglesCollisionTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesCollisionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(731, 494);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Перечисления";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonHandleControl);
            this.SeasonGroupBox.Location = new System.Drawing.Point(376, 356);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(342, 119);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Обработка времени года";
            // 
            // SeasonHandleControl
            // 
            this.SeasonHandleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleControl.Location = new System.Drawing.Point(-6, 0);
            this.SeasonHandleControl.Name = "SeasonHandleControl";
            this.SeasonHandleControl.Size = new System.Drawing.Size(342, 119);
            this.SeasonHandleControl.TabIndex = 0;
            this.SeasonHandleControl.Load += new System.EventHandler(this.SeasonHandleControl_Load);
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayGroupBox.Controls.Add(this.WeekdayParsingControl);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(14, 356);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(342, 119);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Обработка дня недели";
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingControl.Location = new System.Drawing.Point(0, 13);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(342, 119);
            this.WeekdayParsingControl.TabIndex = 0;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumsGroupBox.Controls.Add(this.EnumerationsControl);
            this.EnumsGroupBox.Location = new System.Drawing.Point(14, 14);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(704, 318);
            this.EnumsGroupBox.TabIndex = 6;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Перечисления";
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsControl.Location = new System.Drawing.Point(0, 0);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(704, 318);
            this.EnumerationsControl.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesCollisionTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(739, 520);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(731, 494);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Классы";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGroupBox.Controls.Add(this.MoviesControl);
            this.MoviesGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MoviesGroupBox.Location = new System.Drawing.Point(376, 14);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(342, 461);
            this.MoviesGroupBox.TabIndex = 8;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Фильмы";
            // 
            // MoviesControl
            // 
            this.MoviesControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesControl.Location = new System.Drawing.Point(0, 0);
            this.MoviesControl.Name = "MoviesControl";
            this.MoviesControl.Size = new System.Drawing.Size(342, 461);
            this.MoviesControl.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesGroupBox.Controls.Add(this.RectanglesControl);
            this.RectanglesGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(14, 14);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(342, 461);
            this.RectanglesGroupBox.TabIndex = 7;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Прямоугольники";
            // 
            // RectanglesControl
            // 
            this.RectanglesControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesControl.Location = new System.Drawing.Point(0, 0);
            this.RectanglesControl.Name = "RectanglesControl";
            this.RectanglesControl.Size = new System.Drawing.Size(342, 461);
            this.RectanglesControl.TabIndex = 0;
            // 
            // RectanglesCollisionTabPage
            // 
            this.RectanglesCollisionTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesCollisionTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesCollisionTabPage.Name = "RectanglesCollisionTabPage";
            this.RectanglesCollisionTabPage.Size = new System.Drawing.Size(731, 494);
            this.RectanglesCollisionTabPage.TabIndex = 0;
            this.RectanglesCollisionTabPage.Text = "Прямоугольники";
            this.RectanglesCollisionTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, -1);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(731, 494);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 520);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesCollisionTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabPage RectanglesCollisionTabPage;
        private Panels.RectanglesCollisionControl RectanglesCollisionControl;
        private Panels.RectanglesControl RectanglesControl;
        private Panels.MoviesControl MoviesControl;
        private Panels.EnumerationsControl EnumerationsControl;
        private Panels.WeekdayParsingControl WeekdayParsingControl;
        private Panels.SeasonHandleControl SeasonHandleControl;
    }
}

