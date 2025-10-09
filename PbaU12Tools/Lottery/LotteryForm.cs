using PbaU12Tools.TournamentData;
using PbaU12Tools.Bracket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace PbaU12Tools.Lottery
{
    public partial class LotteryForm : Form
    {
        #region Enum
        private enum InputMode
        {
            DragDrop,
            DirectInput
        }
        #endregion

        #region 定数
        #endregion

        #region ローカル・クラス
        private class LotteryData
        {
            public int LotteryNumber { get; set; }
            public int SeedNumber { get; set; }
        }
        private class LotteryResultData
        {
            public TeamData? TeamData { get; set; } = null;
            public LotteryData? LotteryData { get; set; }
        }
        #endregion

        #region フィールド
        #endregion

        #region コンストラクタ
        public LotteryForm()
        {
            InitializeComponent();

            imageList1.Images.Add(CommonResources.BoysTeam);
            imageList1.Images.Add(CommonResources.GirlsTeam);
            tabPageBoys.ImageIndex = 0;
            tabPageGirls.ImageIndex = 1;
            tabPageBoys.BackColor = CommonValues.BoysBackColor;
            tabPageGirls.BackColor = CommonValues.GirlsBackColor;

            InitializeControls();
        }
        #endregion

        #region プロパティ
        public TournamentData.TournamentData? TournamentData { private get; set; } = null;
        public BracketGenData? BracketGenDataBoys { get; set; } = null;
        public BracketGenData? BracketGenDataGirls { get; set; } = null;
        #endregion

        #region ローカル・メソッド
        private void InitializeControls()
        {
            lotteryResultCtrlGirls.Category = Categories.Boys;
            lotteryResultCtrlGirls.Category = Categories.Girls;
        }

        private void preparingListViewForLottery()
        {
            if (BracketGenDataBoys != null)
            {
                lotteryResultCtrlBoys.BracketGenData = BracketGenDataBoys;
            }

            if (BracketGenDataGirls != null)
            {
                lotteryResultCtrlGirls.BracketGenData = BracketGenDataGirls;
            }
        }

        private void loadTeamDatas()
        {
            try
            {
                TeamDatas? teamDatasBoys = TeamDatas.DeserializeTeamDatas(Categories.Boys);
                if (teamDatasBoys != null)
                {
                    lotteryResultCtrlBoys.TeamDatas = teamDatasBoys;
                }

                TeamDatas? teamDatasGirls = TeamDatas.DeserializeTeamDatas(Categories.Girls);
                if (teamDatasGirls != null)
                {
                    lotteryResultCtrlGirls.TeamDatas = teamDatasGirls;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "チームデータがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region イベント・ハンドラ

        #region フォーム
        private void LotteryForm_Load(object sender, EventArgs e)
        {
            if (TournamentData == null)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            loadTeamDatas();

            preparingListViewForLottery();
        }
        #endregion

        #endregion
    }
}
