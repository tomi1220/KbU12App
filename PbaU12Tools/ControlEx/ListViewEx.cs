using System.ComponentModel;
using System.Diagnostics;

namespace PbaU12Tools
{
    public class ListViewEx : ListView
    {
        #region 定数・Enum
        /// <summary>
        /// 項目の移動方向（ListView等、手動で並び替えを行なう場合に使用）
        /// </summary>
        public enum ItemMovementDirection
        {
            ItemUp = 1,
            ItemDown = 2
        }
        #endregion

        #region フィールド
        private IContainer? components = null;
        #endregion

        #region コンストラクタ
        public ListViewEx()
        {
            this.AllowDrag = true;

            InitializeComponent();

            this.ListViewItemSorter = new ListViewIndexComparer();
        }
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ListViewEx
            // 
            this.AllowDrop = true;
            this.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewEx_ItemDrag);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewEx_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewEx_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewEx_DragOver);
            this.DragLeave += new System.EventHandler(this.listViewEx_DragLeave);
            this.ResumeLayout(false);

        }

        #region プロパティ
        /// <summary>
        /// 並び替えの有無を取得します。
        /// </summary>
        [Description("項目の並び替えが行われたかどうかを取得します。")]
        [Browsable(false)]  // プロパティウィンドウ非表示
        public bool OrderChanged { get; set; }

        [Browsable(false)]                              // プロパティウィンドウ非表示
        [EditorBrowsable(EditorBrowsableState.Never)]   // インテリセンス非表示
        public new bool AllowDrop
        {
            get { return base.AllowDrop; }
            set { base.AllowDrop = value; }
        }


        // ドラッグ後のアイテムにNameの値を引きつづ
        [Browsable(false)]                              // プロパティウィンドウ非表示
        [EditorBrowsable(EditorBrowsableState.Never)]   // インテリセンス非表示
        public bool PassNameToDragddItem { get; set; } = false;

        /// <summary>
        /// 並び替えのドラッグを許可するかどうかを取得します。
        /// </summary>
        [Description("並び替えのドラッグを許可するかどうかを取得します。")]
        [Browsable(false)]                              // プロパティウィンドウ非表示
        public bool AllowDrag { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// 選択状態の項目を移動します。
        /// </summary>
        /// <remarks>ViewがDetailsで、選択項目が1個の場合のみ有効。</remarks>
        /// <param name="direction">移動する方向</param>
        /// <returns>移動後のインデックス</returns>
        public int MoveSelectedItem(ItemMovementDirection direction)
        {
            int index = -1;
            if (this.View == View.Details)
            {
                if (this.SelectedItems.Count == 1)
                {
                    if (this.SelectedItems[0].Clone() is ListViewItem targetItem)
                    {
                        switch (direction)
                        {
                            case ItemMovementDirection.ItemUp:
                                {
                                    if (this.SelectedItems[0].Index > 0)
                                    {
                                        this.BeginUpdate();
                                        this.Items.Insert(
                                            this.SelectedItems[0].Index - 1, targetItem);
                                        this.SelectedItems[0].Remove();
                                        targetItem.Selected = true;
                                        this.EndUpdate();

                                        index = this.SelectedItems[0].Index;
                                    }
                                }
                                break;
                            case ItemMovementDirection.ItemDown:
                                {
                                    if (this.SelectedItems[0].Index < this.Items.Count - 1)
                                    {
                                        this.BeginUpdate();
                                        this.Items.Insert(
                                            this.SelectedItems[0].Index + 1, targetItem);
                                        this.SelectedItems[0].Remove();
                                        targetItem.Selected = true;
                                        this.EndUpdate();

                                        index = this.SelectedItems[0].Index;
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            return index;
        }

        #endregion

        #region ローカル・メソッド
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object? x, object? y)
            {
                return ((ListViewItem)x!).Index - ((ListViewItem)y!).Index;
            }
        }

        #endregion

        #region イベント
        /// <summary>
        /// D&Dで並び替えが行われたことを通知します。
        /// </summary>
        [Description("D&Dで並び替えが行われたことを通知します。")]
        public event EventHandler? DragDropSorted = null;
        protected void OnDragDropSorted(EventArgs e)
        {
            DragDropSorted?.Invoke(this, e);
        }

        /// <summary>
        /// 並び替え以外の目的でドラッグを始めたと判断された場合に通知します。
        /// </summary>
        [Description("並び替え以外の目的でドラッグを始めたと判断された場合に通知します。")]
        public event ItemDragAnotherEventHandler? ItemDragAnother = null;
        protected void OnItemDragAnother(ItemDragAnotherEventArgs e)
        {
            ItemDragAnother?.Invoke(this, e);
        }
        public class ItemDragAnotherEventArgs(ItemDragEventArgs e)
        {
            /// <summary>
            /// ItemDragイベントのデータ
            /// </summary>
            public ItemDragEventArgs ItemDragEventArgs { get; set; } = e!;
            //public List<ListViewItem> SelectedItems { get; set; }
            /// <summary>
            /// 選択されたListViewItemの配列
            /// </summary>
            public ListViewItem[]? SelectedItems { get; set; }
            /// <summary>
            /// 処理されたListViewItemの配列
            /// </summary>
            public List<ListViewItem> ProcessedItems { get; set; } = [];
            /// <summary>
            /// Drag元のListView
            /// </summary>
            public ListView? ListView { get; set; }
        }
        public delegate void ItemDragAnotherEventHandler(object? sender, ItemDragAnotherEventArgs e);

        /// <summary>
        /// 他のコントロールからのドラッグ アンド ドロップ操作が完了したことを通知します。
        /// </summary>
        [Description("他のコントロールからのD&D操作が完了したことを通知します。")]
        public event DragEventHandler? DragDropAnother = null;
        protected void OnDragDropAnother(DragEventArgs e)
        {
            DragDropAnother?.Invoke(this, e);
        }
        /// <summary>
        /// 他のコントロールのオブジェクトがコントロールの境界を超えてドラッグされることを通知します。
        /// </summary>
        [Description("他のコントロールのオブジェクトがコントロールの境界を超えてドラッグされることを通知します。")]
        public event DragEventHandler? DragOverAnother = null;
        protected void OnDragOverAnother(DragEventArgs e)
        {
            DragOverAnother?.Invoke(this, e);
        }
        #endregion

        #region イベント・ハンドラ

        private void listViewEx_ItemDrag(object? sender, ItemDragEventArgs e)
        {
            if (AllowDrag && SelectedItems.Count == 1)
            {
                if (e.Item is ListViewItem item)
                {
                    Debug.WriteLine("ListViewEx_ItemDrag ListView = " +
                        (item.ListView != null ? item.ListView.Name : "null"));
                    this.DoDragDrop(e.Item, DragDropEffects.Move);
                }
            }
            else
            {
                // 並び替え以外の操作
                ItemDragAnotherEventArgs args =
                    new(e)
                    {
                        ListView = this,
                        SelectedItems = new ListViewItem[SelectedItems.Count]
                    };
                SelectedItems.CopyTo(args.SelectedItems, 0);
                OnItemDragAnother(args);
                // ↑2021.03.15
            }
        }

        private void listViewEx_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data!.GetData(typeof(ListViewItem)) is ListViewItem draggedItem)
            {
                if (draggedItem != null)
                {
                    e.Effect = e.AllowedEffect;
                }
                else
                {
                    if (e.Data!.GetData(typeof(ItemDragAnotherEventArgs)) is ItemDragAnotherEventArgs args)
                    {
                        e.Effect = args.ItemDragEventArgs.Item is ListViewItem _ ? e.AllowedEffect : DragDropEffects.None;
                    }
                }
            }
        }

        private void listViewEx_DragOver(object? sender, DragEventArgs e)
        {
            // ドラッグされたアイテムを回収
            if (e.Data!.GetData(typeof(ListViewItem)) is ListViewItem draggedItem)
            {

                if (draggedItem == null)
                {
                    OnDragOverAnother(e);
                    return;
                }

                if (draggedItem.ListView != this)
                {
                    OnDragOverAnother(e);
                    return;
                }

                // マウスポインターのクライアント座標を取得する。
                Point targetPoint =
                    this.PointToClient(new Point(e.X, e.Y));

                // マウスポインターに最も近いアイテムのインデックスを取得する。
                int targetIndex = this.InsertionMark.NearestIndex(targetPoint);
                //Debug.WriteLine("***** targetIndex = " + targetIndex.ToString());

                var item = this.GetItemAt(targetPoint.X, targetPoint.Y);
                if (item == null)
                {
                    return;
                }
                var index = item.Index; int maxIndex = this.Items.Count;
                int scrollZoneHeight = this.Font.Height;

                if (index > 0 && targetPoint.Y < scrollZoneHeight)
                {
                    this.Items[index - 1].EnsureVisible();
                }
                else if (index < maxIndex && targetPoint.Y > this.Height - scrollZoneHeight)
                {
                    this.Items[index + 1].EnsureVisible();
                }

                //ListViewItem draggedItem =
                //	(ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // マウスポインターがドラッグされたアイテム上にないことを確認する。
                if (targetIndex > -1)
                {
                    // マウスポインターが最も近いアイテムの中点の左または右にあるかどうかを判断し、
                    // それに応じてertionMark.AppearsAfterItemプロパティを設定する。
                    Rectangle itemBounds = this.GetItemRect(targetIndex);
                    if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                    {
                        this.InsertionMark.AppearsAfterItem = true;
                    }
                    else
                    {
                        this.InsertionMark.AppearsAfterItem = false;
                        if (targetIndex == draggedItem.Index + 1)
                        {
                            targetIndex = -1;
                        }
                    }
                }

                // 挿入マークの位置を決める。
                // マウスが引かれたアイテムの上にいるならば、targetIndexは-1
                this.InsertionMark.Index = targetIndex;
            }
        }

        private void listViewEx_DragLeave(object? sender, EventArgs e)
        {
            this.InsertionMark.Index = -1;
        }

        private void listViewEx_DragDrop(object? sender, DragEventArgs e)
        {
            // ドラッグされたアイテムを回収
            if (e.Data!.GetData(typeof(ListViewItem)) is ListViewItem draggedItem)
            {
                if (draggedItem == null)
                {
                    OnDragDropAnother(e);
                    return;
                }

                if (draggedItem.ListView != this)
                {
                    OnDragDropAnother(e);
                    return;
                }

                // 挿入マークのインデックスを検索
                int targetIndex = this.InsertionMark.Index;
                if (targetIndex == -1)
                {
                    return;
                }

                // 挿入マークが対応するインデックスでアイテムの右側にあるならば、
                // 目標インデックスを増加させる
                if (this.InsertionMark.AppearsAfterItem)
                {
                    targetIndex++;
                }

                //// ドラッグされたアイテムを回収
                //ListViewItem draggedItem =
                //	(ListViewItem)e.Data.GetData(typeof(ListViewItem));


                // ドラッグされたアイテムを挿入マークの位置へ挿入
                this.Items.Insert(
                    targetIndex, (ListViewItem)draggedItem.Clone());
                if (PassNameToDragddItem)
                {
                    this.Items[targetIndex].Name = draggedItem.Name;
                }

                // ドラッグ元のアイテムを削除
                this.Items.Remove(draggedItem);

                this.OrderChanged = true;

                OnDragDropSorted(new EventArgs());
            }
        }

        #endregion
    }
}
