using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.Venue
{
    public class VenueItemData
    {
        /// <summary>
        /// 対象日
        /// </summary>
        public DateTime TargetDate { get; set; }

        /// <summary>
        /// 会場名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// トーナメント表の会場別の背景色
        /// </summary>
        public int BackColor { get; set; }

        /// <summary>
        /// コート リスト
        /// </summary>
        public List<string> CourtList { get; set; } = new List<string>();
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
