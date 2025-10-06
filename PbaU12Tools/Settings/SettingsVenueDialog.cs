using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PbaU12Tools.Venue;

namespace PbaU12Tools.Settings
{
    public partial class SettingsVenueDialog : Form
    {
        #region コンストラクタ
        public SettingsVenueDialog()
        {
            InitializeComponent();

            this.Icon = CommonResources.HomeIcon;

        }
        #endregion

        #region プロパティ
        public VenueData? VenueData { get; set; }
        #endregion

        #region イベント・ハンドラ
        private void SettingsVenueDialog_Load(object sender, EventArgs e)
        {
            if (VenueData != null)
            {
                textBoxVenueName.Text = VenueData.Name;
                numericUpDownNumberOfCourts.Value = VenueData.NumberOfCourts;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxVenueName.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "会場名を設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = textBoxVenueName;

                return;
            }
            if (numericUpDownNumberOfCourts.Value == 0)
            {
                MessageBox.Show(
                    this,
                    "コート数が設定されていません。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = numericUpDownNumberOfCourts;

                return;
            }

            if (VenueData == null)
            {
                VenueData = new VenueData();
            }
            VenueData.Name = textBoxVenueName.Text.Trim();
            VenueData.NumberOfCourts = (int)numericUpDownNumberOfCourts.Value;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
