using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Возвращает и задаёт пункт вылета рейса.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт пункт назначения рейса.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта рейса в минутах.
        /// </summary>
        public int FlightTimeMinutes { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTimeMinutes">Время полёта в минутах.</param>
        public Flight(string departure,
                      string destination,
                      int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }
    }
}