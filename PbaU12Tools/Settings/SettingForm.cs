using PbaU12Tools.Common;
using PbaU12Tools.TournamentName;
using PbaU12Tools.Venue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

//using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PbaU12Tools.Settings
{
    public partial class SettingForm : Form
    {
        #region Enum
        private enum SaveType
        {
            Save,
            Export
        }
        #endregion

        #region 定数
        private const int ColumnTeamNameKanaIndex = 1;
        private const int ColumnTeamNameShortIndex = 2;
        private const int ColumnDistrictIndex = 3;
        private const int ColumnJbaStatusIndex = 4;
        #endregion

        #region クラス
        #endregion

        #region フィールド
        private readonly string _baseFolder;
        #endregion

        #region コンストラクタ

        public SettingForm()
        {
            InitializeComponent();

            this.Icon = CommonResources.SettingsIcon;

            imageListTournamentNames.Images.Add(CommonResources.BracketDodgerblue);
            buttonAddTournamentName.Image = CommonResources.Add;
            buttonEditTournamentName.Image = CommonResources.Edit;
            buttonDeleteTournamentName.Image = CommonResources.Delete;
            buttonSaveTournamentNameData.Image = CommonResources.Save;

            imageListVenueListView.Images.Add(CommonResources.Home);
            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;
            buttonSaveVenue.Image = CommonResources.Save;
            buttonImportVenue.Image = CommonResources.Import;
            buttonExportVenue.Image = CommonResources.Export;

            imageListTeamRegistration.Images.Add(CommonResources.BoysTeam);
            imageListTeamRegistration.Images.Add(CommonResources.GirlsTeam);
            imageListTeamRegistration.Images.Add(CommonResources.UnknownTeamXXX);
            imageListTeamRegistration.Images.Add(CommonResources.UnknownTeam);
            tabPageBoysTeamList.ImageIndex = 0;
            tabPageGirlsTeamList.ImageIndex = 1;
            buttonAddTeam.Image = CommonResources.Add;
            buttonEditTeam.Image = CommonResources.Edit;
            buttonDeleteTeam.Image = CommonResources.Delete;
            buttonSaveTeams.Image = CommonResources.Save;

            // 保存先ページを削除（後で拡張する予定なので、とりあえずデザインは残す）
            tabControl1.TabPages.Remove(tabPageDataSaveFolders);

            _baseFolder = CommonTools.GetBaseFolder();
        }
        #endregion

        #region プロパティ
        //public string DataFolder { get; set; } = string.Empty;
        #endregion

        #region ローカル・メソッド
        private void loadTournamentNameDatas()
        {
            TournamentNameDatas? tournamentNameDatas;

            try
            {
                string filePath =
                    Path.Combine(
                        CommonTools.DataFolderPath,
                        CommonValues.TournamentNameDatasFileName);

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    tournamentNameDatas = TournamentNameDatas.Deserialize(xmlText);

                    if (tournamentNameDatas != null)
                    {
                        if (tournamentNameDatas.TournamentNameDatasList != null)
                        {
                            List<ListViewItem> listViewItems = [];
                            foreach (var tnd in tournamentNameDatas.TournamentNameDatasList)
                            {
                                ListViewItem item = updateListViewItemForTournamentName(tnd, null);
                                listViewItems.Add(item);
                            }
                            listViewTournamentNames.Items.AddRange([.. listViewItems]);
                        }
                    }
                    adjustTournamentNameColumnWidth();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "大会名データがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void adjustTournamentNameColumnWidth()
        {
            columnTournamentName.Width = -2;
            columnTournamentFixedNumOfTeams.Width = -2;
        }

        private static ListViewItem updateListViewItemForTournamentName(
            TournamentNameData tournamentNameData,
            ListViewItem? item)
        {
            item ??= new ListViewItem();
            item.Text = tournamentNameData.Name;
            item.ImageIndex = 0;
            item.Tag = tournamentNameData;
            if (tournamentNameData.FixedNumOfBoysTeams > 0 ||
                tournamentNameData.FixedNumOfGirlsTeams > 0)
            {
                string subItemText =
                    $"男子={tournamentNameData.FixedNumOfBoysTeams} /女子={tournamentNameData.FixedNumOfGirlsTeams}";
                item.SubItems.Add(subItemText);
            }
            else
            {
                item.SubItems.Add(string.Empty);
            }

            return item;
        }

        private string? serializeTournamentNameDatas()
        {
            TournamentNameDatas? tournamentNameDatas = new();

            foreach (ListViewItem item in listViewTournamentNames.Items)
            {
                if (item.Tag is TournamentNameData TournamentNameData)
                {
                    tournamentNameDatas.TournamentNameDatasList!.Add(TournamentNameData);
                }
            }

            string xmlText = TournamentNameDatas.Serialize(tournamentNameDatas)!;

            return xmlText;
        }

        private void saveTournamentNameDatas()
        {
            string? xmlText = serializeTournamentNameDatas();

            try
            {
                string filePath =
                    Path.Combine(
                        CommonTools.DataFolderPath, CommonValues.TournamentNameDatasFileName);

                using var sw = new StreamWriter(filePath);
                sw.Write(xmlText);

                MessageBox.Show(
                    this,
                    "大会名データをセーブしました。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "大会名データがセーブできませんでした" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void loadVenueDatas()
        {
            try
            {
                VenueDatas? venueDatas = VenueDatas.DeserializeVenueDatas();

                addAllVenueDatas(venueDatas);

                adjustVenueDataColumnWidth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "会場データがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void addAllVenueDatas(VenueDatas? venueDatas)
        {
            listViewVenueDatas.Items.Clear();

            if (venueDatas != null)
            {
                if (venueDatas!.VenueDatasList != null)
                {
                    List<ListViewItem> listViewItems = [];
                    foreach (var vd in venueDatas.VenueDatasList)
                    {
                        ListViewItem item = updateListViewItemForVenueData(vd, null);
                        listViewItems.Add(item);
                    }
                    listViewVenueDatas.Items.AddRange([.. listViewItems]);
                }
            }
        }

        private void adjustVenueDataColumnWidth()
        {
            columnVenueName.Width = -2;
            columnCourts.Width = -2;
        }

        private static ListViewItem updateListViewItemForVenueData(
            VenueData venueData,
            ListViewItem? item)
        {
            item ??= new ListViewItem();
            item.Text = venueData.Name;
            item.ImageIndex = 0;
            item.Tag = venueData;
            if (venueData.NumberOfCourts > 0)
            {
                item.SubItems.Add(venueData.NumberOfCourts.ToString());
            }
            else
            {
                item.SubItems.Add(string.Empty);
            }

            return item;
        }

        private void saveVenueDatas(SaveType saveType, string? saveFilePath = null)
        {
            string? xmlText = serializeVenueDatas();

            if (xmlText == null)
            {
                return;
            }

            try
            {
                string filePath;
                if (string.IsNullOrEmpty(saveFilePath))
                {
                    filePath =
                        Path.Combine(
                            CommonTools.DataFolderPath,
                            CommonValues.VenueDatasFileName);
                }
                else
                {
                    filePath = saveFilePath;
                }

                using var sw = new StreamWriter(filePath);
                sw.Write(xmlText);

                MessageBox.Show(
                    this,
                    (saveType == SaveType.Save
                        ? "会場データをセーブしました。" : "会場データをエクスポートしました。"),
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    (saveType == SaveType.Save
                        ? "会場データがセーブできませんでした"
                        : "会場データがエクスポートできませんでした。") + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string? serializeVenueDatas()
        {
            VenueDatas? venueDatas = new();

            foreach (ListViewItem item in listViewVenueDatas.Items)
            {
                if (item.Tag is VenueData venueData)
                {
                    venueDatas.VenueDatasList!.Add(venueData);
                }
            }

            string xmlText = VenueDatas.Serialize(venueDatas)!;

            return xmlText;
        }

        private void importVenueData()
        {
            using OpenFileDialog ofd = new();
            ofd.Title = "インポートする会場データファイルを選択してください。";
            ofd.Filter = "会場データファイル(*.xml)|*.xml|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            DialogResult result = DialogResult.None;
            if (listViewVenueDatas.Items.Count > 0)
            {
                result =
                    MessageBox.Show(
                        this,
                        "現在の会場データをインポートするデータで置き換えますか？" + Environment.NewLine +
                        Environment.NewLine +
                        "［はい］置き換える" + Environment.NewLine +
                        "［いいえ］会場名が異なるものだけ追加する" + Environment.NewLine +
                        "［キャンセル］インポートを中止する",
                        this.Text,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation);
            }
            if (result == DialogResult.Cancel)
            {
                return;
            }

            VenueDatas? venueDatas = VenueDatas.DeserializeVenueDatas(ofd.FileName);
            if (result == DialogResult.Yes)
            {
                addAllVenueDatas(venueDatas);
            }
            else
            {
                if (venueDatas != null)
                {
                    List<ListViewItem> listViewItems = [];
                    foreach (var vd in venueDatas.VenueDatasList!)
                    {
                        ListViewItem[] items =
                            listViewVenueDatas.Items.Find(vd.Name, false);
                        if (items.Length == 0)
                        {
                            ListViewItem item = updateListViewItemForVenueData(vd, null);
                            listViewItems.Add(item);
                        }
                    }
                    listViewVenueDatas.Items.AddRange([.. listViewItems]);
                }
            }
        }

        private void exportVenueData()
        {
            using SaveFileDialog sfd = new();
            sfd.Title = "エクスポートする会場データファイルを指定してください。";
            sfd.Filter = "会場データファイル(*.xml)|*.xml|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string? xmlText = serializeVenueDatas();

            if (xmlText == null)
            {
                MessageBox.Show(
                    this,
                    "有効な会場データがありません。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            saveVenueDatas(SaveType.Export, sfd.FileName);
        }

        private void loadTeamInfos()
        {
            try
            {
                TeamDatas? teamDatasBoys = TeamDatas.DeserializeTeamDatas(Categories.Boys);
                if (teamDatasBoys == null)
                {
                    teamDatasBoys =
                        new TeamDatas()
                        {
                            TeamDatasList = TeamData.CreateDefaultBoysTeamList()
                        };
                }
                addAllTeamDatas(Categories.Boys, teamDatasBoys);
                adjustTeamDataColumnWidth(Categories.Boys);

                TeamDatas? teamDatasGirls = TeamDatas.DeserializeTeamDatas(Categories.Girls);
                if (teamDatasGirls == null)
                {
                    teamDatasGirls =
                        new TeamDatas()
                        {
                            TeamDatasList = TeamData.CreateDefaultGirlsTeamList()
                        };
                }
                addAllTeamDatas(Categories.Girls, teamDatasGirls);
                adjustTeamDataColumnWidth(Categories.Girls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "会場データがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void addAllTeamDatas(Categories category, TeamDatas? teamDatas)
        {
            ListView listView;

            if (category == Categories.Girls)
            {
                listView = listViewTeamDataGirls;
            }
            else
            {
                listView = listViewTeamDataBoys;
            }

            listView.Items.Clear();

            if (teamDatas != null)
            {
                if (teamDatas!.TeamDatasList != null)
                {
                    List<ListViewItem> listViewItems = [];
                    foreach (var vd in teamDatas.TeamDatasList)
                    {
                        ListViewItem item = updateListViewItemForTeamData(vd, listView, null);
                        listViewItems.Add(item);
                    }
                    listView.Items.AddRange([.. listViewItems]);
                }
            }
        }

        private void adjustTeamDataColumnWidth(Categories category)
        {
            if (category == Categories.Girls)
            {
                columnTeamNameGirls.Width = -2;
                columnTeamNameKanaGirls.Width = 0;
                columnTeamNameShortGirls.Width = -2;
                columnDistrictGirls.Width = -2;
                columnJbaStatusGirls.Width = -2;
            }
            else
            {
                columnTeamNameBoys.Width = -2;
                columnTeamNameKanaBoys.Width = 0;
                columnTeamNameShortGirls.Width = -2;
                columnDistrictBoys.Width = -2;
                columnJbaStatusBoys.Width = -2;
            }
        }

        private static ListViewItem updateListViewItemForTeamData(
            TeamData teamData,
            ListView listView,
            ListViewItem? item)
        {
            if (item == null)
            {
                item ??= new ListViewItem();
                item.SubItems.Add(teamData.TeamNameKana ?? string.Empty);
                item.SubItems.Add(teamData.ShortName ?? string.Empty);
                if (DistrictsList.DicDistrict.TryGetValue(teamData.District, out string? district))
                {
                    item.SubItems.Add(district);
                }
                if (JbaTeamRegistrationStatusesList.DicJbaTeamRegistrationStatuses.TryGetValue(
                    teamData.JbaStatus, out string? jbaStatus))
                {
                    item.SubItems.Add(jbaStatus);
                }
            }
            else
            {
                item.SubItems[ColumnTeamNameKanaIndex].Text = teamData.TeamNameKana ?? string.Empty;
                item.SubItems[ColumnTeamNameShortIndex].Text = teamData.ShortName ?? string.Empty;
                if (DistrictsList.DicDistrict.TryGetValue(teamData.District, out string? district))
                {
                    item.SubItems[ColumnDistrictIndex].Text = district;
                }
                else
                {
                    item.SubItems[ColumnDistrictIndex].Text = string.Empty;
                }
                if (JbaTeamRegistrationStatusesList.DicJbaTeamRegistrationStatuses.TryGetValue(
                    teamData.JbaStatus, out string? jbaStatus))
                {
                    item.SubItems[ColumnJbaStatusIndex].Text = jbaStatus;
                }
                else
                {
                    item.SubItems[ColumnJbaStatusIndex].Text = string.Empty;
                }
            }
            item.Text = teamData.TeamName;
            if (teamData.JbaStatus == JbaTeamRegistrationStatuses.Complete)
            {
                item.UseItemStyleForSubItems = true;
                if (teamData.Category == Categories.Girls)
                {
                    item.ImageIndex = 1;
                }
                else
                {
                    item.ImageIndex = 0;
                }
            }
            else
            {
                item.UseItemStyleForSubItems = false;
                if (teamData.JbaStatus == JbaTeamRegistrationStatuses.Unknown)
                {
                    item.ImageIndex = 2;
                    item.SubItems[ColumnJbaStatusIndex].ForeColor = Color.Gold;
                }
                else
                {
                    item.ImageIndex = 3;
                    item.SubItems[ColumnJbaStatusIndex].ForeColor = Color.Red;
                }
            }
            item.Tag = teamData;

            return item;
        }

        private void saveTeamDatas(SaveType saveType)
        {
            string? xmlText = serializeTeamDatas();

            if (xmlText == null)
            {
                return;
            }

            try
            {
                string filePathBoys =
                    Path.Combine(
                        CommonTools.DataFolderPath,
                        CommonValues.TeamDatasFileName(Categories.Boys));

                using var swBoys = new StreamWriter(filePathBoys);
                swBoys.Write(xmlText);

                string filePathGirls =
                    Path.Combine(
                        CommonTools.DataFolderPath,
                        CommonValues.TeamDatasFileName(Categories.Girls));

                using var swGirls = new StreamWriter(filePathGirls);
                swGirls.Write(xmlText);

                MessageBox.Show(
                    this,
                    "チームデータをセーブしました。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "チームデータがセーブできませんでした" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string? serializeTeamDatas()
        {
            TeamDatas? teamDatasBoys = new();

            foreach (ListViewItem item in listViewTeamDataBoys.Items)
            {
                if (item.Tag is TeamData teamData)
                {
                    teamDatasBoys.TeamDatasList!.Add(teamData);
                }
            }

            string xmlText = TeamDatas.Serialize(teamDatasBoys)!;

            return xmlText;
        }

        private void openSettingsTourneyNameDialog(
            TournamentNameData? tournamentNameData,
            ListViewItem? listViewItem)
        {
            using var settingsTourneyNameDialog = new SettingsTourneyNameDialog();
            settingsTourneyNameDialog.TourneneyNameData = tournamentNameData;
            if (settingsTourneyNameDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (listViewItem != null)
                {
                    updateListViewItemForTournamentName(
                        settingsTourneyNameDialog.TourneneyNameData!, listViewItem);
                }
                else
                {
                    listViewItem =
                        updateListViewItemForTournamentName(
                            settingsTourneyNameDialog.TourneneyNameData!, null);
                    listViewTournamentNames.Items.Add(listViewItem);
                }
                adjustTournamentNameColumnWidth();
            }
        }

        private void openSettingsVenueDataDialog(
            VenueData? venueData,
            ListViewItem? listViewItem)
        {
            using var settingsVenueDialog = new SettingsVenueDialog();
            settingsVenueDialog.VenueData = venueData;
            if (settingsVenueDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (listViewItem != null)
                {
                    updateListViewItemForVenueData(
                        settingsVenueDialog.VenueData!, listViewItem);
                }
                else
                {
                    listViewItem =
                        updateListViewItemForVenueData(
                            settingsVenueDialog.VenueData!, null);
                    listViewVenueDatas.Items.Add(listViewItem);
                }
                adjustVenueDataColumnWidth();
            }
        }

        private void openSettingsTeamDataDialog(
            Categories category,
            TeamData? teamData,
            ListView listView,
            ListViewItem? listViewItem)
        {
            using var settingsTeamDialog = new SettingsTeamDialog();
            settingsTeamDialog.Category = category;
            settingsTeamDialog.TeamData = teamData;
            if (settingsTeamDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (listViewItem != null)
                {
                    updateListViewItemForTeamData(
                        settingsTeamDialog.TeamData!, listView, listViewItem);
                }
                else
                {
                    listViewItem =
                        updateListViewItemForTeamData(
                            settingsTeamDialog.TeamData!, listView, null);
                    listView.Items.Add(listViewItem);
                }
                adjustTeamDataColumnWidth(category);
            }
        }

        private void editTournamentName()
        {
            if (listViewTournamentNames.SelectedItems.Count == 1)
            {
                if (listViewTournamentNames.SelectedItems[0].Tag is
                    TournamentNameData tournamentNameData)
                {
                    openSettingsTourneyNameDialog(
                        tournamentNameData, listViewTournamentNames.SelectedItems[0]);
                }
            }
        }

        private void editVenue()
        {
            if (listViewVenueDatas.SelectedItems.Count == 1)
            {
                if (listViewVenueDatas.SelectedItems[0].Tag is
                    VenueData venueData)
                {
                    openSettingsVenueDataDialog(
                        venueData, listViewVenueDatas.SelectedItems[0]);
                }
            }
        }

        private void editTeamData(ListView listView, Categories category)
        {
            if (listView.SelectedItems.Count == 1)
            {
                if (listView.SelectedItems[0].Tag is
                    TeamData teamData)
                {
                    openSettingsTeamDataDialog(
                        category, teamData, listView, listView.SelectedItems[0]);
                }
            }
        }

        #endregion

        #region イベント・ハンドラ
        private void SettingForm_Load(object sender, EventArgs e)
        {
            loadTournamentNameDatas();

            loadVenueDatas();

            loadTeamInfos();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 大会ページ
        private void buttonAddTournamentName_Click(object sender, EventArgs e)
        {
            openSettingsTourneyNameDialog(null, null);
        }

        private void buttonEditTournamentName_Click(object sender, EventArgs e)
        {
            editTournamentName();
        }

        private void buttonDeleteTournamentName_Click(object sender, EventArgs e)
        {
            if (listViewTournamentNames.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    this,
                    "選択された大会を削除します。",
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    listViewTournamentNames.BeginUpdate();
                    foreach (ListViewItem item in listViewTournamentNames.SelectedItems)
                    {
                        listViewTournamentNames.Items.Remove(item);
                    }
                    listViewTournamentNames.EndUpdate();
                }
            }
        }

        private void buttonSaveTournamentNameData_Click(object sender, EventArgs e)
        {
            saveTournamentNameDatas();
        }

        private void listViewTournamentNames_DoubleClick(object sender, EventArgs e)
        {
            editTournamentName();
        }
        #endregion

        #region 会場ページ
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            openSettingsVenueDataDialog(null, null);
        }

        private void buttonEditVenue_Click(object sender, EventArgs e)
        {
            editVenue();
        }

        private void buttonDeleteVenue_Click(object sender, EventArgs e)
        {
            if (listViewVenueDatas.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    this,
                    "選択された会場を削除します。",
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    listViewVenueDatas.BeginUpdate();
                    foreach (ListViewItem item in listViewVenueDatas.SelectedItems)
                    {
                        listViewVenueDatas.Items.Remove(item);
                    }
                    listViewVenueDatas.EndUpdate();
                }
            }
        }

        private void buttonSaveVenue_Click(object sender, EventArgs e)
        {
            saveVenueDatas(SaveType.Save);
        }

        private void buttonImportVenue_Click(object sender, EventArgs e)
        {
            importVenueData();
        }

        private void buttonExportVenue_Click(object sender, EventArgs e)
        {
            exportVenueData();
        }

        private void listViewVenueDatas_DoubleClick(object sender, EventArgs e)
        {
            editVenue();
        }
        #endregion

        #region チーム登録ページ
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            if (tabControlTeamRagistration.SelectedTab == tabPageBoysTeamList)
            {
                openSettingsTeamDataDialog(Categories.Boys, null, listViewTeamDataBoys, null);
            }
            else
            {
                openSettingsTeamDataDialog(Categories.Girls, null, listViewTeamDataGirls, null);
            }
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            if (tabControlTeamRagistration.SelectedTab == tabPageBoysTeamList)
            {
                editTeamData(listViewTeamDataBoys, Categories.Boys);
            }
            else
            {
                editTeamData(listViewTeamDataGirls, Categories.Girls);
            }
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            if (tabControlTeamRagistration.SelectedTab == tabPageBoysTeamList)
            {
                if (listViewTeamDataBoys.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show(
                        this,
                        "選択されたチームを削除します。",
                        this.Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        listViewTeamDataBoys.BeginUpdate();
                        foreach (ListViewItem item in listViewTeamDataBoys.SelectedItems)
                        {
                            listViewTeamDataBoys.Items.Remove(item);
                        }
                        listViewTeamDataBoys.EndUpdate();
                    }
                }
            }
            else
            {
                if (listViewTeamDataGirls.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show(
                        this,
                        "選択されたチームを削除します。",
                        this.Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        listViewTeamDataGirls.BeginUpdate();
                        foreach (ListViewItem item in listViewTeamDataGirls.SelectedItems)
                        {
                            listViewTeamDataGirls.Items.Remove(item);
                        }
                        listViewTeamDataGirls.EndUpdate();
                    }
                }
            }
        }

        private void buttonSaveTeams_Click(object sender, EventArgs e)
        {
            saveTeamDatas(SaveType.Save);
        }

        private void listViewTeamData_DoubleClick(object sender, EventArgs e)
        {
            if (sender == listViewTeamDataBoys)
            {
                editTeamData(listViewTeamDataBoys, Categories.Boys);
            }
            else
            {
                editTeamData(listViewTeamDataGirls, Categories.Girls);
            }
        }
        #endregion

        #endregion
    }
}
