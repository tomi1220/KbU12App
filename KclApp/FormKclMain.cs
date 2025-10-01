using KbU12Tools;
using System.IO;

namespace KclApp
{
    public partial class FormKclMain : Form
    {
        #region Enum
        #endregion

        #region �萔
        #endregion

        #region �N���X
        #endregion

        #region �t�B�[���h
#if DEBUG
        private readonly DebugInfoForm _debugForm;
#endif
        private readonly string _executablePath;
        //private TournamentData _tournamentData;
        #endregion

        #region �R���X�g���N�^

        public FormKclMain()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;
            checkBoxBoys.Image = CommonResources.BoysTeam;
            checkBoxGirls.Image = CommonResources.GirlsTeam;

            buttonAddVenue.Image = CommonResources.Add;

            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;

            listViewVenue.ListViewItemSorter = new VenueListViewItemComparer();

            _executablePath = Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty;

#if DEBUG
            _debugForm = new DebugInfoForm();
#endif
        }
        #endregion

        #region ���[�J���E���\�b�h
        /// <summary>
        /// ���̂̃��X�g���擾����
        /// </summary>
        /// <returns>TournamentNameDatas?</returns>
        private static TournamentNameDatas? loadTournamentNameDatas()
        {
            TournamentNameDatas? tournamentDatas = null;

            string tournamentNameDatasFile =
                Path.Combine(
                    Application.ExecutablePath,
                    CommonValues.TournamentNameDatasFileName);
            if (File.Exists(tournamentNameDatasFile))
            {
                string xmlText = string.Empty;
                using (StreamReader sr = File.OpenText(tournamentNameDatasFile))
                {
                    xmlText = sr.ReadToEnd();
                }
                if (xmlText != string.Empty)
                {
                    KbU12XmlSerializer serializer = new(typeof(TournamentNameDatas));
                    tournamentDatas = (TournamentNameDatas?)serializer.Deserialize(xmlText);
                }
            }

            return tournamentDatas;
        }

        private static TournamentData? loadTournamentData()
        {
            AppSetting setting = new();
            string recentlyUsedFile = setting["RecentlyUsedFFile"].ToString();
            if (!string.IsNullOrEmpty(recentlyUsedFile))
            {
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
            string fileName = textBoxTournamentName.Text.Trim();
            if (fileName.Length == 0)
            {
                fileName = DateTime.Today.ToString("yyyy-MM-dd") + "_" + CommonValues.DEFAULT_FILE_NAME;
            }
            return fileName;
        }
        #endregion

        #region �C�x���g�E�n���h��

        private void FormKclMain_Load(object sender, EventArgs e)
        {
#if DEBUG
            _debugForm.StartPosition = FormStartPosition.Manual;
            _debugForm.Location = new Point(this.Bounds.Right, this.Bounds.Top);
            _debugForm.Show(this);
#endif
            TournamentData? tournamentData = loadTournamentData();
            if (tournamentData != null)
            {
                textBoxTournamentName.Text = tournamentData.TournamentName;
                if (tournamentData.BrackectDataDic.TryGetValue(Category.Boys, out BracketData? boysBracketData))
                {
                    if (boysBracketData.NumberOfTeams > 0)
                    {
                        checkBoxBoys.Checked = true;
                        numericUpDownNumberOfTeamsBoys.Value = boysBracketData.NumberOfTeams;
                    }
                }
                if (tournamentData.BrackectDataDic.TryGetValue(Category.Girls, out BracketData? girlsBracketData))
                {
                    if (girlsBracketData.NumberOfTeams > 0)
                    {
                        checkBoxGirls.Checked = true;
                        numericUpDownNumberOfTeamsGirls.Value = girlsBracketData.NumberOfTeams;
                    }
                }
            }
            else
            {
                checkBoxBoys.Checked = true;
                numericUpDownNumberOfTeamsBoys.Value = 32;
                checkBoxGirls.Checked = true;
                numericUpDownNumberOfTeamsGirls.Value = 32;
            }

            textBoxOutputFilePath.Text = getTournamentName();
        }

        #region ���j���[
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // �V�K�쐬
            TournamentNameData? tournamentNameData = null;
            using var dlg = new TournamentNameDialog();
            TournamentNameDatas? tournamentNameDatas = loadTournamentNameDatas();
            dlg.TournamentNameDatas = tournamentNameDatas;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tournamentNameData = dlg.TournamentNameData;
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            // �m�ݒ�n
        }

        #endregion

        #region �m���́n
        private void buttonTournamentName_Click(object sender, EventArgs e)
        {
            // �m���́n
        }
        #endregion 

        #region �m�����n
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            // �m�����i�ǉ��j�n

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

        #region �m�o�͐�n
        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            // �m�o�͐�n
        }
        #endregion

        #region �m�g�[�i�����g�\�쐬�n
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            // �m�g�[�i�����g�\�쐬�n
        }

        #endregion
        #endregion
    }
}
