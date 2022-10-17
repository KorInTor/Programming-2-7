using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность фильма в минутах.
        /// </summary>
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Возвращает и задаёт год выпуска фильма.
        /// Должен быть не старше 1900 и не младше текущего года.
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть не меньше 0 и не больше 10.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма</param>
        /// <param name="durationMinutes">Длительность в минутах</param>
        /// <param name="year">Год выпуска</param>
        /// <param name="genre">Жанр</param>
        /// <param name="rating">Рейтинг</param>
        public Movie(string name,
                     int durationMinutes,
                     int year,
                     string genre,
                     int rating)
        {
            Name = name;
            DurationMinutes = durationMinutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }
    }
}