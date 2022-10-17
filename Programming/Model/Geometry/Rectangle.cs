using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Общее количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должна быть положительным.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительным.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт двумерные координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт внутри класса общее количество созданных прямоугольников.
        /// Должно быть положительным.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(AllRectanglesCount));
                _allRectanglesCount = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина.</param>
        /// <param name="width">Ширина.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="xCenter">Координаты по X.</param>
        /// <param name="yCenter">Корординаты по Y.</param>
        public Rectangle(double length,
                         double width,
                         string color,
                         double xCenter,
                         double yCenter)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(xCenter, yCenter);
            AllRectanglesCount = _allRectanglesCount;
            Validator.AssertOnPositiveValue(AllRectanglesCount, "Номер прямоугольника");
            _id = AllRectanglesCount;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
        }
    }
}