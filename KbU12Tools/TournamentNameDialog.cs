using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KbU12Tools
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
        public TournamentNameDatas? TournamentNameDatas { private get; set; }
        public TournamentNameData? TournamentNameData { get; set; }
        #endregion

        #region メソッド
        #endregion

        #region ローカル・メソッド
        private void setTournamentNameComboBox()
        {
            if (TournamentNameDatas != null)
            {
                if (TournamentNameDatas.TournamentNameDatasList != null)
                {
                    foreach (var tn in TournamentNameDatas.TournamentNameDatasList)
                    {
                        ItemData itemData =
                            new()
                            {
                                Text = tn.Name,
                                Tag = tn.MstTournamentNameID
                            };
                        comboBoxTournamentName.Items.Add(itemData);
                    }
                }
            }
        }

        private void setTournamentNameData()
        {
            if (TournamentNameData != null)
            {
                if (TournamentNameData.MstTournamentNameID != 0)
                {
                    foreach (ItemData itemData in comboBoxTournamentName.Items)
                    {
                        if ((int)(itemData.Tag ?? 0) == TournamentNameData.MstTournamentNameID)
                        {
                            comboBoxTournamentName.SelectedItem = itemData;
                            break;
                        }
                    }
                }

                comboBoxTournamentName.Text = TournamentNameData.Name;
                if (TournamentNameData.NumOfTimes != 0)
                {
                    panelNumOfTournaments.Enabled = true;
                    checkBoxNumOfTournaments.Checked = true;
                    numericUpDownNumOfTournaments.Value = TournamentNameData.NumOfTimes;
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
            string tournamentName = string.Empty;
            int mstTournamentNameID = 0;
            int numOfTimes = 0;

            if (!string.IsNullOrWhiteSpace(comboBoxTournamentName.Text))
            {
                if (comboBoxTournamentName.SelectedItem != null)
                {
                    if (comboBoxTournamentName.SelectedItem is ItemData itemData)
                    {
                        if (comboBoxTournamentName.Text == itemData.Text)
                        {
                            mstTournamentNameID = (int)(itemData.Tag ?? 0);
                        }
                    }
                }

                if (checkBoxNumOfTournaments.Checked)
                {
                    tournamentName =
                        labelNumOfTournaments1.Text +
                        numericUpDownNumOfTournaments.Value.ToString() +
                        labelNumOfTournaments2.Text;

                    numOfTimes = (int)numericUpDownNumOfTournaments.Value;
                }
                tournamentName += comboBoxTournamentName.Text;

                if (TournamentNameData == null ||
                    TournamentNameData.FullName != tournamentName ||
                    TournamentNameData.MstTournamentNameID != mstTournamentNameID ||
                    TournamentNameData.NumOfTimes != numOfTimes)
                {
                    TournamentNameData =
                        new TournamentNameData()
                        {
                            FullName = tournamentName,
                            Name = comboBoxTournamentName.Text,
                            MstTournamentNameID = mstTournamentNameID,
                            NumOfTimes = numOfTimes
                        };
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
