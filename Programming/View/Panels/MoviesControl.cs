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

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит данные, методы работы с ними и обработчики событий
    /// пользовательского элемента управления MoviesControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        private void InitMovies()
        {
            Random random = new Random();

            _movies = new Movie[random.Next(3, 15)];
            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    $"Фильм {i + 1}",
                    random.Next(0, 180),
                    random.Next(1900, 2022),
                    $"Жанр {i + 1}", random.Next(0, 10));
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }

            MoviesListBox.SelectedIndex = 0;
        }

        public MoviesControl()
        {
            InitializeComponent();
            InitMovies();
        }

        /// <summary>
        /// Находит фильм с наивысшим рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Выбирает в MoviesListBox фильм с наивысшим рейтингом.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRating = 0;
            int indexMaxRating = 0;

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    indexMaxRating = i;
                }
            }

            return indexMaxRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];

            NameTextBox.Text = _currentMovie.Name.ToString();
            DurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Name = NameTextBox.Text;
                NameTextBox.BackColor = AppColors.DefaultColor;
                ToolTip.SetToolTip(NameTextBox, "");
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(NameTextBox, exception.Message);
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(DurationTextBox.Text, out int duration))
                {
                    DurationTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(DurationTextBox, "Неверное значение.");
                }
                else
                {
                    _currentMovie.DurationMinutes = duration;
                    DurationTextBox.BackColor = AppColors.DefaultColor;
                    ToolTip.SetToolTip(DurationTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(DurationTextBox, exception.Message);
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(YearTextBox.Text, out int year))
                {
                    YearTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(YearTextBox, "Неверное значение.");
                }
                else
                {
                    _currentMovie.Year = year;
                    YearTextBox.BackColor = AppColors.DefaultColor;
                    ToolTip.SetToolTip(YearTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(YearTextBox, exception.Message);
                YearTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = AppColors.DefaultColor;
                ToolTip.SetToolTip(GenreTextBox, "");
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(GenreTextBox, exception.Message);
                GenreTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(RatingTextBox.Text, out int rating))
                {
                    RatingTextBox.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(RatingTextBox, "Неверное значение.");
                }
                else
                {
                    _currentMovie.Rating = rating;
                    RatingTextBox.BackColor = AppColors.DefaultColor;
                    ToolTip.SetToolTip(RatingTextBox, "");
                }
            }
            catch (ArgumentException exception)
            {
                ToolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void MoviesFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);

            NameTextBox.Text = _currentMovie.Name.ToString();
            DurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }
    }
}