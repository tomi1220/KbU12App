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
        public string TeamNameKana { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string ShortNameKana { get; set; } = string.Empty;
        public Categories Category { get; set; }
        public JbaTeamRegistrationStatuses JbaStatus { get; set; } = JbaTeamRegistrationStatuses.Unknown;
        public Districts District { get; set; }
        public string ValidityPeriodSt { get; set; } = string.Empty;
        public string ValidityPeriodEd { get; set; } = string.Empty;
    }
}
