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
        public string TournamentDataFolderPath { get; private set; }

        //public TourneyData? TournamentData { get; private set; }
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

                treeView1.ExpandAll();
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
                TreeNode treeNode =
                    new TreeNode()
                    {
                        Name = Path.GetFileName(dir),
                        Text = Path.GetFileName(dir)
                    };
                parentNode.Nodes.Add(getChildDirectories(dir, treeNode));
            }
            return parentNode;
        }

        private void getRecentlyUsedFileNameInfo(
            out string recentlyUsedFolder, out string recentlyUsedFileName)
        {
            AppSetting setting = new();
            recentlyUsedFolder = setting[CommonValues.RecentlyUsedFolder].ToString();
            recentlyUsedFileName = setting[CommonValues.RecentlyUsedFileName].ToString();
        }


        private void nodeSelectionAtStartup()
        {
            getRecentlyUsedFileNameInfo(
                out string recentlyUsedFolder, out string recentlyUsedFileName);
            if (!string.IsNullOrEmpty(recentlyUsedFolder))
            {
                string[] folders =
                    recentlyUsedFolder.Split(Path.DirectorySeparatorChar);
                if (folders.Length == 2)
                {
                    TreeNode[] treeNodesOfYearFolder =
                        treeView1.Nodes.Find(folders[0], true);
                    if (treeNodesOfYearFolder.Length == 1)
                    {
                        TreeNode[] treeNodes =
                            treeNodesOfYearFolder[0].Nodes.Find(
                                folders[1], true);
                        if (treeNodes.Length == 1)
                        {
                            treeView1.SelectedNode = treeNodes[0];
                        }
                    }
                }
            }
        }
        #endregion

        #region イベント・ハンドラ

        private void StartupNaviForm_Load(object sender, EventArgs e)
        {
            CommonTools.PreparingFolder();

            makeTournamentDataTree();

            nodeSelectionAtStartup();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // ［OK］ボタン
            if (treeView1.SelectedNode == null)
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                treeView1.SelectedNode.
            }
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
