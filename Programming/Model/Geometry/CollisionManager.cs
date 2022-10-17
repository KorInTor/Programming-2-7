using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит методы расчёта коллизии.
    /// </summary>
    internal static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники не пересекаются по X и Y.
        /// И false, если прямоугольники пересекаются по X и/или Y.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs((rectangle1.Center.X + rectangle1.Width/2)
                - (rectangle2.Center.X+rectangle2.Width/2));
            double dY = Math.Abs((rectangle1.Center.Y + rectangle1.Length / 2)
                - (rectangle2.Center.Y + rectangle2.Length / 2));
            double sumWidth = Math.Abs(rectangle1.Width + rectangle2.Width);
            double sumLength = Math.Abs(rectangle1.Length + rectangle2.Length);

            return (dX < (sumWidth / 2)) && (dY < (sumLength / 2));
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца не пересекаются по X и Y.
        /// И false, если кольца пересекаются по X и/или Y.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX*dX + dY*dY);
            double dOuterRadius = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            return c < dOuterRadius;
        }
    }
}
