using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит обработчики событий пользовательского элемента управления
    /// WeekdayParsingControl.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(ParseTextBox.Text, out Model.Enums.Weekdays weekday))
            {
                WeekdayAnswerLabel.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                WeekdayAnswerLabel.Text = "Нет такого дня недели";
            }
        }
    }
}