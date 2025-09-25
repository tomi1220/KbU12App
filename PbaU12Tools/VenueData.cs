using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools
{
    public class VenueData
    {
        /// <summary>
        /// 会場名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// コート数
        /// </summary>
        public int NumberOfCourts { get; set; } = 0;
    }

    public class VenueDatas
    {
        public List<VenueData>? VenueDatasList { get; set; } = [];
    }
}
