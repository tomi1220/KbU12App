using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PbaU12Tools.Bracket;
using PbaU12Tools.Match;
using PbaU12Tools.Venue;
using PbaU12Tools.Xml;

namespace PbaU12Tools.TournamentData
{
    /// <summary>
    /// 大会情報
    /// </summary>
    public class TournamentBaseData
    {
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

        public TournamentBaseData Clone()
        {
            TournamentBaseData newTournamentBaseData =
                new TournamentBaseData()
                {
                    Category = this.Category,
                    NumberOfTeams = this.NumberOfTeams,
                    NumberOfSuperSeed = this.NumberOfSuperSeed
                };

            return newTournamentBaseData;
        }
    }

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
        /// 男子基本情報
        /// </summary>
        public TournamentBaseData BaseDataBoys { get; set; } = new TournamentBaseData();
        /// <summary>
        /// 女子基本情報
        /// </summary>
        public TournamentBaseData BaseDataGirls { get; set; } = new TournamentBaseData();
        /// <summary>
        /// 会場データ
        /// </summary>
        public VenueItemDatas VenueDatas { get; set; } = new VenueItemDatas();
        /// <summary>
        /// BEST4で決勝リーグ
        /// </summary>
        public bool FinalLeague { get; set; }
        /// <summary>
        /// 地区名称の表示
        /// </summary>
        public bool District { get; set; }
        /// <summary>
        /// オープン参加表示枠
        /// </summary>
        public bool OpenDisplayFrame { get; set; }
        /// <summary>
        /// トーナメント表データ
        /// </summary>
        public BracketData? BrackectDataBoys { get; set; }
        public BracketData? BrackectDataGirls { get; set; }
        /// <summary>
        /// 対戦データ
        /// </summary>
        public List<MatchData>? MatchDatas { get; set; }
        #endregion

        #region メソッド
        public TournamentData Clone()
        {
            TournamentData newTournamentData =
                new TournamentData()
                {
                    Status = this.Status,
                    TournamentName = this.TournamentName,
                    BaseDataBoys = this.BaseDataBoys.Clone(),
                    BaseDataGirls = this.BaseDataGirls.Clone(),
                    VenueDatas = this.VenueDatas.Clone(),
                    FinalLeague = this.FinalLeague,
                    District = this.District,
                    OpenDisplayFrame = this.OpenDisplayFrame,
                };

            return newTournamentData;
        }

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
