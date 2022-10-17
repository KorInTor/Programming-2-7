using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит методы валидации.
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Проверяет, что значение - положительное.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// который подлежит проверке.</param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"Значение поля '{propertyName}' не может быть отрицательным.");
            }
        }

        /// <summary>
        /// Проверяет, что значение - положительное.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// который подлежит проверке.</param>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"Значение поля '{propertyName}' не может быть отрицательным.");
            }
        }

        /// <summary>
        /// Проверяет, что значение находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="min">Нижний диапазон.</param>
        /// <param name="max">Верхний диапазон.</param>
        /// <param name="propertyName">Имя свойства или объекта, который подлежит проверке.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"Значение поля '{propertyName}' должно быть от {min} до " +
                    $"{max} включительно.");
            }
        }

        /// <summary>
        /// Проверяет, что значение состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// который подлежит проверке.</param>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"Значение поля '{propertyName}' должно состоять только из букв.");
                }
            }
        }

        /// <summary>
        /// Проверяет, чтобы нижний диапазон был меньше верхнего диапазона.
        /// </summary>
        /// <param name="min">Нижний диапазон.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// к которому принадлежит значение нижнего диапазона.</param>
        /// <param name="max">ОВерхний диапазон.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// к которому принадлежит значение верхнего диапазона.</param>
        public static void AssertMinLessThenMax(double min, string minPropertyName,
            double max, string maxPropertyName)
        {
            if (min >= max)
            {
                throw new ArgumentException(
                    $"Значение поля '{minPropertyName}' должно быть меньше значения поля " +
                    $"'{maxPropertyName}'.");
            }
        }
    }
}