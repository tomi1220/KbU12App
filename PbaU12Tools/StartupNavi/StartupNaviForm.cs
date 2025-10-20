using PbaU12Tools.TournamentData;
using PbaU12Tools.TournamentName;
using PbaU12Tools.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.StartupNavi
{
    public partial class StartupNaviForm : Form
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region コンストラクタ
        public StartupNaviForm()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;
        }
        #endregion

        #region プロパティ
        public string TournamentDataFilePath { get; private set; }

        public TourneyData? TournamentData { get; private set; }
        public TourneyNameData? TournamentNameData { get; set; } = null;
        #endregion

        #region ローカル・メソッド
        private void makeTournamentDataTree()
        {
            try
            {
                TreeNode rootNode = new TreeNode(CommonTools.TournamentDatasFolderPath);
                treeView1.Nodes.Add(
                    getChildDirectories(CommonTools.TournamentDatasFolderPath, rootNode));
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private TreeNode getChildDirectories(string parentDirectory, TreeNode parentNode)
        {
            List<string> dirs =
                new List<string>(
                    Directory.EnumerateDirectories(parentDirectory));

            foreach (var dir in dirs)
            {
                TreeNode treeNode = new TreeNode(Path.GetFileName(dir));
                parentNode.Nodes.Add(getChildDirectories(dir, treeNode));
            }
            return parentNode;
        }

        private void loadRecentlyUsedData()
        {
            AppSetting setting = new();
            string recentlyUsedFolder = setting[CommonValues.RecentlyUsedFolder].ToString();
            string recentlyUsedFileName = setting[CommonValues.RecentlyUsedFileName].ToString();
            if (!string.IsNullOrEmpty(recentlyUsedFolder))
            {
                TournamentDataFilePath =
                    Path.Combine(recentlyUsedFolder, recentlyUsedFileName);

                if (File.Exists(TournamentDataFilePath))
                {
                    string xmlText = string.Empty;
                    using (StreamReader sr = File.OpenText(TournamentDataFilePath))
                    {
                        xmlText = sr.ReadToEnd();
                    }
                    if (xmlText != string.Empty)
                    {
                        KbU12XmlSerializer serializer = new(typeof(TourneyData));
                        TournamentData = (TourneyData?)serializer.Deserialize(xmlText);
                    }
                }
            }
        }
        #endregion

        #region イベント・ハンドラ

        private void StartupNaviForm_Load(object sender, EventArgs e)
        {
            loadRecentlyUsedData();

            makeTournamentDataTree();
        }

        private void buttonNetTournamentData_Click(object sender, EventArgs e)
        {
            // ［新しい大会情報(&N)...］ボタン
            var tournamentNameDialog = new TournamentNameDialog();
            if (tournamentNameDialog.ShowDialog(this) == DialogResult.OK)
            {
                TournamentNameData = tournamentNameDialog.TourneyNameData!;
            }
        }
        #endregion
    }
}
