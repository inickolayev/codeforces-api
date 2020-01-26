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
    public class BaseApi : IBaseApi
    {
        #region .Ctor

        public BaseApi(ContestApiConfig config)
            => (_config) = (config);

        #endregion .Ctor

        #region Public methods

        public async Task<AApiResponse<TResponse>> SendAsync<TResponse>(string methodName, object prms)
        {
            var prmsDict = GetParamsPairs(prms);
            prmsDict.Add(KeyValuePair.Create<string, object>(API_KEY_NAME, _config.PublicKey));
            prmsDict.Add(KeyValuePair.Create<string, object>(TIME_NAME, new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()));
            var rnd = new Random().Next(RND_START, RND_END);
            var sign = GetSign(rnd, methodName, prmsDict);
            Url url = _baseUrl
                .AppendPathSegment(methodName)
                .SetQueryParams(prmsDict)
                .SetQueryParam(API_SIGN_NAME, sign);
            return await url.GetJsonAsync<AApiResponse<TResponse>>();
        }

        #endregion Public methods

        #region Private methods

        protected string GetSign(int rnd, string methodName, IEnumerable<KeyValuePair<string, object>> prms)
            => $"{rnd}{GetHash(rnd, methodName, prms)}";

        protected string GetHash(int rnd, string methodName, IEnumerable<KeyValuePair<string, object>> prms)
        {
            var content = GetSignContent(rnd, methodName, prms);
            using (var sha = SHA512.Create())
            {
                var byteResult = sha.ComputeHash(Encoding.UTF8.GetBytes(content));
                var ans = BitConverter.ToString(byteResult).Replace("-", string.Empty).ToLower();
                return ans;
            }
        }

        protected string GetSignContent(int rnd, string methodName, IEnumerable<KeyValuePair<string, object>> prms)
        {
            var prmsStrs = prms
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => $"{kvp.Key}={kvp.Value}");
            var paramsContent = string.Join("&", prmsStrs);
            return $"{rnd}/{methodName}?{paramsContent}#{_config.SecretKey}";
        }

        protected IList<KeyValuePair<string, object>> GetParamsPairs(object obj)
            => obj
            .GetType()
            .GetProperties()
            .Select(p => KeyValuePair.Create(p.Name, p.GetValue(obj)))
            .ToList();

        #endregion Private methods

        #region Protected fields

        protected readonly string _baseUrl = "https://codeforces.com/api";
        protected readonly ContestApiConfig _config;

        #endregion Protected fields

        #region Contsts

        private const string API_KEY_NAME = "apiKey";
        private const string API_SIGN_NAME = "apiSig";
        private const string TIME_NAME = "time";
        private const int RND_START = 100_000;
        private const int RND_END = 999_999;

        #endregion Contsts
    }
}
