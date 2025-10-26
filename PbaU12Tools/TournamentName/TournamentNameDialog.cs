using PbaU12Tools.Common;
using PbaU12Tools.TournamentData;
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
//using System.Windows.Media;
//using static System.Net.Mime.MediaTypeNames;

namespace PbaU12Tools
{
    public partial class TournamentNameDialog : Form
    {

        #region 定数
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
        public int OldestYear { get; set; } = 0;
        public TourneyNameDatas? TourneyNameDatas { private get; set; } = null;
        public int Year { get; set; } = 0;
        public string TournamentName { get; set; } = string.Empty;
        public int NumberOfTournaments { get; set; } = 0;
        public TourneyNameData? TournamentNameData { get; set; } = null;
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
                if (TourneyNameDatas.TournamentNameDatas != null)
                {
                    foreach (var tn in TourneyNameDatas.TournamentNameDatas)
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
            string baseName =
                TourneyData.TournamentNameSpliter(TournamentName, out int numOfTimes);
            if (!string.IsNullOrEmpty(baseName))
            {
                numericUpDownNumOfTournaments.Value = numOfTimes;

                if (TournamentNameData != null)
                {
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
            int year = 0;
            int numberOfTournaments = 0;
            string tournamentName = string.Empty;
            TourneyNameData? tourneyNameData = null;

            // 年度
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
            else
            {
                MessageBox.Show(
                    this,
                    "年度を選択してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                ActiveControl = comboBoxYear;
                return;
            }

            // 大会回数
            if (checkBoxNumOfTournaments.Checked)
            {
                if (numericUpDownNumOfTournaments.Value == 0)
                {
                    MessageBox.Show(
                        this,
                        "大会回数が設定されていません。",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    ActiveControl = numericUpDownNumOfTournaments;
                    return;
                }

                numberOfTournaments = (int)numericUpDownNumOfTournaments.Value;
            }

            // 大会名
            if (comboBoxTournamentName.SelectedIndex != -1)
            {
                // 既存の大会名からの選択
                if (comboBoxTournamentName.SelectedItem is ItemData itemData)
                {
                    if (comboBoxTournamentName.Text == itemData.Text)
                    {
                        if (itemData.Tag is TourneyNameData tagData)
                        {
                            tourneyNameData = tagData;
                            tournamentName = tourneyNameData.Name;
                        }
                    }
                }
            }
            else
            {
                // 新規の大会名称が入力されている
                tournamentName = comboBoxTournamentName.Text.Trim();
            }

            if (!AllowBlankTournamentName &&
                string.IsNullOrEmpty(tournamentName))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else
            {
                Year = year;
                NumberOfTournaments = numberOfTournaments;
                TournamentName = tournamentName;
                TournamentNameData = tourneyNameData;

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
