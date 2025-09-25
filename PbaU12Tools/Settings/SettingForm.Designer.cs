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
            buttonClose = new Button();
            toolTip1 = new ToolTip(components);
            tabPageOtherOption = new TabPage();
            checkBox1 = new CheckBox();
            tabControl1.SuspendLayout();
            tabPageDataSaveFolders.SuspendLayout();
            tabPageTournamentNames.SuspendLayout();
            tabPageVenues.SuspendLayout();
            tabPageOtherOption.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDataSaveFolders);
            tabControl1.Controls.Add(tabPageTournamentNames);
            tabControl1.Controls.Add(tabPageVenues);
            tabControl1.Controls.Add(tabPageOtherOption);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 323);
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
            tabPageDataSaveFolders.Size = new Size(530, 295);
            tabPageDataSaveFolders.TabIndex = 0;
            tabPageDataSaveFolders.Text = "保存先";
            tabPageDataSaveFolders.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnFolderTitle, columnFolderPath });
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(22, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(420, 200);
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
            textBoxBaseDataFolder.Size = new Size(420, 23);
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
            tabPageTournamentNames.Size = new Size(530, 295);
            tabPageTournamentNames.TabIndex = 1;
            tabPageTournamentNames.Text = "大会";
            tabPageTournamentNames.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTournamentName
            // 
            buttonDeleteTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteTournamentName.Location = new Point(459, 83);
            buttonDeleteTournamentName.Name = "buttonDeleteTournamentName";
            buttonDeleteTournamentName.Size = new Size(49, 27);
            buttonDeleteTournamentName.TabIndex = 9;
            buttonDeleteTournamentName.UseVisualStyleBackColor = true;
            buttonDeleteTournamentName.Click += buttonDeleteTournamentName_Click;
            // 
            // buttonSaveTournamentNameData
            // 
            buttonSaveTournamentNameData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveTournamentNameData.Location = new Point(459, 257);
            buttonSaveTournamentNameData.Name = "buttonSaveTournamentNameData";
            buttonSaveTournamentNameData.Size = new Size(49, 23);
            buttonSaveTournamentNameData.TabIndex = 1;
            buttonSaveTournamentNameData.UseVisualStyleBackColor = true;
            buttonSaveTournamentNameData.Click += buttonSaveTournamentNameData_Click;
            // 
            // buttonEditTournamentName
            // 
            buttonEditTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditTournamentName.Location = new Point(459, 50);
            buttonEditTournamentName.Name = "buttonEditTournamentName";
            buttonEditTournamentName.Size = new Size(49, 27);
            buttonEditTournamentName.TabIndex = 8;
            buttonEditTournamentName.UseVisualStyleBackColor = true;
            buttonEditTournamentName.Click += buttonEditTournamentName_Click;
            // 
            // buttonAddTournamentName
            // 
            buttonAddTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddTournamentName.Location = new Point(459, 17);
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
            listViewTournamentNames.Size = new Size(428, 263);
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
            tabPageVenues.Size = new Size(530, 295);
            tabPageVenues.TabIndex = 2;
            tabPageVenues.Text = "会場";
            tabPageVenues.UseVisualStyleBackColor = true;
            // 
            // buttonExportVenue
            // 
            buttonExportVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportVenue.Location = new Point(459, 174);
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
            buttonImportVenue.Location = new Point(459, 145);
            buttonImportVenue.Name = "buttonImportVenue";
            buttonImportVenue.Size = new Size(49, 23);
            buttonImportVenue.TabIndex = 8;
            toolTip1.SetToolTip(buttonImportVenue, "会場データのインポート");
            buttonImportVenue.UseVisualStyleBackColor = true;
            buttonImportVenue.Click += buttonImportVenue_Click;
            // 
            // buttonSaveVenue
            // 
            buttonSaveVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveVenue.Location = new Point(459, 257);
            buttonSaveVenue.Name = "buttonSaveVenue";
            buttonSaveVenue.Size = new Size(49, 23);
            buttonSaveVenue.TabIndex = 7;
            buttonSaveVenue.UseVisualStyleBackColor = true;
            buttonSaveVenue.Click += buttonSaveVenue_Click;
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(459, 83);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 6;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(459, 50);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 5;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(459, 17);
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
            listViewVenueDatas.Size = new Size(428, 263);
            listViewVenueDatas.SmallImageList = imageListTournamentNames;
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
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(471, 341);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "閉じる";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // tabPageOtherOption
            // 
            tabPageOtherOption.Controls.Add(checkBox1);
            tabPageOtherOption.Location = new Point(4, 24);
            tabPageOtherOption.Name = "tabPageOtherOption";
            tabPageOtherOption.Padding = new Padding(3);
            tabPageOtherOption.Size = new Size(530, 295);
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
            // SettingForm
            // 
            AcceptButton = buttonSaveTournamentNameData;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(562, 376);
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
    }
}