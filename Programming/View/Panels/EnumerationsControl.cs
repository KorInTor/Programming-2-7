using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит обработчики событий пользовательского элемента управления
    /// EnumerationsControl.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string enums = EnumsListBox.SelectedItem.ToString();
            Array values = null;
            ValuesListBox.Items.Clear();

            switch (enums)
            {
                case "Color":
                    values = Enum.GetValues(typeof(Model.Enums.Colors));
                    break;
                case "EducationForm":
                    values = Enum.GetValues(typeof(Model.Enums.EducationForms));
                    break;
                case "Genre":
                    values = Enum.GetValues(typeof(Model.Enums.Genres));
                    break;
                case "Manufacture":
                    values = Enum.GetValues(typeof(Model.Enums.Manufactures));
                    break;
                case "Season":
                    values = Enum.GetValues(typeof(Model.Enums.Seasons));
                    break;
                case "Weekday":
                    values = Enum.GetValues(typeof(Model.Enums.Weekdays));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}