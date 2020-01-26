using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Конфигурация
    /// </summary>
    public class ContestApiConfig
    {
        /// <summary>
        ///     Публичный ключ (API)
        /// </summary>
        public string PublicKey { get; set; }
        /// <summary>
        ///     Приватный ключ (API)
        /// </summary>
        public string SecretKey { get; set; }
    }
}
