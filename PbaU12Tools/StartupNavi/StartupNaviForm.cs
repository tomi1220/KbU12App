using PbaU12Tools.TournamentName;
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
        #endregion

        #region イベント・ハンドラ

        private void StartupNaviForm_Load(object sender, EventArgs e)
        {
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
