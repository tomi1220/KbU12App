using PbaU12Tools;
using PbaU12Tools.Settings;

namespace DistTourney
{
    public partial class FormDistMain : Form
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region クラス
        #endregion

        #region フィールド
#if DEBUG
        private readonly DebugInfoForm _debugForm;
#endif
        private readonly string _executablePath;

        private string? _tournamentDataFilePath = null;
        #endregion

        #region コンストラクタ
        public FormDistMain()
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
            //_baseFolder = CommonValues.GetBaseFolder();

#if DEBUG
            _debugForm = new DebugInfoForm();
#endif
        }
        #endregion

        #region ローカル・メソッド
        /// <summary>
        /// 新規作成
        /// </summary>
        /// <returns></returns>
        private bool NewTournament()
        {
            string? tournamentName = null;
            using var dlg = new TournamentNameDialog();
            dlg.AllowBlankTournamentName = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tournamentName = dlg.TournamentName;
            }

            if (string.IsNullOrEmpty(tournamentName))
            {
                tournamentName =
                    DateTime.Today.ToString(
                        "yyyy-MM-dd_") + CommonValues.TournamentDataFileName;
            }
            using SaveFileDialog sfd = new();
            sfd.Title = "新しい大会情報を保存するファイルを指定してください。";
            sfd.Filter = "大会情報ファイル(*.xml)|*.xml|All files (*.*)|*.*";
            sfd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            sfd.FileName = tournamentName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = sfd.FileName;

                textBoxTournamentName.Text = tournamentName;

                textBoxOutputFilePath.Text =
                    Path.Combine(
                        CommonTools.DocumentsFolderPath,
                        Path.GetFileName(_tournamentDataFilePath));

                panelAll.Enabled = true;

                return true;
            }

            return false;
        }

        private static TournamentData? loadTournamentData()
        {
            AppSetting setting = new();
            string recentlyUsedFile = setting["RecentlyUsedFile"].ToString();
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

        #region イベント・ハンドラ

        private void FormDistMain_Load(object sender, EventArgs e)
        {
#if DEBUG
            _debugForm.StartPosition = FormStartPosition.Manual;
            _debugForm.Location = new Point(this.Bounds.Right, this.Bounds.Top);
            _debugForm.Show(this);
#endif
            if (!CommonTools.PreparingFolder())
            {
                Close();
            }

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

        #region メニュー
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // 新規作成
            string? tournamentName = null;
            using var dlg = new TournamentNameDialog();
            dlg.AllowBlankTournamentName = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tournamentName = dlg.TournamentName;
            }

            if (string.IsNullOrEmpty(tournamentName))
            {
                tournamentName =
                    DateTime.Today.ToString(
                        "yyyy-MM-dd_") + CommonValues.TournamentDataFileName;
            }
            using SaveFileDialog sfd = new();
            sfd.Title = "新しい大会情報を保存するファイルを指定してください。";
            sfd.Filter = "大会情報ファイル(*.xml)|*.xml|All files (*.*)|*.*";
            sfd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            sfd.FileName = tournamentName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = sfd.FileName;

                textBoxTournamentName.Text = tournamentName;

                textBoxOutputFilePath.Text =
                    Path.Combine(
                        CommonTools.DocumentsFolderPath,
                        Path.GetFileName(_tournamentDataFilePath));

                panelAll.Enabled = true;
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
            // ［設定］
            using SettingForm settingForm = new();
            settingForm.ShowDialog();
        }

        #endregion

        #region ［大会名称］
        private void buttonTournamentName_Click(object sender, EventArgs e)
        {
            // ［大会名称］
        }
        #endregion 

        #region ［会場情報］
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（追加）］

        }

        private void buttonEditVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（編集）］
        }

        private void buttonDeleteVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報（削除）］
        }
        #endregion 

        #region ［出力先］
        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            // ［出力先］
        }
        #endregion

        #region ［トーナメント表作成］
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            // ［トーナメント表作成］
        }

        #endregion
        #endregion
    }
}
