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
        //private readonly string _executablePath;

        //private string _tournamentName = string.Empty;

        //private string? _tournamentDataFilePath = null;

        //private TournamentData? _tournamentDataOrg;
        //private TournamentData? _tournamentData;
        #endregion

        #region コンストラクタ

        public TournamentDataBaseDialog()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;

            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;
        }
        #endregion

        #region プロパティ
        public TournamentData? TournamentData { get; set; } = null;
        #endregion

        #region ローカル・メソッド
        private void setTournamentDataInformation(TournamentData? tournamentData)
        {
            Trace.Assert(tournamentData != null);
            if (tournamentData == null)
            {
                return;
            }

            // 大会名
            if (!string.IsNullOrEmpty(tournamentData.TournamentName))
            {
                this.Text += $"［{tournamentData.TournamentName}］";
            }
            // トーナメント表データ
            if (tournamentData.BrackectDataBoys != null)
            {
                // 男子
                if (tournamentData.BaseDataBoys.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlBoys.CategoryValidity = true;
                    numOfTeamsCtrlBoys.Category = Categories.Boys;
                    numOfTeamsCtrlBoys.NumberOfTeams = tournamentData.BaseDataBoys.NumberOfTeams;
                }
            }
            if (tournamentData.BrackectDataGirls != null)
            {
                // 女子
                if (tournamentData.BaseDataGirls.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlGirls.CategoryValidity = true;
                    numOfTeamsCtrlGirls.Category = Categories.Girls;
                    numOfTeamsCtrlGirls.NumberOfTeams = tournamentData.BaseDataGirls.NumberOfTeams;
                }
            }
            if (tournamentData.VenueDatas != null)
            {
                foreach (var item in tournamentData.VenueDatas)
                {
                    updateListViewVenue(item, null);
                }
            }
        }

        private void updateVenueItemData(ListViewItem? listViewItem)
        {
            using VenueSettingDialog dialog = new VenueSettingDialog();
            List<VenueItemData> otherVenueDatas = GetOtherVenueDatas(listViewItem);
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

        private List<VenueItemData> GetOtherVenueDatas(ListViewItem? currentListViewItem)
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
        #endregion

        #region イベント・ハンドラ

        private void TournamentDataBaseDialog_Load(object sender, EventArgs e)
        {
            setTournamentDataInformation(TournamentData);
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
