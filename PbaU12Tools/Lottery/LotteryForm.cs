using PbaU12Tools.TournamentData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace PbaU12Tools.Lottery
{
    public partial class LotteryForm : Form
    {
        #region Enum
        private enum InputMode
        {
            DragDrop,
            DirectInput
        }
        #endregion

        #region 定数
        #endregion

        #region フィールド
        private TournamentData.TournamentData _tournamentData;
        #endregion

        #region コンストラクタ
        public LotteryForm(TournamentData.TournamentData tournamentData)
        {
            InitializeComponent();

            _tournamentData = tournamentData;

            imageList1.Images.Add(CommonResources.BoysTeam);
            imageList1.Images.Add(CommonResources.GirlsTeam);
            tabPageBoys.ImageIndex = 0;
            tabPageGirls.ImageIndex = 1;
            tabPageBoys.BackColor = CommonValues.BoysBackColor;
            tabPageGirls.BackColor = CommonValues.GirlsBackColor;

            panelDirectInputBoys.Dock = DockStyle.Fill;
            panelDnDTeamBoys.Dock = DockStyle.Fill;
            panelDirectInputBoys.Visible = false;
            panelDnDTeamBoys.Visible = true;

            panelDirectInputGirls.Dock = DockStyle.Fill;
            panelDnDTeamGirls.Dock = DockStyle.Fill;
            panelDirectInputGirls.Visible = false;
            panelDnDTeamGirls.Visible = true;

            InitializeControls();
        }
        #endregion

        #region プロパティ
        #endregion

        #region ローカル・メソッド
        private void InitializeControls()
        {
            comboBoxInputMode.Items.Add(
                new ItemData() { Text = "Drag & Drop", Tag = InputMode.DragDrop });
            comboBoxInputMode.Items.Add(
                new ItemData() { Text = "Direct input", Tag = InputMode.DirectInput });
            comboBoxInputMode.SelectedIndex = 0;

            comboBoxInputMode.SelectedIndexChanged += comboBoxInputMode_SelectedIndexChanged;
        }

        private void preparingListViewForLottery()
        {
            for (int i = 1; i <= _tournamentData.BaseDataBoys.NumberOfTeams; i++)
            {
                listViewDndLotteryNumberBoys.Items.Add(
                    new ListViewItem()
                    {
                        Name = i.ToString(),
                        Text = i.ToString(),
                        Tag = i
                    });
            }
            columnDnDLotteryNumberBoys.Width = -2;

            for (int i = 1; i <= _tournamentData.BaseDataGirls.NumberOfTeams; i++)
            {
                listViewDndLotteryNumberGirls.Items.Add(
                    new ListViewItem()
                    {
                        Name = i.ToString(),
                        Text = i.ToString(),
                        Tag = i
                    });
            }
            columnDnDLotteryNumberGirls.Width = -2;
        }

        private void loadTeamDatas()
        {
            try
            {
                TeamDatas? teamDatasBoys = TeamDatas.DeserializeTeamDatas(Categories.Boys);
                if (teamDatasBoys != null)
                {
                    addAllTeamDatas(listViewDnDTeamsBoys, teamDatasBoys);
                }

                TeamDatas? teamDatasGirls = TeamDatas.DeserializeTeamDatas(Categories.Girls);
                if (teamDatasGirls != null)
                {
                    addAllTeamDatas(listViewDnDTeamsGirls, teamDatasGirls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "チームデータがロードできませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void addAllTeamDatas(ListView listView, TeamDatas teamDatas)
        {
            foreach (var team in teamDatas.TeamDatasList!)
            {
                if (team.District == Districts.KagoshimaNorth ||
                    team.District == Districts.KagoshimaWest ||
                    team.District == Districts.KagoshimaSouth ||
                    team.District == Districts.KagoshimaCentral)
                {
                    ListViewItem listViewItem =
                        new ListViewItem()
                        {
                            Text = team.ShortName,
                        };
                    listViewItem.SubItems.Add(string.Empty);
                    listView.Items.Add(listViewItem);
                }
            }
            listView.Columns[1].Width = -2;
        }

        private ListViewItem? getListViewItemFromDraggingPoint(ListView listView, Point point)
        {
            Point targetPoint = listView.PointToClient(point);
            ListViewHitTestInfo hitTestInfo = listView.HitTest(targetPoint);
            if (hitTestInfo != null && hitTestInfo.Item != null)
            {
                return hitTestInfo.Item;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region イベント・ハンドラ

        #region フォーム
        private void LotteryForm_Load(object sender, EventArgs e)
        {
            loadTeamDatas();

            preparingListViewForLottery();
        }
        #endregion

        #region 入力モードComboBox
        private void comboBoxInputMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxInputMode.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (comboBoxInputMode.SelectedItem is ItemData itemData)
                {
                    if ((InputMode)itemData.Tag! == InputMode.DirectInput)
                    {
                        panelDnDTeamBoys.Visible = false;
                        panelDirectInputBoys.Visible = true;
                    }
                    else if ((InputMode)itemData.Tag! == InputMode.DragDrop)
                    {
                        panelDirectInputBoys.Visible = false;
                        panelDnDTeamBoys.Visible = true;
                    }
                }
            }
        }
        #endregion

        #region 抽選番号ListView
        private void listViewDndLotteryNumber_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (listViewDndLotteryNumberBoys.SelectedItems.Count == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Debug.WriteLine("%%% Before DoDragDrop");
                    DoDragDrop(e.Item!, DragDropEffects.Move);
                    Debug.WriteLine("%%% After DoDragDrop");
                }
            }
        }

        private void listViewDndLotteryNumber_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && e.Item != null)
            {
                labelLotteryNumberBoys.Text = e.Item.Text;
            }
            else
            {
                labelLotteryNumberBoys.Text = string.Empty;
            }
        }

        #endregion

        #region 抽選結果ListView
        private void listViewDnDTeams_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is ListView listView)
            {
                ListViewItem? targetItem =
                    getListViewItemFromDraggingPoint(listView, new Point(e.X, e.Y));
                if (targetItem != null)
                {
                    if (e.Data != null)
                    {
                        ListViewItem? draglistViewItem = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                        if (draglistViewItem != null)
                        {
                            targetItem.SubItems[1].Text = draglistViewItem.Text;
                            if (draglistViewItem.Tag is ItemData dragItemData &&
                                targetItem.Tag is ItemData dropItemData)
                            {
                                dropItemData.Tag = dragItemData.Tag;
                                Debug.WriteLine("%%% DragDrop completed!!");
                            }
                        }
                    }
                }
            }
        }

        private void listViewDnDTeams_DragEnter(object sender, DragEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (e.Data != null)
                {
                    if (e.Data.GetDataPresent(typeof(ListViewItem)))
                    {
                        e.Effect = e.AllowedEffect;
                    }
                }
            }
        }

        private void listViewDnDTeams_DragOver(object sender, DragEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (e.Data != null)
                {
                    if (e.Data.GetDataPresent(typeof(ListViewItem)))
                    {
                        ListViewItem? targetItem =
                            getListViewItemFromDraggingPoint(listView, new Point(e.X, e.Y));
                        if (targetItem != null)
                        {
                            targetItem.Selected = true;
                        }
                    }
                }

                // マウスポインターのクライアント座標を取得する。
                Point targetPoint =
                    listView.PointToClient(new Point(e.X, e.Y));

                // マウスポインターに最も近いアイテムのインデックスを取得する。
                ListViewHitTestInfo hitTestInfo = listView.HitTest(targetPoint);
                if (hitTestInfo == null || hitTestInfo.Item == null)
                {
                    return;
                }
                int targetIndex = hitTestInfo.Item.Index;

                var item = hitTestInfo.Item;
                var index = item.Index; int maxIndex = listView.Items.Count;
                int scrollZoneHeight = listView.Font.Height;

                if (index > 0 && targetPoint.Y < scrollZoneHeight)
                {
                    listView.Items[index - 1].EnsureVisible();
                }
                else if (index + 1 < maxIndex && targetPoint.Y > listView.Height - scrollZoneHeight)
                {
                    listView.Items[index + 1].EnsureVisible();
                }
            }
        }

        #endregion

        #endregion
    }
}
