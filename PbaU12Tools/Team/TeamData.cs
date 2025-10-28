using PbaU12Tools.Venue;
using PbaU12Tools.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public partial class TeamData
    {
        public string JbaTeamID { get; set; } = string.Empty;
        public string TeamName { get; set; } = string.Empty;
        public string TeamNameKana { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string ShortNameKana { get; set; } = string.Empty;
        public Categories Category { get; set; }
        public JbaTeamRegistrationStatuses JbaStatus { get; set; } = JbaTeamRegistrationStatuses.Unknown;
        public Districts District { get; set; }
        public string ValidityPeriodSt { get; set; } = string.Empty;
        public string ValidityPeriodEd { get; set; } = string.Empty;
    }

    public partial class TeamDatas
    {
        public Categories Category { get; set; }
        public List<TeamData>? TeamDatasList { get; set; } = [];

        public string? Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string? Serialize(TeamDatas teamDatas)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(TeamDatas));
                string xmlText = xmlSerializer.Serialize(teamDatas);

                return xmlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "チームデータのシリアライズに失敗しました。",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static TeamDatas? Deserialize(string xmlText)
        {
            TeamDatas? teamDatas = null;

            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(TeamDatas));
                teamDatas = (TeamDatas)xmlSerializer.Deserialize(xmlText)!;
                if (teamDatas == null)
                {
                    if (xmlSerializer.ExceptionData != null)
                    {
                        MessageBox.Show(
                            "チームデータの逆シリアル化に失敗しました。" + Environment.NewLine +
                            Environment.NewLine + xmlSerializer.ExceptionData.Message,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                return teamDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "チームデータの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return teamDatas;
            }
        }

        public static TeamDatas? DeserializeTeamDatas(Categories category, string? teamDataFilePath = null)
        {
            TeamDatas? teamDatas = null;

            try
            {
                string filePath;
                if (string.IsNullOrEmpty(teamDataFilePath))
                {
                    filePath =
                        Path.Combine(
                            CommonTools.DataFolderPath,
                            CommonValues.TeamDatasFileName(category));
                }
                else
                {
                    filePath = teamDataFilePath;
                }

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    teamDatas = TeamDatas.Deserialize(xmlText)!;
                }

                return teamDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "チームデータの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "TeamDatas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return teamDatas;
            }
        }

        public static bool loadTeamDatas(out TeamDatas? teamDatasBoys, out TeamDatas? teamDatasGirls)
        {
            teamDatasBoys = null;
            teamDatasGirls = null;

            try
            {
                teamDatasBoys = TeamDatas.DeserializeTeamDatas(Categories.Boys);

                teamDatasGirls = TeamDatas.DeserializeTeamDatas(Categories.Girls);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "チームデータがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
