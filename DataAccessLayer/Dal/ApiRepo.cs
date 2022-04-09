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


        private readonly HttpClient Client;

        public ApiRepo()
        {
            Client = new HttpClient();
        }

        public async Task<List<Match>> GetAllMatches(string url) => JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url)); 
        public async Task<List<Team>> GetAllResults(string url) => JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync(url));        
        public async Task<List<Match>> GetTeamMatches(string url, string fifaCode) => JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));     

        public async Task<List<Player>> GetTeamPlayers(string url, string fifaCode)
        {
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));
            List<StartingEleven> startingElevens = matches[0].home_team_statistics.starting_eleven;
            List<Substitute> substitutes = matches[0].home_team_statistics.substitutes;

            List<Player> playerList = new List<Player>();
            startingElevens.ForEach(x => playerList.Add(x));
            substitutes.ForEach(x => playerList.Add(x));
            List<Player> finalResult = Utilities.CalculatePlayerStatistics(matches, playerList, fifaCode);
            return finalResult;
        }

        public async Task<Team> GetTeamResult(string url, string fifaCode) => JsonConvert.DeserializeObject<Team>(await Client.GetStringAsync(url + fifaCode));
    }
}
