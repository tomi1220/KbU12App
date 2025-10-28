using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClosedXML.Excel;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenerator
    {
        private string ConvertAbsoluteAddress(IXLCell cell)
        {
            return "$" + cell.Address.ColumnLetter + "$" + cell.Address.RowNumber.ToString();
        }

        #region 条件付き書式
        /// <summary>
        /// 点数欄セルの条件付き書式を設定する
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="rule1"></param>
        /// <param name="rule2"></param>
        /// <param name="absolute"></param>
        private void SetFormatConditionPoint(
            IXLWorksheet workSheet, IXLRange rule1, IXLRange rule2, bool absolute = false)
        {
            string adr1 = string.Empty;
            string adr2 = string.Empty;
            if (!absolute)
            {
                adr1 = rule1.Cell(1, 1).Address.ToString();
                adr2 = rule2.Cell(1, 1).Address.ToString();
            }
            else
            {
                adr1 = ConvertAbsoluteAddress(rule1.Cell(1, 1));
                adr2 = ConvertAbsoluteAddress(rule2.Cell(1, 1));
            }

            rule1.AddConditionalFormat().WhenIsTrue("=" + adr1 + ">" + adr2).Font.SetFontColor(XLColor.Red);
            rule2.AddConditionalFormat().WhenIsTrue("=" + adr1 + "<" + adr2).Font.SetFontColor(XLColor.Red);
        }

        /// <summary>
        /// 勝ち上がり罫線の条件付き書式を設定する
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="rule1"></param>
        /// <param name="rule2"></param>
        /// <param name="targetCells"></param>
        /// <param name="border"></param>
        /// <param name="absolute"></param>
        private void SetFormatConditionLine(
            IXLWorksheet workSheet,
            IXLRange rule1,
            IXLRange rule2,
            IXLCell[] targetCells,
            CellBorders border,
            bool absolute = false)
        {
            string formula = string.Empty;
            if (!absolute)
            {
                formula = "=" + rule1.Cell(1, 1).Address.ToString() + ">" + rule2.Cell(1, 1).Address.ToString();
            }
            else
            {
                formula = "=" + ConvertAbsoluteAddress(rule1.Cell(1, 1)) + ">" + ConvertAbsoluteAddress(rule2.Cell(1, 1));
            }

            foreach (var c in targetCells)
            {
                switch (border)
                {
                    case CellBorders.Bottom:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula).Border.SetBottomBorder(XLBorderStyleValues.Thin)
                                .Border.SetBottomBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Right:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetRightBorder(XLBorderStyleValues.Thin)
                                .Border.SetRightBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Top:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                                .Border.SetTopBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Left:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                                .Border.SetLeftBorderColor(XLColor.Red);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 勝ち上がり罫線の条件付き書式を設定する（２）
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="rule1"></param>
        /// <param name="rule2"></param>
        /// <param name="targetCells"></param>
        /// <param name="border"></param>
        /// <param name="absolute"></param>
        private void SetFormatConditionLine2(
            IXLWorksheet workSheet,
            IXLRange rule1,
            IXLRange rule2,
            IXLCell[] targetCells,
            CellBorders border,
            bool absolute = false)
        {
            string formula = string.Empty;
            if (!absolute)
            {
                formula = "=AND(" + rule1.Cell(1, 1).Address.ToString() + "<>\"\"," +
                                    rule2.Cell(1, 1).Address.ToString() + "<>\"\")";
            }
            else
            {
                formula = "=AND(" + ConvertAbsoluteAddress(rule1.Cell(1, 1)) + "<>\"\"," +
                                    ConvertAbsoluteAddress(rule2.Cell(1, 1)) + "<>\"\")";
            }

            foreach (var c in targetCells)
            {
                switch (border)
                {
                    case CellBorders.Bottom:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula).Border.SetBottomBorder(XLBorderStyleValues.Thin)
                                .Border.SetBottomBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Right:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetRightBorder(XLBorderStyleValues.Thin)
                                .Border.SetRightBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Top:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                                .Border.SetTopBorderColor(XLColor.Red);
                        }
                        break;
                    case CellBorders.Left:
                        {
                            c.AddConditionalFormat().WhenIsTrue(formula)
                                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                                .Border.SetLeftBorderColor(XLColor.Red);
                        }
                        break;
                }
            }
        }

        #endregion

    }
}
