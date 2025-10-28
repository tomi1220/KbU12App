using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Match
{
    public class MatchData
    {
        public Categories Categoriy { get; set; }
        public int Round { get; set; }
        public string Court { get; set; } = string.Empty;
        public int Order { get; set; }
        public TeamData? TeamA { get; set; } = null;
        public int ScoreA { get; set; } = 0;
        public bool OpenA { get; set; }
        public TeamData? TeamB { get; set; } = null;
        public int ScoreB { get; set; } = 0;
        public bool OpenB { get; set; }
    }
}
