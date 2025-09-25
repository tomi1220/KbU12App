using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public class VenueData
    {
        /// <summary>
        /// 会場名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// コート数
        /// </summary>
        public int NumberOfCourts { get; set; } = 0;
    }

    public class VenueDatas
    {
        public List<VenueData>? VenueDatasList { get; set; } = [];

        public string? Serialize()
        {
            string xmlText = Serialize(this)!;

            return xmlText;
        }

        public static string? Serialize(VenueDatas venueDatas)
        {
            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(VenueDatas));
                string xmlText = xmlSerializer.Serialize(venueDatas);

                return xmlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "会場データのシリアライズに失敗しました。",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static VenueDatas? Deserialize(string xmlText)
        {
            VenueDatas? venueDatas = null;

            try
            {
                KbU12XmlSerializer xmlSerializer = new(typeof(VenueDatas));
                venueDatas = (VenueDatas)xmlSerializer.Deserialize(xmlText)!;
                if (venueDatas == null)
                {
                    if (xmlSerializer.ExceptionData != null)
                    {
                        MessageBox.Show(
                            "会場データの逆シリアル化に失敗しました。" + Environment.NewLine +
                            Environment.NewLine + xmlSerializer.ExceptionData.Message,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                return venueDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "会場データの逆シリアル化に失敗しました。" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return venueDatas;
            }
        }

    }
}
