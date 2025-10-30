using ClosedXML.Excel;
using PbaU12Tools.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenerator
    {
        private void generateDataSheet(IXLWorkbook _workbook)
        {
            //==================
            // 男子チームデータ
            //==================
            IXLWorksheet boysTeamsDataSheet =
                _workbook.Worksheets.Add(
                    ExcelTournamentBracket.TITLE_BOYS + ExcelTournamentBracket.TEAMDATASHEET_NAME);
            // 初期設定
            teamsDatasheetDefaultSettings(boysTeamsDataSheet);
            // チームデータを設定する
            setTeamData(boysTeamsDataSheet);

            //==================
            // 女子チームデータ
            //==================

            IXLWorksheet GameDataSheet = _workbook.Worksheets.Add(ExcelTournamentBracket.GAMEDATASHEET_NAME);

            boysTeamsDataSheet.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            boysTeamsDataSheet.Style.Font.FontSize = ExcelTournamentBracket.DATASHEET_BASE_FONT_SIZE;
            boysTeamsDataSheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            boysTeamsDataSheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            //========================================
            // 試合開始時刻／ゲーム番号重複チェック欄
            //========================================
            //CreateTimeTable();
            //======================
            // トーナメント・データ
            //======================
            //CreateTournamentData();
        }

        private void teamsDatasheetDefaultSettings(IXLWorksheet teamsDataSheet)
        {
            teamsDataSheet.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            teamsDataSheet.Style.Font.FontSize = ExcelTournamentBracket.DATASHEET_BASE_FONT_SIZE;
            teamsDataSheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            teamsDataSheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        }

        private void setTeamData(IXLWorksheet TeamDataSheet)
        {
            //==============
            // チームリスト
            //==============
            if (!TeamDatas.LoadTeamDatas(out TeamDatas? teamDatasBoysAll, out TeamDatas? teamDatasGirlsAll))
            {
                return;
            }
            if (teamDatasBoysAll == null && teamDatasGirlsAll == null)
            {
                return;
            }
            TeamDatas teamDatasBoys;
            TeamDatas teamDatasGirls;
            if (TourneyData!.TourneyType == TournamentType.PrefecturalTournament)
            {
                teamDatasBoys = teamDatasBoysAll!;
                teamDatasGirls = teamDatasGirlsAll!;
            }
            else
            {
                teamDatasBoys = new TeamDatas();
                foreach (var teamData in teamDatasBoysAll!.TeamDatasList!)
                {
                    if (teamData.District == Districts.KagoshimaNorth ||
                        teamData.District == Districts.KagoshimaWest ||
                        teamData.District == Districts.KagoshimaSouth ||
                        teamData.District == Districts.KagoshimaCentral)
                    {
                        teamDatasBoys.TeamDatasList!.Add(teamData);
                    }
                }
                teamDatasGirls = new TeamDatas();
                foreach (var teamData in teamDatasGirlsAll!.TeamDatasList!)
                {
                    if (teamData.District == Districts.KagoshimaNorth ||
                        teamData.District == Districts.KagoshimaWest ||
                        teamData.District == Districts.KagoshimaSouth ||
                        teamData.District == Districts.KagoshimaCentral)
                    {
                        teamDatasGirls.TeamDatasList!.Add(teamData);
                    }
                }
            }

            int nextCol = 1;
            // 男子
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_NO;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_SHORTNAME;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_TEAMNAME;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_DISTRICT;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_SEEDNUMBER;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.GAP_COL_WIDTH;

            int tempCol = ExcelTournamentBracket.TEAMLIST_TOP_COL + nextCol - 1;
            IXLRange ttlLRange = TeamDataSheet.Range(
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, ExcelTournamentBracket.TEAMLIST_TOP_COL,
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, tempCol++);
            ttlLRange.Merge();
            ttlLRange.Value = ExcelTournamentBracket.TITLE_BOYS;
            ttlLRange.Style.Font.FontColor = ExcelTournamentBracket.TITLE_FONTCOLOR_WHITE;
            ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_BOYS;

            // 女子
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_NO;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_SHORTNAME;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_TEAMNAME;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_DISTRICT;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.TEAMLIST_COL_WIDTH_SEEDNUMBER;
            TeamDataSheet.Column(nextCol++).Width = ExcelTournamentBracket.GAP_COL_WIDTH;

            ttlLRange = TeamDataSheet.Range(
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, tempCol,
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, nextCol - 1);
            ttlLRange.Merge();
            ttlLRange.Value = ExcelTournamentBracket.TITLE_GIRLS;
            ttlLRange.Style.Font.FontColor = ExcelTournamentBracket.TITLE_FONTCOLOR_WHITE;
            ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GIRLS;

            IXLCell cell1 =
                TeamDataSheet.Cell(
                    ExcelTournamentBracket.TEAMLIST_TOP_ROW + 1,
                    ExcelTournamentBracket.TEAMLIST_TOP_COL);
            cell1.Value = ExcelTournamentBracket.TITLE_NUMBER;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_SHORTNAME;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_TEAMNAME;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_DISTRICT;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_SEEDNUMBER;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;

            cell1 = cell1.CellRight(2);

            cell1.Value = ExcelTournamentBracket.TITLE_NUMBER;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_SHORTNAME;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_TEAMNAME;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_DISTRICT;
            cell1.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            cell1.Style.Font.FontSize = ExcelTournamentBracket.DATASHEET_BASE_FONT_SIZE;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            cell1 = cell1.CellRight(1);
            cell1.Value = ExcelTournamentBracket.TITLE_SEEDNUMBER;
            cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;

            IXLCell startCell;
            IXLCell cell2;
            startCell =
                TeamDataSheet.Cell(
                    ExcelTournamentBracket.TEAMLIST_TOP_ROW + 2,
                    ExcelTournamentBracket.TEAMLIST_TOP_COL);
            int numberCounter = 1;
            cell1 = startCell;
            foreach (var t in teamDatasBoys.TeamDatasList!)
            {
                cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
                cell1.Value = numberCounter;

                cell2 = cell1.CellRight(1);
                cell2.Style.Alignment.ShrinkToFit = true;
                cell2.Value = t.ShortName;

                cell2 = cell1.CellRight(1);
                cell2.Style.Alignment.ShrinkToFit = true;
                cell2.Value = t.TeamName;

                cell2 = cell1.CellRight(1);
                cell2.Style.Alignment.ShrinkToFit = true;
                cell2.Value = t.TeamName;

                cell2 = cell2.CellRight(1);
                if (DistrictsList.DicDistrict.TryGetValue(t.District, out string? districtName))
                {
                    cell2.Style.Alignment.ShrinkToFit = true;
                    cell2.Value = districtName;
                }
                cell1 = cell1.CellBelow();
                numberCounter++;
            }
            // 出場チーム合計欄
            cell1.CellRight(3).FormulaA1 =
                cell1.CellAbove().Address.ToString() + "-(COUNTIF(SEEDNUMBER_B,\"×\")+COUNTIF(SEEDNUMBER_B,\"－\"))";

            IXLRange xLRange =
                TeamDataSheet.Range(
                    TeamDataSheet.Cell(
                        ExcelTournamentBracket.TEAMLIST_TOP_ROW,
                        ExcelTournamentBracket.TEAMLIST_TOP_COL),
                    cell1.CellRight(3).CellAbove());
            xLRange.Style
                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                .Border.SetBottomBorder(XLBorderStyleValues.Thin)
                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                .Border.SetRightBorder(XLBorderStyleValues.Thin);
            // 名前（TEAMLIST_B）を付ける
            xLRange =
                TeamDataSheet.Range(startCell.CellRight(), cell1.CellRight(2).CellAbove());
            xLRange.AddToNamed(ExcelTournamentBracket.TEAMLIST_B_NAME);
            // 名前（SEEDNUMBER_B）を付ける
            xLRange =
                TeamDataSheet.Range(startCell.CellRight(3), cell1.CellRight(3).CellAbove());
            xLRange.AddToNamed(ExcelTournamentBracket.SEEDNUMBER_B_NAME);

            startCell =
                TeamDataSheet.Cell(
                    ExcelTournamentBracket.TEAMLIST_TOP_ROW + 2,
                    ExcelTournamentBracket.TEAMLIST_TOP_COL + 5);
            numberCounter = 1;
            cell1 = startCell;
            foreach (var t in teamDatasGirls.TeamDatasList!)
            {
                cell1.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
                cell1.Value = numberCounter;

                cell2 = cell1.CellRight(1);
                cell2.Style.Alignment.ShrinkToFit = true;
                cell2.Value = t.ShortName;

                cell2 = cell1.CellRight(1);
                cell2.Style.Alignment.ShrinkToFit = true;
                cell2.Value = t.TeamName;

                cell2 = cell2.CellRight(1);
                if (DistrictsList.DicDistrict.TryGetValue(t.District, out string? districtName))
                {
                    cell2.Style.Alignment.ShrinkToFit = true;
                    cell2.Value = districtName;
                }
                cell1 = cell1.CellBelow();
                numberCounter++;
            }
            // 出場チーム合計欄
            cell1.CellRight(3).FormulaA1 =
                cell1.CellAbove().Address.ToString() + "-(COUNTIF(SEEDNUMBER_G,\"×\")+COUNTIF(SEEDNUMBER_G,\"－\"))";

            xLRange =
                TeamDataSheet.Range(
                    TeamDataSheet.Cell(
                        ExcelTournamentBracket.TEAMLIST_TOP_ROW,
                        ExcelTournamentBracket.TEAMLIST_TOP_COL + 5),
                    cell1.CellRight(3).CellAbove());
            xLRange.Style
                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                .Border.SetBottomBorder(XLBorderStyleValues.Thin)
                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                .Border.SetRightBorder(XLBorderStyleValues.Thin);
            // 名前（TEAMLIST_G）を付ける
            xLRange =
                TeamDataSheet.Range(startCell.CellRight(), cell1.CellRight(2).CellAbove());
            xLRange.AddToNamed(ExcelTournamentBracket.TEAMLIST_G_NAME);
            // 名前（SEEDNUMBER_G）を付ける
            xLRange =
                TeamDataSheet.Range(startCell.CellRight(3), cell1.CellRight(3).CellAbove());
            xLRange.AddToNamed(ExcelTournamentBracket.SEEDNUMBER_G_NAME);
        }
/*
        private void CreateTimeTable()
        {
            //========================================
            // 試合開始時刻／ゲーム番号重複チェック欄
            //========================================
            //--------------
            // 試合開始時刻
            //--------------
            IXLCell cellInterval1, cellInterval2, cellInterval3;
            string cellInterval1Adr, cellInterval2Adr, cellInterval3Adr;
            IXLRange ttlLRange = GameDataSheet.Range(
                ExcelTournamentBracket.TEAMLIST_TOP_ROW + 2, _nextCol + 1,
                ExcelTournamentBracket.TEAMLIST_TOP_ROW + 11, _nextCol + 3);
            ttlLRange.Style.NumberFormat.Format = ExcelTournamentBracket.TIMETABLE_FORMAT;

            // 1行目（試合開始時刻）
            ttlLRange = GameDataSheet.Range(
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, _nextCol,
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, _nextCol + 3);
            ttlLRange.Merge();
            ttlLRange.Value = ExcelTournamentBracket.TIMETABLE_TITLE;
            ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
            // 2行目（1日目、2日目、3日目）
            IXLCell cell1 = GameDataSheet.Cell(2, _nextCol + 1);
            cell1.Value = ExcelTournamentBracket.TIMETABLE_TITLE_1_1;
            cell1.CellRight(1).Value = ExcelTournamentBracket.TIMETABLE_TITLE_1_2;
            cell1.CellRight(2).Value = ExcelTournamentBracket.TIMETABLE_TITLE_1_3;
            // 3行目（試合時間）
            cell1 = GameDataSheet.Cell(3, _nextCol);
            cell1.Value = ExcelTournamentBracket.TIMETABLE_TITLE_2;
            cellInterval1 = cell1.CellRight(1);
            cellInterval1.Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_INTERVAL_1;
            cellInterval1Adr = "$" + cellInterval1.Address.ColumnLetter + "$" + cellInterval1.Address.RowNumber.ToString();
            cellInterval2 = cell1.CellRight(2);
            cellInterval2.Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_INTERVAL_2;
            cellInterval2Adr = "$" + cellInterval2.Address.ColumnLetter + "$" + cellInterval2.Address.RowNumber.ToString();
            cellInterval3 = cell1.CellRight(3);
            cellInterval3.Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_INTERVAL_3;
            cellInterval3Adr = "$" + cellInterval3.Address.ColumnLetter + "$" + cellInterval3.Address.RowNumber.ToString();
            // 4行目（第1試合）
            cell1 = GameDataSheet.Cell(4, _nextCol);
            cell1.Value = ExcelTournamentBracket.TIMETABLE_TITLE_3_1;
            cell1.CellRight(1).Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_START_1;
            cell1.CellRight(2).Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_START_2;
            cell1.CellRight(3).Value = ExcelTournamentBracket.TIMETABLE_DEFAULT_START_3;
            // 5行目以降（第2試合～第n試合 n=ExcelTournamentBracket.TIMETABLE_NUMOFGAMES）
            for (int i = 2; i <= ExcelTournamentBracket.TIMETABLE_NUMOFGAMES; i++)
            {
                cell1 = GameDataSheet.Cell(4 - 1 + i, _nextCol);
                cell1.Value = string.Format(ExcelTournamentBracket.TIMETABLE_TITLE_3_FORMAT, i);
                cell1.CellRight(1).FormulaA1 =
                    string.Format(
                        ExcelTournamentBracket.TIMETABLE_FormuraA1_1_FORMAT,
                        cell1.CellRight(1).CellAbove().Address.ToString(),
                        cellInterval1Adr);
                cell1.CellRight(2).FormulaA1 =
                    string.Format(
                        ExcelTournamentBracket.TIMETABLE_FormuraA1_1_FORMAT,
                        cell1.CellRight(2).CellAbove().Address.ToString(),
                        cellInterval2Adr);
                cell1.CellRight(3).FormulaA1 =
                    string.Format(
                        ExcelTournamentBracket.TIMETABLE_FormuraA1_1_FORMAT,
                        cell1.CellRight(3).CellAbove().Address.ToString(),
                        cellInterval3Adr);
            }

            IXLRange xLRange =
                GameDataSheet.Range(
                        GameDataSheet.Cell(ExcelTournamentBracket.TEAMLIST_TOP_ROW, _nextCol),
                        cell1.CellRight(3));
            xLRange.Style
                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                .Border.SetBottomBorder(XLBorderStyleValues.Thin)
                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                .Border.SetRightBorder(XLBorderStyleValues.Thin);

            if (_tournamentData.VenueDatas.Count > 0)
            {
                //--------------------------
                // ゲーム番号重複チェック欄
                //--------------------------
                // 1行目（試合開始時刻）
                ttlLRange = GameDataSheet.Range(
                    ExcelTournamentBracket.TEAMLIST_TOP_ROW + 3 + ExcelTournamentBracket.TIMETABLE_NUMOFGAMES + 4, _nextCol,
                    ExcelTournamentBracket.TEAMLIST_TOP_ROW + 3 + ExcelTournamentBracket.TIMETABLE_NUMOFGAMES + 4, _nextCol + 3);
                ttlLRange.Merge();
                ttlLRange.Value = ExcelTournamentBracket.GAMENUMBERCHECK_TITLE_1;
                ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GRAY;
                int tempRow0 = ExcelTournamentBracket.TEAMLIST_TOP_ROW + 3 + ExcelTournamentBracket.TIMETABLE_NUMOFGAMES + 4 + 1;
                int tempRow1 = tempRow0;

                Dictionary<DateTime, List<string>> courtDatas = new Dictionary<DateTime, List<string>>();
                List<string> courtData;
                foreach (var v in _tournamentData.VenueDatas)
                {
                    if (courtDatas.TryGetValue(v.TargetDate, out courtData))
                    {
                        courtData.AddRange(v.CourtList);
                    }
                    else
                    {
                        courtData = new List<string>(v.CourtList);
                        courtDatas.Add(v.TargetDate, courtData);
                    }
                }
                IXLCell day1Cell = null;
                int dayCnt = 0;
                foreach (var d in courtDatas)
                {
                    int i = 0;
                    foreach (var c in d.Value)
                    {
                        if (i == 4)
                        {
                            tempRow1 += ExcelTournamentBracket.TIMETABLE_NUMOFGAMES;
                            i = 0;
                        }
                        for (int j = 0; j < ExcelTournamentBracket.TIMETABLE_NUMOFGAMES; j++)
                        {
                            cell1 = GameDataSheet.Cell(tempRow1 + j, _nextCol + i);
                            cell1.Value = c + (j + 1).ToString();
                            if (day1Cell == null)
                            {
                                day1Cell = cell1;
                            }
                        }
                        i++;
                    }
                    tempRow1 += ExcelTournamentBracket.TIMETABLE_NUMOFGAMES;

                    string condExpression =
                        string.Format(
                            COND1,
                            (dayCnt == 0 ? ExcelTournamentBracket.TOURNAMENTDATA_B_1 : ExcelTournamentBracket.TOURNAMENTDATA_B_2),
                            day1Cell.Address.ToString(),
                            (dayCnt == 0 ? ExcelTournamentBracket.TOURNAMENTDATA_G_1 : ExcelTournamentBracket.TOURNAMENTDATA_G_2));
                    GameDataSheet.Range(day1Cell, cell1).AddConditionalFormat().WhenIsTrue(
                        condExpression).Fill.BackgroundColor = XLColor.LightGreen;
                    condExpression =
                        string.Format(
                            COND2,
                            (dayCnt == 0 ? ExcelTournamentBracket.TOURNAMENTDATA_B_1 : ExcelTournamentBracket.TOURNAMENTDATA_B_2),
                            day1Cell.Address.ToString(),
                            (dayCnt == 0 ? ExcelTournamentBracket.TOURNAMENTDATA_G_1 : ExcelTournamentBracket.TOURNAMENTDATA_G_2));
                    GameDataSheet.Range(day1Cell, cell1).AddConditionalFormat().WhenIsTrue(
                        condExpression).Font.SetBold().Font.SetFontColor(XLColor.Red);

                    day1Cell = null;
                    dayCnt++;
                }
                xLRange =
                    GameDataSheet.Range(
                        ttlLRange.FirstCell(),
                        GameDataSheet.Cell(cell1.Address.RowNumber, ttlLRange.LastCell().Address.ColumnNumber));

                xLRange.Style
                    .Border.SetTopBorder(XLBorderStyleValues.Thin)
                    .Border.SetBottomBorder(XLBorderStyleValues.Thin)
                    .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                    .Border.SetRightBorder(XLBorderStyleValues.Thin);
            }

            GameDataSheet.Column(_nextCol++).Width = ExcelTournamentBracket.TIMETABLE_COL_WIDTH_1;
            GameDataSheet.Column(_nextCol++).Width = ExcelTournamentBracket.TIMETABLE_COL_WIDTH_2;
            GameDataSheet.Column(_nextCol++).Width = ExcelTournamentBracket.TIMETABLE_COL_WIDTH_3;
            GameDataSheet.Column(_nextCol++).Width = ExcelTournamentBracket.TIMETABLE_COL_WIDTH_4;
            _nextCol++;
        }

        private void CreateTournamentData()
        {
            //======================
            // トーナメント・データ
            //======================
            BracketData bracketData;
            if (_tournamentData.BrackectDataDic.TryGetValue(Category.Boys, out bracketData))
            {
                CreateTournamentDataSub(bracketData);
            }
            if (_tournamentData.BrackectDataDic.TryGetValue(Category.Girls, out bracketData))
            {
                _nextCol++;
                CreateTournamentDataSub(bracketData);
            }
        }

        private void CreateTournamentDataSub(BracketData bracketData)
        {
            //======================
            // トーナメント・データ
            //======================
            IXLRange ttlLRange;
            IXLRange xLRange;
            IXLCell cell1;
            int tempRow0;

            // タイトル
            ttlLRange = GameDataSheet.Range(
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, _nextCol,
                ExcelTournamentBracket.TEAMLIST_TOP_ROW, _nextCol + 2 + bracketData.AllDataInfo.Round);
            ttlLRange.Merge();
            XLColor nameCellBackColor;
            string formulaA1;
            string name_DAY1;
            string name_DAY2;
            string name_DAY3;
            if (bracketData.Category == Category.Boys)
            {
                ttlLRange.Value = ExcelTournamentBracket.TITLE_BOYS + ExcelTournamentBracket.TITLE_TOURNAMENT;
                ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_BOYS;
                nameCellBackColor = ExcelTournamentBracket.TITLE_BACKCOLOR_BOYS2;
                formulaA1 = TOURNAMENTDATA_FORMULA_B;
                name_DAY1 = ExcelTournamentBracket.TOURNAMENTDATA_B_1;
                name_DAY2 = ExcelTournamentBracket.TOURNAMENTDATA_B_2;
                name_DAY3 = ExcelTournamentBracket.TOURNAMENTDATA_B_3;
            }
            else
            {
                ttlLRange.Value = ExcelTournamentBracket.TITLE_GIRLS + ExcelTournamentBracket.TITLE_TOURNAMENT;
                ttlLRange.Style.Fill.BackgroundColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GIRLS;
                nameCellBackColor = ExcelTournamentBracket.TITLE_BACKCOLOR_GIRLS2;
                formulaA1 = TOURNAMENTDATA_FORMULA_G;
                name_DAY1 = ExcelTournamentBracket.TOURNAMENTDATA_G_1;
                name_DAY2 = ExcelTournamentBracket.TOURNAMENTDATA_G_2;
                name_DAY3 = ExcelTournamentBracket.TOURNAMENTDATA_G_3;
            }
            ttlLRange.Style.Font.FontColor = ExcelTournamentBracket.TITLE_FONTCOLOR_WHITE;

            tempRow0 = 2;
            int rowCount = 0;
            int cellCount = 1;
            for (int i = 0; i < bracketData.AllDataInfo.FullFrames / 2; i++)
            {
                //if (bracketData.AllDataInfo.FirstRoundData[i, 0] == 0 ||
                //    bracketData.AllDataInfo.FirstRoundData[i, 1] == 0)
                if (bracketData.AllDataInfo.FirstRoundData[i].Slots[0] == 0 ||
                    bracketData.AllDataInfo.FirstRoundData[i].Slots[1] == 0)
                {
                    xLRange =
                        GameDataSheet.Range(
                            tempRow0 + rowCount, _nextCol,
                            tempRow0 + rowCount + 1, _nextCol);
                    xLRange.Merge();
                    xLRange.Value = cellCount++;

                    xLRange =
                        GameDataSheet.Range(
                            tempRow0 + rowCount, _nextCol + 1,
                            tempRow0 + rowCount + 1, _nextCol + 1);
                    xLRange.Merge();
                    xLRange.FormulaA1 = formulaA1;

                    rowCount += 2;
                }
                else
                {
                    cell1 = GameDataSheet.Cell(tempRow0 + rowCount++, _nextCol);
                    cell1.Value = cellCount++;
                    cell1.CellRight().FormulaA1 = formulaA1;

                    cell1 = GameDataSheet.Cell(tempRow0 + rowCount++, _nextCol);
                    cell1.Value = cellCount++;
                    cell1.CellRight().FormulaA1 = formulaA1;
                }
            }
            xLRange =
                GameDataSheet.Range(
                    tempRow0, _nextCol,
                    tempRow0 + rowCount - 1, _nextCol + 1);
            xLRange.Style.Fill.BackgroundColor = nameCellBackColor;
            int tempCol0 = _nextCol + 2;
            int gainRows = 0;
            int tempRow1 = 0;
            for (int i = 0; i <= bracketData.AllDataInfo.Round; i++)
            {
                tempRow0 = 2;
                gainRows = (int)Math.Pow(2, i + 1);
                for (rowCount = 0; rowCount < bracketData.AllDataInfo.FullFrames; rowCount += gainRows)
                {
                    tempRow1 = tempRow0 + gainRows - 1;
                    xLRange =
                        GameDataSheet.Range(
                            tempRow0, tempCol0,
                            tempRow1, tempCol0);
                    xLRange.Merge();
                    tempRow0 = tempRow1 + 1;
                }
                tempCol0++;
            }
            xLRange =
                GameDataSheet.Range(
                    ttlLRange.FirstCell(),
                    GameDataSheet.Cell(tempRow1, ttlLRange.LastCell().Address.ColumnNumber));

            xLRange.Style
                .Border.SetTopBorder(XLBorderStyleValues.Thin)
                .Border.SetBottomBorder(XLBorderStyleValues.Thin)
                .Border.SetLeftBorder(XLBorderStyleValues.Thin)
                .Border.SetRightBorder(XLBorderStyleValues.Thin);

            // 条件付き書式用の名前付け
            if (_tournamentData.VenueDatas.Count > 0)
            {
                xLRange =
                    GameDataSheet.Range(
                        GameDataSheet.Cell(2, ttlLRange.FirstCell().Address.ColumnNumber + 2),
                        GameDataSheet.Cell(tempRow1, ttlLRange.LastCell().Address.ColumnNumber - 3));
                xLRange.AddToNamed(name_DAY1);
                xLRange =
                    GameDataSheet.Range(
                        GameDataSheet.Cell(2, ttlLRange.LastCell().Address.ColumnNumber - 2),
                        GameDataSheet.Cell(tempRow1, ttlLRange.LastCell().Address.ColumnNumber));
                xLRange.AddToNamed(name_DAY2);
            }

            _nextCol = tempCol0;
        }
*/
    }
}
