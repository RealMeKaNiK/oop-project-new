using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Match
    {
        public string venue { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public string fifa_id { get; set; }
        public Weather weather { get; set; }
        public List<string> officials { get; set; }
        public string stage_name { get; set; }
        public DateTime datetime { get; set; }
        public string winner { get; set; }
        public string winner_code { get; set; }
        public HomeTeam home_team { get; set; }
        public AwayTeam away_team { get; set; }
        public List<MatchEvents> home_team_events { get; set; }
        public List<MatchEvents> away_team_events { get; set; }
        public MatchStatistics home_team_statistics { get; set; }
        public MatchStatistics away_team_statistics { get; set; }
        public DateTime last_event_update_at { get; set; }      
        public string location { get; set; }
        public string attendance { get; set; }
        public string home_team_country { get; set; }
        public string away_team_country { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "en")
            {
                sb
                    .AppendLine($"WINNER: {winner}")
                    .AppendLine("RESULT")
                    .Append($"{home_team.code} {home_team.goals} : {away_team.goals} {away_team.code}");
            }
            else
            {
                sb
                    .AppendLine($"POBJEDNIK: {winner}")
                    .AppendLine("REZULTAT")
                    .Append($"{home_team.code} {home_team.goals} : {away_team.goals} {away_team.code}");
            }
            return sb.ToString();
        }
    }
}
