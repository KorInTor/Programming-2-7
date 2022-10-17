using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит данные, методы работы с ними и обработчики событий
    /// пользовательского элемента управления RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Инициализирует список прямоугольников.
        /// </summary>
        private void InitRectangles()
        {
            Random random = new Random();

            _rectangles = new List<Rectangle>();
            for (int i = 0; i < random.Next(3, 15); i++)
            {
                var newRectangle = new Rectangle(
                    random.Next(50, 100),
                    random.Next(50, 100),
                    $"Цвет {random.Next(1, 100)}",
                    random.Next(15, 300),
                    random.Next(15, 300));
                _rectangles.Add(newRectangle);
                RectanglesListBox.Items.Add($"Rectangle {newRectangle.Id + 1}");
            }

            RectanglesListBox.SelectedIndex = 0;
        }

        public RectanglesControl()
        {
            InitializeComponent();
            InitRectangles();
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            double maxWidth = 0;
            int indexMaxWidth = 0;

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }

            return indexMaxWidth;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.Items.Count != 0)
            {
                if (RectanglesListBox.SelectedIndex == -1)
                {
                    RectanglesListBox.SelectedIndex = 0;
                }
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color.ToString();
                XcenterTextBox.Text = _currentRectangle.Center.X.ToString();
                YcenterTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(LengthTextBox.Text, out double length))
                {
                    LengthTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(LengthTextBox, "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Length = length;
                    LengthTextBox.BackColor = AppColors.DefaultColor;
                    ToolTip.SetToolTip(LengthTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = LengthTextBox.BackColor =
                    AppColors.ErrorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(WidthTextBox.Text, out double width))
                {
                    WidthTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(WidthTextBox, "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Width = width;
                    WidthTextBox.BackColor = AppColors.DefaultColor;
                    ToolTip.SetToolTip(WidthTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = AppColors.DefaultColor;
                ToolTip.SetToolTip(ColorTextBox, "");
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(ColorTextBox, exception.Message);
                ColorTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XcenterTextBox.Text = _currentRectangle.Center.X.ToString();
            YcenterTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }
    }
}