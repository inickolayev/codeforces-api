using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Статус контеста
    /// </summary>
    public enum EContestStatus
    {
        /// <summary>
        ///     Окончен
        /// </summary>
        FINISHED,
        /// <summary>
        ///     
        /// </summary>
        BEFORE,
        /// <summary>
        ///     В процессе
        /// </summary>
        CODING,
        /// <summary>
        ///     Ожидает системеного тестирования
        /// </summary>
        PENDING_SYSTEM_TEST,
        /// <summary>
        ///     Системное тестирование
        /// </summary>
        SYSTEM_TEST
    }
}
