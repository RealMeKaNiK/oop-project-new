using DataAccessLayer.Model;
using DataAccessLayer.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public class JsonParserRepo : IGetable
    {
        // DEFAULT CTOR
        public JsonParserRepo()
        {
        }
        public async Task<List<Match>> GetAllMatches(string url)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(url));
                }
                catch (Exception)
                {
                    return new List<Match>();
                }
            });
        }

        public async Task<List<Team>> GetAllResults(string url)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(url));
                }
                catch (Exception)
                {
                    return new List<Team>();
                }
            });
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

        public async Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, string allMatchesURL)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(allMatchesURL));
                    return allMatches.Find(match => (match.home_team.code == firstFifaCode && match.away_team.code == secondFifaCode) || match.away_team.code == firstFifaCode && match.home_team.code == secondFifaCode);
                }
                catch (Exception)
                {
                    return new Match();
                }
            });
        }

        public async Task<List<Match>> GetTeamMatches(string url, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(url));
                    return new List<Match>(allMatches.FindAll(match => match.home_team.code == fifaCode || match.away_team.code == fifaCode));
                }
                catch (Exception)
                {
                    return new List<Match>();
                }
            });
        }

        public async Task<List<Player>> GetTeamPlayers(string url, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(url));

                    List<Match> allTeamMatches = allMatches.FindAll(match => match.home_team.code == fifaCode || match.away_team.code == fifaCode);
                    Match matchFromSelectedCountry = allMatches.Find(match => match.home_team.code == fifaCode || match.away_team.code == fifaCode);

                    List<Player> startingElevens = matchFromSelectedCountry.home_team.code == fifaCode ? matchFromSelectedCountry.home_team_statistics.starting_eleven : matchFromSelectedCountry.away_team_statistics.starting_eleven;
                    List<Player> substitutes = matchFromSelectedCountry.home_team.code == fifaCode ? matchFromSelectedCountry.home_team_statistics.substitutes : matchFromSelectedCountry.away_team_statistics.substitutes;

                    List<Player> playerList = new List<Player>();
                    startingElevens.ForEach(x => playerList.Add(x));
                    substitutes.ForEach(x => playerList.Add(x));
                    return Utilities.CalculatePlayerStatistics(allTeamMatches, playerList, fifaCode);
                }
                catch (Exception)
                {
                    return new List<Player>();
                }
            });
        }

        public async Task<List<Team>> GetTeamResult(string url, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Team> parsedTeams = JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(url));
                    return new List<Team> { parsedTeams.Find(x => x.Fifa_Code == fifaCode) };
                }
                catch (Exception)
                {
                    return new List<Team>();
                }
            });
        }
    }
}
