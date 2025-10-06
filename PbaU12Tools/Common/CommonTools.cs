using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public partial class CommonTools
    {
        #region プロパティ
        public static string DataFolderPath { get; set; } = string.Empty;
        public static string DocumentsFolderPath { get; set; } = string.Empty;
        public static string TournamentDatasFolderPath { get; set; } = string.Empty;
        #endregion

        public static string GetBaseFolder()
        {
            string[] folders = Application.ExecutablePath.Split(Path.DirectorySeparatorChar);
            List<string> pathCombindata = [];
            foreach (string folder in folders)
            {
                //if (folder.ToLower() == "Bin".ToLower())
                if (folder.Equals("Bin", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                pathCombindata.Add(folder);
            }
            string baseFolderPath = string.Empty;
            if (pathCombindata.Count > 0)
            {
                baseFolderPath = Path.Combine([.. pathCombindata]);
            }

            return baseFolderPath;
        }

        private static bool preparingFolder(string folder)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    // フォルダーが存在しない
                    Directory.CreateDirectory(folder);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        /// <summary>
        /// 作成したデータを格納するフォルダーを準備する
        /// </summary>
        /// <returns></returns>
        public static bool PreparingFolder()
        {
            // PbaU12\Data フォルダー
            string dataFolderPath =
                Path.Combine(GetBaseFolder(), CommonValues.BaseDataFolder);
            if (!preparingFolder(dataFolderPath))
            {
                return false;
            }
            DataFolderPath = dataFolderPath;

            // PbaU12\Documents フォルダー
            string documentsFolderPath =
                Path.Combine(GetBaseFolder(), CommonValues.DocumentsFolder);
            if (!preparingFolder(documentsFolderPath))
            {
                return false;
            }
            DocumentsFolderPath = documentsFolderPath;

            // PbaU12\Documents\TournamentDatas フォルダー
            string tournamentDatasFolderPath =
                Path.Combine(documentsFolderPath, CommonValues.TournamentDatasFolder);
            if (!preparingFolder(tournamentDatasFolderPath))
            {
                return false;
            }
            TournamentDatasFolderPath = tournamentDatasFolderPath;

            return true;
        }

        public static string TournamentFolderPath(string tournamentName)
        {
            // PbaU12\Documents\TournamentDatas\大会名 フォルダー
            string tournamentDatasFolderPath =
                Path.Combine(TournamentDatasFolderPath, tournamentName);
            if (!preparingFolder(tournamentDatasFolderPath))
            {
                return string.Empty;
            }
            return tournamentDatasFolderPath;
        }
    }
}
