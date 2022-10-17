using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт внутренний радиус кольца.
        /// Должен быть не больше внешнего радиуса кольца.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внутренний радиус кольца");
                Validator.AssertMinLessThenMax(_innerRadius, "Внутренний радиус кольца",
                    _outerRadius, "Внешний радиус кольца");
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внешний радиус кольца.
        /// Должен быть не меньше внутреннего радиуса кольца.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внешний радиус кольца");
                Validator.AssertMinLessThenMax(_innerRadius, "Внутренний радиус кольца",
                    _outerRadius, "Внешний радиус кольца");
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return (Math.PI * _outerRadius * _outerRadius) -
                    (Math.PI * _innerRadius * _innerRadius);
            }
        }

        /// <summary>
        /// Возвращает и задаёт двумерные координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="innerRadius">Внутренний радиус.</param>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="xCenter">Координаты по X.</param>
        /// <param name="yCenter">Корординаты по Y.</param>
        public Ring(double innerRadius,
                    double outerRadius,
                    double xCenter,
                    double yCenter)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            var area = Area;
            Center = new Point2D(xCenter, yCenter);
        }
    }
}
