using PbaU12Tools;
using PbaU12Tools.Bracket;
using PbaU12Tools.Settings;
using PbaU12Tools.TournamentData;
using PbaU12Tools.Venue;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using PbaU12Tools.Xml;
using PbaU12Tools.Lottery;

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

            toolStripMenuItemSettings.Image = CommonResources.Settings;
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
            // ��{���
            tournamentDataContents1.SetTournamentDataContents(tournamentData);
        }

        private bool saveTournamentData()
        {
            if (_tournamentData == null)
            {
                return false;
            }

            updateTournamentData();

            if (string.IsNullOrEmpty(_tournamentDataFilePath))
            {
                return saveAsTournamentData();
            }

            try
            {
                string xmlText = _tournamentData.Serialize()!;

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
            if (_tournamentDataFilePath != null)
            {
                setting[CommonValues.RecentlyUsedData] =
                    Path.GetDirectoryName(_tournamentDataFilePath)!;
                setting[CommonValues.RecentlyUsedFileName] =
                    Path.GetFileName(_tournamentDataFilePath);
            }
            else
            {
                setting[CommonValues.RecentlyUsedData] = string.Empty;
                setting[CommonValues.RecentlyUsedFileName] = string.Empty;
            }
            setting.Save();
        }

        private bool saveAsTournamentData()
        {
            if (_tournamentData == null)
            {
                return false;
            }
            updateTournamentData();

            using SaveFileDialog sfd = new();
            sfd.Title = "�V����������ۑ�����t�@�C�����w�肵�Ă��������B";
            sfd.Filter = CommonValues.TournamentDataFileFilter;
            sfd.InitialDirectory = CommonTools.TournamentFolderPath(_tournamentName);
            if (!string.IsNullOrEmpty(_tournamentDataFilePath))
            {
                sfd.FileName = Path.GetFileName(_tournamentDataFilePath);
            }
            else
            {
                sfd.FileName = CommonValues.TournamentDataFileName;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = sfd.FileName;

                try
                {
                    string xmlText = _tournamentData.Serialize()!;

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
            string recentlyUsedFolder = setting[CommonValues.RecentlyUsedData].ToString();
            string recentlyUsedFileName = setting[CommonValues.RecentlyUsedFileName].ToString();
            if (!string.IsNullOrEmpty(recentlyUsedFolder))
            {
                _tournamentDataFilePath =
                    Path.Combine(recentlyUsedFolder, recentlyUsedFileName);

                if (File.Exists(_tournamentDataFilePath))
                {
                    string xmlText = string.Empty;
                    using (StreamReader sr = File.OpenText(_tournamentDataFilePath))
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

        private void saveBracketGenData(BracketGenData bracketGenData)
        {
            try
            {
                {
                    string? xmlTextBoys = bracketGenData.Serialize();

                    if (xmlTextBoys == null)
                    {
                        return;
                    }

                    string filePathBoys =
                        Path.Combine(
                            CommonTools.TournamentFolderPath(_tournamentName),
                            CommonValues.BracketGenDataFileName(bracketGenData.Category));

                    using var swBoys = new StreamWriter(filePathBoys);
                    swBoys.Write(xmlTextBoys);

                }

                MessageBox.Show(
                    this,
                    "�g�[�i�����g�\�쐬�f�[�^���Z�[�u���܂����B",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "�g�[�i�����g�\�쐬�f�[�^���Z�[�u�ł��܂���ł���" + Environment.NewLine +
                    Environment.NewLine + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void updateTournamentData()
        {
            if (_tournamentData == null)
            {
                _tournamentData = new TournamentData();
            }
            _tournamentData.TournamentName = _tournamentName;
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

                _tournamentData = _tournamentDataOrg.Clone();

                setTournamentDataInformation(tournamentData);

                panelAll.Enabled = true;
            }
        }

        #region ���j���[
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // �V�K�쐬
            if (newTournamentData())
            {
                labelTournamentName.Text = _tournamentName;

                _tournamentData = new TournamentData();

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

        private void buttonBasedata_Click(object sender, EventArgs e)
        {
            using TournamentDataBaseDialog dialog =
                new TournamentDataBaseDialog(_tournamentData!);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _tournamentData!.BaseDataBoys = dialog.NewTournamentData!.BaseDataBoys.Clone();
                _tournamentData!.BaseDataGirls = dialog.NewTournamentData!.BaseDataGirls.Clone();
                _tournamentData!.VenueDatas = dialog.NewTournamentData!.VenueDatas.Clone();

                tournamentDataContents1.SetTournamentDataContents(dialog.NewTournamentData);

                if (_tournamentData!.BaseDataBoys.NumberOfTeams > 0 ||
                    _tournamentData!.BaseDataBoys.NumberOfTeams > 0)
                {
                    if (MessageBox.Show(
                        this,
                        "�g�[�i�����g�\�쐬�p�̃f�[�^���쐬���܂��B" + Environment.NewLine +
                        Environment.NewLine +
                        $"�j�q�`�[���� = {_tournamentData!.BaseDataBoys.NumberOfTeams.ToString()}" + Environment.NewLine +
                        $"���q�`�[���� = {_tournamentData!.BaseDataGirls.NumberOfTeams.ToString()}" + Environment.NewLine,
                        this.Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BracketGenData bracketGenDataBoys =
                            BracketGenerator.CreateGenData(_tournamentData!.BaseDataBoys);
                        saveBracketGenData(bracketGenDataBoys);

                        BracketGenData bracketGenDataGirls =
                            BracketGenerator.CreateGenData(_tournamentData!.BaseDataGirls);
                        saveBracketGenData(bracketGenDataGirls);
                    }
                }
            }
        }

        #endregion

        #region �m�g�[�i�����g�\�쐬�n
        private void toolStripMenuItemBracketOutput_Click(object sender, EventArgs e)
        {
            // �m�g�[�i�����g�\�쐬�n
            //TournamentData tournamentData = createTournamentData();
            //if (tournamentData.Status == TournamentDataStatuses.None)
            //{
            //    MessageBox.Show(
            //        this,
            //        "�g�[�i�����g�\���쐬���鏀�����o���Ă��܂���B",
            //        this.Text,
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}

            using BracketOutputDialog dialog = new BracketOutputDialog();
            dialog.TourneyData = _tournamentData;
            string filePathBoys =
                Path.Combine(
                    CommonTools.TournamentFolderPath(_tournamentName),
                    CommonValues.BracketGenDataFileName(Categories.Boys));
            dialog.BracketGenDataBoys = BracketGenData.Deserialize(Categories.Boys, filePathBoys);
            string filePathGirls =
                Path.Combine(
                    CommonTools.TournamentFolderPath(_tournamentName),
                    CommonValues.BracketGenDataFileName(Categories.Girls));
            dialog.BracketGenDataGirls = BracketGenData.Deserialize(Categories.Girls, filePathGirls);
            dialog.ShowDialog(this);
        }
        #endregion

        #region ���I����
        private void buttonLottery_Click(object sender, EventArgs e)
        {
            LotteryForm lotteryForm = new LotteryForm(_tournamentData!);
            lotteryForm.Show(this);
        }
        #endregion

        #endregion
    }
}
