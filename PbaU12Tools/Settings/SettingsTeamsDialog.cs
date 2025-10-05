using PbaU12Tools.Common;
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
    public partial class SettingsTeamsDialog : Form
    {
        #region コンストラクタ
        public SettingsTeamsDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        public Categories Category { private get; set; }
        public TeamInfo? TeamInfo { get; set; }
        #endregion

        #region イベント・ハンドラ
        private void setDistrictsComboBox()
        {
            foreach (var d in DistrictsList.DicDistrict)
            {
                comboBoxDistrict.Items.Add(
                    new ItemData()
                    {
                        Text = d.Value,
                        Tag = d.Key,
                    });
            }
        }
        private void setJbaTeamRegistrationStatusesComboBox()
        {
            foreach (var d in JbaTeamRegistrationStatusesList.DicJbaTeamRegistrationStatuses)
            {
                comboBoxJbaTeamRegistrationStatuses.Items.Add(
                    new ItemData()
                    {
                        Text = d.Value,
                        Tag = d.Key,
                    });
            }
        }
        #endregion

        #region イベント・ハンドラ
        private void SettingsVenueDialog_Load(object sender, EventArgs e)
        {
            setDistrictsComboBox();
            setJbaTeamRegistrationStatusesComboBox();

            if (Category == Categories.Girls)
            {
                labelCategory.BackColor = CommonValues.GirlsColor;
            }
            else
            {
                labelCategory.BackColor = CommonValues.BoysColor;
            }

            if (TeamInfo != null)
            {
                textBoxTeamID.Text = TeamInfo.JbaTeamID.Replace("T", "");
                textBoxTeamName.Text = TeamInfo.TeamName;
                textBoxTeamNameKana.Text = TeamInfo.ShortNameKana;
                textBoxShortName.Text = TeamInfo.ShortName;
                if (DistrictsList.DicDistrict.TryGetValue(TeamInfo.District, out string? district))
                {
                    comboBoxDistrict.Text = district;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTeamName.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "チーム名を設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = textBoxTeamName;

                return;
            }
            if (textBoxShortName.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "略称を設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = textBoxShortName;

                return;
            }

            if (comboBoxDistrict.SelectedIndex == -1)
            {
                MessageBox.Show(
                    this,
                    "地区を選択してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = comboBoxDistrict;

                return;
            }

            string jbaTeamID = textBoxTeamID.Text.Trim();
            if (jbaTeamID.Length > 0 &&　jbaTeamID.Length != 9)
            {
                if (MessageBox.Show(
                        this,
                        "JBAチームIDの桁数が 9桁ではありません。" + Environment.NewLine +
                        "間違いではありませんか？" + Environment.NewLine +
                        $"　入力されているIDの桁数 = {jbaTeamID.Length}",
                        Environment.NewLine +
                        "［はい］続行" + Environment.NewLine +
                        "［いいえ］戻って修正" + Environment.NewLine +
                        this.Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    ActiveControl = textBoxTeamID;
                    this.DialogResult = DialogResult.None;
                }

                return;
            }

            if (TeamInfo == null)
            {
                TeamInfo = new TeamInfo();
            }
            TeamInfo.JbaTeamID = jbaTeamID;
            TeamInfo.TeamName = textBoxTeamName.Text.Trim();
            TeamInfo.TeamNameKana = textBoxTeamNameKana.Text.Trim();
            TeamInfo.ShortName = textBoxShortName.Text.Trim();
            if (comboBoxDistrict.SelectedItem is ItemData itemDataDistrict)
            {
                TeamInfo.District =  (Districts)itemDataDistrict.Tag!;
            }
            if (comboBoxJbaTeamRegistrationStatuses.SelectedItem is ItemData itemDataJbaStatus)
            {
                TeamInfo.JbaStatus = (JbaTeamRegistrationStatuses)itemDataJbaStatus.Tag!;
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
