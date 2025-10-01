using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistTourney
{
    internal class DistTourneyConst
    {
        public const string DistTourneyDataFolder = "DistTourney";

        //
        // disttourney_9999_ＮＮＮＮＮＮＮＮ.xml
        //  9999：西暦年度（ex.2025）
        //  ＮＮＮＮＮＮＮＮ：大会名称
        //
        public const string TournamentFileNameFormat = "disttourney_{0}_{1}.xml";
    }
}
