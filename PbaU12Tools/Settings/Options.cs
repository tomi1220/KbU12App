using PbaU12Tools.TournamentName;
using PbaU12Tools.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace PbaU12Tools.Settings
{
    public class Options
    {
        public bool RestoreLastStateWhenStarting { get; set; }

        public string Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string Serialize(Options options)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(Options));
                string xmlText = xmlSerializer.Serialize(options)!;

                return xmlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "オプションデータのシリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }
        }


        public static TournamentNameDatas? Deserialize(string xmlText)
        {
            TournamentNameDatas? tournamentNameDatas = null;

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

            return tournamentNameDatas;
        }
    }
}
