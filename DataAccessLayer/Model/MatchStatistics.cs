using System.Collections.Generic;

namespace DataAccessLayer.Model
{
    public class MatchStatistics
    {
        public string country { get; set; }
        public int attempts_on_goal { get; set; }
        public int on_target { get; set; }
        public int off_target { get; set; }
        public int blocked { get; set; }
        public int corners { get; set; }
        public int offsides { get; set; }
        public int ball_possession { get; set; }
        public int pass_accuracy { get; set; }
        public int num_passes { get; set; }
        public int passes_completed { get; set; }
        public int distance_covered { get; set; }
        public int tackles { get; set; }
        public int clearances { get; set; }
        public int yellow_cards { get; set; }
        public int red_cards { get; set; }

        private int foulsCommited;
        public object fouls_committed
        {
            get => foulsCommited;
            set
            {
                if (value == null)
                {
                    foulsCommited = 0;
                }
                else
                {
                    string test = value.ToString();
                    foulsCommited = int.Parse(test);
                }
            }
        }
        public string tactics { get; set; }
        public List<Player> starting_eleven { get; set; }
        public List<Player> substitutes { get; set; }
    }
}
