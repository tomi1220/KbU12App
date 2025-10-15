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

namespace PbaU12Tools.Settings
{
    public partial class SettingsTournamentNameDialog : Form
    {
        #region コンストラクタ
        public SettingsTournamentNameDialog()
        {
            InitializeComponent();

            this.Icon = CommonResources.BracketIcon;
        }
        #endregion

        #region プロパティ
        public TourneyNameData? TourneyNameData { get; set; }
        #endregion

        #region イベント・ハンドラ
        private void SettingsTourneyNameDialog_Load(object sender, EventArgs e)
        {
            if (TourneyNameData != null)
            {
                textBoxTournamentName.Text = TourneyNameData.Name;
                if (TourneyNameData.FixedNumOfBoysTeams > 0)
                {
                    checkBoxFixedNumOfBoysTeams.Checked = true;
                    numericUpDownNumOfBoysTeams.Value = TourneyNameData.FixedNumOfBoysTeams;
                }
                if (TourneyNameData.FixedNumOfGirlsTeams > 0)
                {
                    checkBoxFixedNumOfGirlsTeams.Checked = true;
                    numericUpDownNumOfGirlsTeams.Value = TourneyNameData.FixedNumOfGirlsTeams;
                }
            }
        }

        private void checkBoxFixedNumOfBoysTeams_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNumOfBoysTeams.Enabled = checkBoxFixedNumOfBoysTeams.Checked;
        }

        private void checkBoxFixedNumOfGirlsTeams_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNumOfGirlsTeams.Enabled = checkBoxFixedNumOfGirlsTeams.Checked;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTournamentName.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "大会名が設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = textBoxTournamentName;

                return;
            }
            if (checkBoxFixedNumOfBoysTeams.Checked &&
                numericUpDownNumOfBoysTeams.Value == 0)
            {
                MessageBox.Show(
                    this,
                    "男子の固定チーム数が設定されていません。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = numericUpDownNumOfBoysTeams;

                return;
            }
            if (checkBoxFixedNumOfGirlsTeams.Checked &&
                numericUpDownNumOfGirlsTeams.Value == 0)
            {
                MessageBox.Show(
                    this,
                    "女子の固定チーム数が設定されていません。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = numericUpDownNumOfGirlsTeams;

                return;
            }

            if (TourneyNameData == null)
            {
                TourneyNameData = new TourneyNameData();
            }
            TourneyNameData.Name = textBoxTournamentName.Text.Trim();
            TourneyNameData.FixedNumOfBoysTeams =
                (int)(checkBoxFixedNumOfBoysTeams.Checked
                    ? numericUpDownNumOfBoysTeams.Value
                    : 0);
            TourneyNameData.FixedNumOfGirlsTeams =
                (int)(checkBoxFixedNumOfGirlsTeams.Checked
                    ? numericUpDownNumOfGirlsTeams.Value
                    : 0);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
