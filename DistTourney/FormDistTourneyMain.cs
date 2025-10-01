using PbaU12Tools;
using PbaU12Tools.Bracket;
using PbaU12Tools.Settings;
using PbaU12Tools.TournamentData;
using PbaU12Tools.Venue;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace DistTourney
{
    public partial class FormDistTourneyMain : Form
    {
        #region Enum
        #endregion

        #region �萔
        #endregion

        #region �N���X
        #endregion

        #region �t�B�[���h
        private readonly string _executablePath;

        private string _tournamentName = string.Empty;

        private string? _tournamentDataFilePath = null;

        private TournamentData? _tournamentDataOrg;
        private TournamentData? _tournamentData;
        #endregion

        #region �R���X�g���N�^
        public FormDistTourneyMain()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;

            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;

            _executablePath = Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty;
        }
        #endregion

        #region ���[�J���E���\�b�h
        /// <summary>
        /// �V�K�쐬
        /// </summary>
        /// <returns></returns>
        private bool newTournamentData()
        {
            return openTournamentNameDialog();
        }

        private bool openTournamentNameDialog()
        {
            using var dlg = new TournamentNameDialog();
            dlg.TournamentName = _tournamentName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _tournamentName = dlg.TournamentName;

                return true;
            }

            return false;
        }

        private bool openTournamentData()
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = CommonValues.TournamentDataFileFilter;
            ofd.Title = "�����t�@�C�����w�肵�Ă��������B";
            ofd.Filter = CommonValues.TournamentDataFileFilter;
            ofd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            //ofd.FileName = tournamentName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = ofd.FileName;

                _tournamentDataOrg = TournamentData.Deserialize(ofd.FileName);
                if (_tournamentDataOrg != null)
                {
                    _tournamentName = _tournamentDataOrg.TournamentName;

                    return true;
                }
                else
                {
                    return false;
                }

                //setTournamentDataInformation();
            }
            else
            {
                return false;
            }
        }

        private void setTournamentDataInformation(TournamentData tournamentData)
        {
            // �i�s��
            if (tournamentData.Status == TournamentDataStatuses.None)
            {
                toolStripTextBox1.Text = string.Empty;
            }
            else
            {
                toolStripTextBox1.Text =
                    CommonValues.TournamentDataStatusesStrings[(int)tournamentData.Status];
            }
            // ��
            if (!string.IsNullOrEmpty(tournamentData.TournamentName))
            {
                labelTournamentName.Text = tournamentData.TournamentName;
            }
            // �g�[�i�����g�\�f�[�^
            if (tournamentData.BrackectDataBoys != null)
            {
                // �j�q
                if (tournamentData.BrackectDataBoys.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlBoys.CategoryValidity = true;
                    numOfTeamsCtrlBoys.Category = Categories.Boys;
                    numOfTeamsCtrlBoys.NumberOfTeams = tournamentData.BrackectDataBoys.NumberOfTeams;
                }
            }
            if (tournamentData.BrackectDataGirls != null)
            {
                // ���q
                if (tournamentData.BrackectDataGirls.NumberOfTeams > 0)
                {
                    numOfTeamsCtrlGirls.CategoryValidity = true;
                    numOfTeamsCtrlGirls.Category = Categories.Girls;
                    numOfTeamsCtrlGirls.NumberOfTeams = tournamentData.BrackectDataGirls.NumberOfTeams;
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

        private TournamentData createTournamentData()
        {
            TournamentData tournamentData = new();

            tournamentData.TournamentName = _tournamentName;
            if (numOfTeamsCtrlBoys.CategoryValidity)
            {
                BracketDataGenerator bracketDataGenerator =
                    new BracketDataGenerator(
                        Categories.Boys,
                        numOfTeamsCtrlBoys.NumberOfTeams,
                        numOfTeamsCtrlBoys.NumberOfSuperSeeds);
                bracketDataGenerator.Create();
                if (bracketDataGenerator.BracketData != null)
                {
                    tournamentData.BrackectDataBoys = bracketDataGenerator.BracketData;
                }

                //tournamentData.BrackectDataBoys =
                //    new()
                //    {
                //        Category = Categories.Boys,
                //        NumberOfTeams = numOfTeamsCtrlBoys.NumberOfTeams,
                //        NumberOfSuperSeed = numOfTeamsCtrlBoys.NumberOfSuperSeeds,
                //        FinalLeague = numOfTeamsCtrlBoys.FinalLeage
                //    };
                tournamentData.Status = TournamentDataStatuses.RafflePreparation;
            }
            if (numOfTeamsCtrlGirls.CategoryValidity)
            {
                BracketDataGenerator bracketDataGenerator =
                    new BracketDataGenerator(
                        Categories.Girls,
                        numOfTeamsCtrlGirls.NumberOfTeams,
                        numOfTeamsCtrlGirls.NumberOfSuperSeeds);
                bracketDataGenerator.Create();
                if (bracketDataGenerator.BracketData != null)
                {
                    tournamentData.BrackectDataGirls = bracketDataGenerator.BracketData;
                }
                //tournamentData.BrackectDataGirls =
                //    new()
                //    {
                //        Category = Categories.Girls,
                //        NumberOfTeams = numOfTeamsCtrlGirls.NumberOfTeams,
                //        NumberOfSuperSeed = numOfTeamsCtrlGirls.NumberOfSuperSeeds,
                //        FinalLeague = numOfTeamsCtrlBoys.FinalLeage
                //    };
                tournamentData.Status = TournamentDataStatuses.RafflePreparation;
            }
            foreach (ListViewItem item in listViewVenue.Items)
            {
                if (item.Tag is VenueItemData venueItemData)
                {
                    tournamentData.VenueDatas.Add(venueItemData);
                }
            }

            return tournamentData;
        }

        private bool saveTournamentData()
        {
            TournamentData tournamentData = createTournamentData();
            if (tournamentData == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(_tournamentDataFilePath))
            {
                return saveAsTournamentData();
            }

            try
            {
                string xmlText = tournamentData.Serialize()!;

                using var sw = new StreamWriter(_tournamentDataFilePath);
                sw.Write(xmlText);

                saveToAppSettingsTournamentDatafilePath();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void saveToAppSettingsTournamentDatafilePath()
        {
            AppSetting setting = new();
            setting["RecentlyUsedFile"] = _tournamentDataFilePath ?? string.Empty;
            setting.Save();
        }

        private bool saveAsTournamentData()
        {
            TournamentData tournamentData = createTournamentData();
            if (tournamentData == null)
            {
                return false;
            }

            using SaveFileDialog sfd = new();
            sfd.Title = "�V����������ۑ�����t�@�C�����w�肵�Ă��������B";
            sfd.Filter = CommonValues.TournamentDataFileFilter;
            sfd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            if (!string.IsNullOrEmpty(_tournamentDataFilePath))
            {
                sfd.FileName = Path.GetFileName(_tournamentDataFilePath);
            }
            else
            {
                sfd.FileName = _tournamentName + CommonValues.DataFileExt;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = sfd.FileName;

                try
                {
                    //string xmlText = TournamentData.Serialize(tournamentData)!;
                    string xmlText = tournamentData.Serialize()!;

                    using var sw = new StreamWriter(_tournamentDataFilePath);
                    sw.Write(xmlText);

                    saveToAppSettingsTournamentDatafilePath();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return false;
        }

        private TournamentData? loadTournamentData()
        {
            AppSetting setting = new();
            string recentlyUsedFile = setting["RecentlyUsedFile"].ToString();
            if (!string.IsNullOrEmpty(recentlyUsedFile))
            {
                _tournamentDataFilePath = recentlyUsedFile;

                if (File.Exists(recentlyUsedFile))
                {
                    string xmlText = string.Empty;
                    using (StreamReader sr = File.OpenText(recentlyUsedFile))
                    {
                        xmlText = sr.ReadToEnd();
                    }
                    if (xmlText != string.Empty)
                    {
                        KbU12XmlSerializer serializer = new(typeof(TournamentData));
                        TournamentData? tournamentData = (TournamentData?)serializer.Deserialize(xmlText);

                        return tournamentData;
                    }
                }
            }

            return null;
        }

        private string getTournamentName()
        {
            string fileName = labelTournamentName.Text;
            if (fileName.Length == 0)
            {
                fileName = DateTime.Today.ToString("yyyy-MM-dd") + "_" + CommonValues.DEFAULT_FILE_NAME;
            }
            return fileName;
        }

        private bool isUpdate()
        {
            return true;
        }

        private void updateVenueItemData(ListViewItem? listViewItem)
        {
            using VenueSettingDialog dialog = new VenueSettingDialog();
            List<VenueItemData> otherVenueDatas = GetOtherVenueDatas(null);
            dialog.OtherVenueList = otherVenueDatas;
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
                    listViewItem.SubItems.Add(string.Join("�E", venueItemData.CourtList));
                subItem.BackColor = Color.FromArgb(venueItemData.BackColor);
                listViewItem.Tag = venueItemData;
                listViewVenue.Items.Add(listViewItem);
            }
            else
            {
                listViewItem.Text = venueItemData.TargetDate.ToString("yyyy-MM-dd");
                listViewItem.SubItems[1].Text = venueItemData.Name;
                listViewItem.SubItems[2].Text = string.Join("�E", venueItemData.CourtList);
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

        #region �C�x���g�E�n���h��

        private void FormDistMain_Load(object sender, EventArgs e)
        {
            if (!CommonTools.PreparingFolder())
            {
                Close();
            }

            TournamentData? tournamentData = loadTournamentData();
            if (tournamentData != null)
            {
                _tournamentDataOrg = tournamentData;

                _tournamentName = _tournamentDataOrg.TournamentName;

                setTournamentDataInformation(tournamentData);

                panelAll.Enabled = true;
            }
            else
            {
            }
        }

        #region ���j���[
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // �V�K�쐬
            if (newTournamentData())
            {
                labelTournamentName.Text = _tournamentName;

                //textBoxOutputFilePath.Text =
                //    Path.Combine(
                //        CommonTools.DocumentsFolderPath,
                //        Path.GetFileNameWithoutExtension(_tournamentDataFilePath!)) +
                //        CommonValues.ExcelExt;
                toolStripTextBox1.Text =
                    CommonValues.TournamentDataStatusesStrings[(int)TournamentDataStatuses.RafflePreparation];

                panelAll.Enabled = true;
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            if (openTournamentData())
            {
                labelTournamentName.Text = _tournamentName;

                int index = (int)_tournamentDataOrg!.Status;
                toolStripTextBox1.Text =
                    CommonValues.TournamentDataStatusesStrings[index != -1 ? index : 0];

                panelAll.Enabled = true;
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            // �ۑ�
            saveTournamentData();
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            // ���O��t���ĕۑ�
            saveAsTournamentData();
        }

        private void toolStripMenuItemOpenInExplorer_Click(object sender, EventArgs e)
        {
            // �ۑ�����J��
            PbaU12Tools.WinAPI.WinApi.ShellExecute(
                IntPtr.Zero, "open", CommonTools.DocumentsFolderPath, null, null, 1);
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            // �X�V�`�F�b�N
            if (isUpdate())
            {
                DialogResult dialogResult =
                    MessageBox.Show(
                        this,
                        "�ύX���e�𔽉f���܂����H",
                        this.Text,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    // �ۑ�
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            Close();
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            // �m�ݒ�n
            using SettingForm settingForm = new();
            settingForm.ShowDialog();
        }

        #endregion

        #region ��
        private void buttonTournamentName_Click(object sender, EventArgs e)
        {
            if (openTournamentNameDialog())
            {
                labelTournamentName.Text = _tournamentName;
            }
        }
        #endregion

        #region ����{���
        #endregion

        #region �m�����n
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            // �m�����i�ǉ��j�n
            updateVenueItemData(null);
        }

        private void buttonEditVenue_Click(object sender, EventArgs e)
        {
            // �m�����i�ҏW�j�n
        }

        private void buttonDeleteVenue_Click(object sender, EventArgs e)
        {
            // �m�����i�폜�j�n
        }
        #endregion 

        #region �m�g�[�i�����g�\�쐬�n
        private void toolStripMenuItemBracketOutput_Click(object sender, EventArgs e)
        {
            // �m�g�[�i�����g�\�쐬�n
            TournamentData tournamentData = createTournamentData();
            if (tournamentData.Status == TournamentDataStatuses.None)
            {
                MessageBox.Show(
                    this,
                    "�g�[�i�����g�\���쐬���鏀�����o���Ă��܂���B",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return ;
            }

            using BracketOutputDialog dialog = new BracketOutputDialog();
            dialog.TourneyData = tournamentData;
            dialog.ShowDialog(this);
        }
        #endregion
        #endregion
    }
}
