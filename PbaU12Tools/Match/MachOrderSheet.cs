using PbaU12Tools.Bracket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClosedXML.Excel;

namespace PbaU12Tools.Match
{
    public class MachOrderSheet
    {
        #region 定数
        #endregion

        #region フィールド
        private BracketGenData? _genData = null;
        private int _nextCol = 1;
        #endregion

        #region コンストラクタ
        public MachOrderSheet() { }
        #endregion

        #region メソッド
        public void GenerateMachOrderSheet(BracketGenData GenData)
        {
            using (var workbook = new XLWorkbook())
            {
/*
                try
                {
                    string xlsxFilePath = OutputPath;
                    workbook.SaveAs(xlsxFilePath);
                    FilePath = xlsxFilePath;

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
*/
            }
        }
        #endregion

        #region ローカル・メソッド
        private void generate()
        {

        }
        #endregion
    }
}
