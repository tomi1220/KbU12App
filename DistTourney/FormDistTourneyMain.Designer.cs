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
            toolStripMenuItemOpenInExplorer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItemExit = new ToolStripMenuItem();
            toolStripMenuItemSettings = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripMenuItemBracketOutput = new ToolStripMenuItem();
            panelAll = new Panel();
            panelName = new Panel();
            labelTournamentName = new Label();
            panel1 = new Panel();
            buttonTournamentName = new Button();
            toolTip1 = new ToolTip(components);
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelBaseData = new TableLayoutPanel();
            tableLayoutPanelGen = new TableLayoutPanel();
            panelBaseData = new Panel();
            buttonBasedata = new Button();
            richTextBoxBaseDataContents = new RichTextBox();
            panelLottery = new Panel();
            buttonLottery = new Button();
            labelDrop = new Label();
            tableLayoutPanelScore = new TableLayoutPanel();
            buttonScore = new Button();
            menuStrip1.SuspendLayout();
            panelAll.SuspendLayout();
            panelName.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelBaseData.SuspendLayout();
            tableLayoutPanelGen.SuspendLayout();
            panelBaseData.SuspendLayout();
            panelLottery.SuspendLayout();
            tableLayoutPanelScore.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, toolStripMenuItemSettings, toolStripTextBox1, toolStripMenuItemBracketOutput });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(617, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemOpen, toolStripSeparator1, toolStripMenuItemSave, toolStripMenuItemSaveAs, toolStripSeparator2, toolStripMenuItemOpenInExplorer, toolStripSeparator3, toolStripMenuItemExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 27);
            ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(253, 26);
            toolStripMenuItemNew.Text = "新規作成(&N)...";
            toolStripMenuItemNew.Click += toolStripMenuItemNew_Click;
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.Size = new Size(253, 26);
            toolStripMenuItemOpen.Text = "開く(&O)...";
            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(250, 6);
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.Size = new Size(253, 26);
            toolStripMenuItemSave.Text = "保存(&S)...";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // toolStripMenuItemSaveAs
            // 
            toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            toolStripMenuItemSaveAs.Size = new Size(253, 26);
            toolStripMenuItemSaveAs.Text = "名前を付けて保存(&A)...";
            toolStripMenuItemSaveAs.Click += toolStripMenuItemSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(250, 6);
            // 
            // toolStripMenuItemOpenInExplorer
            // 
            toolStripMenuItemOpenInExplorer.Name = "toolStripMenuItemOpenInExplorer";
            toolStripMenuItemOpenInExplorer.Size = new Size(253, 26);
            toolStripMenuItemOpenInExplorer.Text = "保存先フォルダーを開く(&E)...";
            toolStripMenuItemOpenInExplorer.Click += toolStripMenuItemOpenInExplorer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(250, 6);
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(253, 26);
            toolStripMenuItemExit.Text = "終了(X)";
            toolStripMenuItemExit.Click += toolStripMenuItemExit_Click;
            // 
            // toolStripMenuItemSettings
            // 
            toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            toolStripMenuItemSettings.Size = new Size(80, 27);
            toolStripMenuItemSettings.Text = "設定(&S)...";
            toolStripMenuItemSettings.Click += toolStripMenuItemSettings_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // toolStripMenuItemBracketOutput
            // 
            toolStripMenuItemBracketOutput.Name = "toolStripMenuItemBracketOutput";
            toolStripMenuItemBracketOutput.Size = new Size(161, 27);
            toolStripMenuItemBracketOutput.Text = "トーナメント表出力(&O)...";
            toolStripMenuItemBracketOutput.Click += toolStripMenuItemBracketOutput_Click;
            // 
            // panelAll
            // 
            panelAll.Controls.Add(tableLayoutPanelMain);
            panelAll.Controls.Add(panelName);
            panelAll.Dock = DockStyle.Fill;
            panelAll.Enabled = false;
            panelAll.Location = new Point(0, 31);
            panelAll.Name = "panelAll";
            panelAll.Size = new Size(617, 383);
            panelAll.TabIndex = 1;
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
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelBaseData, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelGen, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelScore, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 55);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.Size = new Size(617, 328);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanelBaseData
            // 
            tableLayoutPanelBaseData.ColumnCount = 2;
            tableLayoutPanelBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelBaseData.Controls.Add(panelBaseData, 0, 0);
            tableLayoutPanelBaseData.Controls.Add(richTextBoxBaseDataContents, 1, 0);
            tableLayoutPanelBaseData.Dock = DockStyle.Fill;
            tableLayoutPanelBaseData.Location = new Point(3, 3);
            tableLayoutPanelBaseData.Name = "tableLayoutPanelBaseData";
            tableLayoutPanelBaseData.RowCount = 1;
            tableLayoutPanelBaseData.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBaseData.Size = new Size(611, 108);
            tableLayoutPanelBaseData.TabIndex = 0;
            // 
            // tableLayoutPanelGen
            // 
            tableLayoutPanelGen.ColumnCount = 2;
            tableLayoutPanelGen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelGen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelGen.Controls.Add(panelLottery, 0, 0);
            tableLayoutPanelGen.Controls.Add(labelDrop, 1, 0);
            tableLayoutPanelGen.Dock = DockStyle.Fill;
            tableLayoutPanelGen.Location = new Point(3, 117);
            tableLayoutPanelGen.Name = "tableLayoutPanelGen";
            tableLayoutPanelGen.RowCount = 1;
            tableLayoutPanelGen.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelGen.Size = new Size(611, 108);
            tableLayoutPanelGen.TabIndex = 1;
            // 
            // panelBaseData
            // 
            panelBaseData.Controls.Add(buttonBasedata);
            panelBaseData.Dock = DockStyle.Fill;
            panelBaseData.Location = new Point(3, 3);
            panelBaseData.Name = "panelBaseData";
            panelBaseData.Size = new Size(146, 102);
            panelBaseData.TabIndex = 0;
            // 
            // buttonBasedata
            // 
            buttonBasedata.AutoSize = true;
            buttonBasedata.Dock = DockStyle.Fill;
            buttonBasedata.Font = new Font("Meiryo UI", 9F);
            buttonBasedata.Location = new Point(0, 0);
            buttonBasedata.Name = "buttonBasedata";
            buttonBasedata.Size = new Size(146, 102);
            buttonBasedata.TabIndex = 2;
            buttonBasedata.Text = "基本情報(&B)...";
            buttonBasedata.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBaseDataContents
            // 
            richTextBoxBaseDataContents.BackColor = SystemColors.Window;
            richTextBoxBaseDataContents.BorderStyle = BorderStyle.None;
            richTextBoxBaseDataContents.Dock = DockStyle.Fill;
            richTextBoxBaseDataContents.Location = new Point(155, 3);
            richTextBoxBaseDataContents.Name = "richTextBoxBaseDataContents";
            richTextBoxBaseDataContents.ReadOnly = true;
            richTextBoxBaseDataContents.Size = new Size(453, 102);
            richTextBoxBaseDataContents.TabIndex = 1;
            richTextBoxBaseDataContents.Text = "";
            // 
            // panelLottery
            // 
            panelLottery.Controls.Add(buttonLottery);
            panelLottery.Dock = DockStyle.Fill;
            panelLottery.Location = new Point(3, 3);
            panelLottery.Name = "panelLottery";
            panelLottery.Size = new Size(146, 102);
            panelLottery.TabIndex = 0;
            // 
            // buttonLottery
            // 
            buttonLottery.Dock = DockStyle.Fill;
            buttonLottery.Location = new Point(0, 0);
            buttonLottery.Name = "buttonLottery";
            buttonLottery.Size = new Size(146, 102);
            buttonLottery.TabIndex = 0;
            buttonLottery.Text = "抽選結果(&L)...";
            buttonLottery.UseVisualStyleBackColor = true;
            // 
            // labelDrop
            // 
            labelDrop.Dock = DockStyle.Fill;
            labelDrop.ForeColor = Color.Gray;
            labelDrop.Location = new Point(155, 0);
            labelDrop.Name = "labelDrop";
            labelDrop.Padding = new Padding(50, 0, 50, 0);
            labelDrop.Size = new Size(453, 108);
            labelDrop.TabIndex = 1;
            labelDrop.Text = "ここに、会場・試合順の設定が完了した\r\nExcelファイルをドロップしてください";
            labelDrop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelScore
            // 
            tableLayoutPanelScore.ColumnCount = 2;
            tableLayoutPanelScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelScore.Controls.Add(buttonScore, 0, 0);
            tableLayoutPanelScore.Dock = DockStyle.Fill;
            tableLayoutPanelScore.Location = new Point(3, 231);
            tableLayoutPanelScore.Name = "tableLayoutPanelScore";
            tableLayoutPanelScore.RowCount = 1;
            tableLayoutPanelScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelScore.Size = new Size(611, 94);
            tableLayoutPanelScore.TabIndex = 2;
            // 
            // buttonScore
            // 
            buttonScore.Dock = DockStyle.Fill;
            buttonScore.Location = new Point(3, 3);
            buttonScore.Name = "buttonScore";
            buttonScore.Size = new Size(146, 88);
            buttonScore.TabIndex = 0;
            buttonScore.Text = "スコア入力(&S)...";
            buttonScore.UseVisualStyleBackColor = true;
            // 
            // FormDistTourneyMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 414);
            Controls.Add(panelAll);
            Controls.Add(menuStrip1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            MinimumSize = new Size(570, 450);
            Name = "FormDistTourneyMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DistTourney";
            Load += FormDistMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAll.ResumeLayout(false);
            panelName.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelBaseData.ResumeLayout(false);
            tableLayoutPanelGen.ResumeLayout(false);
            panelBaseData.ResumeLayout(false);
            panelBaseData.PerformLayout();
            panelLottery.ResumeLayout(false);
            tableLayoutPanelScore.ResumeLayout(false);
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
        private Button buttonTournamentName;
        private Panel panel1;
        private ToolTip toolTip1;
        private ToolStripMenuItem toolStripMenuItemOpenInExplorer;
        private ToolStripSeparator toolStripSeparator3;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelBaseData;
        private TableLayoutPanel tableLayoutPanelGen;
        private Panel panelBaseData;
        private Button buttonBasedata;
        private RichTextBox richTextBoxBaseDataContents;
        private Panel panelLottery;
        private Button buttonLottery;
        private Label labelDrop;
        private TableLayoutPanel tableLayoutPanelScore;
        private Button buttonScore;
    }
}
