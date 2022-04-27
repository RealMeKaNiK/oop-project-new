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
        Task<List<Team>> GetAllResults(TeamType type);
        Task<List<Match>> GetAllMatches(TeamType type);
        Task<List<Team>> GetTeamResult(TeamType type, string fifaCode);
        Task<List<Match>> GetTeamMatches(TeamType type, string fifaCode);
        Task<List<Player>> GetTeamPlayers(TeamType type, string fifaCode);
        Task<List<Team>> GetFromSelectedTeamOpponents(TeamType type, string fifaCode);
        Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, TeamType type);

    }
}
