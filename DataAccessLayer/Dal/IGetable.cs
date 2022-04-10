using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public interface IGetable
    {
        Task<List<Team>> GetAllResults(string url);
        Task<List<Match>> GetAllMatches(string url);
        Task<List<Team>> GetTeamResult(string url, string fifaCode);
        Task<List<Match>> GetTeamMatches(string url, string fifaCode);
        Task<List<Player>> GetTeamPlayers(string url, string fifaCode);
        Task<List<Team>> GetFromSelectedTeamOpponents(string url, string fifaCode, string teamInfoUrl);

        Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, string allMatchesURL);

    }
}
