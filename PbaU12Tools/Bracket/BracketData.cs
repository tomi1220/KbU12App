using PbaU12Tools.Match;

namespace PbaU12Tools.Bracket
{
    public class BracketData
    {
        #region クラス
        public class RoundData
        {
            public int[] Slots { get; set; } = new int[2];
            public MatchData? Match { get; set; }
        }
        #endregion

        #region プロパティ
        #endregion
    }
}
