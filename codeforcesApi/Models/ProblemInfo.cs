using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Модель задачи
    /// </summary>
    public class ProblemInfo
    {
        /// <summary>
        ///     Идентификатор соревнования
        /// </summary>
        public int ContestId { get; set; }
        /// <summary>
        ///     Индекс задачи в соревновании
        /// </summary>
        public string Index { get; set; }
        /// <summary>
        ///     Название задачи
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///     Тип соревнования
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        ///     Рейтинг задачи
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        ///     Теги задачи
        /// </summary>
        public IEnumerable<string> Tags { get; set; }
    }
}
