using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Utils
{
    public static class Utilities
    {
        public static List<Player> CalculatePlayerStatistics(List<Match> matches, List<Player> players, string fifaCode)
        {
            List<Player> result = new List<Player>(players);

            foreach (Match match in matches)
            {
                if (match.home_team.code == fifaCode)
                {
                    foreach (var item in match.home_team_events)
                    {
                        switch (item.type_of_event)
                        {
                            case "goal":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).GoalNumber++;
                                }
                                break;
                            case "goal-penalty":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).GoalNumber++;
                                }
                                break;
                            case "yellow-card":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).YellowCardNumber++;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (match.away_team.code == fifaCode)
                {
                    foreach (var item in match.home_team_events)
                    {
                        switch (item.type_of_event)
                        {
                            case "goal":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).GoalNumber++;
                                }
                                break;
                            case "goal-penalty":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).GoalNumber++;
                                }
                                break;
                            case "yellow-card":
                                if (result.Find(x => x.name.Contains(item.player))?.name == item.player)
                                {
                                    result.Find(x => x.name.Contains(item.player)).YellowCardNumber++;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            result.Sort((x, y) => -x.GoalNumber.CompareTo(y.GoalNumber));
            return result;
        }
    }
}
