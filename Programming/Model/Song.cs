using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о музыкальном треке.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Возвращает и задаёт название трека.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт название альбома, к которому относиться трек.
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность трека в минутах.
        /// </summary>
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр музыки, к которому относиться трек.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название трека.</param>
        /// <param name="album">Название альбома.</param>
        /// <param name="durationMinutes">Длительность трека в минутах.</param>
        /// <param name="genre">Жанр</param>
        public Song(string name,
                    string album,
                    int durationMinutes, 
                    string genre)
        {
            Name = name;
            Album = album;
            DurationMinutes = durationMinutes;
            Genre = genre;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }
    }
}