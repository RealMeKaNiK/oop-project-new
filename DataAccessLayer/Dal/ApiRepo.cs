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

        public async Task<List<Match>> GetAllMatches(string url)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url));
            }
            catch (Exception)
            {
                return new List<Match>();
            }
        }
        public async Task<List<Team>> GetAllResults(string url)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync(url));
            }
            catch (Exception)
            {
                return new List<Team>();                
            }
        }      

        public async Task<List<Match>> GetTeamMatches(string url, string fifaCode)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));
            }
            catch (Exception)
            {
                return new List<Match>();                
            }
        } 

        public async Task<List<Player>> GetTeamPlayers(string url, string fifaCode)
        {
            try
            {
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(await Client.GetStringAsync(url + fifaCode));
                List<Player> startingElevens = matches[0].home_team_statistics.starting_eleven;
                List<Player> substitutes = matches[0].home_team_statistics.substitutes;

                List<Player> playerList = new List<Player>();
                startingElevens.ForEach(x => playerList.Add(x));
                substitutes.ForEach(x => playerList.Add(x));
                return Utilities.CalculatePlayerStatistics(matches, playerList, fifaCode);
            }
            catch (Exception)
            {
                return new List<Player>();             
            }
        }

        public async Task<List<Team>> GetFromSelectedTeamOpponents(string url, string fifaCode, string allTeamURL)
        {
            try
            {
                List<Match> allTeamMatches = await GetTeamMatches(url, fifaCode);
                List<Team> allTeamsInTournument = await GetAllResults(allTeamURL);
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
                return new List<Team>();
            }
        }
        public async Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, string teamMatchesURL)
        {
            try
            {
                List<Match> allMatches = await GetTeamMatches(teamMatchesURL, firstFifaCode);
                return allMatches.Find(x => (x.home_team.code == firstFifaCode && x.away_team.code == secondFifaCode) || (x.away_team.code == firstFifaCode && x.home_team.code == secondFifaCode));
            }
            catch (Exception)
            {
                return new Match();
            }
        }
        //returning a list with one item in it
        public async Task<List<Team>> GetTeamResult(string url, string fifaCode)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Team>>(await Client.GetStringAsync(url + fifaCode));
            }
            catch (Exception)
            {
                return new List<Team>();
            }
        }       
    }
}
