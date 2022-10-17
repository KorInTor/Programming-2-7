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
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит данные, методы работы с ними и обработчики событий
    /// пользовательского элемента управления RectanglesCollisionControl.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
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
        /// Список панелей.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Инициализирует список прямоугольников и список панелей.
        /// </summary>
        private void InitRectanglesAndPanels()
        {
            Random random = new Random();

            _rectangles = new List<Rectangle>();
            for (int i = 0; i < random.Next(3, 15); i++)
            {
                var newRectangle = RectangleFactory.Randomize
                    (RectanglesCollisionPanel.Width, RectanglesCollisionPanel.Height);
                _rectangles.Add(newRectangle);
                AddRectangleToListBox(newRectangle);
                AddPanelToListBox(newRectangle);
            }

            FindCollisions();
            RectanglesCollisionListBox.SelectedIndex = 0;
        }

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitRectanglesAndPanels();
        }

        /// <summary>
        /// Выполняет проверку коллизии прямоугольников.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.RectangleColor;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i != j)
                    {
                        if (_rectanglePanels[j].BackColor == AppColors.RectangleColor)
                        {
                            if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                            {
                                _rectanglePanels[i].BackColor = AppColors.CollisionColor;
                                _rectanglePanels[j].BackColor = AppColors.CollisionColor;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет данные выбранного прямоугольника.
        /// </summary>
        /// <param name="rectangle">Экземпляр класса Rectangle.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            SelectedRectangleIdTextBox.Text = rectangle.Id.ToString();
            SelectedRectangleXTextBox.Text = rectangle.Center.X.ToString();
            SelectedRectangleYTextBox.Text = rectangle.Center.Y.ToString();
            SelectedRectangleWidthTextBox.Text = rectangle.Width.ToString();
            SelectedRectangleHeightTextBox.Text = rectangle.Length.ToString();
        }

        /// <summary>
        /// Очищает значение всех текстовые поля в RectanglesCollisionControl.
        /// </summary>
        private void ClearRectangleInfo()
        {
            SelectedRectangleIdTextBox.Clear();
            SelectedRectangleXTextBox.Clear();
            SelectedRectangleYTextBox.Clear();
            SelectedRectangleWidthTextBox.Clear();
            SelectedRectangleHeightTextBox.Clear();

            SelectedRectangleIdTextBox.BackColor = AppColors.DefaultColor;
            SelectedRectangleXTextBox.BackColor = AppColors.DefaultColor;
            SelectedRectangleYTextBox.BackColor = AppColors.DefaultColor;
            SelectedRectangleWidthTextBox.BackColor = AppColors.DefaultColor;
            SelectedRectangleHeightTextBox.BackColor = AppColors.DefaultColor;
        }

        private string RectangleListBoxItemText(Rectangle rectangle)
        {
            string text = $"{rectangle.Id + 1}: (X={rectangle.Center.X}; " +
               $"Y={rectangle.Center.Y}; Ш={rectangle.Width}; " +
               $"В={rectangle.Length})";

            return text;
        }

        /// <summary>
        /// Обновляет данные в RectanglesCollisionListBox.
        /// </summary>
        private void UpdateRectangleListBoxInfo(Rectangle rectangle)
        {
            RectanglesCollisionListBox.Items[RectanglesCollisionListBox.SelectedIndex] =
                RectangleListBoxItemText(_currentRectangle);
        }

        /// <summary>
        /// Добавляет экземпляр класса Rectangle в RectanglesCollisionListBox.
        /// </summary>
        private void AddRectangleToListBox(Rectangle rectangle)
        {
            RectanglesCollisionListBox.Items.Add(RectangleListBoxItemText(rectangle));
        }

        /// <summary>
        /// Добавляет экземпляр класса Panel в RectanglesCollisionPanel.
        /// </summary>
        private void AddPanelToListBox(Rectangle newRectangle)
        {
            var newPanel = new Panel();
            newPanel.Location = new Point((int)newRectangle.Center.X,
                (int)newRectangle.Center.Y);
            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Length;
            newPanel.BackColor = AppColors.RectangleColor;
            RectanglesCollisionPanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
        }

        private void RectanglesCollisionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesCollisionListBox.SelectedIndex == -1)
            {
                ClearRectangleInfo();
                return;
            }
            if (RectanglesCollisionListBox.Items.Count > 0)
            {
                _currentRectangle = _rectangles[RectanglesCollisionListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        private void RectanglesCollisionAddButton_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize
                (RectanglesCollisionPanel.Width,RectanglesCollisionPanel.Height);
            _rectangles.Add(newRectangle);
            AddRectangleToListBox(newRectangle);
            AddPanelToListBox(newRectangle);
            FindCollisions();
        }

        private void RectanglesCollisionDeleteButton_Click(object sender, EventArgs e)
        {
            int index = RectanglesCollisionListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            if (RectanglesCollisionListBox.Items.Count == 0)
            {
                return;
            }

            _rectangles.RemoveAt(index);
            _rectanglePanels.RemoveAt(index);
            RectanglesCollisionPanel.Controls.RemoveAt(index);
            RectanglesCollisionListBox.Items.RemoveAt(index);

            FindCollisions();

            if (RectanglesCollisionListBox.Items.Count == 0)
            {
                return;
            }
            else
            {
                RectanglesCollisionListBox.SelectedIndex = 0;
            }
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(SelectedRectangleXTextBox.Text, out double x))
                {
                    SelectedRectangleXTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(SelectedRectangleXTextBox, "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Center.X = x;
                    SelectedRectangleXTextBox.BackColor = AppColors.DefaultColor;

                    UpdateRectangleListBoxInfo(_currentRectangle);
                    var currentPanel = _rectanglePanels
                        [RectanglesCollisionListBox.SelectedIndex];
                    currentPanel.Location = new Point((int)_currentRectangle.Center.X,
                        (int)_currentRectangle.Center.Y);

                    FindCollisions();

                    ToolTip.SetToolTip(SelectedRectangleXTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(SelectedRectangleXTextBox, exception.Message);
                SelectedRectangleXTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void SelectedRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(SelectedRectangleYTextBox.Text, out double y))
                {
                    SelectedRectangleYTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(SelectedRectangleYTextBox, "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Center.Y = y;
                    SelectedRectangleYTextBox.BackColor = AppColors.DefaultColor;

                    UpdateRectangleListBoxInfo(_currentRectangle);
                    var currentPanel = _rectanglePanels
                        [RectanglesCollisionListBox.SelectedIndex];
                    currentPanel.Location = new Point((int)_currentRectangle.Center.X,
                        (int)_currentRectangle.Center.Y);

                    FindCollisions();

                    ToolTip.SetToolTip(SelectedRectangleYTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(SelectedRectangleYTextBox, exception.Message);
                SelectedRectangleYTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void SelectedRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(SelectedRectangleWidthTextBox.Text, out double width))
                {
                    SelectedRectangleWidthTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(SelectedRectangleWidthTextBox, "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Width = width;
                    SelectedRectangleWidthTextBox.BackColor = AppColors.DefaultColor;

                    UpdateRectangleListBoxInfo(_currentRectangle);
                    var currentPanel = _rectanglePanels
                        [RectanglesCollisionListBox.SelectedIndex];
                    currentPanel.Width = (int)_currentRectangle.Width;

                    FindCollisions();

                    ToolTip.SetToolTip(SelectedRectangleWidthTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(SelectedRectangleWidthTextBox, exception.Message);
                SelectedRectangleWidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void SelectedRectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(SelectedRectangleHeightTextBox.Text, out double length))
                {
                    SelectedRectangleHeightTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(SelectedRectangleHeightTextBox,
                        "Неверное значение.");
                }
                else
                {
                    _currentRectangle.Length = length;
                    SelectedRectangleHeightTextBox.BackColor = AppColors.DefaultColor;

                    UpdateRectangleListBoxInfo(_currentRectangle);
                    var currentPanel = _rectanglePanels
                        [RectanglesCollisionListBox.SelectedIndex];
                    currentPanel.Height = (int)_currentRectangle.Length;

                    FindCollisions();

                    ToolTip.SetToolTip(SelectedRectangleHeightTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(SelectedRectangleHeightTextBox, exception.Message);
                SelectedRectangleHeightTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RectanglesCollisionAddButton_MouseEnter(object sender, EventArgs e)
        {
            RectanglesCollisionAddButton.Image = Properties.Resources.
                rectangle_add_24x24;
        }

        private void RectanglesCollisionAddButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesCollisionAddButton.Image = Properties.Resources.
                rectangle_add_24x24_uncolor;
        }

        private void RectanglesCollisionDeleteButton_MouseEnter(object sender, EventArgs e)
        {
            RectanglesCollisionDeleteButton.Image = Properties.Resources.
                rectangle_remove_24x24;
        }

        private void RectanglesCollisionDeleteButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesCollisionDeleteButton.Image = Properties.Resources.
                rectangle_remove_24x24_uncolor;
        }
    }
}