using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    internal class Contact
    {
       /// <summary>
       /// Номер телефона контакта.
       /// </summary>
        private string _number;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// Должен состоять только из цифр в количестве 11 штук.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long number))
                {
                    throw new ArgumentException(
                        "Номер телефона должен состоять только из цифр.");
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "Количество цифр должно быть равно 11.");
                }

                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт организацию, к которой относится контакт.
        /// </summary>
        public string Organization { get; set; }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="number">Номер. Должен состоять только из цифр
        /// в количестве 11 штук.</param>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="organization">Организация.</param>
        public Contact(string number,
                       string name,
                       string surname,
                       string organization)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Organization = organization;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }
    }
}