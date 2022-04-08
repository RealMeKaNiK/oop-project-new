using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public enum Language
    {
        English, Croatian
    }
    public enum TeamType
    {
        Men, Women
    }

    public enum ResolutionType
    {
        Fullscreen, Big, Normal
    }

    public class Config
    {
        private const char DEL = '|';
      
        public TeamType TeamType { get; set; }
        public Language Language { get; set; }
        public Team FavoriteTeam { get; set; }
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
            string[] items = line.Split(DEL);

            return new Config()
            {
                TeamType = (TeamType)Enum.Parse(typeof(TeamType), items[0]),
                Language = (Language)Enum.Parse(typeof(Language), items[1]),                
            };            
        }
    }
}
