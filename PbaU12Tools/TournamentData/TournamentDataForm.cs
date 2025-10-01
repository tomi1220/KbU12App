using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.TournamentData
{
    public partial class TournamentDataForm : Form
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region クラス
        #endregion

        #region フィールド
        #endregion

        #region コンストラクタ
        public TournamentDataForm()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;
            checkBoxBoys.Image = CommonResources.BoysTeam;
            checkBoxGirls.Image = CommonResources.GirlsTeam;

            buttonAddVenue.Image = CommonResources.Add;

            buttonAddVenue.Image = CommonResources.Add;
            buttonEditVenue.Image = CommonResources.Edit;
            buttonDeleteVenue.Image = CommonResources.Delete;
        }
        #endregion

        #region プロパティ
        public TournamentData? PreTournamentData { private get; set; }
        public TournamentData? CurrentTournamentData { get; private set; }
        #endregion

        #region メソッド
        #endregion

        #region ローカル・メソッド
        private void setTournamentData()
        {
            // 大会名
            if (!string.IsNullOrEmpty(PreTournamentData!.TournamentName))
            {
                textBoxTournamentName.Text = PreTournamentData.TournamentName;
            }
            // トーナメント表データ
            // 男子
            if (PreTournamentData.BrackectDataBoys != null)
            {
            }
            // 女子
            // オープン参加表示枠
            checkBoxOpen.Checked = PreTournamentData.OpenDisplayFrame;
            // 会場データ
        }

        #endregion

        #region イベント・ハンドラ
        #region ［フォーム］
        private void TournamentDataForm_Load(object sender, EventArgs e)
        {
            if (PreTournamentData != null)
            {
                setTournamentData();
            }
            else
            {
                checkBoxBoys.Checked = true;
                numericUpDownNumberOfTeamsBoys.Value = 0;
                checkBoxGirls.Checked = true;
                numericUpDownNumberOfTeamsGirls.Value = 0;
            }
        }
        #endregion

        #region ［大会名］
        private void buttonTournamentName_Click(object sender, EventArgs e)
        {
            // 大会名
            using var dlg = new TournamentNameDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxTournamentName.Text = dlg.TournamentName;
            }
        }
        #endregion

        #region ［会場情報］
        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報］追加
        }

        private void buttonEditVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報］変更
        }

        private void buttonDeleteVenue_Click(object sender, EventArgs e)
        {
            // ［会場情報］削除
        }
        #endregion

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // [OK]ボタン
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // [キャンセル]ボタン
        }
        #endregion
    }
}
