using PbaU12Tools.Common;
using PbaU12Tools.TournamentName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;

namespace PbaU12Tools
{
    public partial class TournamentNameDialog : Form
    {

        #region 定数
        //[GeneratedRegex(@"^[0-9]+$")]
        //internal static partial Regex NumericRegex();
        #endregion

        #region フィールド
        #endregion

        #region コンストラクタ
        public TournamentNameDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        public bool AllowBlankTournamentName { get; set; } = false;
        public int OldestYear { get; set; }
        public TourneyNameDatas? TourneyNameDatas { private get; set; }
        public TourneyNameData? TourneyNameData { get; set; }
        public string TournamentName { get; set; } = string.Empty;
        #endregion

        #region メソッド
        #endregion

        #region ローカル・メソッド
        private void setTournamentNameComboBox()
        {
            string selectYear = string.Empty;
            int nextYear = DateTime.Now.Year;
            if (DateTime.Now.Month >= 4)
            {
                // 4月～12月
                nextYear++;
            }
            selectYear = (nextYear - 1).ToString();
            if (OldestYear == 0)
            {
                OldestYear = DateTime.Now.Year;
                if (DateTime.Now.Month < 4)
                {
                    OldestYear--;
                }
            }
            for (int i = OldestYear; i <= nextYear; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }
            comboBoxYear.Text = selectYear;

            if (TourneyNameDatas == null)
            {
                string filePath =
                    Path.Combine(
                        CommonTools.DataFolderPath,
                        CommonValues.TournamentNameDatasFileName);

                if (File.Exists(filePath))
                {
                    using var sr = new StreamReader(filePath);
                    string xmlText = sr.ReadToEnd();

                    TourneyNameDatas = TourneyNameDatas.Deserialize(xmlText);
                }
            }

            if (TourneyNameDatas != null)
            {
                if (TourneyNameDatas.TourneyNameDatasList != null)
                {
                    foreach (var tn in TourneyNameDatas.TourneyNameDatasList)
                    {
                        ItemData itemData =
                            new()
                            {
                                Text = tn.Name,
                                Tag = tn
                            };
                        comboBoxTournamentName.Items.Add(itemData);
                    }
                }
            }
            comboBoxTournamentName.SelectedIndex = -1;
        }

        private void setTournamentNameData()
        {
            if (!string.IsNullOrEmpty(TournamentName))
            {
                string baseName = string.Empty;
                if (TournamentName.StartsWith('第'))
                {
                    // 大会名が"第"で始まるので、回数付きか調べる
                    int kaiIndex = TournamentName.IndexOf('回');
                    if (kaiIndex > -1)
                    {
                        // "回"がある
                        string numberText = TournamentName[1..kaiIndex];
                        // 半角数字のみか？
                        if (NumericRegex().IsMatch(numberText))
                        {
                            int numOfTournament = int.Parse(numberText);
                            panelNumOfTournaments.Enabled = true;
                            checkBoxNumOfTournaments.Checked = true;
                            numericUpDownNumOfTournaments.Value = numOfTournament;
                        }
                        baseName = TournamentName.Substring(kaiIndex + 1);
                    }
                    else
                    {
                        baseName = TournamentName;
                    }
                }
                foreach (ItemData itemData in comboBoxTournamentName.Items)
                {
                    if (itemData.Tag is TourneyNameData tourneyName)
                    {
                        if (tourneyName.Name == baseName)
                        {
                            comboBoxTournamentName.SelectedItem = itemData;
                            break;
                        }
                    }
                }
                if (comboBoxTournamentName.SelectedIndex == -1)
                {
                    comboBoxTournamentName.Text = TournamentName;
                }
            }
        }
        #endregion

        #region イベント・ハンドラ
        private void TournamentNameDialog_Load(object sender, EventArgs e)
        {
            setTournamentNameComboBox();

            setTournamentNameData();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int year;
            string tournamentName = string.Empty;
            TourneyNameData? tourneyNameData = null;

            if (comboBoxYear.SelectedIndex != -1)
            {
                try
                {
                    year = int.Parse(comboBoxYear.Text);
                }
                catch (FormatException formatEx)
                {
                    MessageBox.Show(
                        this,
                        comboBoxYear.Text + ": Bad Format" + Environment.NewLine +
                        formatEx.Message,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    ActiveControl = comboBoxYear;
                    return;
                }
                catch (OverflowException overflowEx)
                {
                    MessageBox.Show(
                        this,
                        comboBoxYear.Text + ": Overflow" + Environment.NewLine +
                        overflowEx.Message,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    ActiveControl = comboBoxYear;
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(comboBoxTournamentName.Text.Trim()))
            {
                if (comboBoxTournamentName.SelectedItem is ItemData itemData)
                {
                    if (comboBoxTournamentName.Text == itemData.Text)
                    {
                        if (itemData.Tag is TourneyNameData tagData)
                        {
                            tourneyNameData = tagData;
                        }
                    }
                }
                tournamentName = comboBoxTournamentName.Text.Trim();

                if (checkBoxNumOfTournaments.Checked)
                {
                    string numOfTimes =
                        labelNumOfTournaments1.Text +
                        numericUpDownNumOfTournaments.Value.ToString() +
                        labelNumOfTournaments2.Text;

                    tournamentName = numOfTimes + tournamentName;
                }
            }

            if (!AllowBlankTournamentName &&
                string.IsNullOrEmpty(tournamentName))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else
            {
                TournamentName = tournamentName;
                this.TourneyNameData = tourneyNameData;

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxNumOfTournaments_CheckedChanged(object sender, EventArgs e)
        {
            panelNumOfTournaments.Enabled = checkBoxNumOfTournaments.Checked;
        }

        private void numericUpDownNumOfTournaments_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDownNumOfTournaments.Value < 1)
                {
                    numericUpDownNumOfTournaments.BackColor = Color.Red;
                }
                else
                {
                    numericUpDownNumOfTournaments.BackColor = SystemColors.Window;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
