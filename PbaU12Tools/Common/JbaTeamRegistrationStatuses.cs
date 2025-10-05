using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Common
{
    public static class JbaTeamRegistrationStatusesList
    {
        public static Dictionary<JbaTeamRegistrationStatuses, string> DicJbaTeamRegistrationStatuses { get; set; } =
            new Dictionary<JbaTeamRegistrationStatuses, string>()
            {
                { JbaTeamRegistrationStatuses.Unknown, "不明" },
                { JbaTeamRegistrationStatuses.Complete, "登録完了" },
                { JbaTeamRegistrationStatuses.Unregistered, "未登録" },
            };
    }
}
