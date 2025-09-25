using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class MatchData
    {
        public Category Category { get; set; }
        public int Round { get; set; }
        public string Court { get; set; } = string.Empty;
        public int Order { get; set; }
        public TeamData? TeamA { get; set; }
        public TeamData? TeamB { get; set; }
    }
}
