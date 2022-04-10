using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Team
    {
        public Team(string fifaCode)
        {
            Fifa_Code = fifaCode;
        }
        public int Id { get; set; }
        public string Country { get; set; }
        public string Alternate_Name { get; set; }
        public string Fifa_Code { get; set; }
        public int Group_Id { get; set; }
        public char Group_Letter { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Games_Played { get; set; }
        public int Points { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
        public int Goal_Differential { get; set; }
        public List<Player> Players { get; set; }
        public override string ToString() => $"{Country} ({Fifa_Code})";

        public string PrepareForDisplayOutput()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"INFORMACIJE O {Country}")
                .AppendLine($"FIFA CODE: {Fifa_Code}")
                .AppendLine($"ODIGRANE/POBEJDA/PORAZ/NEODLUCENE: {Games_Played}/{Wins}/{Losses}/{Draws}")
                .AppendLine($"GOLOVI ZABIJENI/PRIMLJENI/RAZLIKA: {Goals_For}/{Goals_Against}/{Goal_Differential}");
            return sb.ToString();
        }
    }
}
