using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PbaU12Tools
{
    public class TournamentNameData
    {
        /// <summary>
        /// 大会名称（回数を含まない）
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// 男子チーム数固定
        /// </summary>
        public int FixedNumOfBoysTeams { get; set; }
        /// <summary>
        /// 女子チーム数固定
        /// </summary>
        public int FixedNumOfGirlsTeams { get; set; }

        public string GetFullName(int numOfTimes)
        {
            string tournamentName = GetFullName(Name, numOfTimes);
            return tournamentName;
        }

        public static string GetFullName(string name, int numOfTimes)
        {
            string tournamentName =
                (numOfTimes != 0 ? "第" + numOfTimes.ToString() + "回" : "") + name;
            return tournamentName;
        }
    }

    public class TournamentNameDatas
    {
        public List<TournamentNameData>? TournamentNameDatasList { get; set; } = [];

        public static TournamentNameDatas? Deserialize(
            string? tournamentNameDatasFilePath = null)
        {
            TournamentNameDatas? tournamentNameDatas = null;

            try
            {
                string filePath;
                if (string.IsNullOrEmpty(tournamentNameDatasFilePath))
                {
                    filePath =
                        Path.Combine(
                            CommonTools.DataFolderPath, CommonValues.TournamentNameDatasFileName);
                }
                else
                {
                    filePath = tournamentNameDatasFilePath;
                }

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    KbU12XmlSerializer xmlSerializer = new(typeof(TournamentNameDatas));
                    tournamentNameDatas = (TournamentNameDatas)xmlSerializer.Deserialize(xmlText)!;
                    if (tournamentNameDatas == null)
                    {
                        if (xmlSerializer.ExceptionData != null)
                        {
                            MessageBox.Show(
                                "大会名データの逆シリアル化に失敗しました。" + Environment.NewLine +
                                Environment.NewLine + xmlSerializer.ExceptionData.Message,
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }

                return tournamentNameDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "大会名データの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return tournamentNameDatas;
            }
        }
    }
}
