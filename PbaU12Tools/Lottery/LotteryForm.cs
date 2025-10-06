using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PbaU12Tools.TournamentData;

namespace PbaU12Tools.Lottery
{
    public partial class LotteryForm : Form
    {
        #region 定数
        #endregion

        #region フィールド
        private TournamentData.TournamentData _tournamentData;
        #endregion

        #region コンストラクタ
        public LotteryForm(TournamentData.TournamentData tournamentData)
        {
            InitializeComponent();

            _tournamentData = tournamentData;
        }
        #endregion

        #region プロパティ
        #endregion

        #region ローカル・メソッド
        private void preparingListViewForLottery()
        {
            for (int i = 0; i < _tournamentData.BaseDataBoys.NumberOfTeams; i++)
            {
                listViewLotteryResultBoys.Items.Add(
                    new ListViewItem()
                    {
                        Text = (i + 1).ToString(),
                    });
            }
            columnNumberBoys.Width = -2;

            for (int i = 0; i < _tournamentData.BaseDataGirls.NumberOfTeams; i++)
            {
                listViewLotteryResultGirls.Items.Add(
                    new ListViewItem()
                    {
                        Text = (i + 1).ToString(),
                    });
            }
            columnNumberGirls.Width = -2;
        }

        private void preparingListViewTeams()
        {
            for (int i = 0; i < _tournamentData.BaseDataBoys.NumberOfTeams; i++)
            {
                listViewLotteryResultBoys.Items.Add(
                    new ListViewItem()
                    {
                        Text = (i + 1).ToString(),
                    });
            }
            columnNumberBoys.Width = -2;

            for (int i = 0; i < _tournamentData.BaseDataGirls.NumberOfTeams; i++)
            {
                listViewLotteryResultGirls.Items.Add(
                    new ListViewItem()
                    {
                        Text = (i + 1).ToString(),
                    });
            }
            columnNumberGirls.Width = -2;
        }

        private void loadTeamDatas()
        {
            try
            {
                TeamDatas? teamDatasBoys = TeamDatas.DeserializeTeamDatas(Categories.Boys);
                if (teamDatasBoys != null)
                {
                    addAllTeamDatas(Categories.Boys, teamDatasBoys);
                }

                TeamDatas? teamDatasGirls = TeamDatas.DeserializeTeamDatas(Categories.Girls);
                if (teamDatasGirls == null)
                {
                    teamDatasGirls =
                        new TeamDatas()
                        {
                            TeamDatasList = TeamData.CreateDefaultGirlsTeamList()
                        };
                }
                addAllTeamDatas(Categories.Girls, teamDatasGirls);
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

        private void addAllTeamDatas(Categories category, TeamDatas teamDatas)
        {

        }

        #endregion

        #region イベント・ハンドラ

        private void LotteryForm_Load(object sender, EventArgs e)
        {
            preparingListViewForLottery();
        }
        #endregion
    }
}
