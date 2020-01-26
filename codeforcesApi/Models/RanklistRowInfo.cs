using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Представляет строку результатов соревнования
    /// </summary>
    public class RanklistRowInfo
    {
        /// <summary>
        ///     Участник, который занял соответствующее место в соревновании
        /// </summary>
        public PartyInfo Party { get; set; }
        /// <summary>
        ///     Место участника в соревновании
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        ///     Суммарные баллы, набранные участником
        /// </summary>
        public double Points { get; set; }
        /// <summary>
        ///     Суммарное пенальти (в ICPC понимании) участника
        /// </summary>
        public int Penalty { get; set; }
        /// <summary>
        ///     Количество успешных взломов
        /// </summary>
        public int SuccessfulHackCount { get; set; }
        /// <summary>
        ///     Количество неуспешных взломов
        /// </summary>
        public int UnsuccessfulHackCount { get; set; }
        /// <summary>
        ///     Результаты участника по каждой из задач соревнования.
        ///     Порядок задач соответствует порядку задач в поле "problems" возвращаемого объекта.
        /// </summary>
        public IEnumerable<ProblemResultInfo> ProblemResults { get; set; }
    }
}
