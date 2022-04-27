using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Text;

namespace DataAccessLayer.Model
{
    [Serializable]
    public class Player
    {
        public string name { get; set; }
        public bool captain { get; set; }
        public int shirt_number { get; set; }
        public string position { get; set; }
        public int GoalNumber { get; set; }
        public int YellowCardNumber { get; set; }
        public bool FavoritePlayer { get; set; }
        
        [JsonIgnore]
        private Bitmap DefaultPicture = new Bitmap(DataAccessLayer.Properties.ResourceFile.DefaultPicture);

        [JsonIgnore]
        private Bitmap _picture;
        
        [JsonIgnore]
        public Bitmap Picture
        {
            get
            {
                if (_picture != null)
                {                                      
                   return _picture;
                }
                return DefaultPicture;
            }
            set
            {
                _picture = value;
            }
        }     

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "en")
            {
                sb
                    .AppendLine("INFROMATION ABOUT PLAYER")
                    .AppendLine($"NAME: {name}")
                    .AppendLine($"SHIRT NUMBER: {shirt_number}")
                    .AppendLine($"POSITION: {position}")
                    .AppendLine($"{(captain ? "KAPETAN" : "")}")
                    .AppendLine($"GOAL NUMBER: {GoalNumber}")
                    .AppendLine($"YELLOW CARDS: {YellowCardNumber}"); 
            }
            else
            {
                sb
                    .AppendLine("INFORMACIJE O IGRACU")
                    .AppendLine($"IME: {name}")
                    .AppendLine($"SHIRT NUMBER: {shirt_number}")
                    .AppendLine($"POSITION: {position}")
                    .AppendLine($"{(captain ? "KAPETAN" : "")}")
                    .AppendLine($"BROJ GOLOVA: {GoalNumber}")
                    .AppendLine($"BROJ ZUTIH: {YellowCardNumber}");
            }
            return sb.ToString();
        }        
    }
}
