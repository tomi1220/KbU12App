using PbaU12Tools;
using PbaU12Tools.Settings;
using PbaU12Tools.TournamentData;
using System.Xml;
using System.Xml.Linq;

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

        private string _tournamentName = string.Empty;

        private string? _tournamentDataFilePath = null;

        private TournamentData? _tournamentDataOrg;
        private TournamentData? _tournamentData;
        #endregion

        #region コンストラクタ
        public FormDistMain()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;

            listViewVenue.ListViewItemSorter = new VenueListViewItemComparer();

            _executablePath = Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty;

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
        private bool newTournamentData()
        {
            using var dlg = new TournamentNameDialog();
            //dlg.AllowBlankTournamentName = true;
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
            ofd.Title = "大会情報ファイルを指定してください。";
            ofd.Filter = CommonValues.TournamentDataFileFilter;
            ofd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            //ofd.FileName = tournamentName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = ofd.FileName;

                _tournamentDataOrg = TournamentData.Deserialize(ofd.FileName);

                setTournamentDataInformation();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void setTournamentDataInformation()
        {
            /*
            // 進行状況
            if (tournamentData.Status == TournamentDataStatuses.None)
            {
                toolStripTextBox1.Text = string.Empty;
            }
            else
            {
                toolStripTextBox1.Text =
                    CommonValues.TournamentDataStatusesStrings[(int)tournamentData.Status];
            }
            // 大会名
            if (!string.IsNullOrEmpty(tournamentData.TournamentName))
            {
                textBoxTournamentName.Text = tournamentData.TournamentName;
            }
            // トーナメント表データ
            if (tournamentData.BrackectDataDic != null)
            {
                // 男子
                if (tournamentData.BrackectDataDic.TryGetValue(
                    Category.Boys, out BracketData? boysBracketData))
                {
                    if (boysBracketData.NumberOfTeams > 0)
                    {
                        checkBoxBoys.Checked = true;
                        numericUpDownNumberOfTeamsBoys.Value = boysBracketData.NumberOfTeams;
                    }
                }
                // 女子
                if (tournamentData.BrackectDataDic.TryGetValue(
                    Category.Girls, out BracketData? girlsBracketData))
                {
                    if (numericUpDownNumberOfTeamsGirls.Value > 0)
                    {
                        checkBoxGirls.Checked = true;
                        numericUpDownNumberOfTeamsGirls.Value = girlsBracketData.NumberOfTeams;
                    }
                }
            }
            // オープン参加表示枠
            checkBoxOpen.Checked = tournamentData.OpenDisplayFrame;
            // 会場データ
            */
        }

        private TournamentData createTournamentData()
        {
            TournamentData tournamentData = new();

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
                string xmlText = TournamentData.Serialize(tournamentData)!;

                using var sw = new StreamWriter(_tournamentDataFilePath);
                sw.Write(xmlText);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool saveAsTournamentData()
        {
            TournamentData tournamentData = createTournamentData();
            if (tournamentData == null)
            {
                return false;   
            }

            using SaveFileDialog sfd = new();
            sfd.Title = "新しい大会情報を保存するファイルを指定してください。";
            sfd.Filter = CommonValues.TournamentDataFileFilter;
            sfd.InitialDirectory = CommonTools.TournamentDatasFolderPath;
            sfd.FileName = Path.GetFileName(_tournamentDataFilePath);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _tournamentDataFilePath = sfd.FileName;

                try
                {
                    string xmlText = TournamentData.Serialize(tournamentData)!;

                    using var sw = new StreamWriter(_tournamentDataFilePath);
                    sw.Write(xmlText);

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
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
                setTournamentDataInformation();
            }
        }

        #region メニュー
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // 新規作成
            if(newTournamentData())
            {
                labelTournamentName.Text = _tournamentName;

                textBoxOutputFilePath.Text =
                    Path.Combine(
                        CommonTools.DocumentsFolderPath,
                        Path.GetFileNameWithoutExtension(_tournamentDataFilePath!)) +
                        CommonValues.ExcelExt;
                toolStripTextBox1.Text =
                    CommonValues.TournamentDataStatusesStrings[(int)TournamentDataStatuses.RafflePreparation];

                panelAll.Enabled = true;
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            openTournamentData();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            // 保存
            saveTournamentData();
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            // 名前を付けて保存
            saveAsTournamentData();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            // 更新チェック
            if (isUpdate())
            {
                DialogResult dialogResult =
                    MessageBox.Show(
                        this,
                        "変更内容を反映しますか？",
                        this.Text,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    // 保存
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
            // ［設定］
            using SettingForm settingForm = new();
            settingForm.ShowDialog();
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
