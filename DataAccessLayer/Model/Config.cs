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

        public static Config ParseFromFile(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                return new Config
                {
                    FavoriteTeam = new Team(),
                    FavoritePlayers = new List<Player>()
                };
            }
            string[] items = line.Split(DEL);

            return new Config()
            {
                TeamType = items.Length > 0 ? (TeamType)Enum.Parse(typeof(TeamType), items[0]) : TeamType.Men,
                Language = items.Length > 1 ? (Language)Enum.Parse(typeof(Language), items[1]) : Language.Croatian,
                FavoriteTeam = items.Length > 2 ? new Team(items[2]) : new Team(),
                ResolutionType = items.Length > 3 ? (ResolutionType)Enum.Parse(typeof(ResolutionType), items[3]) : ResolutionType.Normal,
                FavoritePlayers = FileRepo.LoadFavoritePlayersFromFile()
            };            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "en")
            {
                sb
                .AppendLine("CURRENT SETTINGS")
                .AppendLine($"CHOOSEN COMPETITION: {TeamType}")
                .AppendLine($"CHOOSEN LANGUAGE: {Language}")
                .AppendLine($"CHOOSEN RESOLUTION: {ResolutionType}");
            }
            else
            {
                sb
                .AppendLine("TRENUTNE POSTAVKE")
                .AppendLine($"ODABRANO PRVENSTVO: {TeamType}")
                .AppendLine($"ODABRANI JEZIK: {Language}")
                .AppendLine($"ODABRANA REZOLUCIJA: {ResolutionType}");
            }
            
            return sb.ToString();
        }
    }
}
