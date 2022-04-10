using DataAccessLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public enum Language
    {
        NotSet, English, Croatian
    }
    public enum TeamType
    {
        NotSet, Men, Women
    }

    public enum ResolutionType
    {
        Normal, Big, Fullscreen
    }

    public class Config
    {
        private const string WOMEN_API_RESULTS = "http://worldcup.sfg.io/teams/results";
        private const string WOMEN_API_TEAM_RESULTS = "http://worldcup.sfg.io/teams/results?fifa_code=";
        private const string WOMEN_API_ALL_MATCHES = "http://worldcup.sfg.io/matches";
        private const string WOMEN_API_TEAM_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";

        private const string MEN_API_RESULTS = "http://world-cup-json-2018.herokuapp.com/teams/results";
        private const string MEN_API_TEAM_RESULTS = "http://world-cup-json-2018.herokuapp.com/teams/results?fifa_code=";
        private const string MEN_API_ALL_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        private const string MEN_API_TEAM_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";

        private const char DEL = '|';
      
        public TeamType TeamType { get; set; }
        public Language Language { get; set; }
        public Team FavoriteTeam { get; set; }
        public List<Player> FavoritePlayers { get; set; }
        public ResolutionType ResolutionType { get; set; }

        public string PrepareConfigForFile()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .Append(TeamType)
                .Append(DEL)
                .Append(Language)
                .Append(DEL)
                .Append(FavoriteTeam.Fifa_Code)
                .Append(DEL)
                .Append(ResolutionType);

            return sb.ToString();
        }

        public string GetURLAllResults() => TeamType == TeamType.Men ? MEN_API_RESULTS : WOMEN_API_RESULTS;     

        public string GetURLTeamResult() => TeamType == TeamType.Men ? MEN_API_TEAM_RESULTS : WOMEN_API_TEAM_RESULTS;

        public string GetURLTeamMatches() => TeamType == TeamType.Men ? MEN_API_TEAM_MATCHES : WOMEN_API_TEAM_MATCHES;
        public string GetURLAllMatches() => TeamType == TeamType.Men ? MEN_API_ALL_MATCHES : WOMEN_API_ALL_MATCHES;

        public static Config ParseFromFile(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                return new Config
                {
                    FavoritePlayers = new List<Player>(),
                };
            }
            string[] items = line.Split(DEL);

            return new Config()
            {
                TeamType = (TeamType)Enum.Parse(typeof(TeamType), items[0]),
                Language = (Language)Enum.Parse(typeof(Language), items[1]),
                FavoriteTeam = new Team(items[2]),
                FavoritePlayers = FileRepo.LoadFavoritePlayersFromFile()
            };            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine("TRENUTNE POSTAVKE")
                .AppendLine($"ODABRANO PRVENSTVO: {TeamType}")
                .AppendLine($"ODABRANI JEZIK: {Language}")
                .AppendLine($"ODABRANA REZOLUCIJA: {ResolutionType}");
            return sb.ToString();
        }
    }
}
