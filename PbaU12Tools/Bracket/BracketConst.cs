using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Bracket
{
    internal class BracketConst
    {
    }

    public static class ExcelTournamentBracket
    {
        public const int DEFAULT_NUMBER_OF_DIVISIONS = 2;

        public const string DEFAULT_FONT_NAME = "Meiryo UI";
        public const int FONT_SIZE_TEAM = 11;
        public const int FONT_SIZE_TO_ETC = 9;
        public const int FONT_SIZE_DISTRICT = 7;
        public const int FONT_SIZE_NUMBER = 11;
        public const int FONT_SIZE_POINT = 10;
        public const int FONT_SIZE_GAME = 10;
        public const int FONT_SIZE_POINT_FINALS = 11;
        public const int FONT_SIZE_WINNER = 12;

        //public const int TOURNAMENT_HEADER_COL_MARGIN = 2;
        public const string TOURNAMENT_TITLE = "トーナメント表";
        public const int TOURNAMENT_TITLE_ROW = 1;
        //public const int TOURNAMENT_TITLE_WIDTH = 10;
        public const double TOURNAMENT_TITLE_ROW_HEIGHT = 21.75;
        public const double TOURNAMENT_TITLE_FONT_SIZE = 16;

        public const int TOURNAMENT_NAME_ROW = 2;
        public const double TOURNAMENT_NAME_ROW_HEIGHT = 24.75;
        public const double TOURNAMENT_NAME_FONT_SIZE = 16;

        //public const int GAP_L_ROW = 3;
        public const double GAP_L_ROW_HEIGHT = 18.0;
        public const double GAP_S_ROW_HEIGHT = 10.0;
        //public const double GAP_FONT_SIZE = 11;

        public const int CATEGORY_ROW = 4;
        public const double CATEGORY_ROW_HEIGHT = 15.0;
        public const double CATEGORY_FONT_SIZE = 11;

        public const double BRACKET_ROW_HEIGHT = 12.0;
        public const double BRACKET_ADD_TO_ETC_ROW_HEIGHT = 9.75;

        //public const int SCHEDULE_ROW = 4;
        public const double SCHEDULE_ROW_HEIGHT = 12.0;
        public const double SCHEDULE_FONT_SIZE = 10;

        public static Color FINAL_LEAGUE_MATCH_BOX_BACK_COLOR = Color.FromArgb(228, 223, 236);

        public const string CATEGORY_BOYS = "【男子の部】";
        public const string CATEGORY_GIRLS = "【女子の部】";

        public const string SHEET_NAME_COMMON = "【組合せ】";
        public const string SHEET_NAME_BOYS = "【組合せ（男子）】";
        public const string SHEET_NAME_GIRLS = "【組合せ（女子）】";
        public const string SHEET_NAME_RESULT_INPUT = "【結果入力】";
        public const string SHEET_NAME_COMMON_RESULT = "【結果配布用】";
        public const string SHEET_NAME_BOYS_RESULT = "【結果配布用（男子）】";
        public const string SHEET_NAME_GIRLS_RESULT = "【結果配布用（女子）】";

        public const int DEFAULT_LEFT_COLUMN_MARGIN = 0;
        public const int DEFAULT_RIGHT_COLUMN_MARGIN = 0;

        //public const int FINAL_SPACE_COLUMNS = 2;
        public const int FINAL_SPACE_COLUMNS = 1;
        public const double DEFAULT_ROW_HEIGHT = 9.75;
        public const double DEFAULT_COLUMN_WIDTH = 4.29;
        public const double GAP_CATEGORY_COLUMN_WIDTH = 1.0;
        public const double FINAL_BASE_COLUMN_WIDTH = 1.0;
        public const double FINAL_GAP_COLUMN_WIDTH = 0.3;

        public const int FINAL_LEAGUE_SPACE_COLUMNS = 5;

        public const int FINAL_LEAGUE_MATCH_BOX_COLUMNS =
            (FINAL_SPACE_COLUMNS + 1) * 2 - 2;
        public const int FINAL_LEAGUE_MATCH_BOX_GAME_NUMBER_ROWS = 2;
        public const int FINAL_LEAGUE_MATCH_BOX_TEAM_NAME_ROWS = 2;
        public const int FINAL_LEAGUE_MATCH_BOX_ROWS =
            FINAL_LEAGUE_MATCH_BOX_GAME_NUMBER_ROWS +
            FINAL_LEAGUE_MATCH_BOX_TEAM_NAME_ROWS * 2;
        public const int FINAL_LEAGUE_MATCH_BOX_GAME_NUMBER_COLUMNS = 3;
        public const int FINAL_LEAGUE_MATCH_BOX_GAME_STARTTIME_COLUMNS =
            FINAL_LEAGUE_MATCH_BOX_COLUMNS - FINAL_LEAGUE_MATCH_BOX_GAME_NUMBER_COLUMNS;
        public const int FINAL_LEAGUE_MATCH_BOX_SCORE_COLUMNS = 3;
        public const int FINAL_LEAGUE_MATCH_BOX_TEAM_NAME_COLUMNS =
            FINAL_LEAGUE_MATCH_BOX_COLUMNS - FINAL_LEAGUE_MATCH_BOX_SCORE_COLUMNS;
        public const double FINAL_LEAGUE_MATCH_BOX_GAME_NUMBER_FONT_SIZE = 11.0;
        public const double FINAL_LEAGUE_MATCH_BOX_TEAM_NAME_FONT_SIZE = 12.0;

        public const int DEFAULT_TOURNAMENT_START_ROW = 6;

        public const string LINE_CONNECTING_POINT_FLAG = "ConnectingPoint";
        //public const string LINE_SEMIFINAL_POINT_FLAG = "SemifinalPoint";
        //public const string MERGE_POSITION_FLAG = "Merge";

        public const int TEAM_ROW = 2;
        public const int TO_ETC_ROW = 2;

        public const int COL_TEAM = 3;
        public const int COL_DISTRICT = 2;
        public const int COL_NUMBER = 1;

        //public const int COL_TOURNAMENT_LEFT_START = 2;

        public static string[] COLUMN_ALPHA =
            new string[]
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

        // セルの名前のPREFIX
        public const string CELL_NAME_DELIMITER = "_";
        public const string CELL_NAME_PREFIX_BOYS_BASE = "B";           // 男子
        public const string CELL_NAME_PREFIX_BOYS =
            CELL_NAME_PREFIX_BOYS_BASE + CELL_NAME_DELIMITER;
        public const string CELL_NAME_PREFIX_GIRLS_BASE = "G";          // 女子
        public const string CELL_NAME_PREFIX_GIRLS =
            CELL_NAME_PREFIX_GIRLS_BASE + CELL_NAME_DELIMITER;
        public const string CELL_NAME_PREFIX_MIX_BASE = "M";            // 混成
        public const string CELL_NAME_PREFIX_MIX =
            CELL_NAME_PREFIX_MIX_BASE + CELL_NAME_DELIMITER;
        public const string CELL_NAME_PREFIX_TEAM = "TEAM";             // チーム名
        public const string CELL_NAME_PREFIX_DISTRICT = "DISTRICT";     // 地区名称
        //public const string CELL_NAME_PREFIX_SEED = "SEED";           // シード
        public const string CELL_NAME_PREFIX_TNUM = "TNUM";             // トーナメント番号
        public const string CELL_NAME_PREFIX_NOTE = "NOTE";             // 備考（TO／オープンなど）

        public const string CELL_FormulaA1_LEFT_FORMAT =
            "=IF(ISERROR(INDEX({0},MATCH(@OFFSET(INDIRECT(ADDRESS(ROW(),COLUMN())),0,3),{1},0),1)),\"\",INDEX({0},MATCH(@OFFSET(INDIRECT(ADDRESS(ROW(),COLUMN())),0,3),{1},0),1))";
        public const string CELL_FormulaA1_RIGHT_FORMAT =
            "=IF(ISERROR(INDEX({0},MATCH(@OFFSET(INDIRECT(ADDRESS(ROW(),COLUMN())),0,-1),{1},0),1)),\"\",INDEX({0},MATCH(@OFFSET(INDIRECT(ADDRESS(ROW(),COLUMN())),0,-1),{1},0),1))";

        // ラウンド文字列
        public const string ROUND_1_NAME = "１回戦";
        public const int ROUND_1_VALUE = 1;
        public const string ROUND_2_NAME = "２回戦";
        public const int ROUND_2_VALUE = 2;
        public const string ROUND_3_NAME = "３回戦";
        public const int ROUND_3_VALUE = 3;
        public const string ROUND_4_NAME = "４回戦";
        public const int ROUND_4_VALUE = 4;
        public const string ROUND_5_NAME = "５回戦";
        public const int ROUND_5_VALUE = 5;
        public const string ROUND_6_NAME = "６回戦";
        public const int ROUND_6_VALUE = 6;
        public const string ROUND_QUARTER_FINALS_NAME = "準々決勝";
        public const int ROUND_QUARTER_FINALS_VALUE = 90;
        public const string ROUND_SEMIFINALS_NAME = "準々決勝";
        public const int ROUND_SEMIFINALS_VALUE = 91;
        public const string ROUND_FINALS_NAME = "決勝";
        public const int ROUND_FINALS_VALUE = 92;
        public const string ROUND_FINAL_1_NAME = "決勝リーグ第１試合";
        public const int ROUND_FINAL_1_VALUE = 97;
        public const string ROUND_FINAL_2_NAME = "決勝リーグ第２試合";
        public const int ROUND_FINAL_2_VALUE = 98;
        public const string ROUND_FINAL_3_NAME = "決勝リーグ最終試合";
        public const int ROUND_FINAL_3_VALUE = 99;

        public const string CELL_NAME_PREFIX_POINT = "POINT";           // 得点
        public const string CELL_NAME_PREFIX_GAME = "GAME";             // ゲーム
        public const string CELL_NAME_PREFIX_ANALYSIS_START_POSITION = "ANALYSIS_START";    // 解析開始位置
        public const string CELL_NAME_SEMIFINAL_GAME = "Y";             // 準決勝
        public const string CELL_NAME_FINAL_GAME = "Z";                 // 決勝
        public const int CELL_NAME_FINAL_GAME_MAGIC_NUMBER = ROUND_FINALS_VALUE;    // 決勝戦
        public const string CELL_NAME_FINAL_WINNER = "WINNER";          // 優勝チーム

        public const string BEST4_1 = "①";                             // ベスト４第１シード
        public const string BEST4_4 = "②";                             // ベスト４第４シード
        public const string BEST4_3 = "③";                             // ベスト４第３シード
        public const string BEST4_2 = "④";                             // ベスト４第２シード

        // トーナメントデータ・ファイル名
        public const string TOURNAMENT_DATA_BASE_DATA = "BaseData";     // 基本データ
        public const string TOURNAMENT_DATA_SEED_DIC = "SeedDic";       // シード・番号対応辞書
        public const string TOURNAMENT_DATA_MATCH_DATA = "MatchData";   // 対戦カード・データ

        //--------------
        // データ Sheet
        //--------------
        public const string TEAMDATASHEET_NAME = "チームデータ";
        public const string GAMEDATASHEET_NAME = "ゲームデータ";
        public const int DATASHEET_BASE_FONT_SIZE = 10;
        public const int GAP_COL_WIDTH = 3;

        public const int TEAMLIST_TOP_ROW = 1;
        public const int TEAMLIST_TOP_COL = 1;
        public const int TEAMLIST_COL_WIDTH_NO = 4;
        public const int TEAMLIST_COL_WIDTH_SHORTNAME = 9;
        public const int TEAMLIST_COL_WIDTH_TEANNAME = 30;
        public const int TEAMLIST_COL_WIDTH_DISTRICT = 9;
        public const int TEAMLIST_COL_WIDTH_SEEDNUMBER = 7;
        public const string TITLE_BOYS = "男子";
        public const string TITLE_GIRLS = "女子";
        public const string TITLE_NUMBER = "№";
        public const string TITLE_SHORTNAME = "チーム名";
        public const string TITLE_TEAMNAME = "登録名";
        public const string TITLE_DISTRICT = "地区";
        public const string TITLE_SEEDNUMBER = "番号";
        public const string TITLE_TOURNAMENT = "トーナメント";

        public static readonly XLColor TITLE_BACKCOLOR_GRAY = XLColor.Gainsboro;
        public static readonly XLColor TITLE_FONTCOLOR_WHITE = XLColor.White;
        public static readonly XLColor TITLE_BACKCOLOR_BOYS = XLColor.DodgerBlue;
        public static readonly XLColor TITLE_BACKCOLOR_GIRLS = XLColor.Crimson;

        public static readonly XLColor TITLE_BACKCOLOR_BOYS2 = XLColor.PaleTurquoise;
        public static readonly XLColor TITLE_BACKCOLOR_GIRLS2 = XLColor.LightPink;

        public const string TEAMLIST_B_NAME = "TEAMLIST_B";
        public const string TEAMLIST_G_NAME = "TEAMLIST_G";
        public const string SEEDNUMBER_B_NAME = "SEEDNUMBER_B";
        public const string SEEDNUMBER_G_NAME = "SEEDNUMBER_G";

        public const int TIMETABLE_COL_WIDTH_1 = 9;
        public const int TIMETABLE_COL_WIDTH_2 = 9;
        public const int TIMETABLE_COL_WIDTH_3 = 9;
        public const int TIMETABLE_COL_WIDTH_4 = 9;
        public const string TIMETABLE_TITLE = "試合開始時刻";
        public const string TIMETABLE_TITLE_1_1 = "1日目";
        public const string TIMETABLE_TITLE_1_2 = "2日目";
        public const string TIMETABLE_TITLE_1_3 = "3日目";

        public const string TIMETABLE_TITLE_2 = "試合時間";

        public const string TIMETABLE_TITLE_3_1 = "第1試合";
        //public const string TIMETABLE_TITLE_3_2 = "第2試合";
        //public const string TIMETABLE_TITLE_3_3 = "第3試合";
        //public const string TIMETABLE_TITLE_3_4 = "第4試合";
        //public const string TIMETABLE_TITLE_3_5 = "第5試合";
        //public const string TIMETABLE_TITLE_3_6 = "第6試合";
        //public const string TIMETABLE_TITLE_3_7 = "第7試合";
        //public const string TIMETABLE_TITLE_3_8 = "第8試合";
        //public const string TIMETABLE_TITLE_3_9 = "第9試合";

        public const string TIMETABLE_FORMAT = "hh:mm";

        public const string TIMETABLE_DEFAULT_INTERVAL_1 = "1:10";
        public const string TIMETABLE_DEFAULT_INTERVAL_2 = "1:10";
        public const string TIMETABLE_DEFAULT_INTERVAL_3 = "1:10";
        public const string TIMETABLE_DEFAULT_START_1 = "9:30";
        public const string TIMETABLE_DEFAULT_START_2 = "9:00";
        public const string TIMETABLE_DEFAULT_START_3 = "9:00";

        public const int TIMETABLE_NUMOFGAMES = 9;
        public const string TIMETABLE_TITLE_3_FORMAT = "第{0}試合";
        public const string TIMETABLE_FormuraA1_1_FORMAT = "=IF({0}=\"\",\"\",{0}+{1})";

        public const string GAMENUMBERCHECK_TITLE_1 = "ゲーム番号重複チェック";
        public const int GAMENUMBERCHECK_START_ROW = 17;

        public const string TOURNAMENTDATA_B_1 = "TOURNAMENTDATA_B_1";
        public const string TOURNAMENTDATA_B_2 = "TOURNAMENTDATA_B_2";
        public const string TOURNAMENTDATA_B_3 = "TOURNAMENTDATA_B_3";

        public const string TOURNAMENTDATA_G_1 = "TOURNAMENTDATA_G_1";
        public const string TOURNAMENTDATA_G_2 = "TOURNAMENTDATA_G_2";
        public const string TOURNAMENTDATA_G_3 = "TOURNAMENTDATA_G_3";
    }
}
