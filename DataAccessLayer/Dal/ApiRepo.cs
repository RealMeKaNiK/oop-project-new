using DataAccessLayer.Model;
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

        public async Task<List<Match>> GetAllMatches(string url)
        {
            return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url));
        }

        public async Task<List<Team>> GetAllResults(string url)
        {
            return JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync(url));
        }

        public async Task<List<Match>> GetTeamMatches(string url, string fifaCode)
        {
            return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));
        }

        public async Task<List<Player>> GetTeamPlayers(string url, string fifaCode)
        {
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));
            List<StartingEleven> startingElevens = matches[0].home_team_statistics.starting_eleven;
            List<Substitute> substitutes = matches[0].home_team_statistics.substitutes;

            List<Player> playerList = new List<Player>();
            startingElevens.ForEach(x => playerList.Add(x));
            substitutes.ForEach(x => playerList.Add(x));
            return playerList;
        }

        public async Task<Team> GetTeamResult(string url, string fifaCode)
        {
            return JsonConvert.DeserializeObject<Team>(await Client.GetStringAsync(url + fifaCode));
        }
    }
}
