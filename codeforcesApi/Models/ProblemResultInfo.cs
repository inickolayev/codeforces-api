using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Результат участника по задаче
    /// </summary>
    public class ProblemResultInfo
    {
        /// <summary>
        ///     Количество баллов за задачу
        /// </summary>
        public double Points { get; set; }
        /// <summary>
        ///     Пенальти (в ICPC понимании) участника по задаче
        /// </summary>
        public int Penalty { get; set; }
        /// <summary>
        ///     Количество неправильный попыток
        /// </summary>
        public int RejectedAttemptCount { get; set; }
        /// <summary>
        ///     Тип результата
        /// </summary>
        /// <remarks>
        ///     Если имеет значение PRELIMINARY, то количество баллов может уменьшиться (например, если решение не пройдет системное тестирование).
        ///     Иначе, участник может только лишь увеличить количество баллов, послав решение лучше..
        /// </remarks>
        public EProblemResultType Type { get; set; }
        /// <summary>
        ///     Время в секундах от начала соревнования до посылки, которая получила максимальный балл по задаче.
        /// </summary>
        public int BestSubmissionTimeSeconds { get; set; }
    }
}
