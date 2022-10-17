using System;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о цветах, используемых в программе.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Стандартный цвет текстовых полей.
        /// </summary>
        public static Color DefaultColor = Color.White;

        /// <summary>
        /// Цвет текстовых полей при ошибке валидации.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет панелей, не имеющих пересечений с другими панелями.
        /// </summary>
        public static Color RectangleColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет панелей, имеющих пересечений с другими панелями.
        /// </summary>
        public static Color CollisionColor = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет фона пользовательского элемента управления SeasonHandleControl
        /// при выбора варианта "Winter".
        /// </summary>
        public static Color WinterColor = ColorTranslator.FromHtml("#B0E0E6");

        /// <summary>
        /// Цвет фона пользовательского элемента управления SeasonHandleControl
        /// при выбора варианта "Spring".
        /// </summary>
        public static Color SpringColor = ColorTranslator.FromHtml("#FF0000");

        /// <summary>
        /// Цвет фона пользовательского элемента управления SeasonHandleControl
        /// при выбора варианта "Summer".
        /// </summary>
        public static Color SummerColor = ColorTranslator.FromHtml("#00FF00");

        /// <summary>
        /// Цвет фона пользовательского элемента управления SeasonHandleControl
        /// при выбора варианта "Autumn".
        /// </summary>
        public static Color AutumnColor = ColorTranslator.FromHtml("#FFA500");
    }
}