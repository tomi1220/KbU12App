namespace PbaU12Tools.ControlEx
{
    partial class LotteryResultCtrl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            panelDirectInput = new Panel();
            listViewDiTeams = new ListView();
            columnLotteryNumber = new ColumnHeader();
            columnTeamName = new ColumnHeader();
            panelDnDTeam = new Panel();
            tableLayoutPanelLottery = new TableLayoutPanel();
            panel4 = new Panel();
            listViewDndLotteryNumber = new ListView();
            columnDnDLotteryNumber = new ColumnHeader();
            labelLotteryNumber = new Label();
            panel2 = new Panel();
            listViewDnDTeams = new ListView();
            columnDnDTeam = new ColumnHeader();
            columnDnDLotteryResult = new ColumnHeader();
            panelButton = new Panel();
            buttonReset = new Button();
            buttonSet = new Button();
            panel1 = new Panel();
            label1 = new Label();
            comboBoxInputMode = new ComboBox();
            panelDirectInput.SuspendLayout();
            panelDnDTeam.SuspendLayout();
            tableLayoutPanelLottery.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panelButton.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDirectInput
            // 
            panelDirectInput.BackColor = Color.Transparent;
            panelDirectInput.Controls.Add(listViewDiTeams);
            panelDirectInput.Location = new Point(287, 126);
            panelDirectInput.Name = "panelDirectInput";
            panelDirectInput.Padding = new Padding(6);
            panelDirectInput.Size = new Size(200, 325);
            panelDirectInput.TabIndex = 3;
            // 
            // listViewDiTeams
            // 
            listViewDiTeams.Columns.AddRange(new ColumnHeader[] { columnLotteryNumber, columnTeamName });
            listViewDiTeams.Dock = DockStyle.Fill;
            listViewDiTeams.FullRowSelect = true;
            listViewDiTeams.GridLines = true;
            listViewDiTeams.LabelEdit = true;
            listViewDiTeams.Location = new Point(6, 6);
            listViewDiTeams.Name = "listViewDiTeams";
            listViewDiTeams.Size = new Size(188, 313);
            listViewDiTeams.TabIndex = 1;
            listViewDiTeams.UseCompatibleStateImageBehavior = false;
            listViewDiTeams.View = View.Details;
            // 
            // columnLotteryNumber
            // 
            columnLotteryNumber.Text = "抽選番号";
            // 
            // columnTeamName
            // 
            columnTeamName.Text = "チーム名";
            // 
            // panelDnDTeam
            // 
            panelDnDTeam.BackColor = Color.Transparent;
            panelDnDTeam.Controls.Add(tableLayoutPanelLottery);
            panelDnDTeam.Location = new Point(65, 48);
            panelDnDTeam.Name = "panelDnDTeam";
            panelDnDTeam.Size = new Size(380, 390);
            panelDnDTeam.TabIndex = 4;
            // 
            // tableLayoutPanelLottery
            // 
            tableLayoutPanelLottery.ColumnCount = 3;
            tableLayoutPanelLottery.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelLottery.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanelLottery.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelLottery.Controls.Add(panel4, 2, 0);
            tableLayoutPanelLottery.Controls.Add(panel2, 0, 0);
            tableLayoutPanelLottery.Controls.Add(panelButton, 1, 0);
            tableLayoutPanelLottery.Dock = DockStyle.Fill;
            tableLayoutPanelLottery.Location = new Point(0, 0);
            tableLayoutPanelLottery.Name = "tableLayoutPanelLottery";
            tableLayoutPanelLottery.RowCount = 1;
            tableLayoutPanelLottery.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLottery.Size = new Size(380, 390);
            tableLayoutPanelLottery.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(listViewDndLotteryNumber);
            panel4.Controls.Add(labelLotteryNumber);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(281, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(6);
            panel4.Size = new Size(96, 384);
            panel4.TabIndex = 2;
            // 
            // listViewDndLotteryNumber
            // 
            listViewDndLotteryNumber.Columns.AddRange(new ColumnHeader[] { columnDnDLotteryNumber });
            listViewDndLotteryNumber.Dock = DockStyle.Fill;
            listViewDndLotteryNumber.FullRowSelect = true;
            listViewDndLotteryNumber.GridLines = true;
            listViewDndLotteryNumber.Location = new Point(6, 49);
            listViewDndLotteryNumber.MultiSelect = false;
            listViewDndLotteryNumber.Name = "listViewDndLotteryNumber";
            listViewDndLotteryNumber.Size = new Size(84, 329);
            listViewDndLotteryNumber.TabIndex = 0;
            listViewDndLotteryNumber.UseCompatibleStateImageBehavior = false;
            listViewDndLotteryNumber.View = View.Details;
            listViewDndLotteryNumber.ItemDrag += listViewDndLotteryNumber_ItemDrag;
            listViewDndLotteryNumber.ItemSelectionChanged += listViewDndLotteryNumber_ItemSelectionChanged;
            // 
            // columnDnDLotteryNumber
            // 
            columnDnDLotteryNumber.Text = "抽選番号";
            // 
            // labelLotteryNumber
            // 
            labelLotteryNumber.BackColor = SystemColors.Control;
            labelLotteryNumber.BorderStyle = BorderStyle.FixedSingle;
            labelLotteryNumber.Dock = DockStyle.Top;
            labelLotteryNumber.Font = new Font("Meiryo UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelLotteryNumber.Location = new Point(6, 6);
            labelLotteryNumber.Name = "labelLotteryNumber";
            labelLotteryNumber.Size = new Size(84, 43);
            labelLotteryNumber.TabIndex = 2;
            labelLotteryNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewDnDTeams);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(229, 384);
            panel2.TabIndex = 0;
            // 
            // listViewDnDTeams
            // 
            listViewDnDTeams.Activation = ItemActivation.OneClick;
            listViewDnDTeams.AllowDrop = true;
            listViewDnDTeams.Columns.AddRange(new ColumnHeader[] { columnDnDTeam, columnDnDLotteryResult });
            listViewDnDTeams.Dock = DockStyle.Fill;
            listViewDnDTeams.FullRowSelect = true;
            listViewDnDTeams.GridLines = true;
            listViewDnDTeams.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewDnDTeams.Location = new Point(6, 6);
            listViewDnDTeams.MultiSelect = false;
            listViewDnDTeams.Name = "listViewDnDTeams";
            listViewDnDTeams.Size = new Size(217, 372);
            listViewDnDTeams.TabIndex = 0;
            listViewDnDTeams.UseCompatibleStateImageBehavior = false;
            listViewDnDTeams.View = View.Details;
            listViewDnDTeams.DragDrop += listViewDnDTeams_DragDrop;
            listViewDnDTeams.DragEnter += listViewDnDTeams_DragEnter;
            listViewDnDTeams.DragOver += listViewDnDTeams_DragOver;
            listViewDnDTeams.DoubleClick += listViewDnDTeamsBoys_DoubleClick;
            // 
            // columnDnDTeam
            // 
            columnDnDTeam.Text = "チーム名";
            columnDnDTeam.Width = 140;
            // 
            // columnDnDLotteryResult
            // 
            columnDnDLotteryResult.Text = "抽選番号";
            columnDnDLotteryResult.TextAlign = HorizontalAlignment.Center;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(buttonReset);
            panelButton.Controls.Add(buttonSet);
            panelButton.Dock = DockStyle.Fill;
            panelButton.Location = new Point(238, 3);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(37, 384);
            panelButton.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(3, 35);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(31, 23);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "&>";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(3, 6);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(31, 23);
            buttonSet.TabIndex = 0;
            buttonSet.Text = "&<";
            buttonSet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxInputMode);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 29);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "入力モード(&I):";
            // 
            // comboBoxInputMode
            // 
            comboBoxInputMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInputMode.FormattingEnabled = true;
            comboBoxInputMode.Location = new Point(91, 4);
            comboBoxInputMode.Name = "comboBoxInputMode";
            comboBoxInputMode.Size = new Size(122, 23);
            comboBoxInputMode.TabIndex = 1;
            comboBoxInputMode.SelectedIndexChanged += comboBoxInputMode_SelectedIndexChanged;
            // 
            // LotteryResultCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelDnDTeam);
            Controls.Add(panelDirectInput);
            Controls.Add(panel1);
            Name = "LotteryResultCtrl";
            Size = new Size(511, 486);
            panelDirectInput.ResumeLayout(false);
            panelDnDTeam.ResumeLayout(false);
            tableLayoutPanelLottery.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelButton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDirectInput;
        private ListView listViewDiTeams;
        private ColumnHeader columnLotteryNumber;
        private ColumnHeader columnTeamName;
        private Panel panelDnDTeam;
        private TableLayoutPanel tableLayoutPanelLottery;
        private Panel panel4;
        private ListView listViewDndLotteryNumber;
        private ColumnHeader columnDnDLotteryNumber;
        private Label labelLotteryNumber;
        private Panel panel2;
        private ListView listViewDnDTeams;
        private ColumnHeader columnDnDTeam;
        private ColumnHeader columnDnDLotteryResult;
        private Panel panelButton;
        private Button buttonReset;
        private Button buttonSet;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxInputMode;
    }
}
