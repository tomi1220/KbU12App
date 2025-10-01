namespace PbaU12Tools.Settings
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPageDataSaveFolders = new TabPage();
            listView1 = new ListView();
            columnFolderTitle = new ColumnHeader();
            columnFolderPath = new ColumnHeader();
            buttonBrowseBaseDataFolder = new Button();
            textBoxBaseDataFolder = new TextBox();
            tabPageTournamentNames = new TabPage();
            buttonDeleteTournamentName = new Button();
            buttonSaveTournamentNameData = new Button();
            buttonEditTournamentName = new Button();
            buttonAddTournamentName = new Button();
            listViewTournamentNames = new ListView();
            columnTournamentName = new ColumnHeader();
            columnTournamentFixedNumOfTeams = new ColumnHeader();
            imageListTournamentNames = new ImageList(components);
            tabPageVenues = new TabPage();
            buttonExportVenue = new Button();
            buttonImportVenue = new Button();
            buttonSaveVenue = new Button();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewVenueDatas = new ListView();
            columnVenueName = new ColumnHeader();
            columnCourts = new ColumnHeader();
            imageListVenueListView = new ImageList(components);
            tabPageTeamRegistration = new TabPage();
            tabControlTeamRagistration = new TabControl();
            tabPageBoysTeamList = new TabPage();
            dataGridViewBoysTeamList = new DataGridView();
            ColumnJbaTeamID = new DataGridViewTextBoxColumn();
            ColumnTeamName = new DataGridViewTextBoxColumn();
            ColumnTeamNameKana = new DataGridViewTextBoxColumn();
            ColumnTeamNameShort = new DataGridViewTextBoxColumn();
            ColumnJbaTeamRegistrationStatus = new DataGridViewTextBoxColumn();
            tabPageGirlsTeamList = new TabPage();
            dataGridViewGirlsTeamList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            imageListTeamRegistration = new ImageList(components);
            tabPageOtherOption = new TabPage();
            checkBox1 = new CheckBox();
            buttonClose = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPageDataSaveFolders.SuspendLayout();
            tabPageTournamentNames.SuspendLayout();
            tabPageVenues.SuspendLayout();
            tabPageTeamRegistration.SuspendLayout();
            tabControlTeamRagistration.SuspendLayout();
            tabPageBoysTeamList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoysTeamList).BeginInit();
            tabPageGirlsTeamList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGirlsTeamList).BeginInit();
            tabPageOtherOption.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDataSaveFolders);
            tabControl1.Controls.Add(tabPageTournamentNames);
            tabControl1.Controls.Add(tabPageVenues);
            tabControl1.Controls.Add(tabPageTeamRegistration);
            tabControl1.Controls.Add(tabPageOtherOption);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(581, 379);
            tabControl1.TabIndex = 0;
            // 
            // tabPageDataSaveFolders
            // 
            tabPageDataSaveFolders.Controls.Add(listView1);
            tabPageDataSaveFolders.Controls.Add(buttonBrowseBaseDataFolder);
            tabPageDataSaveFolders.Controls.Add(textBoxBaseDataFolder);
            tabPageDataSaveFolders.Location = new Point(4, 24);
            tabPageDataSaveFolders.Name = "tabPageDataSaveFolders";
            tabPageDataSaveFolders.Padding = new Padding(3);
            tabPageDataSaveFolders.Size = new Size(573, 351);
            tabPageDataSaveFolders.TabIndex = 0;
            tabPageDataSaveFolders.Text = "保存先";
            tabPageDataSaveFolders.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnFolderTitle, columnFolderPath });
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(22, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(487, 200);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnFolderTitle
            // 
            columnFolderTitle.Text = "フォルダー";
            // 
            // columnFolderPath
            // 
            columnFolderPath.Text = "パス";
            // 
            // buttonBrowseBaseDataFolder
            // 
            buttonBrowseBaseDataFolder.Location = new Point(6, 6);
            buttonBrowseBaseDataFolder.Name = "buttonBrowseBaseDataFolder";
            buttonBrowseBaseDataFolder.Size = new Size(130, 23);
            buttonBrowseBaseDataFolder.TabIndex = 0;
            buttonBrowseBaseDataFolder.Text = "基準となるフォルダー(&B)";
            buttonBrowseBaseDataFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxBaseDataFolder
            // 
            textBoxBaseDataFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBaseDataFolder.Location = new Point(22, 35);
            textBoxBaseDataFolder.Name = "textBoxBaseDataFolder";
            textBoxBaseDataFolder.Size = new Size(487, 23);
            textBoxBaseDataFolder.TabIndex = 1;
            // 
            // tabPageTournamentNames
            // 
            tabPageTournamentNames.Controls.Add(buttonDeleteTournamentName);
            tabPageTournamentNames.Controls.Add(buttonSaveTournamentNameData);
            tabPageTournamentNames.Controls.Add(buttonEditTournamentName);
            tabPageTournamentNames.Controls.Add(buttonAddTournamentName);
            tabPageTournamentNames.Controls.Add(listViewTournamentNames);
            tabPageTournamentNames.Location = new Point(4, 24);
            tabPageTournamentNames.Name = "tabPageTournamentNames";
            tabPageTournamentNames.Padding = new Padding(3);
            tabPageTournamentNames.Size = new Size(573, 351);
            tabPageTournamentNames.TabIndex = 1;
            tabPageTournamentNames.Text = "大会";
            tabPageTournamentNames.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTournamentName
            // 
            buttonDeleteTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteTournamentName.Location = new Point(502, 83);
            buttonDeleteTournamentName.Name = "buttonDeleteTournamentName";
            buttonDeleteTournamentName.Size = new Size(49, 27);
            buttonDeleteTournamentName.TabIndex = 9;
            buttonDeleteTournamentName.UseVisualStyleBackColor = true;
            buttonDeleteTournamentName.Click += buttonDeleteTournamentName_Click;
            // 
            // buttonSaveTournamentNameData
            // 
            buttonSaveTournamentNameData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveTournamentNameData.Location = new Point(502, 313);
            buttonSaveTournamentNameData.Name = "buttonSaveTournamentNameData";
            buttonSaveTournamentNameData.Size = new Size(49, 23);
            buttonSaveTournamentNameData.TabIndex = 1;
            buttonSaveTournamentNameData.UseVisualStyleBackColor = true;
            buttonSaveTournamentNameData.Click += buttonSaveTournamentNameData_Click;
            // 
            // buttonEditTournamentName
            // 
            buttonEditTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditTournamentName.Location = new Point(502, 50);
            buttonEditTournamentName.Name = "buttonEditTournamentName";
            buttonEditTournamentName.Size = new Size(49, 27);
            buttonEditTournamentName.TabIndex = 8;
            buttonEditTournamentName.UseVisualStyleBackColor = true;
            buttonEditTournamentName.Click += buttonEditTournamentName_Click;
            // 
            // buttonAddTournamentName
            // 
            buttonAddTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddTournamentName.Location = new Point(502, 17);
            buttonAddTournamentName.Name = "buttonAddTournamentName";
            buttonAddTournamentName.Size = new Size(49, 27);
            buttonAddTournamentName.TabIndex = 7;
            buttonAddTournamentName.UseVisualStyleBackColor = true;
            buttonAddTournamentName.Click += buttonAddTournamentName_Click;
            // 
            // listViewTournamentNames
            // 
            listViewTournamentNames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTournamentNames.Columns.AddRange(new ColumnHeader[] { columnTournamentName, columnTournamentFixedNumOfTeams });
            listViewTournamentNames.FullRowSelect = true;
            listViewTournamentNames.LabelEdit = true;
            listViewTournamentNames.Location = new Point(9, 17);
            listViewTournamentNames.Name = "listViewTournamentNames";
            listViewTournamentNames.Size = new Size(479, 319);
            listViewTournamentNames.SmallImageList = imageListTournamentNames;
            listViewTournamentNames.TabIndex = 0;
            listViewTournamentNames.UseCompatibleStateImageBehavior = false;
            listViewTournamentNames.View = View.Details;
            // 
            // columnTournamentName
            // 
            columnTournamentName.Text = "大会名";
            columnTournamentName.Width = 342;
            // 
            // columnTournamentFixedNumOfTeams
            // 
            columnTournamentFixedNumOfTeams.Text = "チーム数";
            // 
            // imageListTournamentNames
            // 
            imageListTournamentNames.ColorDepth = ColorDepth.Depth32Bit;
            imageListTournamentNames.ImageSize = new Size(16, 16);
            imageListTournamentNames.TransparentColor = Color.Transparent;
            // 
            // tabPageVenues
            // 
            tabPageVenues.Controls.Add(buttonExportVenue);
            tabPageVenues.Controls.Add(buttonImportVenue);
            tabPageVenues.Controls.Add(buttonSaveVenue);
            tabPageVenues.Controls.Add(buttonDeleteVenue);
            tabPageVenues.Controls.Add(buttonEditVenue);
            tabPageVenues.Controls.Add(buttonAddVenue);
            tabPageVenues.Controls.Add(listViewVenueDatas);
            tabPageVenues.Location = new Point(4, 24);
            tabPageVenues.Name = "tabPageVenues";
            tabPageVenues.Padding = new Padding(3);
            tabPageVenues.Size = new Size(573, 351);
            tabPageVenues.TabIndex = 2;
            tabPageVenues.Text = "会場";
            tabPageVenues.UseVisualStyleBackColor = true;
            // 
            // buttonExportVenue
            // 
            buttonExportVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportVenue.Location = new Point(502, 174);
            buttonExportVenue.Name = "buttonExportVenue";
            buttonExportVenue.Size = new Size(49, 23);
            buttonExportVenue.TabIndex = 9;
            toolTip1.SetToolTip(buttonExportVenue, "会場データのエクスポート");
            buttonExportVenue.UseVisualStyleBackColor = true;
            buttonExportVenue.Click += buttonExportVenue_Click;
            // 
            // buttonImportVenue
            // 
            buttonImportVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonImportVenue.Location = new Point(502, 145);
            buttonImportVenue.Name = "buttonImportVenue";
            buttonImportVenue.Size = new Size(49, 23);
            buttonImportVenue.TabIndex = 8;
            toolTip1.SetToolTip(buttonImportVenue, "会場データのインポート");
            buttonImportVenue.UseVisualStyleBackColor = true;
            buttonImportVenue.Click += buttonImportVenue_Click;
            // 
            // buttonSaveVenue
            // 
            buttonSaveVenue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveVenue.Location = new Point(502, 313);
            buttonSaveVenue.Name = "buttonSaveVenue";
            buttonSaveVenue.Size = new Size(49, 23);
            buttonSaveVenue.TabIndex = 7;
            buttonSaveVenue.UseVisualStyleBackColor = true;
            buttonSaveVenue.Click += buttonSaveVenue_Click;
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(502, 83);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 6;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(502, 50);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 5;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(502, 17);
            buttonAddVenue.Name = "buttonAddVenue";
            buttonAddVenue.Size = new Size(49, 27);
            buttonAddVenue.TabIndex = 4;
            buttonAddVenue.UseVisualStyleBackColor = true;
            buttonAddVenue.Click += buttonAddVenue_Click;
            // 
            // listViewVenueDatas
            // 
            listViewVenueDatas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVenueDatas.Columns.AddRange(new ColumnHeader[] { columnVenueName, columnCourts });
            listViewVenueDatas.Location = new Point(9, 17);
            listViewVenueDatas.Name = "listViewVenueDatas";
            listViewVenueDatas.Size = new Size(471, 319);
            listViewVenueDatas.SmallImageList = imageListVenueListView;
            listViewVenueDatas.TabIndex = 1;
            listViewVenueDatas.UseCompatibleStateImageBehavior = false;
            listViewVenueDatas.View = View.Details;
            // 
            // columnVenueName
            // 
            columnVenueName.Text = "会場";
            columnVenueName.Width = 100;
            // 
            // columnCourts
            // 
            columnCourts.Text = "コート数";
            // 
            // imageListVenueListView
            // 
            imageListVenueListView.ColorDepth = ColorDepth.Depth32Bit;
            imageListVenueListView.ImageSize = new Size(16, 16);
            imageListVenueListView.TransparentColor = Color.Transparent;
            // 
            // tabPageTeamRegistration
            // 
            tabPageTeamRegistration.Controls.Add(tabControlTeamRagistration);
            tabPageTeamRegistration.Location = new Point(4, 24);
            tabPageTeamRegistration.Name = "tabPageTeamRegistration";
            tabPageTeamRegistration.Padding = new Padding(3);
            tabPageTeamRegistration.Size = new Size(573, 351);
            tabPageTeamRegistration.TabIndex = 4;
            tabPageTeamRegistration.Text = "チーム登録";
            tabPageTeamRegistration.UseVisualStyleBackColor = true;
            // 
            // tabControlTeamRagistration
            // 
            tabControlTeamRagistration.Alignment = TabAlignment.Bottom;
            tabControlTeamRagistration.Controls.Add(tabPageBoysTeamList);
            tabControlTeamRagistration.Controls.Add(tabPageGirlsTeamList);
            tabControlTeamRagistration.ImageList = imageListTeamRegistration;
            tabControlTeamRagistration.Location = new Point(6, 6);
            tabControlTeamRagistration.Name = "tabControlTeamRagistration";
            tabControlTeamRagistration.SelectedIndex = 0;
            tabControlTeamRagistration.Size = new Size(486, 339);
            tabControlTeamRagistration.TabIndex = 1;
            // 
            // tabPageBoysTeamList
            // 
            tabPageBoysTeamList.Controls.Add(dataGridViewBoysTeamList);
            tabPageBoysTeamList.Location = new Point(4, 4);
            tabPageBoysTeamList.Name = "tabPageBoysTeamList";
            tabPageBoysTeamList.Padding = new Padding(3);
            tabPageBoysTeamList.Size = new Size(478, 311);
            tabPageBoysTeamList.TabIndex = 0;
            tabPageBoysTeamList.Text = "男子チーム";
            tabPageBoysTeamList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBoysTeamList
            // 
            dataGridViewBoysTeamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBoysTeamList.Columns.AddRange(new DataGridViewColumn[] { ColumnJbaTeamID, ColumnTeamName, ColumnTeamNameKana, ColumnTeamNameShort, ColumnJbaTeamRegistrationStatus });
            dataGridViewBoysTeamList.Dock = DockStyle.Fill;
            dataGridViewBoysTeamList.Location = new Point(3, 3);
            dataGridViewBoysTeamList.Name = "dataGridViewBoysTeamList";
            dataGridViewBoysTeamList.Size = new Size(472, 305);
            dataGridViewBoysTeamList.TabIndex = 0;
            // 
            // ColumnJbaTeamID
            // 
            ColumnJbaTeamID.HeaderText = "JBAチームID";
            ColumnJbaTeamID.Name = "ColumnJbaTeamID";
            // 
            // ColumnTeamName
            // 
            ColumnTeamName.HeaderText = "チーム名";
            ColumnTeamName.Name = "ColumnTeamName";
            // 
            // ColumnTeamNameKana
            // 
            ColumnTeamNameKana.HeaderText = "チーム名カナ";
            ColumnTeamNameKana.Name = "ColumnTeamNameKana";
            // 
            // ColumnTeamNameShort
            // 
            ColumnTeamNameShort.HeaderText = "チーム名略称";
            ColumnTeamNameShort.Name = "ColumnTeamNameShort";
            // 
            // ColumnJbaTeamRegistrationStatus
            // 
            ColumnJbaTeamRegistrationStatus.HeaderText = "JBAチーム登録状態";
            ColumnJbaTeamRegistrationStatus.Name = "ColumnJbaTeamRegistrationStatus";
            // 
            // tabPageGirlsTeamList
            // 
            tabPageGirlsTeamList.Controls.Add(dataGridViewGirlsTeamList);
            tabPageGirlsTeamList.Location = new Point(4, 4);
            tabPageGirlsTeamList.Name = "tabPageGirlsTeamList";
            tabPageGirlsTeamList.Padding = new Padding(3);
            tabPageGirlsTeamList.Size = new Size(478, 311);
            tabPageGirlsTeamList.TabIndex = 1;
            tabPageGirlsTeamList.Text = "女子チーム";
            tabPageGirlsTeamList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGirlsTeamList
            // 
            dataGridViewGirlsTeamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGirlsTeamList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewGirlsTeamList.Dock = DockStyle.Fill;
            dataGridViewGirlsTeamList.Location = new Point(3, 3);
            dataGridViewGirlsTeamList.Name = "dataGridViewGirlsTeamList";
            dataGridViewGirlsTeamList.Size = new Size(472, 305);
            dataGridViewGirlsTeamList.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "JBAチームID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "チーム名";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "チーム名カナ";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "チーム名略称";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "JBAチーム登録状態";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // imageListTeamRegistration
            // 
            imageListTeamRegistration.ColorDepth = ColorDepth.Depth32Bit;
            imageListTeamRegistration.ImageSize = new Size(16, 16);
            imageListTeamRegistration.TransparentColor = Color.Transparent;
            // 
            // tabPageOtherOption
            // 
            tabPageOtherOption.Controls.Add(checkBox1);
            tabPageOtherOption.Location = new Point(4, 24);
            tabPageOtherOption.Name = "tabPageOtherOption";
            tabPageOtherOption.Padding = new Padding(3);
            tabPageOtherOption.Size = new Size(573, 351);
            tabPageOtherOption.TabIndex = 3;
            tabPageOtherOption.Text = "その他";
            tabPageOtherOption.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(235, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "起動時に前回終了時の状態を復元する(&R)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(514, 397);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "閉じる";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // SettingForm
            // 
            AcceptButton = buttonSaveTournamentNameData;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(605, 432);
            Controls.Add(buttonClose);
            Controls.Add(tabControl1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "SettingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "設定";
            Load += SettingForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageDataSaveFolders.ResumeLayout(false);
            tabPageDataSaveFolders.PerformLayout();
            tabPageTournamentNames.ResumeLayout(false);
            tabPageVenues.ResumeLayout(false);
            tabPageTeamRegistration.ResumeLayout(false);
            tabControlTeamRagistration.ResumeLayout(false);
            tabPageBoysTeamList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoysTeamList).EndInit();
            tabPageGirlsTeamList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGirlsTeamList).EndInit();
            tabPageOtherOption.ResumeLayout(false);
            tabPageOtherOption.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageDataSaveFolders;
        private TabPage tabPageTournamentNames;
        private TabPage tabPageVenues;
        private Button buttonSaveTournamentNameData;
        private Button buttonClose;
        private ImageList imageListTournamentNames;
        private Button buttonBrowseBaseDataFolder;
        private TextBox textBoxBaseDataFolder;
        private ListView listView1;
        private ColumnHeader columnFolderTitle;
        private ColumnHeader columnFolderPath;
        private ListView listViewVenueDatas;
        private ColumnHeader columnVenueName;
        private ColumnHeader columnCourts;
        private Button buttonDeleteTournamentName;
        private Button buttonEditTournamentName;
        private Button buttonAddTournamentName;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ListView listViewTournamentNames;
        private ColumnHeader columnTournamentName;
        private Button buttonSaveVenue;
        private Button buttonExportVenue;
        private Button buttonImportVenue;
        private ToolTip toolTip1;
        private ColumnHeader columnTournamentFixedNumOfTeams;
        private TabPage tabPageOtherOption;
        private CheckBox checkBox1;
        private TabPage tabPageTeamRegistration;
        private DataGridView dataGridViewBoysTeamList;
        private DataGridViewTextBoxColumn ColumnJbaTeamID;
        private DataGridViewTextBoxColumn ColumnTeamName;
        private DataGridViewTextBoxColumn ColumnTeamNameKana;
        private DataGridViewTextBoxColumn ColumnTeamNameShort;
        private DataGridViewTextBoxColumn ColumnJbaTeamRegistrationStatus;
        private TabControl tabControlTeamRagistration;
        private TabPage tabPageBoysTeamList;
        private TabPage tabPageGirlsTeamList;
        private DataGridView dataGridViewGirlsTeamList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ImageList imageListTeamRegistration;
        private ImageList imageListVenueListView;
    }
}