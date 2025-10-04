using PbaU12Tools.Bracket;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenerator
    {
        #region クラス
        /// <summary>
        /// パート毎の情報
        /// </summary>
        public class PartInfo
        {
            /// <summary>
            /// パート番号
            /// </summary>
            public int PartNumber { get; set; }
            /// <summary>
            /// チーム数
            /// </summary>
            public int NumOfTeams { get; set; } = 0;
            /// <summary>
            /// 回戦数
            /// </summary>
            public int Round { get; set; } = 0;
            /// <summary>
            /// 作業用の枠数（出場チーム数以上の最小べき数）
            /// </summary>
            public int FullFrames { get; set; } = 0;
            /// <summary>
            /// 1回戦のデータ（0は、不要な枠を表します）
            /// </summary>
            //public int[,] FirstRoundData { get; set; }
            public List<BracketData.RoundData> FirstRoundData { get; set; } = [];
            public int NumberOfElement { get; set; }
            public int[] Node { get; set; } = [0];
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// カテゴリー
        /// </summary>
        public Categories Category { get; set; }
        /// <summary>
        /// 出場チーム数
        /// </summary>
        public int NumberOfTeams { get; set; }
        /// <summary>
        /// スーパーシードチーム数
        /// </summary>
        public int NumberOfSuperSeed { get; set; } = 0;
        /// <summary>
        /// BEST4で決勝リーグ
        /// </summary>
        public bool FinalLeague { get; set; }
        /// <summary>
        /// トーナメントの山の分割数
        /// </summary>
        public int NumberOfDivisions { get; set; } = 2;

        public PartInfo? AllDataInfo { get; set; } = new();

        public List<PartInfo> PartInfos { get; set; } = [];

        public int[]? PureSeedArray { get; set; }

        #endregion
    }
}
