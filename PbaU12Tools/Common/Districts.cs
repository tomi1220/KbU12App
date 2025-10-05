using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Common
{
    public static class DistrictsList
    {
        public static Dictionary<Districts, string> DicDistrict { get; set; } =
            new Dictionary<Districts, string>()
            {
                { Districts.KagoshimaNorth, "鹿児島北" },
                { Districts.KagoshimaWest, "鹿児島西" },
                { Districts.KagoshimaSouth, "鹿児島南" },
                { Districts.KagoshimaCentral, "鹿児島中央" },
                { Districts.Sendai, "北薩川内" },
                { Districts.Izumi, "北薩出水" },
                { Districts.Aira, "姶良" },
                { Districts.Kimotsuki, "肝属" },
                { Districts.HiokiMinamisatsu, "日置・南薩" },
                { Districts.Oshima, "大島" },
            };
    }
}
