using CodeforcesApi.Consts;
using CodeforcesApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesApi.Api
{
    public interface IContestApi
    {
        /// <summary>
        ///     Получить соревнование и запрошенную часть результатов.
        /// </summary>
        /// <param name="contestId">Id соревнования. Это не номер раунда. Его можно увидеть в URL соревнования. Например: /contest/566/status</param>
        /// <param name="from">Индекс (начиная с 1) первой возвращаемой строки результатов</param>
        /// <param name="count">Количество возвращаемых строк результатов</param>
        /// <param name="showUnofficial">Если имеет значение true, то все участники (виртуальные, вне конкурса) будут возвращены. Иначе, только официальные участники соревнования будут возвращены</param>
        /// <returns>Описание контеста, задач и участников</returns>
        Task<AApiResponse<ContestStandingsResponse>> GetStandingsAsync(long contestId, int from = Constans.ENTRIES_FROM_MIN, int count = Constans.ENTRIES_COUNT_MAX, bool showUnofficial = true);
    }
}
