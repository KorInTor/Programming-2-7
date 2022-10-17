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
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит обработчики событий пользовательского элемента управления
    /// SeasonHandleControl.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            var allSeasons = Enum.GetValues(typeof(Seasons));
            foreach (var season in allSeasons)
            {
                SeasonComboBox.Items.Add(season);
            }
        }

        private void GoBotton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                return;
            }

            switch (SeasonComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    BackColor = AppColors.WinterColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    BackColor = AppColors.SpringColor;
                    MessageBox.Show("Пора сажать урожай!");
                    break;
                case Seasons.Summer:
                    BackColor = AppColors.SummerColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    BackColor = AppColors.AutumnColor;
                    MessageBox.Show("Пора собирать урожай!");
                    break;
                default:
                    throw new NotImplementedException();
            }
            SeasonComboBox.SelectedItem = null;
        }
    }
}