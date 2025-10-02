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
    public partial class SettingsTourneyNameDialog : Form
    {
        #region コンストラクタ
        public SettingsTourneyNameDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        public TournamentNameData? TourneneyNameData { get; set; }
        #endregion

        #region イベント・ハンドラ
        private void SettingsTourneyNameDialog_Load(object sender, EventArgs e)
        {
            if (TourneneyNameData != null)
            {
                textBoxTournamentName.Text = TourneneyNameData.Name;
                if (TourneneyNameData.FixedNumOfBoysTeams > 0)
                {
                    checkBoxFixedNumOfBoysTeams.Checked = true;
                    numericUpDownNumOfBoysTeams.Value = TourneneyNameData.FixedNumOfBoysTeams;
                }
                if (TourneneyNameData.FixedNumOfGirlsTeams > 0)
                {
                    checkBoxFixedNumOfGirlsTeams.Checked = true;
                    numericUpDownNumOfGirlsTeams.Value = TourneneyNameData.FixedNumOfGirlsTeams;
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

            if (TourneneyNameData == null)
            {
                TourneneyNameData = new TournamentNameData();
            }
            TourneneyNameData.Name = textBoxTournamentName.Text.Trim();
            TourneneyNameData.FixedNumOfBoysTeams =
                (int)(checkBoxFixedNumOfBoysTeams.Checked
                    ? numericUpDownNumOfBoysTeams.Value
                    : 0);
            TourneneyNameData.FixedNumOfGirlsTeams =
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
