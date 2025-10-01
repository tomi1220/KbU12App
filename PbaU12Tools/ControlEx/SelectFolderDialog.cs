using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public partial class CommonTools
    {
        public static bool SelectFolderDialog(
            string title,
            string initialDirectory,
            string defaultFolderPath,
            out string folderPath)
        {
            folderPath = string.Empty;

            using CommonOpenFileDialog cofd = new();
            cofd.Title = "インポートする会場データファイルを選択してください。";
            cofd.Filters.Add(
                new CommonFileDialogFilter()
                {
                    DisplayName = "会場データファイル",
                    ShowExtensions = true,
                    Extensions = { "*.xml", "*.*" }
                });
            // フォルダーを選択するかどうか
            cofd.IsFolderPicker = false;
            // 対象のフォルダー
            cofd.InitialDirectory = initialDirectory;
            // 対象のフォルダーが存在しなかった場合のフォルダー
            cofd.DefaultDirectory = defaultFolderPath;

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath = cofd.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
