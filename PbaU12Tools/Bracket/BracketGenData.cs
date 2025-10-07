using PbaU12Tools.Bracket;
using PbaU12Tools.Xml;
using System.Runtime.CompilerServices;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenData
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

        #region メソッド
        //public BracketGenData Clone()
        //{
        //    BracketGenData newBracketGenData =
        //        new BracketGenData()
        //        {
        //            Status = this.Status,
        //            TournamentName = this.TournamentName,
        //            BaseDataBoys = this.BaseDataBoys.Clone(),
        //            BaseDataGirls = this.BaseDataGirls.Clone(),
        //            VenueDatas = this.VenueDatas.Clone(),
        //            FinalLeague = this.FinalLeague,
        //            District = this.District,
        //            OpenDisplayFrame = this.OpenDisplayFrame,
        //        };

        //    return newBracketGenData;
        //}

        public string? Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string? Serialize(BracketGenData bracketGenData)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(BracketGenData));
                string xmlText = xmlSerializer.Serialize(bracketGenData);

                return xmlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "大会情報データのシリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static BracketGenData? Deserialize(
            Categories category,
            string? bracketGenDataFilePath = null)
        {
            BracketGenData? BracketGenData = null;

            try
            {
                string filePath;
                if (string.IsNullOrEmpty(bracketGenDataFilePath))
                {
                    filePath =
                        Path.Combine(
                            CommonTools.TournamentDatasFolderPath, CommonValues.BracketGenDataFileName(category));
                }
                else
                {
                    filePath = bracketGenDataFilePath;
                }

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    KbU12XmlSerializer xmlSerializer = new(typeof(BracketGenData));
                    BracketGenData = (BracketGenData)xmlSerializer.Deserialize(xmlText)!;
                    if (BracketGenData == null)
                    {
                        if (xmlSerializer.ExceptionData != null)
                        {
                            MessageBox.Show(
                                "大会情報データの逆シリアル化に失敗しました。" + Environment.NewLine +
                                Environment.NewLine + xmlSerializer.ExceptionData.Message,
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }

                return BracketGenData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "大会情報データの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return BracketGenData;
            }
        }
        #endregion
    }
}
