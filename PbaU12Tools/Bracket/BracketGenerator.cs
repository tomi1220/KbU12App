using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using PbaU12Tools.TournamentData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Bracket
{
    public partial class BracketGenerator
    {
        #region Enum
        public enum GenerateType
        {
            /// <summary>Excelのみで（従来の方法）</summary>
            ExcelOnly = 1,
            /// <summary>抽選会用</summary>
            Lottery = 3,
            /// <summary>試合順調整用</summary>
            MatchOrder = 3,
            /// <summary>トーナメント表</summary>
            TournamentBracket = 4,
        }
        public enum BracketArrangement
        {
            /// <summary>横</summary>
            Horizontal = 1,
            /// <summary>縦</summary>
            Vertical = 2,
            /// <summary>シートを分ける</summary>
            DivideTheSheet = 3,
        }

        public enum BracketSide
        {
            Left,
            Right
        }

        [FlagsAttribute]
        public enum CellBorders : short
        {
            None,
            Top,
            Bottom,
            Left,
            Right,
            DiagonalDown,
            DiagonalUp,
            InsideHorizontal,
            InsideVertical
        }

        #endregion

        #region 定数
        #endregion

        #region フィールド
        private int _numOfColsUsed = 0;
        /// <summary>処理中の行</summary>
        private int _currentRow = 0;
        /// <summary>処理中の列</summary>
        private int _currentCol = 0;
        private int _startColumnL = 0;
        private int _startColumnR = 0;
        #endregion

        #region コンストラクタ
        public BracketGenerator()
        {
        }

        public BracketGenerator(GenerateType generateType)
        {
            GenType = generateType;
        }

        public BracketGenerator(
            int numberOfBoysTeams,
            int numberOfGirlsTeams,
            int numberOfBoysSuperSeed = 0,
            int numberOfGirlsSuperSeed = 0)
        {
            GenType = GenerateType.Lottery;
            TourneyData = new TourneyData();
            TourneyData.BaseDataBoys.NumberOfTeams = numberOfBoysTeams;
            TourneyData.BaseDataBoys.NumberOfSuperSeed = numberOfBoysSuperSeed;
            TourneyData.BaseDataBoys.NumberOfTeams = numberOfGirlsTeams;
            TourneyData.BaseDataBoys.NumberOfSuperSeed = numberOfGirlsSuperSeed;
            GenDataBoys =
                CreateGenData(
                    new TournenyBaseData
                    {
                        Category = Categories.Boys,
                        NumberOfTeams = numberOfBoysTeams,
                        NumberOfSuperSeed = numberOfBoysSuperSeed
                    });
            GenDataGirls =
                CreateGenData(
                    new TournenyBaseData
                    {
                        Category = Categories.Girls,
                        NumberOfTeams = numberOfGirlsTeams,
                        NumberOfSuperSeed = numberOfGirlsSuperSeed
                    });
        }
        #endregion

        #region プロパティ
        public GenerateType GenType { get; set; } = (GenerateType)0;
        public BracketArrangement Arrangement { get; set; }
        public TourneyData? TourneyData { get; set; } = null;
        public BracketGenData? GenDataBoys { get; set; } = null;
        public BracketGenData? GenDataGirls { get; set; } = null;

        public string OutputFilePath { get; set; } = string.Empty;
        //public string FileName { get; set; } = string.Empty;

        //public string FilePath { get; set; } = string.Empty;

        private int RowIncriment { get; set; } = ExcelTournamentBracket.TEAM_ROW;
        private int NumOfVLine { get; set; } = ExcelTournamentBracket.TEAM_ROW / 2;
        private int PointCellOffset { get; set; } = 1;
        #endregion

        #region メソッド
        /// <summary>
        /// トーナメント表を作成する
        /// </summary>
        public bool GeneratBracket()
        {
            if (GenType == (GenerateType)0 ||
                (GenType != GenerateType.Lottery &&
                 TourneyData == null))
            {
                return false;
            }

            if (string.IsNullOrEmpty(OutputFilePath))
            {
                return false;
            }

            if (GenType != GenerateType.Lottery)
            {
                if (TourneyData!.OpenDisplayFrame)
                {
                    RowIncriment += ExcelTournamentBracket.TO_ETC_ROW;
                    NumOfVLine += ExcelTournamentBracket.TO_ETC_ROW;
                    PointCellOffset++;
                }
            }

            using (var workbook = new XLWorkbook())
            {
                // ワークシートを追加する
                AddBracketSheet(workbook);
                // データ sheet
                //generateDataSheet(workbook);

                //if ((TourneyData.Usage == TournamentData.UsageCls.ForDraw ||
                //     TourneyData.Usage == TournamentData.UsageCls.ForTournament) &&
                //    _datTournamentInfoID != 0)
                //{
                //    // チーム名・地区名を埋め込む
                //    EmbedNames(worksheet);
                //}

                try
                {
                    string xlsxFilePath = OutputFilePath;
                    workbook.SaveAs(xlsxFilePath);
                    //FilePath = xlsxFilePath;

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        #endregion

        #region ローカル・メソッド
        private void AddBracketSheet(XLWorkbook workbook)
        {
            // "組合せ" ワークシートを追加する
            if (TourneyData!.BaseDataBoys.NumberOfSuperSeed == 0 &&
                TourneyData!.BaseDataGirls.NumberOfSuperSeed == 0 &&
                GenDataBoys!.AllDataInfo!.Round == GenDataGirls!.AllDataInfo!.Round)
            {
                var worksheet = workbook.Worksheets.Add("組合せ");
                worksheet.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                worksheet.Style.Font.FontSize = ExcelTournamentBracket.DATASHEET_BASE_FONT_SIZE;
                worksheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                worksheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                GenBacket(worksheet, GenDataBoys, GenDataGirls, 1, 1);
            }
        }

        private void GenBacket(
            IXLWorksheet worksheet,
            BracketGenData bracketGenDataBoys,
            BracketGenData bracketGenDataGirls,
            int startCol,
            int startRow)
        {
            _currentRow = startRow;

            // 行の高さ・列幅、見出しなど
            initializeBrancketWorksheet(worksheet, GenDataBoys!);
            initializeBrancketWorksheet(worksheet, GenDataGirls!);
        }

        private void GenBacket(
            IXLWorksheet worksheet,
            BracketGenData bracketGenData,
            int startCol, int startRow)
        {
            // トーナメントの山
            startRow = ExcelTournamentBracket.CATEGORY_ROW + 3;

            string categoryPrefix =
                (bracketGenData.Category == Categories.Boys
                    ? ExcelTournamentBracket.CELL_NAME_PREFIX_BOYS
                    : ExcelTournamentBracket.CELL_NAME_PREFIX_GIRLS);

            if (bracketGenData.NumberOfSuperSeed == 0)
            {
                // スーパーシードなし
                Round1and2(worksheet, bracketGenData, categoryPrefix);

                CompleteBracket(worksheet, bracketGenData, bracketGenData.AllDataInfo, categoryPrefix);
            }
            else
            {
                // スーパーシードあり
                Round1and2SuperSeedCompatible(worksheet, bracketGenData, categoryPrefix);

                CompleteBracket(worksheet, bracketGenData, bracketGenData.AllDataInfo, categoryPrefix);
            }

            // 行の高さ・列幅、見出しなど
            initializeBrancketWorksheet(worksheet, GenDataBoys!);
            initializeBrancketWorksheet(worksheet, GenDataGirls!);
            // ブラケット以外の設定
            BuildOtherBracket(worksheet);
        }

        /// <summary>
        /// ［組合せ］シートの初期化
        /// </summary>
        /// <param name="worksheet"></param>
        private void initializeBrancketWorksheet(
            IXLWorksheet worksheet, BracketGenData genData)
        {
            int maxBracketRows = 0;
            int col = 1;
            string categoryText =
                (genData.Category == Categories.Boys)
                    ? ExcelTournamentBracket.CELL_NAME_PREFIX_BOYS
                    : ExcelTournamentBracket.CELL_NAME_PREFIX_GIRLS;

            if (col > 1)
            {
                worksheet.Column(col++).Width = ExcelTournamentBracket.GAP_CATEGORY_COLUMN_WIDTH;
            }

            // カラム
            int numOfColsUsed =
                ExcelTournamentBracket.DEFAULT_LEFT_COLUMN_MARGIN +
                ExcelTournamentBracket.DEFAULT_RIGHT_COLUMN_MARGIN +
                (ExcelTournamentBracket.COL_TEAM +
                 ExcelTournamentBracket.COL_NUMBER) * 2 +
                 (genData.AllDataInfo!.Round - 1) * 2 +
                ExcelTournamentBracket.FINAL_SPACE_COLUMNS * 2;
            if (TourneyData!.District)
            {
                numOfColsUsed += ExcelTournamentBracket.COL_DISTRICT * 2;
            }
            if (!TourneyData.FinalLeague)
            {
                numOfColsUsed += 2;
            }
            else
            {
                // 決勝リーグ枠を確保
                numOfColsUsed += ExcelTournamentBracket.FINAL_LEAGUE_SPACE_COLUMNS;
            }
            for (int wCol = 1; wCol <= numOfColsUsed; wCol++, col++)
            {
                worksheet.Column(col).Width = ExcelTournamentBracket.DEFAULT_COLUMN_WIDTH;
            }

            // カテゴリー行
            worksheet.Row(ExcelTournamentBracket.CATEGORY_ROW).Height = ExcelTournamentBracket.CATEGORY_ROW_HEIGHT;
            IXLRange categoryRange =
                worksheet.Range(
                    ExcelTournamentBracket.CATEGORY_ROW,
                    col - numOfColsUsed,
                    ExcelTournamentBracket.CATEGORY_ROW,
                    col - 1).Merge(false);
            categoryRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
            categoryRange.Style.Font.FontSize = ExcelTournamentBracket.CATEGORY_FONT_SIZE;

            string textFormulaA1_Left;      // 計算式（左）
            string textFormulaA1_Right;     // 計算式（右）
            if (genData.Category == Categories.Boys)
            {
                categoryRange.Value = ExcelTournamentBracket.CATEGORY_BOYS;
                // 計算式
                textFormulaA1_Left =
                    string.Format(
                        ExcelTournamentBracket.CELL_FormulaA1_LEFT_FORMAT,
                        ExcelTournamentBracket.TEAMLIST_B_NAME,
                        ExcelTournamentBracket.SEEDNUMBER_B_NAME);
                textFormulaA1_Right =
                    string.Format(
                        ExcelTournamentBracket.CELL_FormulaA1_RIGHT_FORMAT,
                        ExcelTournamentBracket.TEAMLIST_B_NAME,
                        ExcelTournamentBracket.SEEDNUMBER_B_NAME);
            }
            else
            {
                categoryRange.Value = ExcelTournamentBracket.CATEGORY_GIRLS;
                // 計算式
                textFormulaA1_Left =
                    string.Format(
                        ExcelTournamentBracket.CELL_FormulaA1_LEFT_FORMAT,
                        ExcelTournamentBracket.TEAMLIST_G_NAME,
                        ExcelTournamentBracket.SEEDNUMBER_G_NAME);
                textFormulaA1_Right =
                    string.Format(
                        ExcelTournamentBracket.CELL_FormulaA1_RIGHT_FORMAT,
                        ExcelTournamentBracket.TEAMLIST_G_NAME,
                        ExcelTournamentBracket.SEEDNUMBER_G_NAME);
            }
            categoryRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            categoryRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // カテゴリー行の下の隙間行
            worksheet.Row(ExcelTournamentBracket.CATEGORY_ROW + 1).Height = ExcelTournamentBracket.GAP_L_ROW_HEIGHT;
            worksheet.Row(ExcelTournamentBracket.CATEGORY_ROW + 2).Height = ExcelTournamentBracket.GAP_S_ROW_HEIGHT;

            maxBracketRows =
                Math.Max(
                    maxBracketRows,
                    maxBracketRows = genData.NumberOfTeams / 2 + genData.NumberOfTeams % 2);

            // チーム名・地区・番号
            int colT = col - numOfColsUsed;
            int colD = 0;
            int colN = 0;
            if (TourneyData.District)
            {
                colD = colT + ExcelTournamentBracket.COL_TEAM;
                colN = colD + ExcelTournamentBracket.COL_DISTRICT;
            }
            else
            {
                colN = colT + ExcelTournamentBracket.COL_TEAM;
            }
            //d.Value.StartColumnL = colN + ExcelTournamentBracket.COL_NUMBER;
            int numbering = 1;

            //----
            // 左
            //----
            int i = 0;
            for (int row = _currentRow; genData.PureSeedArray![i] != 3; i++, row += ExcelTournamentBracket.TEAM_ROW)
            {
                // チーム名
                IXLRange tempRange =
                    worksheet.Range(
                        row,
                        colT,
                        row + ExcelTournamentBracket.TEAM_ROW - 1,
                        colT + ExcelTournamentBracket.COL_TEAM - 1).Merge(false);
                tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_TEAM;
                tempRange.Value = "";
                tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Distributed;
                tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                string teamName =
                    categoryText +
                    ExcelTournamentBracket.CELL_NAME_PREFIX_TEAM +
                    ExcelTournamentBracket.CELL_NAME_DELIMITER +
                    numbering.ToString();
                tempRange.AddToNamed(teamName, XLScope.Worksheet);
                tempRange.FirstCell().FormulaA1 = textFormulaA1_Left;

                if (TourneyData.District)
                {
                    // 地区名称
                    tempRange =
                        worksheet.Range(
                            row,
                            colD,
                            row + ExcelTournamentBracket.TEAM_ROW - 1,
                            colD + ExcelTournamentBracket.COL_DISTRICT - 1).Merge(false);
                    tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                    tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_DISTRICT;
                    tempRange.Value = "";
                    tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    string districtName =
                        categoryText +
                        ExcelTournamentBracket.CELL_NAME_PREFIX_DISTRICT +
                        ExcelTournamentBracket.CELL_NAME_DELIMITER +
                        numbering.ToString();
                    tempRange.AddToNamed(districtName, XLScope.Worksheet);
                }
                // 番号
                tempRange =
                    worksheet.Range(
                        row,
                        colN,
                        row + ExcelTournamentBracket.TEAM_ROW - 1,
                        colN + ExcelTournamentBracket.COL_NUMBER - 1).Merge(false);
                tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_NUMBER;
                tempRange.Value = numbering.ToString();
                tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                string tournamentNumber =
                    categoryText +
                    ExcelTournamentBracket.CELL_NAME_PREFIX_TNUM +
                    ExcelTournamentBracket.CELL_NAME_DELIMITER +
                    numbering.ToString();
                tempRange.AddToNamed(tournamentNumber, XLScope.Worksheet);

                if (TourneyData.OpenDisplayFrame)
                {
                    // TO/オープン参加等表示枠
                    row += ExcelTournamentBracket.TO_ETC_ROW;
                    tempRange =
                        worksheet.Range(
                            row,
                            colT,
                            row + ExcelTournamentBracket.TEAM_ROW - 1,
                            colT + ExcelTournamentBracket.COL_TEAM - 1).Merge(false);
                    tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                    tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_TO_ETC;
                    tempRange.Value = "";
                    tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Distributed;
                    tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    string noteName =
                        categoryText +
                        ExcelTournamentBracket.CELL_NAME_PREFIX_NOTE +
                        ExcelTournamentBracket.CELL_NAME_DELIMITER +
                        numbering.ToString();
                    tempRange.AddToNamed(noteName, XLScope.Worksheet);
                }

                numbering++;
            }
            //----
            // 右
            //----
            if (TourneyData.District)
            {
                colD = col - ExcelTournamentBracket.COL_DISTRICT;
                colT = colD - ExcelTournamentBracket.COL_TEAM;
                colN = colT - ExcelTournamentBracket.COL_NUMBER;
            }
            else
            {
                colD = 0;
                colT = col - ExcelTournamentBracket.COL_TEAM;
                colN = colT - ExcelTournamentBracket.COL_NUMBER;
            }
            //d.Value.StartColumnR = colN - 1;
            for (int row = _currentRow; i < genData.NumberOfTeams; i++, row += ExcelTournamentBracket.TEAM_ROW)
            {
                // 番号
                IXLRange tempRange =
                    worksheet.Range(
                        row,
                        colN,
                        row + ExcelTournamentBracket.TEAM_ROW - 1,
                        colN + ExcelTournamentBracket.COL_NUMBER - 1).Merge(false);
                tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_NUMBER;
                tempRange.Value = numbering.ToString();
                tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                string tournamentNumber =
                    categoryText +
                    ExcelTournamentBracket.CELL_NAME_PREFIX_TNUM +
                    ExcelTournamentBracket.CELL_NAME_DELIMITER +
                    numbering.ToString();
                tempRange.AddToNamed(tournamentNumber, XLScope.Worksheet);
                // チーム名
                tempRange =
                    worksheet.Range(
                        row,
                        colT,
                        row + ExcelTournamentBracket.TEAM_ROW - 1,
                        colT + ExcelTournamentBracket.COL_TEAM - 1).Merge(false);
                tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_TEAM;
                tempRange.Value = "";
                tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Distributed;
                tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                string teamName =
                    categoryText +
                    ExcelTournamentBracket.CELL_NAME_PREFIX_TEAM +
                    ExcelTournamentBracket.CELL_NAME_DELIMITER +
                    numbering.ToString();
                tempRange.AddToNamed(teamName, XLScope.Worksheet);
                tempRange.FirstCell().FormulaA1 = textFormulaA1_Right;

                if (TourneyData.District)
                {
                    // 地区名称
                    tempRange =
                    worksheet.Range(
                        row,
                        colD,
                        row + ExcelTournamentBracket.TEAM_ROW - 1,
                        colD + ExcelTournamentBracket.COL_DISTRICT - 1).Merge(false);
                    tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                    tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_DISTRICT;
                    tempRange.Value = "";
                    tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    string districtName =
                        categoryText +
                        ExcelTournamentBracket.CELL_NAME_PREFIX_DISTRICT +
                        ExcelTournamentBracket.CELL_NAME_DELIMITER +
                        numbering.ToString();
                    tempRange.AddToNamed(districtName, XLScope.Worksheet);
                }

                if (TourneyData.OpenDisplayFrame)
                {
                    // TO/オープン参加等表示枠
                    row += 2;
                    tempRange =
                        worksheet.Range(
                            row,
                            colT,
                            row + ExcelTournamentBracket.TEAM_ROW - 1,
                            colT + ExcelTournamentBracket.COL_TEAM - 1).Merge(false);
                    tempRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                    tempRange.Style.Font.FontSize = ExcelTournamentBracket.FONT_SIZE_TO_ETC;
                    tempRange.Value = "";
                    tempRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Distributed;
                    tempRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    string noteName =
                        categoryText +
                        ExcelTournamentBracket.CELL_NAME_PREFIX_NOTE +
                        ExcelTournamentBracket.CELL_NAME_DELIMITER +
                        numbering.ToString();
                    tempRange.AddToNamed(noteName, XLScope.Worksheet);
                }

                numbering++;
            }
            _numOfColsUsed = col - 1;

            // トーナメントの行
            for (int l = 0, row = ExcelTournamentBracket.CATEGORY_ROW + 3; l < maxBracketRows; l++, row += ExcelTournamentBracket.TEAM_ROW)
            {
                if (TourneyData!.OpenDisplayFrame)
                {
                    worksheet.Row(row).Height = ExcelTournamentBracket.BRACKET_ADD_TO_ETC_ROW_HEIGHT;
                    worksheet.Row(row + 1).Height = ExcelTournamentBracket.BRACKET_ADD_TO_ETC_ROW_HEIGHT;
                    worksheet.Row(row + 2).Height = ExcelTournamentBracket.BRACKET_ADD_TO_ETC_ROW_HEIGHT;
                    worksheet.Row(row + 3).Height = ExcelTournamentBracket.BRACKET_ADD_TO_ETC_ROW_HEIGHT;

                    row += ExcelTournamentBracket.TO_ETC_ROW;
                }
                else
                {
                    worksheet.Row(row).Height = ExcelTournamentBracket.BRACKET_ROW_HEIGHT;
                    worksheet.Row(row + 1).Height = ExcelTournamentBracket.BRACKET_ROW_HEIGHT;
                }
            }
        }

        private void BuildOtherBracket(IXLWorksheet worksheet)
        {
            // 先頭行"トーナメント表"
            {
                worksheet.Row(ExcelTournamentBracket.TOURNAMENT_TITLE_ROW).Height = ExcelTournamentBracket.TOURNAMENT_TITLE_ROW_HEIGHT;
                IXLRange titleRange =
                    worksheet.Range(
                        ExcelTournamentBracket.TOURNAMENT_TITLE_ROW,
                        1,
                        ExcelTournamentBracket.TOURNAMENT_TITLE_ROW,
                        _numOfColsUsed).Merge(false);
                titleRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                titleRange.Style.Font.FontSize = ExcelTournamentBracket.TOURNAMENT_TITLE_FONT_SIZE;
                titleRange.Value = ExcelTournamentBracket.TOURNAMENT_TITLE;
                titleRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                titleRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            }

            // 大会名称行
            {
                worksheet.Row(ExcelTournamentBracket.TOURNAMENT_NAME_ROW).Height = ExcelTournamentBracket.TOURNAMENT_NAME_ROW_HEIGHT;
                IXLRange nameRange =
                    worksheet.Range(
                        ExcelTournamentBracket.TOURNAMENT_NAME_ROW,
                        1,
                        ExcelTournamentBracket.TOURNAMENT_NAME_ROW,
                        _numOfColsUsed).Merge(false);
                nameRange.Style.Font.FontName = ExcelTournamentBracket.DEFAULT_FONT_NAME;
                nameRange.Style.Font.FontSize = ExcelTournamentBracket.TOURNAMENT_NAME_FONT_SIZE;
                nameRange.Value = TourneyData!.TournamentName;
                nameRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                nameRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            }

            // 大会名称行の下の隙間行
            {
                worksheet.Row(ExcelTournamentBracket.TOURNAMENT_NAME_ROW + 1).Height = ExcelTournamentBracket.GAP_L_ROW_HEIGHT;
            }
        }

        /// <summary>
        /// １，２回戦の山のパターンを作る
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="bracketData"></param>
        /// <param name="categoryPrefix"></param>
        private void Round1and2(
            IXLWorksheet worksheet,
            BracketGenData bracketData,
            string categoryPrefix)
        {
            // １，２回戦の山のパターンは４種類

            int underNo = (int)Math.Pow(2, (bracketData.AllDataInfo!.Round - 1));

            IXLCell nextCell = getBracketStartCell(worksheet, bracketData.Category, BracketSide.Left);
            if (_startColumnL == 0)
            {
                _startColumnL = nextCell.Address.ColumnNumber;
            }

            if (bracketData.NumberOfDivisions < 2)
            {
                for (int i = underNo - 1; i < bracketData.AllDataInfo.NumberOfElement; i++)
                {
                    int oddNumber = (i + 1) % 2;

                    if (bracketData.AllDataInfo.Node[i] == 2)
                    {
                        nextCell = LeftDoubleSeed(worksheet, nextCell, categoryPrefix);
                    }
                    else if (bracketData.AllDataInfo.Node[i] == 4)
                    {
                        nextCell = LeftNoSeed(worksheet, nextCell, categoryPrefix);
                    }
                    else if (bracketData.AllDataInfo.Node[i] == 3 && oddNumber == 0)
                    {
                        nextCell = LeftAboveSeed(worksheet, nextCell, categoryPrefix);
                    }
                    else if (bracketData.AllDataInfo.Node[i] == 3 && oddNumber == 1)
                    {
                        nextCell = LeftBelowSeed(worksheet, nextCell, categoryPrefix);
                    }
                }
            }
            else
            {
                int leftNumber;
                int numberOfDivisionsOnOneSide = bracketData.NumberOfDivisions / 2;

                int page = 0;
                int interval = (underNo / 2) / numberOfDivisionsOnOneSide;

                for (int j = 0; j < numberOfDivisionsOnOneSide; j++)
                {
                    leftNumber = underNo + interval;

                    for (int i = underNo - 1; i < leftNumber - 1; i++)
                    {
                        int Kisuu = (i + 1) % 2;

                        if (bracketData.AllDataInfo.Node[i] == 2)
                        {
                            nextCell = LeftDoubleSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 4)
                        {
                            nextCell = LeftNoSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 3 && Kisuu == 0)
                        {
                            nextCell = LeftAboveSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 3 && Kisuu == 1)
                        {
                            nextCell = LeftBelowSeed(worksheet, nextCell, categoryPrefix);
                        }
                    }

                    nextCell = getBracketStartCell(worksheet, bracketData.Category, BracketSide.Right);
                    if (_startColumnR == 0)
                    {
                        _startColumnR = nextCell.Address.ColumnNumber;
                    }

                    for (int i = leftNumber - 1; i < leftNumber + interval - 1; i++)
                    {
                        int Kisuu = (i + 1) % 2;

                        if (bracketData.AllDataInfo.Node[i] == 2)
                        {
                            nextCell = RightDoubleSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 4)
                        {
                            nextCell = RightNoSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 3 && Kisuu == 0)
                        {
                            nextCell = RightAboveSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (bracketData.AllDataInfo.Node[i] == 3 && Kisuu == 1)
                        {
                            nextCell = RightBelowSeed(worksheet, nextCell, categoryPrefix);
                        }
                    }

                    underNo = underNo + interval * 2;
                    page = page + bracketData.AllDataInfo.Node[0] / numberOfDivisionsOnOneSide + 4;
                }
            }

            return;
        }

        /// <summary>
        /// スーパーシード対応の１，２回戦の山のパターンを作る
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="bracketData"></param>
        /// <param name="categoryPrefix"></param>
        private void Round1and2SuperSeedCompatible(
            IXLWorksheet worksheet,
            BracketGenData bracketData,
            string categoryPrefix)
        {
            // １，２回戦の山のパターンは４種類

            IXLCell nextCell = getBracketStartCell(worksheet, bracketData.Category, BracketSide.Left);
            if (_startColumnL == 0)
            {
                _startColumnL = nextCell.Address.ColumnNumber;
            }

            //foreach (var d in bracketData.PartInfos)
            foreach (var partInfo in bracketData.PartInfos)
            {
                //BracketGenData.PartInfo partInfo = d.Value;

                int underNo = (int)Math.Pow(2, (partInfo.Round - 1));

                if (partInfo.PartNumber - 1 < bracketData.NumberOfSuperSeed / 2)
                {
                    if (partInfo.PartNumber % 2 == 1)
                    {
                        // スパーシード用の横線（上側）
                        IXLRange tempRange1 = worksheet.Range(nextCell, nextCell.CellRight(partInfo.Round + 1));
                        tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        // 上位のヤマのためのフラグ用の仮の値
                        tempRange1.LastCell().Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

                        nextCell = nextCell.CellBelow(2);
                    }

                    for (int i = underNo - 1; i < partInfo.NumberOfElement; i++)
                    {
                        int oddNumber = (i + 1) % 2;

                        if (partInfo.Node[i] == 2)
                        {
                            nextCell = LeftDoubleSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 4)
                        {
                            nextCell = LeftNoSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 3 && oddNumber == 0)
                        {
                            nextCell = LeftAboveSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 3 && oddNumber == 1)
                        {
                            nextCell = LeftBelowSeed(worksheet, nextCell, categoryPrefix);
                        }
                    }

                    if (partInfo.PartNumber % 2 == 0)
                    {
                        // スパーシード用の横線（下側）
                        IXLRange tempRange1 = worksheet.Range(nextCell, nextCell.CellRight(partInfo.Round + 1));
                        tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        // 上位のヤマのためのフラグ用の仮の値
                        tempRange1.LastCell().Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

                        nextCell = nextCell.CellBelow(2);
                    }
                }
                else
                {
                    if (_startColumnR == 0)
                    {
                        nextCell = getBracketStartCell(worksheet, bracketData.Category, BracketSide.Right);
                        _startColumnR = nextCell.Address.ColumnNumber;
                    }

                    if (partInfo.PartNumber % 2 == 1)
                    {
                        // スパーシード用の横線（上側）
                        IXLRange tempRange1 = worksheet.Range(nextCell, nextCell.CellLeft(partInfo.Round + 1));
                        tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        // 上位のヤマのためのフラグ用の仮の値
                        tempRange1.LastCell().Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

                        nextCell = nextCell.CellBelow(2);
                    }

                    for (int i = underNo - 1; i < partInfo.NumberOfElement; i++)
                    {
                        int oddNumber = (i + 1) % 2;

                        if (partInfo.Node[i] == 2)
                        {
                            nextCell = RightDoubleSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 4)
                        {
                            nextCell = RightNoSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 3 && oddNumber == 0)
                        {
                            nextCell = RightAboveSeed(worksheet, nextCell, categoryPrefix);
                        }
                        else if (partInfo.Node[i] == 3 && oddNumber == 1)
                        {
                            nextCell = RightBelowSeed(worksheet, nextCell, categoryPrefix);
                        }
                    }

                    if (partInfo.PartNumber % 2 == 0)
                    {
                        // スパーシード用の横線（下側）
                        IXLRange tempRange1 = worksheet.Range(nextCell, nextCell.CellLeft(partInfo.Round + 1));
                        tempRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        // 上位のヤマのためのフラグ用の仮の値
                        tempRange1.LastCell().Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;

                        nextCell = nextCell.CellBelow(2);
                    }
                }
            }

            return;
        }

        /// <summary>
        /// ３回戦以降の山を完成させる
        /// </summary>
        /// <param name="xlApp"></param>
        /// <param name="xlSheet"></param>
        /// <param name="node"></param>
        /// <param name="round"></param>
        /// <param name="numberOfElement"></param>
        /// <param name="categoryPrefix"></param>
        private void CompleteBracket(
            IXLWorksheet worksheet,
            BracketGenData bracketData,
            BracketGenData.PartInfo? partInfo,
            string categoryPrefix)
        {
            if (partInfo == null)
            {
                return;
            }

            int numberOfDivisionsOnOneSide = bracketData.NumberOfDivisions / 2;

            int[] left = new int[numberOfDivisionsOnOneSide];
            int[] right = new int[numberOfDivisionsOnOneSide];

            for (int i = 0, j = numberOfDivisionsOnOneSide * 2;
                i < numberOfDivisionsOnOneSide;
                i++)
            {
                left[i] = partInfo.Node[j - 1];
                right[i] = partInfo.Node[j];
                j = j + 2;
            }

            int rnd = partInfo.Round - 2;

            int roundStartColumn = _startColumnL + 2;
            IXLCell? rule1 = null;
            IXLCell? rule2 = null;

            int finalRow = 0;
            int finalLeftCol = 0;
            int finalRightCol = 0;
            IXLCell rule1LeftSemiFinal = null;
            IXLCell rule2LeftSemiFinal = null;
            IXLCell rule1RightSemiFinal = null;
            IXLCell rule2RightSemiFinal = null;

            int rowIncriment = ExcelTournamentBracket.TEAM_ROW;
            int numOfVLine = ExcelTournamentBracket.TEAM_ROW / 2;
            int pointCellOffset = 1;
            if (TourneyData.OpenDisplayFrame)
            {
                rowIncriment += ExcelTournamentBracket.TO_ETC_ROW;
                numOfVLine += ExcelTournamentBracket.TO_ETC_ROW;
                pointCellOffset++;
            }

            for (int i = 0; i < numberOfDivisionsOnOneSide; i++)
            {
                for (int nl = 0; nl < rnd; nl++)
                {
                    roundStartColumn = _startColumnL + 2;
                    //for (int il = 1; il <= left[i] * 2; il++)
                    for (int il = 1; il <= left[i] * rowIncriment; il++)
                    {
                        IXLCell checkCell = worksheet.Cell(_currentRow + il - 1, nl + roundStartColumn);
                        if ((string)checkCell.Value == ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG)
                        {
                            if (rule1 == null)
                            {
                                rule1 = checkCell;
                                rule1.Value = string.Empty;
                            }
                            else
                            {
                                checkCell.Value = string.Empty;

                                // 上側の横線
                                rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                                // 横線
                                IXLRange tempRange1 = worksheet.Range(rule1.CellBelow(1), checkCell);
                                tempRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                                // 下側の横線
                                checkCell.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                                rule2 = checkCell.CellBelow(1);

                                // 上位のヤマのためのフラグ用の仮の値
                                if (nl < rnd - 1)
                                {
                                    int connectCellRow = connectCellRow = tempRange1.RowCount() / 2;
                                    IXLCell connectCell = tempRange1.Cell(1, 1).CellRight(1).CellBelow(connectCellRow - 1);
                                    connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;
                                    // ゲーム番号
                                    worksheet.Range(connectCell.CellLeft(1), connectCell.CellLeft(1).CellBelow(1)).Merge(false);
                                    // 勝ち上がり罫線の条件付き書式
                                    SetFormatConditionLine(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        new IXLCell[] { rule1 },
                                        CellBorders.Bottom);
                                    SetFormatConditionLine(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        worksheet.Range(rule1.CellRight(1).CellBelow(1), connectCell).Cells().ToArray(),
                                        CellBorders.Left);
                                    SetFormatConditionLine(
                                        worksheet, rule2.AsRange(), rule1.AsRange(),
                                        new IXLCell[] { rule2 },
                                        CellBorders.Top);
                                    SetFormatConditionLine(
                                        worksheet, rule2.AsRange(), rule1.AsRange(),
                                        worksheet.Range(connectCell.CellBelow(1), rule2.CellRight(1).CellAbove(1)).Cells().ToArray(),
                                        CellBorders.Left);
                                    SetFormatConditionLine2(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        new IXLCell[] { connectCell },
                                        CellBorders.Bottom);
                                }
                                else
                                {
                                    finalRow = tempRange1.Cell(1, 1).CellBelow(tempRange1.RowCount() / 2).Address.RowNumber;
                                    finalLeftCol = tempRange1.FirstCell().Address.ColumnNumber + 1;

                                    rule1LeftSemiFinal = rule1;
                                    rule2LeftSemiFinal = rule2;
                                }
                                // 点数欄の条件付き書式
                                SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());

                                rule1 = null;
                                rule2 = null;
                            }
                        }
                    }
                    roundStartColumn = _startColumnR - 2;
                    //for (int il = 1; il <= right[i] * 2; il++)
                    for (int il = 1; il <= right[i] * rowIncriment; il++)
                    {
                        IXLCell checkCell = worksheet.Cell(_currentRow + il - 1, nl * (-1) + roundStartColumn);
                        if ((string)checkCell.Value == ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG)
                        {
                            if (rule1 == null)
                            {
                                rule1 = checkCell;
                                rule1.Value = string.Empty;
                            }
                            else
                            {
                                checkCell.Value = string.Empty;

                                // 上側の横線
                                rule1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                                // 横線
                                IXLRange tempRange1 = worksheet.Range(rule1.CellBelow(1), checkCell);
                                tempRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                                // 下側の横線
                                checkCell.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                                rule2 = checkCell.CellBelow(1);

                                // 上位のヤマのためのフラグ用の仮の値
                                if (nl < rnd - 1)
                                {
                                    int connectCellRow = connectCellRow = tempRange1.RowCount() / 2;
                                    IXLCell connectCell = tempRange1.Cell(1, 1).CellLeft(1).CellBelow(connectCellRow - 1);
                                    connectCell.Value = ExcelTournamentBracket.LINE_CONNECTING_POINT_FLAG;
                                    // ゲーム番号
                                    worksheet.Range(connectCell.CellRight(1), connectCell.CellRight(1).CellBelow(1)).Merge(false);
                                    // 勝ち上がり罫線の条件付き書式
                                    SetFormatConditionLine(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        new IXLCell[] { rule1 },
                                        CellBorders.Bottom);
                                    SetFormatConditionLine(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        worksheet.Range(rule1.CellLeft(1).CellBelow(1), connectCell).Cells().ToArray(),
                                        CellBorders.Right);
                                    SetFormatConditionLine(
                                        worksheet, rule2.AsRange(), rule1.AsRange(),
                                        new IXLCell[] { rule2 },
                                        CellBorders.Top);
                                    SetFormatConditionLine(
                                        worksheet, rule2.AsRange(), rule1.AsRange(),
                                        worksheet.Range(connectCell.CellBelow(1), rule2.CellLeft(1).CellAbove(1)).Cells().ToArray(),
                                        CellBorders.Right);
                                    SetFormatConditionLine2(
                                        worksheet, rule1.AsRange(), rule2.AsRange(),
                                        new IXLCell[] { connectCell },
                                        CellBorders.Bottom);
                                }
                                else
                                {
                                    finalRow =
                                        Math.Max(
                                            finalRow,
                                            tempRange1.Cell(1, 1).CellBelow(tempRange1.RowCount() / 2).Address.RowNumber);
                                    finalRightCol = tempRange1.FirstCell().Address.ColumnNumber - 1;

                                    rule1RightSemiFinal = rule1;
                                    rule2RightSemiFinal = rule2;
                                }
                                // 点数欄の条件付き書式
                                rule1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                                rule2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                                SetFormatConditionPoint(worksheet, rule1.AsRange(), rule2.AsRange());

                                rule1 = null;
                                rule2 = null;
                            }
                        }
                    }
                }
                bool debugF = true;
                if (!debugF)
                {
                    // 決勝の得点欄
                    IXLRange rule1Range = worksheet.Range(finalRow - 1, finalLeftCol, finalRow - 1, finalLeftCol + 1).Merge(false);
                    rule1Range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    IXLRange rule2Range = worksheet.Range(finalRow - 1, finalRightCol - 1, finalRow - 1, finalRightCol).Merge(false);
                    rule2Range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    // 点数欄の条件付き書式
                    SetFormatConditionPoint(worksheet, rule1Range, rule2Range);
                    // 決勝戦の罫線
                    rule1Range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    rule2Range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    rule2Range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    // 準決勝のゲーム番号
                    worksheet.Range(finalRow - 1, finalLeftCol - 1, finalRow, finalLeftCol - 1).Merge(false);
                    worksheet.Range(finalRow - 1, finalRightCol + 1, finalRow, finalRightCol + 1).Merge(false);
                    // 準決勝の勝ち上がり罫線の条件付き書式（左側）
                    SetFormatConditionLine(
                        worksheet, rule1LeftSemiFinal.AsRange(), rule2LeftSemiFinal.AsRange(),
                        new IXLCell[] { rule1LeftSemiFinal },
                        CellBorders.Bottom);
                    SetFormatConditionLine(
                        worksheet, rule1LeftSemiFinal.AsRange(), rule2LeftSemiFinal.AsRange(),
                        worksheet.Range(rule1LeftSemiFinal.CellRight(1).CellBelow(1), rule1Range.Cell(1, 1)).Cells().ToArray(),
                        CellBorders.Left);
                    SetFormatConditionLine(
                        worksheet, rule2LeftSemiFinal.AsRange(), rule1LeftSemiFinal.AsRange(),
                        new IXLCell[] { rule2LeftSemiFinal },
                        CellBorders.Top);
                    SetFormatConditionLine(
                        worksheet, rule2LeftSemiFinal.AsRange(), rule1LeftSemiFinal.AsRange(),
                        worksheet.Range(rule1Range.Cell(1, 1).CellBelow(1), rule2LeftSemiFinal.CellRight(1).CellAbove(1)).Cells().ToArray(),
                        CellBorders.Left);
                    // 準決勝の勝ち上がり罫線の条件付き書式（右側）
                    SetFormatConditionLine(
                        worksheet, rule1RightSemiFinal.AsRange(), rule2RightSemiFinal.AsRange(),
                        new IXLCell[] { rule1RightSemiFinal },
                        CellBorders.Bottom);
                    SetFormatConditionLine(
                        worksheet, rule1RightSemiFinal.AsRange(), rule2RightSemiFinal.AsRange(),
                        worksheet.Range(rule1RightSemiFinal.CellLeft(1).CellBelow(1), rule2Range.Cell(1, 2)).Cells().ToArray(),
                        CellBorders.Right);
                    SetFormatConditionLine(
                        worksheet, rule2RightSemiFinal.AsRange(), rule1RightSemiFinal.AsRange(),
                        new IXLCell[] { rule2RightSemiFinal },
                        CellBorders.Top);
                    SetFormatConditionLine(
                        worksheet, rule2RightSemiFinal.AsRange(), rule1RightSemiFinal.AsRange(),
                        worksheet.Range(rule2Range.Cell(1, 2).CellBelow(1), rule2RightSemiFinal.CellLeft(1).CellAbove(1)).Cells().ToArray(),
                        CellBorders.Right);
                    // 決勝の勝ち上がり罫線の条件付き書式
                    SetFormatConditionLine(
                        worksheet, rule1Range, rule2Range,
                        rule1Range.Cells().ToArray(),
                        CellBorders.Bottom,
                        true);
                    SetFormatConditionLine(
                        worksheet, rule2Range, rule1Range,
                        rule2Range.Cells().ToArray(),
                        CellBorders.Bottom,
                        true);
                    SetFormatConditionLine2(
                        worksheet, rule1Range, rule2Range,
                        new IXLCell[] { rule1Range.Cell(1, 2) },
                        CellBorders.Right,
                        true);
                }
            }
        }

        #endregion
    }
}
