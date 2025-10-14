using PbaU12Tools.Venue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.TournamentData
{
    public partial class TournamentDataBaseDialog : Form
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region フィールド
        private TourneyData? _tournamentDataOrg;
        #endregion

        #region コンストラクタ

        public TournamentDataBaseDialog(TourneyData tournamentData)
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;

            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;

            _tournamentDataOrg = tournamentData.Clone();
        }
        #endregion

        #region プロパティ
        public TourneyData? NewTournamentData { get; set; } = null;
        #endregion

        #region ローカル・メソッド
        private void setTournamentDataInformation()
        {
            Trace.Assert(_tournamentDataOrg != null);
            if (_tournamentDataOrg == null)
            {
                return;
            }

            // 大会名
            if (!string.IsNullOrEmpty(_tournamentDataOrg.TournamentName))
            {
                this.Text += $"［{_tournamentDataOrg.TournamentName}］";
            }
            // トーナメント表データ
            if (_tournamentDataOrg.BaseDataBoys != null)
            {
                // 男子
                if (_tournamentDataOrg.BaseDataBoys.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlBoys.CategoryValidity = true;
                    numOfTeamsCtrlBoys.Category = Categories.Boys;
                    numOfTeamsCtrlBoys.NumberOfTeams = _tournamentDataOrg.BaseDataBoys.NumberOfTeams;
                }
            }
            if (_tournamentDataOrg.BaseDataGirls != null)
            {
                // 女子
                if (_tournamentDataOrg.BaseDataGirls.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlGirls.CategoryValidity = true;
                    numOfTeamsCtrlGirls.Category = Categories.Girls;
                    numOfTeamsCtrlGirls.NumberOfTeams = _tournamentDataOrg.BaseDataGirls.NumberOfTeams;
                }
            }
            if (_tournamentDataOrg.VenueDatas != null)
            {
                foreach (var item in _tournamentDataOrg.VenueDatas.VenueItemDataList)
                {
                    updateListViewVenue(item, null);
                }
            }
        }

        private void updateVenueItemData(ListViewItem? listViewItem)
        {
            using VenueSettingDialog dialog = new VenueSettingDialog();
            List<VenueItemData> otherVenueDatas = getOtherVenueDatas(listViewItem);
            dialog.OtherVenueList = otherVenueDatas;
            if (listViewItem != null)
            {
                if (listViewItem.Tag is VenueItemData venueItemData)
                {
                    dialog.VenueData = venueItemData;
                }
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                updateListViewVenue(dialog.VenueData!, listViewItem);
            }
        }

        private void updateListViewVenue(VenueItemData venueItemData, ListViewItem? listViewItem)
        {
            if (listViewItem == null)
            {
                listViewItem = new ListViewItem();
                listViewItem.UseItemStyleForSubItems = false;
                listViewItem.Text = venueItemData.TargetDate.ToString("yyyy-MM-dd");
                listViewItem.SubItems.Add(venueItemData.Name);
                ListViewItem.ListViewSubItem subItem =
                    listViewItem.SubItems.Add(string.Join("・", venueItemData.CourtList));
                subItem.BackColor = Color.FromArgb(venueItemData.BackColor);
                listViewItem.Tag = venueItemData;
                listViewVenue.Items.Add(listViewItem);
            }
            else
            {
                listViewItem.Text = venueItemData.TargetDate.ToString("yyyy-MM-dd");
                listViewItem.SubItems[1].Text = venueItemData.Name;
                listViewItem.SubItems[2].Text = string.Join("・", venueItemData.CourtList);
                listViewItem.SubItems[2].BackColor = Color.FromArgb(venueItemData.BackColor);
                listViewItem.Tag = venueItemData;
            }
        }

        private List<VenueItemData> getOtherVenueDatas(ListViewItem? currentListViewItem)
        {
            List<VenueItemData> otherVenueDatas = new List<VenueItemData>();
            foreach (ListViewItem lvi in listViewVenue.Items)
            {
                if (lvi != currentListViewItem)
                {
                    if (lvi.Tag is VenueItemData venueData)
                    {
                        otherVenueDatas.Add(venueData);
                    }
                }
            }
            return otherVenueDatas;
        }

        private TourneyData createTournamentData()
        {
            TourneyData tournamentData = new TourneyData();
            if (numOfTeamsCtrlBoys.CategoryValidity)
            {
                tournamentData.BaseDataBoys =
                    new()
                    {
                        Category = Categories.Boys,
                        NumberOfTeams = numOfTeamsCtrlBoys.NumberOfTeams,
                        NumberOfSuperSeed = numOfTeamsCtrlBoys.NumberOfSuperSeeds,
                    };
            }
            if (numOfTeamsCtrlGirls.CategoryValidity)
            {
                tournamentData.BaseDataGirls =
                    new()
                    {
                        Category = Categories.Girls,
                        NumberOfTeams = numOfTeamsCtrlGirls.NumberOfTeams,
                        NumberOfSuperSeed = numOfTeamsCtrlGirls.NumberOfSuperSeeds,
                    };
            }
            foreach (ListViewItem item in listViewVenue.Items)
            {
                if (item.Tag is VenueItemData venueItemData)
                {
                    tournamentData.VenueDatas.VenueItemDataList.Add(venueItemData);
                }
            }

            return tournamentData;
        }

        #endregion

        #region イベント・ハンドラ

        private void TournamentDataBaseDialog_Load(object sender, EventArgs e)
        {
            setTournamentDataInformation();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NewTournamentData = createTournamentData();
        }

        #region ［会場情報］
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（追加）］
            updateVenueItemData(null);
        }

        private void buttonEditVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（編集）］
            if (listViewVenue.SelectedItems.Count == 1)
            {
                updateVenueItemData(listViewVenue.SelectedItems[0]);
            }
        }

        private void buttonDeleteVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（削除）］
            if (listViewVenue.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    this,
                    $"選択されている {listViewVenue.SelectedItems.Count.ToString()}項目を削除します。",
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void listViewVenue_DoubleClick(object sender, EventArgs e)
        {
            if (listViewVenue.SelectedItems.Count == 1)
            {
                updateVenueItemData(listViewVenue.SelectedItems[0]);
            }
        }
        #endregion

        #endregion
    }
}
