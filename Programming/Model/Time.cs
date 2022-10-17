using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт часы. Должны быть не меньше 0 и не больше 59.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Часы");
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт минуты. Должны быть не меньше 0 и не больше 59.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Минуты");
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт секунды. Должны быть не меньше 0 и не больше 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Секунды");
                _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours,
                    int minutes,
                    int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {
        }
    }
}