using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Модель контеста
    /// </summary>
    public class ContestInfo
    {
        /// <summary>
        ///     Идентификатор контеста
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Название контеста
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///     
        /// </summary>
        public EContestType Type { get; set; }
        public EContestStatus Phase { get; set;}
        public bool Frozen { get; set; }
        public int DurationSeconds { get; set; }
        public string StartTimeSeconds { get; set; }
        public string RelativeTimeSeconds { get; set; }
    }
}
