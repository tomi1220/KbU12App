using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KbU12Tools
{
    public partial class DebugInfoForm : Form
    {
        #region 定数
        #endregion

        #region フィールド
        #endregion

        #region コンストラクタ
        public DebugInfoForm()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        #endregion

        #region メソッド
        public void FillDebugInfo(TournamentData tournamentData)
        {
            if (tournamentData == null)
            {
                return;
            }

            listBoxBoys.Items.Clear();
            listViewSeedNumBoys.Items.Clear();
            listViewSuperSeedBoys.Items.Clear();

            listBoxGirls.Items.Clear();
            listViewSeedNumGirls.Items.Clear();
            listViewSuperSeedGirls.Items.Clear();

            // 男子
            if (tournamentData.BrackectDataDic.TryGetValue(Category.Boys, out BracketData? boysData))
            {
                labelWorkFramesBoys.Text = boysData.AllDataInfo.FullFrames.ToString();
                labelRoundBoys.Text = boysData.AllDataInfo.Round.ToString();

                listBoxBoys.Items.Clear();
                for (int i = 0; i < boysData.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + boysData.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        boysData.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxBoys.Items.Add(itemData);
                }

                listViewSeedNumBoys.Items.Clear();
                int index = 0;
                foreach (int i in boysData.PureSeedArray)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(boysData.PureSeedArray[index].ToString());
                    listViewSeedNumBoys.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < boysData.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketData.PartInfo? partInfo =
                        boysData.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
                    if (partInfo != null)
                    {
                        lvi.SubItems.Add(partInfo.NumOfTeams.ToString());
                        lvi.SubItems.Add(partInfo.Round.ToString());
                    }
                    else
                    {
                        lvi.SubItems.Add("????");
                        lvi.SubItems.Add("????");
                    }
                    listViewSuperSeedBoys.Items.Add(lvi);
                }
            }

            // 女子
            if (tournamentData.BrackectDataDic.TryGetValue(Category.Girls, out BracketData? girlsData))
            {
                labelWorkFramesGirls.Text = girlsData.AllDataInfo.FullFrames.ToString();
                labelRoundGirls.Text = girlsData.AllDataInfo.Round.ToString();

                listBoxGirls.Items.Clear();
                for (int i = 0; i < girlsData.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + girlsData.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        girlsData.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxGirls.Items.Add(itemData);
                }

                listViewSeedNumGirls.Items.Clear();
                int index = 0;
                foreach (int i in girlsData.PureSeedArray)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(girlsData.PureSeedArray[index].ToString());
                    listViewSeedNumGirls.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < girlsData.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketData.PartInfo? partInfo =
                        girlsData.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
                    if (partInfo != null)
                    {
                        lvi.SubItems.Add(partInfo.NumOfTeams.ToString());
                        lvi.SubItems.Add(partInfo.Round.ToString());
                    }
                    else
                    {
                        lvi.SubItems.Add("????");
                        lvi.SubItems.Add("????");
                    }
                    listViewSuperSeedGirls.Items.Add(lvi);
                }
            }
        }
        #endregion

        #region ローカル・メソッド
        #endregion

        #region イベント・ハンドラ
        private void DebugInfoForm_Load(object sender, EventArgs e)
        {
            listBoxBoys.Items.Clear();
            listViewSeedNumBoys.Items.Clear();
            listViewSuperSeedBoys.Items.Clear();

            listBoxGirls.Items.Clear();
            listViewSeedNumGirls.Items.Clear();
            listViewSuperSeedGirls.Items.Clear();
        }
        #endregion
    }
}
