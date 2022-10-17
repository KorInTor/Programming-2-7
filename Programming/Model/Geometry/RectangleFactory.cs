using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит метод создания прямоугольника.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Ограничение для минимального значения.
        /// </summary>
        const int marginMin = 15;

        /// <summary>
        /// Ограничение для максимального значения.
        /// </summary>
        const int marginMax = 115;

        /// <summary>
        /// Создаёт экземпляр класса Rectangle со случайными значениями параметров.
        /// </summary>
        /// <param name="panelWidth">Ширина панели.</param>
        /// <param name="panelHeight">Высота панели.</param>
        /// <returns>Возвращает экземпляр класса Rectangle</returns>
        public static Rectangle Randomize(int panelWidth, int panelHeight)
        {
            var newRectangle = new Rectangle(
                _random.Next(50, 100),
                _random.Next(50, 100),
                $"Цвет {_random.Next(1, 100)}",
                _random.Next(marginMin, panelWidth- marginMax),
                _random.Next(marginMin, panelHeight- marginMax));
            return newRectangle;
        }
    }
}