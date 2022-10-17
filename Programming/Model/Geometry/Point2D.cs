using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит двумерные координаты точки.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Хранит значение координат точки по X.
        /// </summary>
        private double _x;

        /// <summary>
        /// Хранит значение координат точки по Y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задаёт значение координат по X. Должно быть положительным.
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Координата X");
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение координат по Y. Должно быть положительным.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Координата Y");
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Значение координат по X.</param>
        /// <param name="y">Значение координат по Y.</param>
        public Point2D(double x,
                       double y)
        {
            Validator.AssertOnPositiveValue(x, "Координата X");
            Validator.AssertOnPositiveValue(y, "Координата Y");
            _x = x;
            _y = y;
        }
    }
}
