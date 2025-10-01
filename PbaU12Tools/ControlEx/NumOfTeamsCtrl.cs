using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.ControlEx
{
    public partial class NumOfTeamsCtrl : UserControl
    {
        #region 定数
        private const string CheckBoxBoysTeamsTextFormatString = "男子(&B)";
        private const string CheckBoxGirlsTeamsTextFormatString = "女子(&G)";
        private const string CheckBoxUnknownTeamsTextFormatString = "不明(&U)";
        private const string labelNumOfTeamsText1 = "出場チーム数(&";
        private const string labelNumOfTeamsText2 = "):";
        private const string labelNumOfSuperSeedText1 = "スーパーシード・チーム数(&";
        private const string CheckBoxFinalLeagueTextFormatString = "決勝リーグ(&";
        #endregion

        #region コンストラクタ
        public NumOfTeamsCtrl()
        {
            InitializeComponent();

            checkBoxTeams.Image = CommonResources.UnknownTeam;
        }
        #endregion

        #region プロパティ
        private Category _category = Category.Unknown;
        /// <summary>
        /// カテゴリー
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;

                    if (_category == Category.Boys)
                    {
                        checkBoxTeams.Text = CheckBoxBoysTeamsTextFormatString;
                        checkBoxTeams.Image = CommonResources.BoysTeam;
                        labelNumOfTeams.Text =
                            labelNumOfTeamsText1 + "1" + labelNumOfTeamsText2;
                        labelNumOfSuperSeed.Text =
                            labelNumOfSuperSeedText1 + "2" + labelNumOfTeamsText2;
                        checkBoxFinalLeague.Text =
                            CheckBoxFinalLeagueTextFormatString + "3" + labelNumOfTeamsText2;
                    }
                    else if (_category == Category.Girls)
                    {
                        checkBoxTeams.Text = CheckBoxGirlsTeamsTextFormatString;
                        checkBoxTeams.Image = CommonResources.GirlsTeam;
                        labelNumOfTeams.Text =
                            labelNumOfTeamsText1 + "4" + labelNumOfTeamsText2;
                        labelNumOfSuperSeed.Text =
                            labelNumOfSuperSeedText1 + "5" + labelNumOfTeamsText2;
                        checkBoxFinalLeague.Text =
                            CheckBoxFinalLeagueTextFormatString + "6" + labelNumOfTeamsText2;
                    }
                    else
                    {
                        checkBoxTeams.Text = CheckBoxUnknownTeamsTextFormatString;
                        checkBoxTeams.Image = CommonResources.UnknownTeam;
                        labelNumOfTeams.Text =
                            labelNumOfTeamsText1 + "0" + labelNumOfTeamsText2;
                        labelNumOfSuperSeed.Text =
                            labelNumOfSuperSeedText1 + "0" + labelNumOfTeamsText2;
                        checkBoxFinalLeague.Text =
                            CheckBoxFinalLeagueTextFormatString + "0" + labelNumOfTeamsText2;
                    }
                }
            }
        }

        private bool _categoryValidity = false;
        /// <summary>
        /// カテゴリーの有効性
        /// </summary>
        public bool CategoryValidity
        {
            get { return _categoryValidity; }
            set
            {
                if (_categoryValidity != value)
                {
                    _categoryValidity = value;

                    checkBoxTeams.Checked = _categoryValidity;
                }
            }
        }

        private int _numberOfTeams = 0;
        /// <summary>
        /// 出場チーム数
        /// </summary>
        public int NumberOfTeams
        {
            get { return (int)numericUpDownNumberOfTeams.Value; }
            set
            {
                if (numericUpDownNumberOfTeams.Value != value)
                {
                    _numberOfTeams = value;

                    numericUpDownNumberOfTeams.Value = value;
                }
            }
        }

        private bool _useSuperSeeds = false;
        /// <summary>
        /// スーパーシード・チーム数を使用するかどうか
        /// </summary>
        public bool UseSuperSeeds
        {
            get { return _useSuperSeeds; }
            set
            {
                if (_useSuperSeeds != value)
                {
                    _useSuperSeeds = value;
                    labelNumOfSuperSeed.Enabled = _useSuperSeeds;
                    numericUpDownSuperSeed.Enabled = _useSuperSeeds;
                }
            }
        }

        private int _numberOfSuperSeeds = 0;
        /// <summary>
        /// スーパーシード・チーム数
        /// </summary>
        public int NumberOfSuperSeeds
        {
            get { return _numberOfSuperSeeds; }
            set
            {
                if (_numberOfSuperSeeds != value)
                {
                    _numberOfSuperSeeds = value;
                    numericUpDownSuperSeed.Value = value;
                }
            }
        }

        private bool _useFinalLeage = false;
        /// <summary>
        /// 決勝リーグ チェックボックスを使用するかどうか
        /// </summary>
        public bool UseFinalLeage
        {
            get { return _useFinalLeage; }
            set
            {
                if (_useFinalLeage != value)
                {
                    _useFinalLeage = value;
                    checkBoxFinalLeague.Enabled = _useFinalLeage;
                }
            }
        }

        private bool _finalLeage = false;
        /// <summary>
        /// 決勝リーグ
        /// </summary>
        public bool FinalLeage
        {
            get { return _finalLeage; }
            set
            {
                if (_finalLeage != value)
                {
                    _finalLeage = value;
                    checkBoxFinalLeague.Checked = _finalLeage;
                }
            }
        }
        #endregion

        #region イベント・ハンドラ
        private void checkBoxTeams_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTeams.Enabled = checkBoxTeams.Checked;
            CategoryValidity = checkBoxTeams.Checked;
        }

        private void numericUpDownNumberOfTeams_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSuperSeed.Value > numericUpDownNumberOfTeams.Value)
            {
                numericUpDownSuperSeed.Maximum = numericUpDownNumberOfTeams.Value;
                numericUpDownSuperSeed.Value = numericUpDownNumberOfTeams.Value;
            }
        }
        #endregion
    }
}
