using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public class CommonValues
    {
        public const string BaseTopFolder = "PbaU12";
        public const string BinFolder = "Bin";
        public const string BaseDataFolder = "Data";
        public const string DocumentsFolder = "Documents";
        public const string TournamentDatasFolder = "TournamentDatas";
        public const string ExcelWorksheetFolder = "ExcelWorksheet";

        public const string TournamentDataFileName = "TournamentData.xml";
        public const string TournamentNameDatasFileName = "TournamentNameDatas.xml";
        public const string VenueItemDatasFileName = "VenueItemDatas.xml";
        public const string VenueDatasFileName = "VenueDatas.xml";

        public const string TournamentDataFileFilter = "大会情報ファイル(*.xml)|*.xml|All files (*.*)|*.*";
        public const string BracketExcelFileFilter = "トーナメント表 Excelファイル(*.xlsx)|*.xlsx|All files (*.*)|*.*";

        public const string DataFileExt = ".xml";
        public const string ExcelExt = ".xlsx";

        public const string ForRaffle = "（抽選会用）";

        public static readonly string[] TournamentDataStatusesStrings =
        {
            "抽選会準備中",
            "試合順調整中",
            "トーナメント表完成・配布",
            "大会準備中",
            "大会開催中",
            "大会終了"
        };

        public const string BoysText = "男子";
        public const string GirlsText = "女子";
        public const string UnknownText = "不明";
        public const string BoysMnemonic = "&B";
        public const string GirlsMnemonic = "&G";
        public const string UnknownMnemonic = "U";

        public const string NumOfTeamsFormatString = "{0}：{1} チーム（スーパーシード：{2} チーム）";

        public const string NewTournamentName = "新しい大会";
        public const string NewVenue = "新しい会場";

        public const string DATE_FORMAT_BASE = "yyyy/MM/dd";
        public const string DATE_FORMAT_WITH_WEEKDAY = "yyyy/MM/dd(ddd)";

        public const string DEFAULT_FILE_NAME = "noname";
    }
}
