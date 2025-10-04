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
    public partial class SettingsTeamsDialog : Form
    {
        #region コンストラクタ
        public SettingsVenueDialog()
        {
            InitializeComponent();
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
                textBoxTeamID.Text = VenueData.Name;
                numericUpDownNumberOfCourts.Value = VenueData.NumberOfCourts;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTeamID.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    this,
                    "会場名が設定してください。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ActiveControl = textBoxTeamID;

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
                VenueData = new VenueData();
            }
            VenueData.Name = textBoxTeamID.Text.Trim();
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
