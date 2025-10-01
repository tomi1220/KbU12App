using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class VenueItemData
    {
        /// <summary>
        /// 対象日
        /// </summary>
        public DateTime TargetDate { get; set; }
        public string TargetDateYMD { get; set; } = string.Empty;

        /// <summary>
        /// 会場名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public int Color { get; set; }

        /// <summary>
        /// コート リスト
        /// </summary>
        public List<string> CourtList { get; set; } = [];

        //public static VenueItemData ConvertToVenueItemData(DatVenueData datVenueData)
        //{
        //    VenueItemData venueItemData =
        //        new VenueItemData()
        //        {
        //            Name = datVenueData.VenueName,
        //            TargetDateYMD = datVenueData.TargetDate,
        //            TargetDate = Tools.CnvDate(datVenueData.TargetDate),
        //            Color = datVenueData.Color,
        //            CourtList = new List<string>(datVenueData.CourtList.Split(new string[] { "・" }, StringSplitOptions.None))
        //        };

        //    return venueItemData;
        //}

    }

    public class VenueListViewItemComparer : IComparer
    {
        public VenueListViewItemComparer()
        {
        }

        public int Compare(object? x, object? y)
        {
            if (x is ListViewItem listViewItemX &&
                y is ListViewItem listViewItemY)
            {
                if (listViewItemX.Tag is VenueItemData venueDataX &&
                    listViewItemY.Tag is VenueItemData venueDataY)
                {
                    if (venueDataX.TargetDate < venueDataY.TargetDate)
                    {
                        return -1;
                    }
                    else if (venueDataX.TargetDate > venueDataY.TargetDate)
                    {
                        return 1;
                    }
                    else
                    {
                        if (venueDataX.CourtList[0][0] < venueDataY.CourtList[0][0])
                        {
                            return -1;
                        }
                        else if (venueDataX.CourtList[0][0] > venueDataY.CourtList[0][0])
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
