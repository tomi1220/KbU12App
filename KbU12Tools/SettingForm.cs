using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace KbU12Tools
{
    public partial class SettingForm : Form
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region クラス
        #endregion

        #region フィールド
        #endregion

        #region コンストラクタ

        public SettingForm()
        {
            InitializeComponent();

            imageListTournamentNames.Images.Add(CommonResources.BracketDodgerblue);

            listViewTournamentNames.ListViewItemSorter = new VenueListViewItemComparer();
        }
        #endregion

        #region プロパティ
        #endregion

        #region ローカル・メソッド
        #endregion

        #region イベント・ハンドラ
        #endregion

        private void buttonBrowseBaseDataFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        }
    }
}
