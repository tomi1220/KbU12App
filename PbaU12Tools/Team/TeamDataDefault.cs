using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public partial class TeamData
    {
        public static List<TeamData> CreateDefaultBoysTeamList()
        {
            List<TeamData> teamInfosB = new List<TeamData>();
            teamInfosB.AddRange(
                new TeamData[]
                {
                    new TeamData()
                    {
                        TeamName = "伊敷ミニバスケットボールスポーツ少年団",
                        ShortName = "伊敷",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "川上ミニバスケットボールスポーツ少年団",
                        ShortName = "川上",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ＣＲＥＳＴ",
                        ShortName = "ＣＲＥＳＴ",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "花野バスケットボールスポーツ少年団",
                        ShortName = "花野",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西伊敷ミニバスケットボールスポーツ少年団",
                        ShortName = "西伊敷",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "吉野東ミニバスケットボール少年団",
                        ShortName = "吉野",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "吉野ミニバスケットボールスポーツ少年団",
                        ShortName = "吉野東",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "BlackSailsJr.",
                        ShortName = "BlackSaIlsJr.",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西陵ミニバスケットボールクラブ",
                        ShortName = "西陵",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "武岡ＪＢＳ",
                        ShortName = "武岡",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "紫原ミニバスケットボールクラブ",
                        ShortName = "紫原",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "松元ミニバスケットボール少年団",
                        ShortName = "松元",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "アローズ",
                        ShortName = "アローズ",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "広木ﾐﾆﾊﾞｽｹｯﾄﾎﾞｰﾙｸﾗﾌﾞ",
                        ShortName = "広木",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LANI BASKETBALL CLUB",
                        ShortName = "ＬＡＮＩ",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "桜丘ドリームゲッターズ",
                        ShortName = "桜丘",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "谷山RED BURNINGS 男子",
                        ShortName = "谷山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "中山GOLDEN　STARS Jr.",
                        ShortName = "中山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "東谷山ミニバスケット",
                        ShortName = "東谷山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ＭＥＥＫ",
                        ShortName = "ＭＥＥＫ",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "福平ミニバスケットボールスポーツ少年団",
                        ShortName = "福平",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "和田AIRKIDS",
                        ShortName = "和田",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "宇宿レッドファルコンズ",
                        ShortName = "宇宿",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "鴨池ミニバスケットボールスポーツ少年団",
                        ShortName = "鴨池",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "清水ミニバスケットボールスポーツ少年団",
                        ShortName = "清水",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "大龍ＲＩＳＩＮＧＳＵＮ",
                        ShortName = "大龍",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "武バスケットボールスポーツ少年団",
                        ShortName = "武",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ラピスグリフィンズ",
                        ShortName = "ラピスグリフィンズ",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西田 WILD GIRAFFES",
                        ShortName = "西田",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "八幡ミニバスケットボールスポーツ少年団",
                        ShortName = "八幡",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "平佐西ミニバスケットボールクラブ",
                        ShortName = "平佐西",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "盈進ミニバスケットボールスポーツ少年団",
                        ShortName = "盈進",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "可愛ミニバスケットボールクラブ",
                        ShortName = "可愛",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "亀山ミニバスケットボールクラブ",
                        ShortName = "亀山",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "隈之城BRAVE BOYS",
                        ShortName = "隈之城",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "永利BTS",
                        ShortName = "永利",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "川内GREENBACKS",
                        ShortName = "川内",
                        District = Districts.Sendai,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "FLYERS",
                        ShortName = "ＦＬＹＥＲＳ",
                        District = Districts.Izumi,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "脇本UNITY",
                        ShortName = "脇本",
                        District = Districts.Izumi,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ノヴァアウルズ",
                        ShortName = "ノヴァアウルズ",
                        District = Districts.Izumi,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "阿久根バスケットボール少年団",
                        ShortName = "阿久根",
                        District = Districts.Izumi,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        ShortName = "姶良",
                        TeamName = "姶良ＷＩＮＧＳ",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "加治木・柁城ミニバスケットボールスポーツ少年団",
                        ShortName = "加治木柁城",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "蒲生カンファーズJr",
                        ShortName = "蒲生",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "国分シューティングスターズ",
                        ShortName = "国分",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "隼人ファルコンズ",
                        ShortName = "隼人",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "きりしま舞鶴スポーツクラブ",
                        ShortName = "きりしま舞鶴",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "霧島UNITE",
                        ShortName = "霧島UNITE",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "Laugh",
                        ShortName = "Ｌａｕｇｈ",
                        District = Districts.Aira,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "KANOYA",
                        ShortName = "ＫＡＮＯＹＡ",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "高山ミニバスケットボールスポーツ少年団",
                        ShortName = "高山",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "寿北バスケットボールクラブ",
                        ShortName = "寿北",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ネクサス鹿屋",
                        ShortName = "ネクサス鹿屋",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "東串良ＢＢＣ",
                        ShortName = "東串良ＢＢＣ",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "BLAX",
                        ShortName = "ＢＬＡＸ",
                        District = Districts.Kimotsuki,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "TROWRE",
                        ShortName = "ＴＲＯＷＲＥ",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "AXLS_12",
                        ShortName = "ＡＸＬＳ＿１２",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "川辺ミニバスケットボールスポーツ少年団",
                        ShortName = "川辺",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "喜入男子ミニバスケットボールクラブ",
                        ShortName = "喜入",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LAULE'A　TANBAバスケットボールクラブ",
                        ShortName = "ＬＡＵＬＥ’Ａ",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "指宿今和泉バスケットボールクラブ",
                        ShortName = "指宿今和泉",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "日置REX",
                        ShortName = "日置ＲＥＸ",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "妙円寺ミニバスケットボールスポーツ少年団",
                        ShortName = "妙円寺",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LEPUS SAKURAYAMA",
                        ShortName = "LEPUS SAKURAYAMA",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "枕崎バスケットボールクラブ",
                        ShortName = "枕崎",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "知覧小ﾐﾆﾊﾞｽｹｯﾄﾎﾞｰﾙ",
                        ShortName = "知覧",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "PRIDE",
                        ShortName = "ＰＲＩＤＥ",
                        District = Districts.HiokiMinamisatsu,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "朝日ミニバスケットボールスポーツ少年団",
                        ShortName = "朝日",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "小宿ミニバスケットボールスポーツ少年団",
                        ShortName = "小宿",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "名瀬ミニバスケットボールスポーツ少年団",
                        ShortName = "名瀬",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "奄美ブラックラビッツ",
                        ShortName = "奄美",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "古仁屋RED ＧＲＯＷＳ",
                        ShortName = "古仁屋",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "伊津部",
                        ShortName = "伊津部",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "徳之島町ﾐﾆﾊﾞｽｹｯﾄﾎﾞｰﾙｽﾎﾟｰﾂ少年団",
                        ShortName = "徳之島",
                        District = Districts.Oshima,
                        Category = Categories.Boys,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    }
                });

            return teamInfosB;
        }

        public static List<TeamData> CreateDefaultGirlsTeamList()
        {
            List<TeamData> teamInfosG = new List<TeamData>();
            teamInfosG.AddRange(
                new TeamData[]
                {
                    new TeamData()
                    {
                        TeamName = "伊敷ミニバスケットボールスポーツ少年団",
                        ShortName = "伊敷",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "川上ミニバスケットボールスポーツ少年団",
                        ShortName = "川上",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ＣＲＥＳＴ",
                        ShortName = "ＣＲＥＳＴ",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "花野バスケットボールスポーツ少年団",
                        ShortName = "花野",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西伊敷ミニバスケットボールスポーツ少年団",
                        ShortName = "西伊敷",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "吉野東ミニバスケットボール少年団",
                        ShortName = "吉野",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "吉野ミニバスケットボールスポーツ少年団",
                        ShortName = "吉野東",
                        District = Districts.KagoshimaNorth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西陵ミニバスケットボールクラブ",
                        ShortName = "西陵",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "武岡ＪＢＳ",
                        ShortName = "武岡",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "紫原ミニバスケットボールクラブ",
                        ShortName = "紫原",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "松元ミニバスケットボール少年団",
                        ShortName = "松元",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "アローズ",
                        ShortName = "アローズ",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "広木ﾐﾆﾊﾞｽｹｯﾄﾎﾞｰﾙｸﾗﾌﾞ",
                        ShortName = "広木",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LANI BASKETBALL CLUB",
                        ShortName = "ＬＡＮＩ",
                        District = Districts.KagoshimaWest,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "桜丘ドリームゲッターズ",
                        ShortName = "桜丘",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "谷山RED BURNINGS 女子",
                        ShortName = "谷山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "中山GOLDEN　STARS Jr.",
                        ShortName = "中山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "東谷山ミニバスケット",
                        ShortName = "東谷山",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ＭＥＥＫ",
                        ShortName = "ＭＥＥＫ",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "福平ミニバスケットボールスポーツ少年団",
                        ShortName = "福平",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "和田AIRKIDS",
                        ShortName = "和田",
                        District = Districts.KagoshimaSouth,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "宇宿レッドファルコンズ",
                        ShortName = "宇宿",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "鴨池ミニバスケットボールスポーツ少年団",
                        ShortName = "鴨池",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "清水ミニバスケットボールスポーツ少年団",
                        ShortName = "清水",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "武バスケットボールスポーツ少年団",
                        ShortName = "武",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ラピスグリフィンズ",
                        ShortName = "ラピスグリフィンズ",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "西田 WILD GIRAFFES",
                        ShortName = "西田",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "八幡ミニバスケットボールスポーツ少年団",
                        ShortName = "八幡",
                        District = Districts.KagoshimaCentral,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "平佐西ミニバスケットボールクラブ",
                        ShortName = "平佐西",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "育英ＢＢＣ",
                        ShortName = "育英",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "盈進女子ミニバスケットボールスポーツ少年団",
                        ShortName = "盈進",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "可愛Shining　Star",
                        ShortName = "可愛",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "亀山ミニバスケットボールクラブ",
                        ShortName = "亀山",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "隈之城 White Bears",
                        ShortName = "隈之城",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "proud wings",
                        ShortName = "ｐｒｏｕｄ　ｗｉｎｇｓ",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "川内バスケットボールクラブ",
                        ShortName = "川内",
                        District = Districts.Sendai,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "米ノ津東スマイルファイターズ",
                        ShortName = "米ノ津東",
                        District = Districts.Izumi,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "FLYERS",
                        ShortName = "ＦＬＹＥＲＳ",
                        District = Districts.Izumi,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "脇本UNITY",
                        ShortName = "脇本",
                        District = Districts.Izumi,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "阿久根バスケットボール少年団",
                        ShortName = "阿久根",
                        District = Districts.Izumi,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "姶良ＷＩＮＧＳ",
                        ShortName = "姶良",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "加治木・柁城ミニバスケットボールスポーツ少年団",
                        ShortName = "加治木柁城",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "蒲生カンファーズJr",
                        ShortName = "蒲生",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "国分シューティングスターズ",
                        ShortName = "国分",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "隼人ファルコンズ",
                        ShortName = "隼人",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "きりしま舞鶴スポーツクラブ",
                        ShortName = "きりしま舞鶴",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "霧島UNITE",
                        ShortName = "霧島UNITE",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "Laugh",
                        ShortName = "Ｌａｕｇｈ",
                        District =    Districts.Aira,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "KANOYA",
                        ShortName = "ＫＡＮＯＹＡ",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "高山ミニバスケットボールスポーツ少年団",
                        ShortName = "高山",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "寿北バスケットボールクラブ",
                        ShortName = "寿北",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "ネクサス鹿屋",
                        ShortName = "ネクサス鹿屋",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "東串良ＢＢＣ",
                        ShortName = "東串良ＢＢＣ",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "BLAX",
                        ShortName = "ＢＬＡＸ",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "SKY　BASKETBALL　CLUB",
                        ShortName = "ＳＫＹ ＢＣ",
                        District =    Districts.Kimotsuki,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "TROWRE",
                        ShortName = "ＴＲＯＷＲＥ",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "加世田女子ミニバスケットボール　コミュニティークラブ",
                        ShortName = "加世田",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "喜入女子ミニバスケットボールクラブ",
                        ShortName = "喜入",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LAULE'A　TANBAバスケットボールクラブ",
                        ShortName = "ＬＡＵＬＥ’Ａ",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "指宿今和泉バスケットボールクラブ",
                        ShortName = "指宿今和泉",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "日置REX",
                        ShortName = "日置ＲＥＸ",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "妙円寺ミニバスケットボールスポーツ少年団",
                        ShortName = "妙円寺",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "LEPUS SAKURAYAMA",
                        ShortName = "LEPUS SAKURAYAMA",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "枕崎バスケットボールクラブ",
                        ShortName = "枕崎",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "知覧小ﾐﾆﾊﾞｽｹｯﾄﾎﾞｰﾙ",
                        ShortName = "知覧",
                        District =    Districts.HiokiMinamisatsu,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "朝日ミニバスケットボールスポーツ少年団",
                        ShortName = "朝日",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "小宿ミニバスケットボールスポーツ少年団",
                        ShortName = "小宿",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "名瀬ミニバスケットボールスポーツ少年団",
                        ShortName = "名瀬",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "奄美ブラックラビッツ",
                        ShortName = "奄美",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "古仁屋RED ＧＲＯＷＳ",
                        ShortName = "古仁屋",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "伊津部",
                        ShortName = "伊津部",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    },
                    new TeamData()
                    {
                        TeamName = "知名Star whales B.B.C",
                        ShortName = "知名",
                        District =    Districts.Oshima,
                        Category = Categories.Girls,
                        JbaStatus = JbaTeamRegistrationStatuses.Complete
                    }
                });

            return teamInfosG;
        }
    }
}
