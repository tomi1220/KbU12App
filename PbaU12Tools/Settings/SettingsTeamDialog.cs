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
    public partial class SettingsTeamDialog : Form
    {
        #region コンストラクタ
        public SettingsTeamDialog()
        {
            InitializeComponent();

            this.Icon = CommonResources.MixedTeamIcon;
        }
        #endregion

        #region プロパティ
        public Categories Category { private get; set; }
        public TeamData? TeamData { get; set; }
        #endregion

        #region ローカル・メソッド
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
                labelCategory.Text = "女子";
            }
            else
            {
                labelCategory.BackColor = CommonValues.BoysColor;
                labelCategory.Text = "男子";
            }

            if (TeamData != null)
            {
                textBoxTeamID.Text = TeamData.JbaTeamID.Replace("T", "");
                textBoxTeamName.Text = TeamData.TeamName;
                textBoxTeamNameKana.Text = TeamData.ShortNameKana;
                textBoxShortName.Text = TeamData.ShortName;
                if (DistrictsList.DicDistrict.TryGetValue(TeamData.District, out string? district))
                {
                    comboBoxDistrict.Text = district;
                }
                if (JbaTeamRegistrationStatusesList.DicJbaTeamRegistrationStatuses.TryGetValue(TeamData.JbaStatus, out string? jbaStatus))
                {
                    comboBoxJbaTeamRegistrationStatuses.Text = jbaStatus;
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

            if (TeamData == null)
            {
                TeamData = new TeamData();
            }
            TeamData.JbaTeamID = jbaTeamID;
            TeamData.TeamName = textBoxTeamName.Text.Trim();
            TeamData.TeamNameKana = textBoxTeamNameKana.Text.Trim();
            TeamData.ShortName = textBoxShortName.Text.Trim();
            if (comboBoxDistrict.SelectedItem is ItemData itemDataDistrict)
            {
                TeamData.District =  (Districts)itemDataDistrict.Tag!;
            }
            if (comboBoxJbaTeamRegistrationStatuses.SelectedItem is ItemData itemDataJbaStatus)
            {
                TeamData.JbaStatus = (JbaTeamRegistrationStatuses)itemDataJbaStatus.Tag!;
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
