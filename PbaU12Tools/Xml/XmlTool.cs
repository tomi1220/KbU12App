using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace PbaU12Tools.Xml
{
    public class KbU12XmlSerializer
    {
        #region フィールド

        #endregion

        #region コンストラクタ
        public KbU12XmlSerializer()
        {
            ExceptionData = null;
        }
        public KbU12XmlSerializer(Type objectType)
        {
            ExceptionData = null;
            ClassType = objectType;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 逆シリアル化するクラス
        /// </summary>
        [XmlIgnore]
        public Encoding Encoding { get; set; } = Encoding.UTF8;
        /// <summary>
        /// 逆シリアル化するクラス
        /// </summary>
        [XmlIgnore]
        public Type ClassType { get; set; } = typeof(object);
        /// <summary>
        /// 例外情報
        /// </summary>
        [XmlIgnore]
        public Exception? ExceptionData { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// シリアライズ
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        //protected bool Serialize()
        public string Serialize(object targetObj)
        {
            string xmlText = string.Empty;
            MemoryStream? stream = null;

            try
            {
                // objectType型の XmlSerializer を作成
                XmlSerializer xmlSerializer = new(ClassType);

                XmlSerializerNamespaces ns = new();
                ns.Add(string.Empty, string.Empty);

                stream = new MemoryStream();
                xmlSerializer.Serialize(stream, targetObj, ns);

                xmlText = Encoding.GetString(stream.ToArray());
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message, "Error(Exception)");
#endif
                ExceptionData = ex;
            }
            finally
            {
                // FileStream が開いている場合は閉じる
                stream?.Dispose();
            }
            return xmlText;
        }

        /// <summary>
        /// 逆シリアライズ
        /// </summary>
        /// <returns></returns>
        //protected object Deserialize(string xmlText)
        public object? Deserialize(string xmlText)
        {
            MemoryStream? stream = null;
            object? clsObject = null;
            ExceptionData = null;

            try
            {
                // 文字列をバイト配列にエンコードする
                byte[] byteArray = Encoding.GetBytes(xmlText);

                // byte配列から、メモリを使用するストリームを作成する　
                stream = new MemoryStream(byteArray);

                // objectTypeで表される型の XmlSerializer を作成
                XmlSerializer xmlSerializer = new(ClassType);

                // 
                clsObject = xmlSerializer.Deserialize(stream);

            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message, "Error(Exception)");
#endif
                ExceptionData = ex;
            }
            finally
            {
                stream?.Dispose();
            }

            return clsObject;
        }
        #endregion
    }
}
