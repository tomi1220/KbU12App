namespace DistTourney
{
    partial class FormDistTourneyMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemNew = new ToolStripMenuItem();
            toolStripMenuItemOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemSave = new ToolStripMenuItem();
            toolStripMenuItemSaveAs = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemExit = new ToolStripMenuItem();
            toolStripMenuItemSettings = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripMenuItemBracketOutput = new ToolStripMenuItem();
            panelAll = new Panel();
            tabControlMain = new TabControl();
            tabPageTournamentBaseData = new TabPage();
            panelTournamentBaseData = new Panel();
            panelVenue = new Panel();
            groupBoxVenue = new GroupBox();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewVenue = new ListView();
            columnTargetDate = new ColumnHeader();
            columnVenue = new ColumnHeader();
            columnCourt = new ColumnHeader();
            tableLayoutPanelTournamentBaseData = new TableLayoutPanel();
            numOfTeamsCtrlGirls = new PbaU12Tools.ControlEx.NumOfTeamsCtrl();
            numOfTeamsCtrlBoys = new PbaU12Tools.ControlEx.NumOfTeamsCtrl();
            tabPageBracketData = new TabPage();
            tabPageScore = new TabPage();
            panelName = new Panel();
            labelTournamentName = new Label();
            panel1 = new Panel();
            buttonTournamentName = new Button();
            toolTip1 = new ToolTip(components);
            toolStripMenuItemOpenInExplorer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            panelAll.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageTournamentBaseData.SuspendLayout();
            panelTournamentBaseData.SuspendLayout();
            panelVenue.SuspendLayout();
            groupBoxVenue.SuspendLayout();
            tableLayoutPanelTournamentBaseData.SuspendLayout();
            panelName.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, toolStripMenuItemSettings, toolStripTextBox1, toolStripMenuItemBracketOutput });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(617, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemOpen, toolStripSeparator1, toolStripMenuItemSave, toolStripMenuItemSaveAs, toolStripSeparator2, toolStripMenuItemOpenInExplorer, toolStripSeparator3, toolStripMenuItemExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 23);
            ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(204, 22);
            toolStripMenuItemNew.Text = "新規作成(&N)...";
            toolStripMenuItemNew.Click += toolStripMenuItemNew_Click;
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.Size = new Size(204, 22);
            toolStripMenuItemOpen.Text = "開く(&O)...";
            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(201, 6);
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.Size = new Size(204, 22);
            toolStripMenuItemSave.Text = "保存(&S)...";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // toolStripMenuItemSaveAs
            // 
            toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            toolStripMenuItemSaveAs.Size = new Size(204, 22);
            toolStripMenuItemSaveAs.Text = "名前を付けて保存(&A)...";
            toolStripMenuItemSaveAs.Click += toolStripMenuItemSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(201, 6);
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(204, 22);
            toolStripMenuItemExit.Text = "終了(X)";
            toolStripMenuItemExit.Click += toolStripMenuItemExit_Click;
            // 
            // toolStripMenuItemSettings
            // 
            toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            toolStripMenuItemSettings.Size = new Size(66, 23);
            toolStripMenuItemSettings.Text = "設定(&S)...";
            toolStripMenuItemSettings.Click += toolStripMenuItemSettings_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // toolStripMenuItemBracketOutput
            // 
            toolStripMenuItemBracketOutput.Name = "toolStripMenuItemBracketOutput";
            toolStripMenuItemBracketOutput.Size = new Size(131, 23);
            toolStripMenuItemBracketOutput.Text = "トーナメント表出力(&O)...";
            toolStripMenuItemBracketOutput.Click += toolStripMenuItemBracketOutput_Click;
            // 
            // panelAll
            // 
            panelAll.Controls.Add(tabControlMain);
            panelAll.Controls.Add(panelName);
            panelAll.Dock = DockStyle.Fill;
            panelAll.Enabled = false;
            panelAll.Location = new Point(0, 27);
            panelAll.Name = "panelAll";
            panelAll.Size = new Size(617, 387);
            panelAll.TabIndex = 1;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageTournamentBaseData);
            tabControlMain.Controls.Add(tabPageBracketData);
            tabControlMain.Controls.Add(tabPageScore);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 55);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(617, 332);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageTournamentBaseData
            // 
            tabPageTournamentBaseData.Controls.Add(panelTournamentBaseData);
            tabPageTournamentBaseData.Location = new Point(4, 24);
            tabPageTournamentBaseData.Name = "tabPageTournamentBaseData";
            tabPageTournamentBaseData.Padding = new Padding(3);
            tabPageTournamentBaseData.Size = new Size(609, 304);
            tabPageTournamentBaseData.TabIndex = 0;
            tabPageTournamentBaseData.Text = "大会基本情報";
            tabPageTournamentBaseData.UseVisualStyleBackColor = true;
            // 
            // panelTournamentBaseData
            // 
            panelTournamentBaseData.Controls.Add(panelVenue);
            panelTournamentBaseData.Controls.Add(tableLayoutPanelTournamentBaseData);
            panelTournamentBaseData.Dock = DockStyle.Fill;
            panelTournamentBaseData.Location = new Point(3, 3);
            panelTournamentBaseData.Name = "panelTournamentBaseData";
            panelTournamentBaseData.Size = new Size(603, 298);
            panelTournamentBaseData.TabIndex = 0;
            // 
            // panelVenue
            // 
            panelVenue.Controls.Add(groupBoxVenue);
            panelVenue.Dock = DockStyle.Fill;
            panelVenue.Location = new Point(0, 138);
            panelVenue.Name = "panelVenue";
            panelVenue.Size = new Size(603, 160);
            panelVenue.TabIndex = 5;
            // 
            // groupBoxVenue
            // 
            groupBoxVenue.Controls.Add(buttonDeleteVenue);
            groupBoxVenue.Controls.Add(buttonEditVenue);
            groupBoxVenue.Controls.Add(buttonAddVenue);
            groupBoxVenue.Controls.Add(listViewVenue);
            groupBoxVenue.Dock = DockStyle.Fill;
            groupBoxVenue.Location = new Point(0, 0);
            groupBoxVenue.Name = "groupBoxVenue";
            groupBoxVenue.Size = new Size(603, 160);
            groupBoxVenue.TabIndex = 5;
            groupBoxVenue.TabStop = false;
            groupBoxVenue.Text = "会場情報(&V):";
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(539, 88);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 3;
            toolTip1.SetToolTip(buttonDeleteVenue, "日程・会場の削除");
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(539, 55);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 2;
            toolTip1.SetToolTip(buttonEditVenue, "日程・会場の編集");
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(539, 22);
            buttonAddVenue.Name = "buttonAddVenue";
            buttonAddVenue.Size = new Size(49, 27);
            buttonAddVenue.TabIndex = 1;
            toolTip1.SetToolTip(buttonAddVenue, "日程・会場の追加");
            buttonAddVenue.UseVisualStyleBackColor = true;
            buttonAddVenue.Click += buttonAddVenue_Click;
            // 
            // listViewVenue
            // 
            listViewVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVenue.Columns.AddRange(new ColumnHeader[] { columnTargetDate, columnVenue, columnCourt });
            listViewVenue.Location = new Point(11, 22);
            listViewVenue.Name = "listViewVenue";
            listViewVenue.Size = new Size(515, 129);
            listViewVenue.TabIndex = 0;
            listViewVenue.UseCompatibleStateImageBehavior = false;
            listViewVenue.View = View.Details;
            // 
            // columnTargetDate
            // 
            columnTargetDate.Text = "対象日";
            columnTargetDate.Width = 100;
            // 
            // columnVenue
            // 
            columnVenue.Text = "会場";
            columnVenue.Width = 250;
            // 
            // columnCourt
            // 
            columnCourt.Text = "コート";
            columnCourt.Width = 150;
            // 
            // tableLayoutPanelTournamentBaseData
            // 
            tableLayoutPanelTournamentBaseData.ColumnCount = 2;
            tableLayoutPanelTournamentBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.Controls.Add(numOfTeamsCtrlGirls, 1, 0);
            tableLayoutPanelTournamentBaseData.Controls.Add(numOfTeamsCtrlBoys, 0, 0);
            tableLayoutPanelTournamentBaseData.Dock = DockStyle.Top;
            tableLayoutPanelTournamentBaseData.Location = new Point(0, 0);
            tableLayoutPanelTournamentBaseData.Name = "tableLayoutPanelTournamentBaseData";
            tableLayoutPanelTournamentBaseData.RowCount = 1;
            tableLayoutPanelTournamentBaseData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.Size = new Size(603, 138);
            tableLayoutPanelTournamentBaseData.TabIndex = 3;
            // 
            // numOfTeamsCtrlGirls
            // 
            numOfTeamsCtrlGirls.Category = PbaU12Tools.Categories.Girls;
            numOfTeamsCtrlGirls.CategoryValidity = false;
            numOfTeamsCtrlGirls.Dock = DockStyle.Fill;
            numOfTeamsCtrlGirls.FinalLeage = false;
            numOfTeamsCtrlGirls.Location = new Point(304, 3);
            numOfTeamsCtrlGirls.MinimumSize = new Size(270, 127);
            numOfTeamsCtrlGirls.Name = "numOfTeamsCtrlGirls";
            numOfTeamsCtrlGirls.NumberOfSuperSeeds = 0;
            numOfTeamsCtrlGirls.NumberOfTeams = 0;
            numOfTeamsCtrlGirls.Padding = new Padding(6, 0, 6, 6);
            numOfTeamsCtrlGirls.Size = new Size(296, 132);
            numOfTeamsCtrlGirls.TabIndex = 1;
            numOfTeamsCtrlGirls.UseFinalLeage = false;
            numOfTeamsCtrlGirls.UseSuperSeeds = false;
            // 
            // numOfTeamsCtrlBoys
            // 
            numOfTeamsCtrlBoys.Category = PbaU12Tools.Categories.Boys;
            numOfTeamsCtrlBoys.CategoryValidity = false;
            numOfTeamsCtrlBoys.Dock = DockStyle.Fill;
            numOfTeamsCtrlBoys.FinalLeage = false;
            numOfTeamsCtrlBoys.Location = new Point(3, 3);
            numOfTeamsCtrlBoys.MinimumSize = new Size(270, 127);
            numOfTeamsCtrlBoys.Name = "numOfTeamsCtrlBoys";
            numOfTeamsCtrlBoys.NumberOfSuperSeeds = 0;
            numOfTeamsCtrlBoys.NumberOfTeams = 0;
            numOfTeamsCtrlBoys.Padding = new Padding(6, 0, 6, 6);
            numOfTeamsCtrlBoys.Size = new Size(295, 132);
            numOfTeamsCtrlBoys.TabIndex = 0;
            numOfTeamsCtrlBoys.UseFinalLeage = false;
            numOfTeamsCtrlBoys.UseSuperSeeds = false;
            // 
            // tabPageBracketData
            // 
            tabPageBracketData.Location = new Point(4, 24);
            tabPageBracketData.Name = "tabPageBracketData";
            tabPageBracketData.Padding = new Padding(3);
            tabPageBracketData.Size = new Size(609, 304);
            tabPageBracketData.TabIndex = 1;
            tabPageBracketData.Text = "組合せ情報";
            tabPageBracketData.UseVisualStyleBackColor = true;
            // 
            // tabPageScore
            // 
            tabPageScore.Location = new Point(4, 24);
            tabPageScore.Name = "tabPageScore";
            tabPageScore.Size = new Size(609, 304);
            tabPageScore.TabIndex = 2;
            tabPageScore.Text = "スコア管理";
            tabPageScore.UseVisualStyleBackColor = true;
            // 
            // panelName
            // 
            panelName.Controls.Add(labelTournamentName);
            panelName.Controls.Add(panel1);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(617, 55);
            panelName.TabIndex = 0;
            // 
            // labelTournamentName
            // 
            labelTournamentName.Dock = DockStyle.Fill;
            labelTournamentName.Font = new Font("Meiryo UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelTournamentName.Location = new Point(120, 0);
            labelTournamentName.Name = "labelTournamentName";
            labelTournamentName.Size = new Size(497, 55);
            labelTournamentName.TabIndex = 2;
            labelTournamentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTournamentName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 2;
            // 
            // buttonTournamentName
            // 
            buttonTournamentName.AutoSize = true;
            buttonTournamentName.Dock = DockStyle.Fill;
            buttonTournamentName.Font = new Font("Meiryo UI", 9F);
            buttonTournamentName.Location = new Point(6, 6);
            buttonTournamentName.Name = "buttonTournamentName";
            buttonTournamentName.Size = new Size(108, 43);
            buttonTournamentName.TabIndex = 1;
            buttonTournamentName.Text = "大会名(&N)...";
            buttonTournamentName.UseVisualStyleBackColor = true;
            buttonTournamentName.Click += buttonTournamentName_Click;
            // 
            // toolStripMenuItemOpenInExplorer
            // 
            toolStripMenuItemOpenInExplorer.Name = "toolStripMenuItemOpenInExplorer";
            toolStripMenuItemOpenInExplorer.Size = new Size(204, 22);
            toolStripMenuItemOpenInExplorer.Text = "保存先フォルダーを開く(&E)...";
            toolStripMenuItemOpenInExplorer.Click += toolStripMenuItemOpenInExplorer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(201, 6);
            // 
            // FormDistMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 414);
            Controls.Add(panelAll);
            Controls.Add(menuStrip1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            MinimumSize = new Size(570, 450);
            Name = "FormDistMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DistTourney";
            Load += FormDistMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAll.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageTournamentBaseData.ResumeLayout(false);
            panelTournamentBaseData.ResumeLayout(false);
            panelVenue.ResumeLayout(false);
            groupBoxVenue.ResumeLayout(false);
            tableLayoutPanelTournamentBaseData.ResumeLayout(false);
            panelName.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripMenuItem toolStripMenuItemSettings;
        private Panel panelAll;
        private Panel panelName;
        private ToolStripTextBox toolStripTextBox1;
        private Label labelTournamentName;
        private ToolStripMenuItem toolStripMenuItemBracketOutput;
        private TabControl tabControlMain;
        private TabPage tabPageTournamentBaseData;
        private TabPage tabPageBracketData;
        private TabPage tabPageScore;
        private Panel panelTournamentBaseData;
        private Button buttonTournamentName;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelTournamentBaseData;
        private PbaU12Tools.ControlEx.NumOfTeamsCtrl numOfTeamsCtrlGirls;
        private PbaU12Tools.ControlEx.NumOfTeamsCtrl numOfTeamsCtrlBoys;
        private Panel panelVenue;
        private GroupBox groupBoxVenue;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ListView listViewVenue;
        private ColumnHeader columnTargetDate;
        private ColumnHeader columnVenue;
        private ColumnHeader columnCourt;
        private ToolTip toolTip1;
        private ToolStripMenuItem toolStripMenuItemOpenInExplorer;
        private ToolStripSeparator toolStripSeparator3;
    }
}
