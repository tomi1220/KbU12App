using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class TeamData
    {
        public string JbaID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Kana { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string KanaShortName { get; set; } = string.Empty;
        public int Category { get; set; }
        public bool JbaTeamRegistrationStatus { get; set; }
        public District District { get; set; }
    }
}
