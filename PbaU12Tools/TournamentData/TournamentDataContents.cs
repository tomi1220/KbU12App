using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.TournamentData
{
    public partial class TournamentDataContents : UserControl
    {
        #region 定数
        private const string NumOfTeamsText = "チーム数：";
        private const string LeftParentheses = "（";
        private const string RightParentheses = "）";
        private const string SuperSeed = "スーパーシード：";
        private const string ScheduleText = "日程";
        #endregion

        public TournamentDataContents()
        {
            InitializeComponent();
        }

        public void SetTournamentDataContents(TourneyData data)
        {
            if (data != null)
            {
                richTextBox1.Clear();

                if (data.BaseDataBoys != null)
                {
                    // 男子
                    richTextBox1.SelectionColor = CommonValues.BoysColor;
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    string boysText =
                        $"【{CommonValues.BoysText}】" +
                        NumOfTeamsText + data.BaseDataBoys.NumberOfTeams.ToString() +
                        LeftParentheses +
                        SuperSeed + data.BaseDataBoys.NumberOfSuperSeed.ToString() +
                        RightParentheses + Environment.NewLine;
                    richTextBox1.AppendText(boysText);
                    richTextBox1.SelectionLength = boysText.Length;
                    // 女子
                    richTextBox1.SelectionColor = CommonValues.GirlsColor;
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    string girlsText =
                        $"【{CommonValues.GirlsText}】" +
                        NumOfTeamsText + data.BaseDataGirls.NumberOfTeams.ToString() +
                        LeftParentheses +
                        SuperSeed + data.BaseDataGirls.NumberOfSuperSeed.ToString() +
                        RightParentheses + Environment.NewLine;
                    richTextBox1.AppendText(girlsText);
                    richTextBox1.SelectionLength = girlsText.Length;
                    // 日程
                    richTextBox1.AppendText($"【{ScheduleText}】" + Environment.NewLine);
                    foreach (var venue in data.VenueDatas.VenueItemDataList)
                    {
                        richTextBox1.AppendText(
                            venue.TargetDate.ToString("yyyy-MM-dd") + "：" +
                            venue.Name +
                            LeftParentheses + string.Join('・', venue.CourtList) + RightParentheses + Environment.NewLine);
                    }
                }
            }
        }
    }
}
