using PbaU12Tools.Bracket;
using PbaU12Tools.TournamentData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PbaU12Tools.ControlEx
{
    public partial class LotteryResultCtrl : UserControl
    {
        #region Enum
        private enum InputMode
        {
            DragDrop,
            DirectInput
        }
        #endregion

        #region ローカル・クラス
        private class LotteryData
        {
            public int LotteryNumber { get; set; }
            public int SeedNumber { get; set; }
        }
        private class LotteryResultData
        {
            public TeamData? TeamData { get; set; } = null;
            public LotteryData? LotteryData { get; set; }
        }
        #endregion

        #region コンストラクタ
        public LotteryResultCtrl()
        {
            InitializeComponent();

            panelDirectInput.Dock = DockStyle.Fill;
            panelDnDTeam.Dock = DockStyle.Fill;
            panelDirectInput.Visible = false;
            panelDnDTeam.Visible = true;

            InitializeControls();
        }
        #endregion

        #region プロパティ
        public TournamentData.TourneyData? TournamentData { private get; set; } = null;
        public TournenyBaseData? TournamentBaseData { private get; set; } = null;
        private Categories _category = Categories.Unknown;
        public Categories Category
        {
            get { return _category; }
            set
            {
                if (value != _category)
                {
                    _category = value;
                }
            }
        }
        private TeamDatas? _teamDatas = null;
        public TeamDatas? TeamDatas
        {
            set
            {
                if (value != _teamDatas)
                {
                    _teamDatas = value;
                    addAllTeamDatas(listViewDnDTeams, _teamDatas!);
                }
            }
        }
        private BracketGenData? _bracketGenData = null;
        public BracketGenData? BracketGenData
        {
            set
            {
                if (value != _bracketGenData)
                {
                    _bracketGenData = value;
                    preparingListViewForLottery(_bracketGenData);
                }
            }
        }
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

        private void preparingListViewForLottery(BracketGenData? bracketGenData)
        {
            listViewDndLotteryNumber.Items.Clear();
            if (bracketGenData != null)
            {
                for (int i = 1; i <= bracketGenData.NumberOfTeams; i++)
                {
                    listViewDndLotteryNumber.Items.Add(
                        new ListViewItem()
                        {
                            Name = i.ToString(),
                            Text = i.ToString(),
                            Tag = new LotteryData()
                            {
                                LotteryNumber = i,
                                SeedNumber = bracketGenData.PureSeedArray![i - 1]
                            }
                        });
                }
                columnDnDLotteryNumber.Width = -2;
            }
        }

        private void addAllTeamDatas(ListView listView, TeamDatas teamDatas)
        {
            listViewDnDTeams.Items.Clear();
            if (teamDatas != null)
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
                                Tag = new LotteryResultData()
                                {
                                    TeamData = team,
                                }
                            };
                        listViewItem.SubItems.Add(string.Empty);
                        listView.Items.Add(listViewItem);
                    }
                }
                listView.Columns[1].Width = -2;
            }
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

        private void InsertLotteryNumber(Categories category, LotteryResultData? lotteryResultData)
        {
            int index = -1;
            foreach (ListViewItem item in listViewDndLotteryNumber.Items)
            {
                if (item.Tag is LotteryData lotteryData)
                {
                    if (lotteryData.LotteryNumber > lotteryResultData!.LotteryData!.LotteryNumber)
                    {
                        index = item.Index;
                        break;
                    }
                }
            }
            ListViewItem listViewItem =
                new ListViewItem()
                {
                    Text = lotteryResultData!.LotteryData!.LotteryNumber.ToString(),
                    Tag = new LotteryData()
                    {
                        LotteryNumber = lotteryResultData.LotteryData!.LotteryNumber,
                        SeedNumber = lotteryResultData.LotteryData!.SeedNumber
                    }
                };
            ListViewItem visibleItem;
            if (index != -1)
            {
                visibleItem = listViewDndLotteryNumber.Items.Insert(index, listViewItem);
            }
            else
            {
                visibleItem = listViewDndLotteryNumber.Items.Add(listViewItem);
            }
            visibleItem.Selected = true;
            listViewDndLotteryNumber.EnsureVisible(visibleItem.Index);
        }

        #endregion

        #region イベント・ハンドラ

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
                        panelDnDTeam.Visible = false;
                        panelDirectInput.Visible = true;
                    }
                    else if ((InputMode)itemData.Tag! == InputMode.DragDrop)
                    {
                        panelDirectInput.Visible = false;
                        panelDnDTeam.Visible = true;
                    }
                }
            }
        }
        #endregion

        #region 抽選番号ListView
        private void listViewDndLotteryNumber_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (listViewDndLotteryNumber.SelectedItems.Count == 1)
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
                labelLotteryNumber.Text = e.Item.Text;
            }
            else
            {
                labelLotteryNumber.Text = string.Empty;
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
                            if (draglistViewItem.Tag is LotteryData lotteryData &&
                                targetItem.Tag is LotteryResultData lotteryResultData)
                            {
                                lotteryResultData.LotteryData = lotteryData;
                                Debug.WriteLine("%%% DragDrop completed!!");

                                draglistViewItem.ListView!.Items.Remove(draglistViewItem);
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

        private void listViewDnDTeamsBoys_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.SelectedItems.Count == 1)
                {
                    InsertLotteryNumber(
                        (Categories)listView.Tag!,
                        listView.SelectedItems[0].Tag as LotteryResultData);

                    listView.SelectedItems[0].SubItems[1].Text = string.Empty;
                    listView.SelectedItems[0].SubItems[1].Tag = null;
                }
            }
        }

        #endregion

        #endregion
    }
}
