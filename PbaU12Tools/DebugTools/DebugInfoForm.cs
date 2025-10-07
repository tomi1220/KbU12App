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
        public void FillDebugInfo(
            PbaU12Tools.TournamentData.TournamentData tournamentData,
            BracketGenData bracketGenDataBoys,
            BracketGenData bracketGenDataGirls)
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
            if (bracketGenDataBoys != null)
            {
                labelWorkFramesBoys.Text = bracketGenDataBoys.AllDataInfo!.FullFrames.ToString();
                labelRoundBoys.Text = bracketGenDataBoys.AllDataInfo.Round.ToString();

                listBoxBoys.Items.Clear();
                for (int i = 0; i < bracketGenDataBoys.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + bracketGenDataBoys.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        bracketGenDataBoys.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxBoys.Items.Add(itemData);
                }

                listViewSeedNumBoys.Items.Clear();
                int index = 0;
                foreach (int i in bracketGenDataBoys.PureSeedArray!)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(bracketGenDataBoys.PureSeedArray[index].ToString());
                    listViewSeedNumBoys.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < bracketGenDataBoys.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketGenData.PartInfo? partInfo =
                        bracketGenDataBoys.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
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
            if (bracketGenDataGirls != null)
            {
                labelWorkFramesGirls.Text = bracketGenDataGirls.AllDataInfo!.FullFrames.ToString();
                labelRoundGirls.Text = bracketGenDataGirls.AllDataInfo.Round.ToString();

                listBoxGirls.Items.Clear();
                for (int i = 0; i < bracketGenDataGirls.AllDataInfo.FullFrames / 2; i++)
                {
                    string itemData =
                        "[" + bracketGenDataGirls.AllDataInfo.FirstRoundData[i].Slots[0].ToString() +
                        "," +
                        bracketGenDataGirls.AllDataInfo.FirstRoundData[i].Slots[1].ToString() + "]";
                    listBoxGirls.Items.Add(itemData);
                }

                listViewSeedNumGirls.Items.Clear();
                int index = 0;
                foreach (int i in bracketGenDataGirls.PureSeedArray!)
                {
                    ListViewItem lvi = new((index + 1).ToString());
                    lvi.SubItems.Add(bracketGenDataGirls.PureSeedArray[index].ToString());
                    listViewSeedNumGirls.Items.Add(lvi);
                    index++;
                }
                for (int i = 0; i < bracketGenDataGirls.PartInfos.Count; i++)
                {
                    ListViewItem lvi = new((i + 1).ToString());

                    BracketGenData.PartInfo? partInfo =
                        bracketGenDataGirls.PartInfos.FirstOrDefault(p => p.PartNumber == i + 1);
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
