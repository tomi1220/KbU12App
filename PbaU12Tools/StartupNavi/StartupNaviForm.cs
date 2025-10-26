using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
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

#if DEBUG
        private Label labelDebug;
#endif

        #region コンストラクタ
        public StartupNaviForm()
        {
            InitializeComponent();
#if DEBUG
            // 
            // labelDebug
            // 
            labelDebug = new Label();
            labelDebug.AutoSize = true;
            labelDebug.Location = new Point(190, 12);
            labelDebug.Name = "labelDebug";
            labelDebug.Size = new Size(0, 15);
            labelDebug.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelDebug);
            // 
            // treeView1
            // 
            treeView1.AfterSelect += treeView1_AfterSelect;
#endif

            this.Icon = CommonResources.BracketIcon;

            this.imageList1.Images.Add(CommonResources.FolderClosed);
        }
        #endregion

        #region プロパティ
        public string TournamentDataFilePath { get; private set; } = string.Empty;

        public TourneyData? TournamentData { get; set; } = null;
        #endregion

        #region ローカル・メソッド
        private void makeTournamentDataTree()
        {
            try
            {
                TreeNode rootNode =
                    new TreeNode()
                    {
                        Name = CommonTools.TournamentDatasFolderPath,
                        Text = CommonTools.TournamentDatasFolderPath,
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                        Tag = NodeID.Root,
                    };
                treeView1.Nodes.Add(
                    getChildDirectories(CommonTools.TournamentDatasFolderPath, rootNode, (int)NodeID.Year));

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

        private TreeNode getChildDirectories(
            string parentDirectory, TreeNode parentNode, int nodeID)
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
                        Text = Path.GetFileName(dir),
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                        Tag = (NodeID)nodeID,
                    };
                parentNode.Nodes.Add(getChildDirectories(dir, treeNode, nodeID + 1));
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

        private string getTournamentDataFilePath(TreeNode treeNode)
        {
            List<string> folders = new List<string>();
            folders.Add(treeNode.Text);

            TreeNode parentNode = treeNode.Parent;
            while (parentNode != null)
            {
                folders.Add(parentNode.Text);
                parentNode = parentNode.Parent;
            }

            if (folders.Count > 1)
            {
                folders.Reverse();
            }

            string path = Path.Combine(folders.ToArray());
            return path;
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
                if ((NodeID)treeView1.SelectedNode.Tag == NodeID.Tourney)
                {
                    TournamentDataFilePath =
                        getTournamentDataFilePath(treeView1.SelectedNode);
                }
            }
        }

        private void buttonNetTournamentData_Click(object sender, EventArgs e)
        {
            // ［新しい大会情報(&N)...］ボタン
            var tournamentNameDialog = new TournamentNameDialog();
            if (tournamentNameDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (tournamentNameDialog.TournamentNameData != null)
                {
                    TournamentData =
                        new TourneyData
                        {
                            Year = tournamentNameDialog.Year,
                            NumberOfTimes = tournamentNameDialog.NumberOfTournaments,
                            TournamentName = tournamentNameDialog.TournamentNameData.Name,
                        };
                    TournamentData.BaseDataBoys.NumberOfTeams = tournamentNameDialog.TournamentNameData.FixedNumOfBoysTeams;
                    TournamentData.BaseDataGirls.NumberOfTeams = tournamentNameDialog.TournamentNameData.FixedNumOfGirlsTeams;
                }
                else
                {
                    TournamentData =
                        new TourneyData
                        {
                            Year = tournamentNameDialog.Year,
                            NumberOfTimes = tournamentNameDialog.NumberOfTournaments,
                            TournamentName = tournamentNameDialog.TournamentName,
                        };
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }
#if DEBUG
        private void treeView1_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            NodeID nodeID = (NodeID)e.Node!.Tag;
            labelDebug.Text = nodeID.ToString();
        }
#endif
        #endregion
    }
}
