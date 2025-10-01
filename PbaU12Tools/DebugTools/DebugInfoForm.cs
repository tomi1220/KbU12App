using PbaU12Tools.Bracket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools
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
        public void FillDebugInfo(PbaU12Tools.TournamentData.TournamentData tournamentData)
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
            //if (tournamentData.BrackectDataDic.TryGetValue(Category.Boys, out BracketData? boysData))
            if (tournamentData.BrackectDataBoys != null)
            {
                labelWorkFramesBoys.Text = tournamentData.BrackectDataBoys.AllDataInfo.FullFrames.ToString();
                labelRoundBoys.Text = tournamentData.BrackectDataBoys.AllDataInfo.Round.ToString();

                listBoxBoys.Items.Clear();
                for (int i = 0; i < tournamentData.BrackectDataBoys.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + tournamentData.BrackectDataBoys.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        tournamentData.BrackectDataBoys.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxBoys.Items.Add(itemData);
                }

                listViewSeedNumBoys.Items.Clear();
                int index = 0;
                foreach (int i in tournamentData.BrackectDataBoys.PureSeedArray)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(tournamentData.BrackectDataBoys.PureSeedArray[index].ToString());
                    listViewSeedNumBoys.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < tournamentData.BrackectDataBoys.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketData.PartInfo? partInfo =
                        tournamentData.BrackectDataBoys.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
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
            if (tournamentData.BrackectDataGirls != null)
            {
                labelWorkFramesGirls.Text = tournamentData.BrackectDataGirls.AllDataInfo.FullFrames.ToString();
                labelRoundGirls.Text = tournamentData.BrackectDataGirls.AllDataInfo.Round.ToString();

                listBoxGirls.Items.Clear();
                for (int i = 0; i < tournamentData.BrackectDataGirls.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + tournamentData.BrackectDataGirls.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        tournamentData.BrackectDataGirls.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxGirls.Items.Add(itemData);
                }

                listViewSeedNumGirls.Items.Clear();
                int index = 0;
                foreach (int i in tournamentData.BrackectDataGirls.PureSeedArray)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(tournamentData.BrackectDataGirls.PureSeedArray[index].ToString());
                    listViewSeedNumGirls.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < tournamentData.BrackectDataGirls.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketData.PartInfo? partInfo =
                        tournamentData.BrackectDataGirls.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
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
