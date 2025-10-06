using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PbaU12Tools.Common;
using PbaU12Tools.Venue;

namespace PbaU12Tools.Venue
{
    public partial class VenueSettingDialog : Form
    {
        #region 定数
        #endregion

        #region フィールド
        private Dictionary<DateTime, List<string>> _courtDatas = new Dictionary<DateTime, List<string>>();
        #endregion

        #region コンストラクタ
        public VenueSettingDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        public DateTime TargetDate { get; set; } = DateTime.Today;
        public VenueItemData? VenueData { get; set; }
        public List<VenueItemData> OtherVenueList { get; set; } = new List<VenueItemData>();
        #endregion

        #region メソッド
        #endregion

        #region ローカル・メソッド
        /// <summary>
        /// 他の会場のコートデータを作成する
        /// </summary>
        private void CreateOtherVenueCourtDatas()
        {
            if (OtherVenueList != null)
            {
                foreach (var v in OtherVenueList)
                {
                    if (_courtDatas.TryGetValue(v.TargetDate, out List<string>? courtData))
                    {
                        courtData.AddRange(v.CourtList);
                    }
                    else
                    {
                        courtData = new List<string>(v.CourtList);
                        _courtDatas.Add(v.TargetDate, courtData);
                    }
                }
            }
        }

        /// <summary>
        /// 会場データをロードする
        /// </summary>
        /// <returns></returns>
        private VenueDatas? loadVenueDatas()
        {
            try
            {
                VenueDatas? venueDatas = VenueDatas.DeserializeVenueDatas();

                return venueDatas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "会場データがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// 会場ComboBoxに会場情報を設定する
        /// </summary>
        /// <param name="venueDatas"></param>
        private void SetVenueComboBox(VenueDatas? venueDatas)
        {
            if (venueDatas != null)
            {
                if (venueDatas!.VenueDatasList != null)
                {
                    List<ItemData> itemDatas = new List<ItemData>();
                    foreach (var vd in venueDatas.VenueDatasList)
                    {
                        itemDatas.Add(
                            new ItemData()
                            {
                                Text = vd.Name,
                                Tag = vd
                            });
                    }
                    comboBoxVenue.Items.AddRange([.. itemDatas]);
                }
            }
        }

        private void SetCourtInfo(List<string>? courtData)
        {
            foreach (var o in groupBoxCourt.Controls)
            {
                if (o is CheckBox checkBox)
                {
                    if (courtData == null || (courtData != null && courtData.Count == 0))
                    {
                        checkBox.Enabled = true;
                        checkBox.Checked = false;
                    }
                    else
                    {
                        string checkCourt = checkBox.Text.Replace("&", "");
                        if (courtData!.Contains(checkCourt))
                        {
                            checkBox.Checked = true;
                            checkBox.Enabled = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                            checkBox.Checked = false;
                        }
                    }
                }
            }
        }

        private List<string> GetCourtInfo()
        {
            List<string> courtList = new List<string>();
            foreach (var o in groupBoxCourt.Controls)
            {
                if (o is CheckBox checkBox)
                {
                    if (checkBox.Enabled && checkBox.Checked)
                    {
                        string court = checkBox.Text.Replace("&", "");
                        courtList.Add(court);
                    }
                }
            }
            return courtList;
        }

        #endregion

        #region イベント・ハンドラ

        private void VenueSettingDialog_Load(object sender, EventArgs e)
        {
            VenueDatas? venueDatas = loadVenueDatas();

            SetVenueComboBox(venueDatas);

            CreateOtherVenueCourtDatas();

            if (VenueData != null)
            {
                dateTimePicker1.Value = VenueData.TargetDate;

                comboBoxVenue.SelectedText = VenueData.Name;

                if (_courtDatas.TryGetValue(VenueData.TargetDate, out List<string>? courtData))
                {
                    SetCourtInfo(courtData);
                }

                foreach (var c in VenueData.CourtList)
                {
                    foreach (var o in groupBoxCourt.Controls)
                    {
                        if (o is CheckBox checkBox)
                        {
                            if (checkBox.Enabled)
                            {
                                if (checkBox.Text == "&" + c)
                                {
                                    checkBox.Checked = true;
                                }
                            }
                        }
                    }
                }

                if (VenueData.BackColor != 0xFFFFFF &&
                    VenueData.BackColor != Color.Transparent.ToArgb())
                {
                    labelBackColor.BackColor = Color.FromArgb(VenueData.BackColor);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxVenue.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "会場を設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = comboBoxVenue;

                DialogResult = DialogResult.None;
                return;
            }
            List<string> courtList = GetCourtInfo();
            if (courtList.Count == 0)
            {
                MessageBox.Show(
                    this,
                    "コートを設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = groupBoxCourt;

                DialogResult = DialogResult.None;
                return;
            }

            int colorIntVal = 0xFFFFFF;
            if (labelBackColor.BackColor != Color.White &&
                labelBackColor.BackColor != Color.Transparent)
            {
                colorIntVal = labelBackColor.BackColor.ToArgb();
            }

            VenueData = new VenueItemData()
            {
                TargetDate = dateTimePicker1.Value.Date,
                Name = comboBoxVenue.Text.Trim(),
                BackColor = colorIntVal
            };
            courtList.Sort(delegate (string a, string b)
            {
                return a.CompareTo(b);
            });
            VenueData.CourtList.AddRange(courtList);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 対象日が変更された
            if (_courtDatas.TryGetValue(
                dateTimePicker1.Value.Date, out List<string>? courtData))
            {
                SetCourtInfo(courtData);
            }
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            int[] customColors =
                new int[]
                {
                    0xE2EFDA,
                    0xDDEBF7,
                    0xFFF2CC,
                    0xFCE4D6,
                    0xD9E1F2,
                    0xD5F4EE,
                    0xF9D3D2,
                    0xECDEF5,
                    0xDBF4EF,
                    0xD8F0F5,
                    0xE9F5CF,
                    0xEBDEEA,
                    0xFAF0D3,
                    0xFDECD0
                };

            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.CustomColors = customColors;
                if (colorDialog.ShowDialog(this) == DialogResult.OK)
                {
                    labelBackColor.BackColor = colorDialog.Color;
                }
            }
        }
        #endregion
    }
}
