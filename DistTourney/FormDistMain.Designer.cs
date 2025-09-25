namespace DistTourney
{
    partial class FormDistMain
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
            panelAll = new Panel();
            panelVenue = new Panel();
            groupBoxVenue = new GroupBox();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewVenue = new ListView();
            columnTargetDate = new ColumnHeader();
            columnVenue = new ColumnHeader();
            columnCourt = new ColumnHeader();
            panelOptions = new Panel();
            panelName = new Panel();
            labelTournamentName = new Label();
            トーナメント表出力OToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelAll.SuspendLayout();
            panelVenue.SuspendLayout();
            groupBoxVenue.SuspendLayout();
            panelName.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, toolStripMenuItemSettings, toolStripTextBox1, トーナメント表出力OToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(650, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemOpen, toolStripSeparator1, toolStripMenuItemSave, toolStripMenuItemSaveAs, toolStripSeparator2, toolStripMenuItemExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 23);
            ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(186, 22);
            toolStripMenuItemNew.Text = "新規作成(&N)...";
            toolStripMenuItemNew.Click += toolStripMenuItemNew_Click;
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.Size = new Size(186, 22);
            toolStripMenuItemOpen.Text = "開く(&O)...";
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
            // panelAll
            // 
            panelAll.Controls.Add(panelVenue);
            panelAll.Controls.Add(panelOptions);
            panelAll.Controls.Add(panelName);
            panelAll.Dock = DockStyle.Fill;
            panelAll.Enabled = false;
            panelAll.Location = new Point(0, 27);
            panelAll.Name = "panelAll";
            panelAll.Size = new Size(650, 443);
            panelAll.TabIndex = 1;
            // 
            // panelVenue
            // 
            panelVenue.Controls.Add(groupBoxVenue);
            panelVenue.Dock = DockStyle.Fill;
            panelVenue.Location = new Point(0, 95);
            panelVenue.Name = "panelVenue";
            panelVenue.Size = new Size(650, 348);
            panelVenue.TabIndex = 3;
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
            groupBoxVenue.Size = new Size(650, 348);
            groupBoxVenue.TabIndex = 5;
            groupBoxVenue.TabStop = false;
            groupBoxVenue.Text = "会場情報(&V):";
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(595, 88);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 3;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(595, 55);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 2;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(593, 22);
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
            listViewVenue.Size = new Size(578, 320);
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
            // panelOptions
            // 
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 43);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(650, 52);
            panelOptions.TabIndex = 2;
            // 
            // panelName
            // 
            panelName.Controls.Add(labelTournamentName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(650, 43);
            panelName.TabIndex = 0;
            // 
            // labelTournamentName
            // 
            labelTournamentName.Dock = DockStyle.Fill;
            labelTournamentName.Font = new Font("Meiryo UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelTournamentName.Location = new Point(0, 0);
            labelTournamentName.Name = "labelTournamentName";
            labelTournamentName.Size = new Size(650, 43);
            labelTournamentName.TabIndex = 2;
            labelTournamentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // トーナメント表出力OToolStripMenuItem
            // 
            トーナメント表出力OToolStripMenuItem.Name = "トーナメント表出力OToolStripMenuItem";
            トーナメント表出力OToolStripMenuItem.Size = new Size(131, 23);
            トーナメント表出力OToolStripMenuItem.Text = "トーナメント表出力(&O)...";
            // 
            // FormDistMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 470);
            Controls.Add(panelAll);
            Controls.Add(menuStrip1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "FormDistMain";
            Text = "DistTourney";
            Load += FormDistMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAll.ResumeLayout(false);
            panelVenue.ResumeLayout(false);
            groupBoxVenue.ResumeLayout(false);
            panelName.ResumeLayout(false);
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
        private Panel panelOptions;
        private GroupBox groupBoxVenue;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ListView listViewVenue;
        private ColumnHeader columnTargetDate;
        private ColumnHeader columnVenue;
        private ColumnHeader columnCourt;
        private Panel panelVenue;
        private ToolStripTextBox toolStripTextBox1;
        private Label labelTournamentName;
        private ToolStripMenuItem トーナメント表出力OToolStripMenuItem;
    }
}
