using PbaU12Tools.TournamentData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.Bracket
{
    public partial class BracketOutputDialog : Form
    {
        #region フィールド
#if DEBUG
        private readonly DebugInfoForm _debugForm;
#endif
        #endregion

        #region コンストラクタ
        public BracketOutputDialog()
        {
            InitializeComponent();
#if DEBUG
            _debugForm = new DebugInfoForm();
#endif
        }
        #endregion

        #region プロパティ
        public TournamentData.TourneyData? TourneyData { get; set; }
        public BracketGenData? BracketGenDataBoys { get; set; }
        public BracketGenData? BracketGenDataGirls { get; set; }
        public TournamentDataStatuses CurrentStatus { get; set; } = TournamentDataStatuses.None;
        #endregion

        #region ローカル・メソッド
        #endregion

        #region イベント・ハンドラ
        private void BracketOutputDialog_Load(object sender, EventArgs e)
        {
            if (TourneyData!.Status == TournamentDataStatuses.RafflePreparation)
            {
                radioButtonPurposeForRaffle.Checked = true;
                radioButtonPurposeVenueAndMatchOrder.Enabled = false;
            }
            else
            {
                radioButtonPurposeVenueAndMatchOrder.Checked = true;
                //radioButtonPurposeVenueAndMatchOrder.Enabled = true;
            }
#if DEBUG
            _debugForm.StartPosition = FormStartPosition.Manual;
            _debugForm.Location = new Point(this.Bounds.Right, this.Bounds.Top);
            _debugForm.Show(this);
            _debugForm.FillDebugInfo(TourneyData!, BracketGenDataBoys, BracketGenDataGirls);
#endif
        }

        private void radioButtonPurpose_CheckedChanged(object sender, EventArgs e)
        {
            // 用途のRadioButton
            if (radioButtonPurposeForRaffle.Checked)
            {
                panelPurposeVenueAndMatchOrder.Enabled = false;
            }
            if (radioButtonPurposeForRaffle.Checked)
            {
                panelPurposeVenueAndMatchOrder.Enabled = true;
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            // 出力先 Button

            // トーナメント表作成用データの生成
            if (TourneyData.BaseDataBoys.NumberOfTeams == 0 &&
                TourneyData.BaseDataGirls.NumberOfTeams ==0)
            {
                return;
            }

            BracketGenerator.GenerateType genType;
            if (radioButtonPurposeForRaffle.Checked)
            {
                genType = BracketGenerator.GenerateType.Lottery;
            }
            else
            {
                genType = BracketGenerator.GenerateType.ExcelOnly;
            }

            using SaveFileDialog sfd = new();
            sfd.Title = "トーナメント表を保存するExcelファイルを指定してください。";
            sfd.Filter = CommonValues.BracketExcelFileFilter;
            sfd.InitialDirectory = CommonTools.DocumentsFolderPath;
            sfd.FileName =
                TourneyData!.TournamentName +
                (radioButtonPurposeForRaffle.Checked ? CommonValues.ForRaffle : string.Empty) +
                CommonValues.ExcelExt;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BracketGenerator bracketGenerator = new BracketGenerator();
                bracketGenerator.TourneyData = TourneyData;
                bracketGenerator.GenType = genType;
                bracketGenerator.Arrangement =
                    TourneyData.TourneyType == TournamentType.PrefecturalTournament
                        ? BracketGenerator.BracketArrangement.Horizontal
                        : BracketGenerator.BracketArrangement.Vertical;
                bracketGenerator.OutputFilePath = sfd.FileName;
                bracketGenerator.GeneratBracket();
            }
        }
        #endregion
    }
}
