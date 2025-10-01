using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PbaU12Tools.Bracket;
using PbaU12Tools.Venue;

namespace PbaU12Tools.TournamentData
{
    /// <summary>
    /// 大会情報
    /// </summary>
    public class TournamentData
    {
        #region プロパティ
        /// <summary>
        /// 進行状況
        /// </summary>
        public TournamentDataStatuses Status { get; set; } = TournamentDataStatuses.None;

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
        /// <summary>
        /// 会場データ
        /// </summary>
        public List<VenueItemData> VenueDatas { get; set; } = [];
        /// <summary>
        /// トーナメント表データ
        /// </summary>
        //public Dictionary<Category, BracketData> BrackectDataDic { get; set; } = [];
        public BracketData? BrackectDataBoys { get; set; }
        public BracketData? BrackectDataGirls { get; set; }
        /// <summary>
        /// 対戦データ
        /// </summary>
        public List<MatchData>? MatchDatas { get; set; }
        #endregion

        #region メソッド
        public string? Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string? Serialize(TournamentData tournamentData)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(TournamentData));
                string xmlText = xmlSerializer.Serialize(tournamentData);

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

        public static TournamentData? Deserialize(
            string? tournamentDataFilePath = null)
        {
            TournamentData? TournamentData = null;

            try
            {
                string filePath;
                if (string.IsNullOrEmpty(tournamentDataFilePath))
                {
                    filePath =
                        Path.Combine(
                            CommonTools.DataFolderPath, CommonValues.TournamentDataFileName);
                }
                else
                {
                    filePath = tournamentDataFilePath;
                }

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    KbU12XmlSerializer xmlSerializer = new(typeof(TournamentData));
                    TournamentData = (TournamentData)xmlSerializer.Deserialize(xmlText)!;
                    if (TournamentData == null)
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

                return TournamentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "大会情報データの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return TournamentData;
            }
        }
        #endregion
    }
}
