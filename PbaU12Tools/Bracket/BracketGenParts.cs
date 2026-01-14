using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenerator
    {
        #region ローカル・メソッド

        /// <summary>
        /// トーナメント表の必要な列数を求める
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        private int getNumberOfBracketColumn(Categories category)
        {
            // todo : 2025-10-31未調整
            int cols =
                (ExcelTournamentBracket.COL_TEAM +
                 ExcelTournamentBracket.COL_NUMBER) * 2 +
                 ExcelTournamentBracket.FINAL_SPACE_COLUMNS * 2;
            //if (TourneyData.District)
            //{
            //    cols += ExcelTournamentBracket.COL_DISTRICT * 2;
            //}

            //BracketData bracketData = null;
            //if (TourneyData.BrackectDataDic.TryGetValue(category, out bracketData))
            //{
            //    cols += (GenDataBoys.AllDataInfo!.Round - 1) * 2;
            //}
            //if (TourneyData.FinalLeague)
            //{
            //    // 決勝リーグ枠を確保
            //    cols += ExcelTournamentBracket.FINAL_LEAGUE_SPACE_COLUMNS;
            //}
            //else
            //{
            //    // 決勝
            //    cols += 2;
            //}
            return cols;
        }

        /// <summary>
        /// 左右の山の開始位置となるセルを求める
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="category"></param>
        /// <param name="bracketSide"></param>
        /// <returns></returns>
        private IXLCell getBracketStartCell(IXLWorksheet worksheet, Categories category, BracketSide bracketSide)
        {
            // todo : 2025-10-31未調整

            // カラム
            int startColumn = ExcelTournamentBracket.DEFAULT_LEFT_COLUMN_MARGIN + 1;
            int startRow = ExcelTournamentBracket.CATEGORY_ROW + 3;
/*
            if (category == Categories.Girls)
            {
                // 女子
                //startColumn += getNumberOfBracketColumn(Categories.Boys);
                startColumn++;
            }
            if (bracketSide == BracketSide.Left)
            {
                // 左側
                startColumn +=
                    ExcelTournamentBracket.COL_TEAM +
                    ExcelTournamentBracket.COL_NUMBER;
                if (TourneyData.District)
                {
                    startColumn += ExcelTournamentBracket.COL_DISTRICT;
                }
                startColumn++;
            }
            else
            {
                // 右側
                startColumn +=
                    ExcelTournamentBracket.COL_TEAM +
                    ExcelTournamentBracket.COL_NUMBER +
                    ExcelTournamentBracket.FINAL_SPACE_COLUMNS * 2;
                if (TourneyData.District)
                {
                    startColumn += ExcelTournamentBracket.COL_DISTRICT;
                }
                BracketData bracketData;
                if (TourneyData.BrackectDataDic.TryGetValue(category, out bracketData))
                {
                    // 勝ち上がり部分
                    startColumn += (bracketData.AllDataInfo.Round - 1) * 2;
                }
                if (TourneyData.FinalLeague)
                {
                    // 決勝リーグ枠を確保
                    startColumn += ExcelTournamentBracket.FINAL_LEAGUE_SPACE_COLUMNS;
                }
                else
                {
                    // 決勝
                    startColumn += 2;
                }
            }
*/
            IXLCell startCell = worksheet.Cell(startRow, startColumn);
            return startCell;
        }

        /// <summary>
        // 左側の山で、両方がシードとなっているパターンをセルを使って作成する
        // ━──┐
        //       │
        // ───┘
        /// </summary>
        /// <param name="xlApp"></param>
        /// <param name="worksheet"></param>
        /// <param name="categoryPrefix"></param>
        private IXLCell LeftDoubleSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLCell rule1;
            IXLCell rule2;

            // 得点欄
            // 上側の得点欄
            rule1 = startCell.CellRight(1);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, true);
            // 上側の横線
            tempRange1 = worksheet.Range(rule1.CellLeft(1), rule1);
            tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            // ゲーム番号
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            // 上位のヤマのためのフラグ用の仮の値
            rule1.CellRight(1).CellBelow(RowIncriment / 2).Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;
            // 下側の得点欄
            rule2 = tempRange1.LastCell().CellBelow(1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, false);
            // 下側の横線
            tempRange1 = worksheet.Range(rule2.CellLeft(1), rule2);
            tempRange1.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());

            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[]
                {
                    rule1.CellLeft(1), rule1
                },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[]
                {
                    rule2.CellLeft(1), rule2
                },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1.CellRight(1).CellBelow(RowIncriment / 2) },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 2);
            return nextCell;
        }

        /// <summary>
        // 左側の山で、シード部分がないパターンをセルを使って作成する
        //  ─┐
        //    ├─┐
        //  ─┘  │
        //        │
        //  ─┐  │
        //    ├─┘
        //  ─┘
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell LeftNoSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLCell rule1;
            IXLCell rule2;

            //----------------------
            // 上側のノーシード部分
            //----------------------
            // 上側の得点欄
            rule1 = startCell;
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1 },
                CellBorders.Bottom);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2 },
                CellBorders.Top);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule1.CellRight(1).CellBelow(PointCellOffset) },
                CellBorders.Bottom);

            //----------------------
            // 下側のノーシード部分
            //----------------------
            // 上側の得点欄
            rule1 = rule2.CellBelow(RowIncriment - 1);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1 },
                CellBorders.Bottom);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2 },
                CellBorders.Top);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2.CellRight(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // ２回戦部分
            //------------
            // 上側の得点欄
            rule1 = startCell.CellRight(1).CellBelow(PointCellOffset);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment * 2 + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule2.CellAbove(1));
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            // ゲーム番号
            tempRange1 = worksheet.Range(rule1.CellBelow(RowIncriment), rule1.CellBelow(RowIncriment + 1)).Merge(false);
            // 上位のヤマのためのフラグ用の仮の値
            rule1.CellRight(1).CellBelow(RowIncriment).Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            cells.Clear();
            for (int i = 1; i <= RowIncriment; i++)
            {
                cells.Add(rule1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (int i = 1; i <= RowIncriment; i++)
            {
                cells.Add(rule2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1.CellRight(1).CellBelow(RowIncriment) },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 4);
            return nextCell;
        }

        /// <summary>
        /// 左側の山で、上側がシードとなっているパターンのヤマをセルを使って作成する
        ///  ━──┐
        ///  ─┐  │
        ///    ├─┘
        ///  ─┘
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell LeftAboveSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLRange tempRange2;
            IXLCell rule1_1;
            IXLCell rule1_2;
            IXLCell rule2_1;
            IXLCell rule2_2;

            //----------------
            // ノーシード部分
            //----------------
            // 上側の得点欄
            rule1_1 = startCell.CellBelow(RowIncriment);
            rule1_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1_1.CellBelow(1), rule1_1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule1_2 = rule1_1.CellBelow(RowIncriment + 1);
            rule1_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule1_2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1_1.AsRange(), rule1_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_1 },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                new IXLCell[] { rule1_2 },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_2.CellRight(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // シード部分
            //------------
            // 上側の得点欄
            rule2_1 = startCell.CellRight(1);
            rule2_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, true);
            // 上側の横線
            tempRange1 = worksheet.Range(startCell, startCell.CellRight(1));
            tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule2_1.CellBelow(1), rule2_1.CellBelow(RowIncriment + RowIncriment / 2));
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            // シードとノーシードを繋ぐ横線
            tempRange1.LastCell().Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // シードの下側の得点欄
            rule2_2 = tempRange1.LastCell().CellBelow(1);
            rule2_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, false);
            // ゲーム番号用にマージ
            int tempRow0 =
                (tempRange1.LastCell().Address.RowNumber -
                 tempRange1.FirstCell().Address.RowNumber + 1) / 2;
            tempRange2 =
                worksheet.Range(
                    tempRange1.FirstCell().CellBelow(tempRow0 - 1),
                    tempRange1.FirstCell().CellBelow(tempRow0)).Merge(false);
            tempRange2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // 上位のヤマのためのフラグ用の仮の値
            IXLCell connectCell = tempRange1.FirstCell().CellBelow(tempRow0 - 1).CellRight();
            connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule2_1.AsRange(), rule2_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                new IXLCell[] { startCell, startCell.CellRight(1) },
                CellBorders.Bottom);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_1.CellRight(1).CellBelow(1);
                 tempCell0.Address.RowNumber <= connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellBelow())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_2.CellRight(1).CellAbove(1);
                 tempCell0.Address.RowNumber > connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellAbove())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                new IXLCell[] { connectCell },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 3);
            return nextCell;
        }

        /// <summary>
        /// 左側の山で、下側がシードとなっているパターンをセルを使って作成する
        ///  ━┐
        ///    ├─┐
        ///  ─┘  │
        ///  ───┘
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell LeftBelowSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLRange tempRange2;
            IXLCell rule1_1;
            IXLCell rule1_2;
            IXLCell rule2_1;
            IXLCell rule2_2;

            //----------------
            // ノーシード部分
            //----------------
            // 上側の得点欄
            rule1_1 = startCell;
            rule1_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1_1.CellBelow(1), rule1_1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule1_2 = rule1_1.CellBelow(RowIncriment + 1);
            rule1_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule1_2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1_1.AsRange(), rule1_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_1 },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                new IXLCell[] { rule1_2 },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_1.CellRight(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_2.CellRight(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine2(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_2.CellRight(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // シード部分
            //------------
            // 上側の得点欄
            rule2_1 = startCell.CellRight(1).CellBelow(RowIncriment / 2);
            rule2_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, true);
            // シードとノーシードを繋ぐ横線
            rule2_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule2_1.CellBelow(1), rule2_1.CellBelow(RowIncriment * 3 / 2));
            tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            // 下側の得点欄
            rule2_2 = tempRange1.LastCell().CellBelow(1);
            rule2_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, false);
            // ゲーム番号用にマージ
            int tempRow0 =
                (tempRange1.LastCell().Address.RowNumber -
                 tempRange1.FirstCell().Address.RowNumber + 1) / 2;
            tempRange2 =
                worksheet.Range(
                    tempRange1.LastCell().CellAbove(tempRow0),
                    tempRange1.LastCell().CellAbove(tempRow0 - 1)).Merge(false);
            tempRange2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // 上位のヤマのためのフラグ用の仮の値
            IXLCell connectCell = tempRange1.LastCell().CellAbove(tempRow0).CellRight();
            connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 下側の横線
            tempRange1 = worksheet.Range(rule2_2.CellLeft(1), rule2_2);
            tempRange1.Style.Border.TopBorder = XLBorderStyleValues.Thin;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule2_1.AsRange(), rule2_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            cells.Clear();
            for (IXLCell tempCell0 = rule2_1.CellRight(1).CellBelow(1);
                 tempCell0.Address.RowNumber <= connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellBelow())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_2.CellRight(1).CellAbove(1);
                 tempCell0.Address.RowNumber > connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellAbove())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                cells.ToArray(),
                CellBorders.Left);
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                new IXLCell[] { rule2_2.CellLeft(1), rule2_2 },
                CellBorders.Top);
            SetFormatConditionLine2(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                new IXLCell[] { connectCell },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 3);
            return nextCell;
        }

        /// <summary>
        /// 右側の山で、両方がシードとなっているパターンをセルを使って作成する
        /// ┌──━
        /// │
        /// └───
        /// </summary>
        /// <param name="xlApp"></param>
        /// <param name="worksheet"></param>
        /// <param name="categoryPrefix"></param>
        private IXLCell RightDoubleSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLCell rule1;
            IXLCell rule2;

            // 得点欄
            // 上側の得点欄
            rule1 = startCell.CellLeft(1);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, true);
            // 上側の横線
            tempRange1 = worksheet.Range(rule1, rule1.CellRight(1));
            tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            // ゲーム番号
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            // 上位のヤマのためのフラグ用の仮の値
            rule1.CellLeft(1).CellBelow(RowIncriment / 2).Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;
            // 下側の得点欄
            rule2 = tempRange1.LastCell().CellBelow(1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 2, false);
            // 下側の横線
            tempRange1 = worksheet.Range(rule2, rule2.CellRight(1));
            tempRange1.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());

            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[]
                {
                    rule1, rule1.CellRight(1)
                },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[]
                {
                    rule2, rule2.CellRight(1)
                },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1.CellLeft(1).CellBelow(RowIncriment / 2) },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 2);
            return nextCell;
        }

        /// <summary>
        // 右側の山で、シード部分がないパターンをセルを使って作成す
        //      ┌━
        //  ┌─┤
        //  │  └─
        //  │
        //  │  ┌─
        //  └─┤
        //      └─
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell RightNoSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLCell rule1;
            IXLCell rule2;

            //----------------------
            // 上側のノーシード部分
            //----------------------
            // 上側の得点欄
            rule1 = startCell;
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1 },
                CellBorders.Bottom);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i < NumOfVLine; i++)
            {
                cells.Add(rule1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2 },
                CellBorders.Top);
            cells.Clear();
            for (int i = 1; i < NumOfVLine; i++)
            {
                cells.Add(rule2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule1.CellLeft(1).CellBelow(PointCellOffset) },
                CellBorders.Bottom);

            //----------------------
            // 下側のノーシード部分
            //----------------------
            // 上側の得点欄
            rule1 = rule2.CellBelow(RowIncriment - 1);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1 },
                CellBorders.Bottom);
            cells.Clear();
            for (int i = 1; i < RowIncriment - 1; i++)
            {
                cells.Add(rule1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2 },
                CellBorders.Top);
            cells.Clear();
            for (int i = 1; i < RowIncriment - 1; i++)
            {
                cells.Add(rule2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                new IXLCell[] { rule2.CellLeft(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // ２回戦部分
            //------------
            // 上側の得点欄
            rule1 = startCell.CellLeft(1).CellBelow(PointCellOffset);
            rule1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, true);
            // 上側の横線
            rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 下側の得点欄
            rule2 = rule1.CellBelow(RowIncriment * 2 + 1);
            rule2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignRight, 1, false);
            // 下側の横線
            rule2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule1.CellBelow(1), rule2.CellAbove(1));
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            // ゲーム番号
            tempRange1 = worksheet.Range(rule1.CellBelow(RowIncriment), rule1.CellBelow(RowIncriment + 1)).Merge(false);
            // 上位のヤマのためのフラグ用の仮の値
            rule1.CellLeft(1).CellBelow(RowIncriment).Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            cells.Clear();
            for (int i = 1; i <= RowIncriment; i++)
            {
                cells.Add(rule1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (int i = 1; i <= RowIncriment; i++)
            {
                cells.Add(rule2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule2.AsRange(), rule1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule1.AsRange(), rule2.AsRange(),
                new IXLCell[] { rule1.CellLeft(1).CellBelow(RowIncriment) },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 4);
            return nextCell;
        }

        /// <summary>
        /// 右側の山で、上側がシードとなっているパターンのヤマをセルを使って作成する
        ///  ┌──━
        ///  │  ┌─
        ///  └─┤
        ///      └─
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell RightAboveSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLRange tempRange2;
            IXLCell rule1_1;
            IXLCell rule1_2;
            IXLCell rule2_1;
            IXLCell rule2_2;

            //----------------
            // ノーシード部分
            //----------------
            // 上側の得点欄
            rule1_1 = startCell.CellBelow(RowIncriment);
            rule1_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 1, true);
            // 上側の横線
            rule1_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1_1.CellBelow(1), rule1_1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule1_2 = rule1_1.CellBelow(RowIncriment + 1);
            rule1_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 1, false);
            // 下側の横線
            rule1_2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1_1.AsRange(), rule1_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_1 },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                new IXLCell[] { rule1_2 },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_2.CellLeft(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // シード部分
            //------------
            // 上側の得点欄
            rule2_1 = startCell.CellLeft(1);
            rule2_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 2, true);
            // 上側の横線
            tempRange1 = worksheet.Range(startCell, startCell.CellLeft(1));
            tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule2_1.CellBelow(1), rule2_1.CellBelow(RowIncriment + RowIncriment / 2));
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            // シードとノーシードを繋ぐ横線
            tempRange1.LastCell().Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // シードの下側の得点欄
            rule2_2 = tempRange1.LastCell().CellBelow(1);
            rule2_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 2, false);
            // ゲーム番号用にマージ
            int tempRow0 =
                (tempRange1.LastCell().Address.RowNumber -
                 tempRange1.FirstCell().Address.RowNumber + 1) / 2;
            tempRange2 =
                worksheet.Range(
                    tempRange1.FirstCell().CellBelow(tempRow0 - 1),
                    tempRange1.FirstCell().CellBelow(tempRow0)).Merge(false);
            tempRange2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // 上位のヤマのためのフラグ用の仮の値
            IXLCell connectCell = tempRange1.FirstCell().CellBelow(tempRow0 - 1).CellLeft();
            connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule2_1.AsRange(), rule2_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                new IXLCell[] { startCell, startCell.CellLeft(1) },
                CellBorders.Bottom);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_1.CellLeft(1).CellBelow(1);
                 tempCell0.Address.RowNumber <= connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellBelow())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_2.CellLeft(1).CellAbove(1);
                 tempCell0.Address.RowNumber > connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellAbove())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                new IXLCell[] { connectCell },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 3);
            return nextCell;
        }

        /// <summary>
        /// 右側の山で、下側がシードとなっているパターンをセルを使って作成する関数
        ///      ┌━
        ///  ┌─┤
        ///  │  └─
        ///  └───
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="startCell"></param>
        /// <param name="categoryPrefix"></param>
        /// <returns></returns>
        private IXLCell RightBelowSeed(
            IXLWorksheet worksheet,
            IXLCell startCell,
            string categoryPrefix)
        {
            IXLRange tempRange1;
            IXLRange tempRange2;
            IXLCell rule1_1;
            IXLCell rule1_2;
            IXLCell rule2_1;
            IXLCell rule2_2;

            //----------------
            // ノーシード部分
            //----------------
            // 上側の得点欄
            rule1_1 = startCell;
            rule1_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule1, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 1, true);
            // 上側の横線
            rule1_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // マージして右側の縦線
            tempRange1 = worksheet.Range(rule1_1.CellBelow(1), rule1_1.CellBelow(RowIncriment)).Merge(false);
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            tempRange1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;

            // 下側の得点欄
            rule1_2 = rule1_1.CellBelow(RowIncriment + 1);
            rule1_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule1_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule1_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    rule2, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 1, false);
            // 下側の横線
            rule1_2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule1_1.AsRange(), rule1_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_1 },
                CellBorders.Bottom);
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                new IXLCell[] { rule1_2 },
                CellBorders.Top);
            List<IXLCell> cells = new List<IXLCell>();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_1.CellLeft(1).CellBelow(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (int i = 1; i <= RowIncriment / 2; i++)
            {
                cells.Add(rule1_2.CellLeft(1).CellAbove(i));
            }
            SetFormatConditionLine(
                worksheet, rule1_2.AsRange(), rule1_1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine2(
                worksheet, rule1_1.AsRange(), rule1_2.AsRange(),
                new IXLCell[] { rule1_2.CellLeft(1).CellAbove(PointCellOffset) },
                CellBorders.Top);

            //------------
            // シード部分
            //------------
            // 上側の得点欄
            rule2_1 = startCell.CellLeft(1).CellBelow(RowIncriment / 2);
            rule2_1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_1.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 2, true);
            // シードとノーシードを繋ぐ横線
            rule2_1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // 縦線
            tempRange1 = worksheet.Range(rule2_1.CellBelow(1), rule2_1.CellBelow(RowIncriment * 3 / 2));
            tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            // 下側の得点欄
            rule2_2 = tempRange1.LastCell().CellBelow(1);
            rule2_2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            rule2_2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_POINT;
            rule2_2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            //SetNameOfPointCell(
            //    startCell, categoryPrefix, ExcelApp.XlHAlign.xlHAlignLeft, 2, false);
            // ゲーム番号用にマージ
            int tempRow0 =
                (tempRange1.LastCell().Address.RowNumber -
                 tempRange1.FirstCell().Address.RowNumber + 1) / 2;
            tempRange2 =
                worksheet.Range(
                    tempRange1.LastCell().CellAbove(tempRow0),
                    tempRange1.LastCell().CellAbove(tempRow0 - 1)).Merge(false);
            tempRange2.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            tempRange2.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_GAME;
            tempRange2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRange2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // 上位のヤマのためのフラグ用の仮の値
            IXLCell connectCell = tempRange1.LastCell().CellAbove(tempRow0).CellLeft();
            connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

            // 下側の横線
            tempRange1 = worksheet.Range(rule2_2.CellRight(1), rule2_2);
            tempRange1.Style.Border.TopBorder = XLBorderStyleValues.Thin;

            // 点数欄の条件付き書式
            SetFormatConditionPoint(worksheet, rule2_1.AsRange(), rule2_2.AsRange());
            // 勝ち上がり罫線の条件付き書式
            cells.Clear();
            for (IXLCell tempCell0 = rule2_1.CellLeft(1).CellBelow(1);
                 tempCell0.Address.RowNumber <= connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellBelow())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            cells.Clear();
            for (IXLCell tempCell0 = rule2_2.CellLeft(1).CellAbove(1);
                 tempCell0.Address.RowNumber > connectCell.Address.RowNumber;
                 tempCell0 = tempCell0.CellAbove())
            {
                cells.Add(tempCell0);
            }
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                cells.ToArray(),
                CellBorders.Right);
            SetFormatConditionLine(
                worksheet, rule2_2.AsRange(), rule2_1.AsRange(),
                new IXLCell[] { rule2_2, rule2_2.CellRight(1) },
                CellBorders.Top);
            SetFormatConditionLine2(
                worksheet, rule2_1.AsRange(), rule2_2.AsRange(),
                new IXLCell[] { connectCell },
                CellBorders.Bottom);

            // 次のヤマのためのセル情報
            IXLCell nextCell = startCell.CellBelow(RowIncriment * 3);
            return nextCell;
        }
        #endregion
    }
}
