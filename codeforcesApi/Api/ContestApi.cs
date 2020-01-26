using CodeforcesApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesApi.Api
{
    public class ContestApi : IContestApi
    {
        #region .Ctor

        public ContestApi(IBaseApi api)
            => (_api) = (api);

        #endregion .Ctor

        /// <summary>
        ///     Получить соревнование и запрошенную часть результатов.
        /// </summary>
        /// <param name="contestId">Id соревнования. Это не номер раунда. Его можно увидеть в URL соревнования. Например: /contest/566/status</param>
        /// <param name="from">Индекс (начиная с 1) первой возвращаемой строки результатов</param>
        /// <param name="count">Количество возвращаемых строк результатов</param>
        /// <param name="showUnofficial">Если имеет значение true, то все участники (виртуальные, вне конкурса) будут возвращены. Иначе, только официальные участники соревнования будут возвращены</param>
        /// <returns></returns>
        public Task<AApiResponse<ContestStandingsResponse>> GetStandingsAsync(long contestId, int from, int count, bool showUnofficial)
            => _api.SendAsync<ContestStandingsResponse>(GET_STANDINGS_NAME, new {
                contestId,
                from,
                count,
                showUnofficial
            });

        #region Private fields

        private readonly IBaseApi _api;

        #endregion Private fields

        #region Consts

        private const string GET_STANDINGS_NAME = "contest.standings";

        #endregion Consts
    }
}
