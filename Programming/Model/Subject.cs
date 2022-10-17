using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об оценках по учебной дисциплине.
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Возвращает и задаёт имя учащегося.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя и/или фамилию учителя.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должна быть не менее 2 и не более 5.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentException(
                        "Оценка не может быть меньше 2 и больше 5.");
                }
                _mark = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Имя учащегося.</param>
        /// <param name="teacher">Имя и/или фамилия учителя</param>
        /// <param name="mark">Оценка по дисциплине.</param>
        public Subject(string name,
                       string teacher,
                       int mark)
        {
            Name = name;
            Teacher = teacher;
            Mark = mark;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }
    }
}