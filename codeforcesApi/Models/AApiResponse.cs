using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesApi.Models
{
    /// <summary>
    ///     Базовый ответ от Codeforces Api
    /// </summary>
    /// <typeparam name="TResult">Тип результата</typeparam>
    public class AApiResponse<TResult>
    {
        /// <summary>
        ///     Статус выполнения запроса
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        ///     Результат выполнения запроса
        /// </summary>
        public TResult Result { get; set; }
    }
}
