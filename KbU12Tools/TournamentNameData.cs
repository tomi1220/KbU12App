using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class TournamentNameData
    {
        /// <summary>
        /// 大会名称（回数を含む）
        /// </summary>
        public string FullName { get; set; } = string.Empty;
        /// <summary>
        /// 大会名称（回数を含まない）
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// 大会名称マスターID
        /// </summary>
        public int MstTournamentNameID { get; set; }
        /// <summary>
        /// 大会回数
        /// </summary>
        public int NumOfTimes { get; set; } = 0;
        /// <summary>
        /// チーム数固定
        /// </summary>
        public int FixedNumOfTeams { get; set; }

        public static string GetFullName(string name, int numOfTimes)
        {
            string tournamentName =
                (numOfTimes != 0 ? "第" + numOfTimes.ToString() + "回" : "") + name;
            return tournamentName;
        }
    }

    public class TournamentNameDatas
    {
        public List<TournamentNameData>? TournamentNameDatasList { get; set; }
    }
}
