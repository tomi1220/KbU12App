using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public partial class TeamInfo
    {
        public string JbaTeamID { get; set; } = string.Empty;
        public string TeamName { get; set; } = string.Empty;
        public string Kana { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string KanaShortName { get; set; } = string.Empty;
        public Categories Category { get; set; }
        public bool JbaTeamRegistrationStatus { get; set; } = false;
        public Districts District { get; set; }
        public string ValidityPeriodSt { get; set; } = string.Empty;
        public string ValidityPeriodEd { get; set; } = string.Empty;
    }
}
