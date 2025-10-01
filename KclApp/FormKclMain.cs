using KbU12Tools;
using System.IO;

namespace KclApp
{
    public partial class FormKclMain : Form
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
        //private TournamentData _tournamentData;
        #endregion

        #region コンストラクタ

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

        #region ローカル・メソッド
        /// <summary>
        /// 大会名称のリストを取得する
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

        #region イベント・ハンドラ

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

        #region メニュー
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // 新規作成
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
            // ［設定］
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
