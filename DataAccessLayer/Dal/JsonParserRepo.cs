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
        //FILE ENDPOINTS
        private const string WOMEN_FILE_RESULTS = @"..\..\..\worldcup-sfg-io\women\results.json";
        private const string WOMEN_FILE_TEAMS = @"..\..\..\worldcup-sfg-io\women\teams.json";
        private const string WOMEN_FILE_ALL_MATCHES = @"..\..\..\worldcup-sfg-io\women\matches.json";

        private const string MEN_FILE_RESULTS = @"..\..\..\worldcup-sfg-io\men\results.json";
        private const string MEN_FILE_TEAMS = @"..\..\..\worldcup-sfg-io\men\teams.json";
        private const string MEN_FILE_ALL_MATCHES = @"..\..\..\worldcup-sfg-io\men\matches.json";

        public async Task<List<Match>> GetAllMatches(TeamType type)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_ALL_MATCHES : WOMEN_FILE_ALL_MATCHES));
                }
                catch (Exception)
                {
                    return new List<Match>();
                }
            });
        }

        public async Task<List<Team>> GetAllResults(TeamType type)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_RESULTS : WOMEN_FILE_RESULTS));
                }
                catch (Exception)
                {
                    return new List<Team>();
                }
            });
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
                return new List<Team>();
            }
        }

        public async Task<Match> GetSpecificMatch(string firstFifaCode, string secondFifaCode, TeamType type)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_ALL_MATCHES : WOMEN_FILE_ALL_MATCHES));
                    return allMatches.Find(match => (match.home_team.code == firstFifaCode && match.away_team.code == secondFifaCode) || match.away_team.code == firstFifaCode && match.home_team.code == secondFifaCode);
                }
                catch (Exception)
                {
                    return new Match();
                }
            });
        }

        public async Task<List<Match>> GetTeamMatches(TeamType type, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_ALL_MATCHES : WOMEN_FILE_ALL_MATCHES));
                    return new List<Match>(allMatches.FindAll(match => match.home_team.code == fifaCode || match.away_team.code == fifaCode));
                }
                catch (Exception)
                {
                    return new List<Match>();
                }
            });
        }

        public async Task<List<Player>> GetTeamPlayers(TeamType type, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_ALL_MATCHES : WOMEN_FILE_ALL_MATCHES));

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

        public async Task<List<Team>> GetTeamResult(TeamType type, string fifaCode)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Team> parsedTeams = JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(type == TeamType.Men ? MEN_FILE_RESULTS : WOMEN_FILE_RESULTS));
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
