using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    /// <summary>
    /// 大会情報
    /// </summary>
    public class TournamentData
    {
        public enum UsageCls
        {
            None = 0,
            ForLottery = 1,
            ForDraw = 2,
            ForTournament = 3
        }

        /// <summary>
        /// 用途
        /// </summary>
        public UsageCls Usage { get; set; } = UsageCls.None;

        /// <summary>
        /// 大会名称
        /// </summary>
        public string TournamentName { get; set; } = string.Empty;

        /// <summary>
        /// 地区名称の表示
        /// </summary>
        public bool District { get; set; }
        /// <summary>
        /// BEST4で決勝リーグ
        /// </summary>
        public bool FinalLeague { get; set; }
        /// <summary>
        /// オープン参加表示枠
        /// </summary>
        public bool OpenDisplayFrame { get; set; }
        public List<VenueItemData> VenueDatas { get; set; } = [];
        public Dictionary<Category, BracketData> BrackectDataDic { get; set; } = [];
        public List<MatchData>? MatchDatas { get; set; }
    }
}
