using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     
    /// </summary>
    public class ContestStandingsResponse
    {
        /// <summary>
        ///     Соревнование
        /// </summary>
        public ContestInfo Contest { get; set; }
        /// <summary>
        ///     Список задач
        /// </summary>
        public IEnumerable<ProblemInfo> Problems { get; set; }
        /// <summary>
        ///     Список результатов соревнования
        /// </summary>
        public IEnumerable<RanklistRowInfo> Rows { get; set; }
    }
}
