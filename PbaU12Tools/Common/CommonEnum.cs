using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public enum JbaTeamRegistrationStatuses
    {
        /// <summary>不明</summary>
        Unknown = 0,
        /// <summary>登録完了</summary>
        Complete = 1,
        /// <summary>未登録</summary>
        Unregistered = 2
    }

    public enum NodeID
    {
        Root = 1,
        Year = 2,
        Tourney = 3
    }

    /// <summary>
    /// カテゴリー
    /// </summary>
    public enum Categories
    {
        /// <summary>不明・指定なし</summary>
        Unknown = 0,
        /// <summary>男子</summary>
        Boys = 1,
        /// <summary>女子</summary>
        Girls = 2,
        /// <summary>混成</summary>
        Mix = 3
    }

    public enum Districts
    {
        /// <summary>鹿児島北</summary>
        KagoshimaNorth = 1,
        /// <summary>鹿児島西</summary>
        KagoshimaWest = 2,
        /// <summary>鹿児島南</summary>
        KagoshimaSouth = 3,
        /// <summary>鹿児島中央</summary>
        KagoshimaCentral = 4,
        /// <summary>北薩川内</summary>
        Sendai = 5,
        /// <summary>北薩出水</summary>
        Izumi = 6,
        /// <summary>姶良</summary>
        Aira = 7,
        /// <summary>肝属</summary>
        Kimotsuki = 8,
        /// <summary>日置・南薩</summary>
        HiokiMinamisatsu = 9,
        /// <summary>大島</summary>
        Oshima = 10
    }

    public enum TournamentDataStatuses
    {
        None = -1,
        /// <summary>抽選会準備中</summary>
        RafflePreparation = 0,
        /// <summary>試合順調整中</summary>
        MatchOrderAdjustments = 1,
        /// <summary>トーナメント表完成・配布</summary>
        BracketCreationComplete = 2,
        /// <summary>大会準備中</summary>
        PreparingForTheTournament = 3,
        /// <summary>大会開催中</summary>
        DuringTheTournament = 4,
        /// <summary>大会終了</summary>
        EndOfTheTournament = 5
    }
}
