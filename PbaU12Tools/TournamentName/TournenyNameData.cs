using PbaU12Tools.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PbaU12Tools.TournamentName
{
    public class TourneyNameData
    {
        /// <summary>
        /// 大会名称（回数を含まない）
        /// </summary>
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }
        /// <summary>
        /// 男子チーム数固定
        /// </summary>
        public int FixedNumOfBoysTeams { get; set; }
        /// <summary>
        /// 女子チーム数固定
        /// </summary>
        public int FixedNumOfGirlsTeams { get; set; }
    }

    public class TourneyNameDatas
    {
        public List<TourneyNameData>? TourneyNameDatasList { get; set; } = [];

        public string? Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string? Serialize(TourneyNameDatas tourneyNameDatas)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(TourneyNameDatas));
                string xmlText = xmlSerializer.Serialize(tourneyNameDatas);

                return xmlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "大会名データのシリアライズに失敗しました。",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static TourneyNameDatas? Deserialize(string xmlText)
        {
            TourneyNameDatas? tourneyNameDatas = null;

            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(TourneyNameDatas));
                tourneyNameDatas = (TourneyNameDatas)xmlSerializer.Deserialize(xmlText)!;
                if (tourneyNameDatas == null)
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

                return tourneyNameDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "大会名データの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return tourneyNameDatas;
            }
        }
    }
}
