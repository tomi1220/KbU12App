using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    /// <summary>
    /// カテゴリー
    /// </summary>
    public enum Category
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

    public enum District
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

}
