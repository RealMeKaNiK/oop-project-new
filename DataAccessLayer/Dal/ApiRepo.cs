using DataAccessLayer.Exceptions;
using DataAccessLayer.Model;
using DataAccessLayer.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public class ApiRepo : IGetable
    {
        // API ENDPOINTS
        private const string WOMEN_API_RESULTS = "http://worldcup.sfg.io/teams/results";
        private const string WOMEN_API_TEAM_RESULTS = "http://worldcup.sfg.io/teams/results?fifa_code=";
        private const string WOMEN_API_ALL_MATCHES = "http://worldcup.sfg.io/matches";
        private const string WOMEN_API_TEAM_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";

        private const string MEN_API_RESULTS = "http://world-cup-json-2018.herokuapp.com/teams/results";
        private const string MEN_API_TEAM_RESULTS = "http://world-cup-json-2018.herokuapp.com/teams/results?fifa_code=";
        private const string MEN_API_ALL_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        private const string MEN_API_TEAM_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";

        private readonly HttpClient Client;

        public ApiRepo()
        {
            Client = new HttpClient();
        }

        public async Task<List<Match>> GetAllMatches(TeamType type)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(type == TeamType.Men ? MEN_API_ALL_MATCHES : WOMEN_API_ALL_MATCHES));
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }
        public async Task<List<Team>> GetAllResults(TeamType type)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync(type == TeamType.Men ? MEN_API_RESULTS : WOMEN_API_RESULTS));
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }      

        public async Task<List<Match>> GetTeamMatches(TeamType type, string fifaCode)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync((type == TeamType.Men ? MEN_API_TEAM_MATCHES : WOMEN_API_TEAM_MATCHES) + fifaCode));
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        } 

        public async Task<List<Player>> GetTeamPlayers(TeamType type, string fifaCode)
        {
            try
            {
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync((type == TeamType.Men ? MEN_API_TEAM_MATCHES : WOMEN_API_TEAM_MATCHES) + fifaCode));
                List<Player> startingElevens = matches[0].home_team_statistics.starting_eleven;
                List<Player> substitutes = matches[0].home_team_statistics.substitutes;

                List<Player> playerList = new List<Player>();
                startingElevens.ForEach(x => playerList.Add(x));
                substitutes.ForEach(x => playerList.Add(x));
                return Utilities.CalculatePlayerStatistics(matches, playerList, fifaCode);
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }

        public async Task<List<Team>> GetFromSelectedTeamOpponents(TeamType type, string fifaCode)
        {
            try
            {
                List<Match> allTeamMatches = await GetTeamMatches(type, fifaCode);
                List<Team> allTeamsInTournument = await GetAllResults(type);
                List<string> opponentsFifaCode = new List<string>();

                foreach (Match item in allTeamMatches)
                {
                    if (item.home_team.code != fifaCode)
                    {
                        opponentsFifaCode.Add(item.home_team.code);
                    }
                    else
                    {
                        opponentsFifaCode.Add(item.away_team.code);
                    }
                }
                List<Team> oppTeams = new List<Team>();
                opponentsFifaCode.ForEach(x => oppTeams.Add(allTeamsInTournument.Find(y => y.Fifa_Code == x)));
                return oppTeams;
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }
        public async Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, TeamType type)
        {
            try
            {
                List<Match> allMatches = await GetTeamMatches(type, firstFifaCode);
                return allMatches.Find(x => (x.home_team.code == firstFifaCode && x.away_team.code == secondFifaCode) || (x.away_team.code == firstFifaCode && x.home_team.code == secondFifaCode));
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }
        public async Task<List<Team>> GetTeamResult(TeamType type, string fifaCode)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync((type == TeamType.Men ? MEN_API_TEAM_RESULTS : WOMEN_API_TEAM_RESULTS) + fifaCode));
            }
            catch (Exception)
            {
                throw new ConfigMissingException(Utilities.ErrorMessage());
            }
        }       
    }
}
