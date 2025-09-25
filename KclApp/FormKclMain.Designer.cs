namespace KclApp
{
    partial class FormKclMain
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
            panelName = new Panel();
            textBoxTournamentName = new TextBox();
            buttonTournamentName = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            checkBoxGirls = new CheckBox();
            groupBox1 = new GroupBox();
            numericUpDownNumberOfTeamsGirls = new NumericUpDown();
            label2 = new Label();
            panelBoys = new Panel();
            checkBoxBoys = new CheckBox();
            groupBoxBoys = new GroupBox();
            numericUpDownNumberOfTeamsBoys = new NumericUpDown();
            label1 = new Label();
            panelOptions = new Panel();
            checkBoxOpen = new CheckBox();
            panelSchedule = new Panel();
            groupBoxVenue = new GroupBox();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewVenue = new ListView();
            columnTargetDate = new ColumnHeader();
            columnVenue = new ColumnHeader();
            columnCourt = new ColumnHeader();
            panelBottom = new Panel();
            buttonBuild = new Button();
            buttonBrowseFolder = new Button();
            textBoxOutputFilePath = new TextBox();
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
            panelName.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsGirls).BeginInit();
            panelBoys.SuspendLayout();
            groupBoxBoys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsBoys).BeginInit();
            panelOptions.SuspendLayout();
            panelSchedule.SuspendLayout();
            groupBoxVenue.SuspendLayout();
            panelBottom.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelName
            // 
            panelName.Controls.Add(textBoxTournamentName);
            panelName.Controls.Add(buttonTournamentName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 24);
            panelName.Name = "panelName";
            panelName.Size = new Size(650, 37);
            panelName.TabIndex = 1;
            // 
            // textBoxTournamentName
            // 
            textBoxTournamentName.Location = new Point(123, 8);
            textBoxTournamentName.Name = "textBoxTournamentName";
            textBoxTournamentName.ReadOnly = true;
            textBoxTournamentName.Size = new Size(515, 23);
            textBoxTournamentName.TabIndex = 1;
            // 
            // buttonTournamentName
            // 
            buttonTournamentName.Location = new Point(12, 7);
            buttonTournamentName.Name = "buttonTournamentName";
            buttonTournamentName.Size = new Size(105, 23);
            buttonTournamentName.TabIndex = 0;
            buttonTournamentName.Text = "大会名称(&N)...";
            buttonTournamentName.UseVisualStyleBackColor = true;
            buttonTournamentName.Click += buttonTournamentName_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panelBoys, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(650, 88);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxGirls);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(328, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 82);
            panel1.TabIndex = 1;
            // 
            // checkBoxGirls
            // 
            checkBoxGirls.Location = new Point(12, 2);
            checkBoxGirls.Name = "checkBoxGirls";
            checkBoxGirls.Size = new Size(88, 27);
            checkBoxGirls.TabIndex = 0;
            checkBoxGirls.Text = "女子(&G)";
            checkBoxGirls.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBoxGirls.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numericUpDownNumberOfTeamsGirls);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 73);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // numericUpDownNumberOfTeamsGirls
            // 
            numericUpDownNumberOfTeamsGirls.Location = new Point(112, 24);
            numericUpDownNumberOfTeamsGirls.Name = "numericUpDownNumberOfTeamsGirls";
            numericUpDownNumberOfTeamsGirls.Size = new Size(46, 23);
            numericUpDownNumberOfTeamsGirls.TabIndex = 1;
            numericUpDownNumberOfTeamsGirls.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "出場チーム数(&1):";
            // 
            // panelBoys
            // 
            panelBoys.Controls.Add(checkBoxBoys);
            panelBoys.Controls.Add(groupBoxBoys);
            panelBoys.Dock = DockStyle.Fill;
            panelBoys.Location = new Point(3, 3);
            panelBoys.Name = "panelBoys";
            panelBoys.Size = new Size(319, 82);
            panelBoys.TabIndex = 0;
            // 
            // checkBoxBoys
            // 
            checkBoxBoys.Location = new Point(12, 2);
            checkBoxBoys.Name = "checkBoxBoys";
            checkBoxBoys.Size = new Size(88, 27);
            checkBoxBoys.TabIndex = 0;
            checkBoxBoys.Text = "男子(&B)";
            checkBoxBoys.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBoxBoys.UseVisualStyleBackColor = true;
            // 
            // groupBoxBoys
            // 
            groupBoxBoys.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBoys.Controls.Add(numericUpDownNumberOfTeamsBoys);
            groupBoxBoys.Controls.Add(label1);
            groupBoxBoys.Location = new Point(0, 6);
            groupBoxBoys.Name = "groupBoxBoys";
            groupBoxBoys.Size = new Size(316, 73);
            groupBoxBoys.TabIndex = 1;
            groupBoxBoys.TabStop = false;
            // 
            // numericUpDownNumberOfTeamsBoys
            // 
            numericUpDownNumberOfTeamsBoys.Location = new Point(112, 24);
            numericUpDownNumberOfTeamsBoys.Name = "numericUpDownNumberOfTeamsBoys";
            numericUpDownNumberOfTeamsBoys.Size = new Size(46, 23);
            numericUpDownNumberOfTeamsBoys.TabIndex = 1;
            numericUpDownNumberOfTeamsBoys.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "出場チーム数(&1):";
            // 
            // panelOptions
            // 
            panelOptions.Controls.Add(checkBoxOpen);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 149);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(650, 52);
            panelOptions.TabIndex = 3;
            // 
            // checkBoxOpen
            // 
            checkBoxOpen.AutoSize = true;
            checkBoxOpen.Checked = true;
            checkBoxOpen.CheckState = CheckState.Checked;
            checkBoxOpen.Location = new Point(12, 6);
            checkBoxOpen.Name = "checkBoxOpen";
            checkBoxOpen.Size = new Size(206, 19);
            checkBoxOpen.TabIndex = 0;
            checkBoxOpen.Text = "TO/オープン参加等表示枠を作る(&O)";
            checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // panelSchedule
            // 
            panelSchedule.Controls.Add(groupBoxVenue);
            panelSchedule.Dock = DockStyle.Fill;
            panelSchedule.Location = new Point(0, 201);
            panelSchedule.Name = "panelSchedule";
            panelSchedule.Size = new Size(650, 169);
            panelSchedule.TabIndex = 4;
            // 
            // groupBoxVenue
            // 
            groupBoxVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxVenue.Controls.Add(buttonDeleteVenue);
            groupBoxVenue.Controls.Add(buttonEditVenue);
            groupBoxVenue.Controls.Add(buttonAddVenue);
            groupBoxVenue.Controls.Add(listViewVenue);
            groupBoxVenue.Location = new Point(3, 6);
            groupBoxVenue.Name = "groupBoxVenue";
            groupBoxVenue.Size = new Size(641, 157);
            groupBoxVenue.TabIndex = 0;
            groupBoxVenue.TabStop = false;
            groupBoxVenue.Text = "会場情報(&V):";
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(586, 88);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 3;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(586, 55);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 2;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(586, 22);
            buttonAddVenue.Name = "buttonAddVenue";
            buttonAddVenue.Size = new Size(49, 27);
            buttonAddVenue.TabIndex = 1;
            buttonAddVenue.UseVisualStyleBackColor = true;
            buttonAddVenue.Click += buttonAddVenue_Click;
            // 
            // listViewVenue
            // 
            listViewVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVenue.Columns.AddRange(new ColumnHeader[] { columnTargetDate, columnVenue, columnCourt });
            listViewVenue.Location = new Point(6, 22);
            listViewVenue.Name = "listViewVenue";
            listViewVenue.Size = new Size(574, 129);
            listViewVenue.TabIndex = 0;
            listViewVenue.UseCompatibleStateImageBehavior = false;
            listViewVenue.View = View.Details;
            // 
            // columnTargetDate
            // 
            columnTargetDate.Text = "対象日";
            columnTargetDate.Width = 119;
            // 
            // columnVenue
            // 
            columnVenue.Text = "会場";
            columnVenue.Width = 231;
            // 
            // columnCourt
            // 
            columnCourt.Text = "コート";
            columnCourt.Width = 200;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonBuild);
            panelBottom.Controls.Add(buttonBrowseFolder);
            panelBottom.Controls.Add(textBoxOutputFilePath);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 370);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(650, 100);
            panelBottom.TabIndex = 5;
            // 
            // buttonBuild
            // 
            buttonBuild.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuild.Location = new Point(12, 65);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(626, 23);
            buttonBuild.TabIndex = 2;
            buttonBuild.Text = "トーナメント表作成";
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += buttonBuild_Click;
            // 
            // buttonBrowseFolder
            // 
            buttonBrowseFolder.Location = new Point(9, 9);
            buttonBrowseFolder.Name = "buttonBrowseFolder";
            buttonBrowseFolder.Size = new Size(75, 27);
            buttonBrowseFolder.TabIndex = 0;
            buttonBrowseFolder.Text = "出力先(&F)";
            buttonBrowseFolder.UseVisualStyleBackColor = true;
            buttonBrowseFolder.Click += buttonBrowseFolder_Click;
            // 
            // textBoxOutputFilePath
            // 
            textBoxOutputFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutputFilePath.Location = new Point(90, 12);
            textBoxOutputFilePath.Name = "textBoxOutputFilePath";
            textBoxOutputFilePath.Size = new Size(548, 23);
            textBoxOutputFilePath.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, toolStripMenuItemSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(650, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemOpen, toolStripSeparator1, toolStripMenuItemSave, toolStripMenuItemSaveAs, toolStripSeparator2, toolStripMenuItemExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(186, 22);
            toolStripMenuItemNew.Text = "新規作成(&N)";
            toolStripMenuItemNew.Click += toolStripMenuItemNew_Click;
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.Size = new Size(186, 22);
            toolStripMenuItemOpen.Text = "開く(&O)";
            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(183, 6);
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.Size = new Size(186, 22);
            toolStripMenuItemSave.Text = "保存(&S)...";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // toolStripMenuItemSaveAs
            // 
            toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            toolStripMenuItemSaveAs.Size = new Size(186, 22);
            toolStripMenuItemSaveAs.Text = "名前を付けて保存(&A)...";
            toolStripMenuItemSaveAs.Click += toolStripMenuItemSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(186, 22);
            toolStripMenuItemExit.Text = "終了(X)";
            toolStripMenuItemExit.Click += toolStripMenuItemExit_Click;
            // 
            // toolStripMenuItemSettings
            // 
            toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            toolStripMenuItemSettings.Size = new Size(66, 20);
            toolStripMenuItemSettings.Text = "設定(&S)...";
            toolStripMenuItemSettings.Click += toolStripMenuItemSettings_Click;
            // 
            // FormKclMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 470);
            Controls.Add(panelSchedule);
            Controls.Add(panelOptions);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelName);
            Controls.Add(panelBottom);
            Controls.Add(menuStrip1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            MainMenuStrip = menuStrip1;
            Name = "FormKclMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KCL App";
            Load += FormKclMain_Load;
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsGirls).EndInit();
            panelBoys.ResumeLayout(false);
            groupBoxBoys.ResumeLayout(false);
            groupBoxBoys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsBoys).EndInit();
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panelSchedule.ResumeLayout(false);
            groupBoxVenue.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelBoys;
        private CheckBox checkBoxBoys;
        private GroupBox groupBoxBoys;
        private NumericUpDown numericUpDownNumberOfTeamsBoys;
        private Label label1;
        private Panel panel1;
        private CheckBox checkBoxGirls;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownNumberOfTeamsGirls;
        private Label label2;
        private TextBox textBoxTournamentName;
        private Button buttonTournamentName;
        private Panel panelOptions;
        private CheckBox checkBoxOpen;
        private Panel panelSchedule;
        private Panel panelBottom;
        private GroupBox groupBoxVenue;
        private ListView listViewVenue;
        private ColumnHeader columnTargetDate;
        private ColumnHeader columnVenue;
        private ColumnHeader columnCourt;
        private Button buttonAddVenue;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonBrowseFolder;
        private TextBox textBoxOutputFilePath;
        private Button buttonBuild;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemSettings;
    }
}
