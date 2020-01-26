using CodeforcesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace CodeforcesApi.Api
{
    /// <summary>
    ///     Базовый класс для всех апи
    /// </summary>
    public interface IBaseApi
    {
        Task<AApiResponse<TResponse>> SendAsync<TResponse>(string methodName, object prms);
    }
}
