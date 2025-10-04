using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public class MatchData
    {
        public Categories Categoriy { get; set; }
        public int Round { get; set; }
        public string Court { get; set; } = string.Empty;
        public int Order { get; set; }
        public TeamInfo? TeamA { get; set; } = null;
        public int ScoreA { get; set; } = 0;
        public TeamInfo? TeamB { get; set; } = null;
        public int ScoreB { get; set; } = 0;
    }
}
