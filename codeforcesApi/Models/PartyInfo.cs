using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    public class PartyInfo
    {
        /// <summary>
        ///     Может отсутствовать.
        ///     Id соревнования, в котором участник принимает участие
        /// </summary>
        public int ContestId { get; set; }
        /// <summary>
        ///     Члены группы участников
        /// </summary>
        public IEnumerable<MemberInfo> Members { get; set; }
        /// <summary>
        ///     Тип участника
        /// </summary>
        public EParticipantType ParticipantType { get; set; }
        /// <summary>
        ///     Если имеет значение true, то участник является призраком.
        ///     Он участвовал в этом соревновании, но не на Codeforces.
        /// </summary>
        /// <remarks>
        ///     Например, в контестах Андрея Станкевича в Тренировках есть призраки участников Петрозаводских Сборов.
        /// </remarks>
        public bool Ghost { get; set; }
        /// <summary>
        ///     Время, когда этот участник начал соревнование
        /// </summary>
        public int StartTimeSeconds { get; set; }
    }
}
