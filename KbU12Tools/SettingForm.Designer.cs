namespace KbU12Tools
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
            textBoxExcelWorksheetSaveFolder = new TextBox();
            buttonBrowseExcelWorksheetSaveFolder = new Button();
            textBoxTournamentDataFolder = new TextBox();
            buttonBrowseTournamentDataFolder = new Button();
            buttonBrowseBaseDataFolder = new Button();
            textBoxBaseDataFolder = new TextBox();
            tabPageTournamentNames = new TabPage();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewTournamentNames = new ListView();
            columnTournamentName = new ColumnHeader();
            tabPageVenues = new TabPage();
            buttonOK = new Button();
            buttonCancel = new Button();
            imageListTournamentNames = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPageDataSaveFolders.SuspendLayout();
            tabPageTournamentNames.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDataSaveFolders);
            tabControl1.Controls.Add(tabPageTournamentNames);
            tabControl1.Controls.Add(tabPageVenues);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(456, 323);
            tabControl1.TabIndex = 0;
            // 
            // tabPageDataSaveFolders
            // 
            tabPageDataSaveFolders.Controls.Add(textBoxExcelWorksheetSaveFolder);
            tabPageDataSaveFolders.Controls.Add(buttonBrowseExcelWorksheetSaveFolder);
            tabPageDataSaveFolders.Controls.Add(textBoxTournamentDataFolder);
            tabPageDataSaveFolders.Controls.Add(buttonBrowseTournamentDataFolder);
            tabPageDataSaveFolders.Controls.Add(buttonBrowseBaseDataFolder);
            tabPageDataSaveFolders.Controls.Add(textBoxBaseDataFolder);
            tabPageDataSaveFolders.Location = new Point(4, 24);
            tabPageDataSaveFolders.Name = "tabPageDataSaveFolders";
            tabPageDataSaveFolders.Padding = new Padding(3);
            tabPageDataSaveFolders.Size = new Size(448, 295);
            tabPageDataSaveFolders.TabIndex = 0;
            tabPageDataSaveFolders.Text = "保存先";
            tabPageDataSaveFolders.UseVisualStyleBackColor = true;
            // 
            // textBoxExcelWorksheetSaveFolder
            // 
            textBoxExcelWorksheetSaveFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxExcelWorksheetSaveFolder.Location = new Point(22, 177);
            textBoxExcelWorksheetSaveFolder.Name = "textBoxExcelWorksheetSaveFolder";
            textBoxExcelWorksheetSaveFolder.Size = new Size(420, 23);
            textBoxExcelWorksheetSaveFolder.TabIndex = 5;
            // 
            // buttonBrowseExcelWorksheetSaveFolder
            // 
            buttonBrowseExcelWorksheetSaveFolder.Location = new Point(6, 148);
            buttonBrowseExcelWorksheetSaveFolder.Name = "buttonBrowseExcelWorksheetSaveFolder";
            buttonBrowseExcelWorksheetSaveFolder.Size = new Size(220, 23);
            buttonBrowseExcelWorksheetSaveFolder.TabIndex = 4;
            buttonBrowseExcelWorksheetSaveFolder.Text = "Excelワークシートの保存先フォルダー(&E)";
            buttonBrowseExcelWorksheetSaveFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxTournamentDataFolder
            // 
            textBoxTournamentDataFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTournamentDataFolder.Location = new Point(22, 108);
            textBoxTournamentDataFolder.Name = "textBoxTournamentDataFolder";
            textBoxTournamentDataFolder.Size = new Size(420, 23);
            textBoxTournamentDataFolder.TabIndex = 3;
            // 
            // buttonBrowseTournamentDataFolder
            // 
            buttonBrowseTournamentDataFolder.Location = new Point(6, 79);
            buttonBrowseTournamentDataFolder.Name = "buttonBrowseTournamentDataFolder";
            buttonBrowseTournamentDataFolder.Size = new Size(220, 23);
            buttonBrowseTournamentDataFolder.TabIndex = 2;
            buttonBrowseTournamentDataFolder.Text = "大会データの保存先フォルダー(&T)";
            buttonBrowseTournamentDataFolder.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseBaseDataFolder
            // 
            buttonBrowseBaseDataFolder.Location = new Point(6, 6);
            buttonBrowseBaseDataFolder.Name = "buttonBrowseBaseDataFolder";
            buttonBrowseBaseDataFolder.Size = new Size(220, 23);
            buttonBrowseBaseDataFolder.TabIndex = 0;
            buttonBrowseBaseDataFolder.Text = "基本データの保存先フォルダー(&B)";
            buttonBrowseBaseDataFolder.UseVisualStyleBackColor = true;
            buttonBrowseBaseDataFolder.Click += buttonBrowseBaseDataFolder_Click;
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
            tabPageTournamentNames.Controls.Add(buttonDeleteVenue);
            tabPageTournamentNames.Controls.Add(buttonEditVenue);
            tabPageTournamentNames.Controls.Add(buttonAddVenue);
            tabPageTournamentNames.Controls.Add(listViewTournamentNames);
            tabPageTournamentNames.Location = new Point(4, 24);
            tabPageTournamentNames.Name = "tabPageTournamentNames";
            tabPageTournamentNames.Padding = new Padding(3);
            tabPageTournamentNames.Size = new Size(448, 295);
            tabPageTournamentNames.TabIndex = 1;
            tabPageTournamentNames.Text = "大会名称";
            tabPageTournamentNames.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(377, 83);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 3;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(377, 50);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 2;
            buttonEditVenue.UseVisualStyleBackColor = true;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(377, 17);
            buttonAddVenue.Name = "buttonAddVenue";
            buttonAddVenue.Size = new Size(49, 27);
            buttonAddVenue.TabIndex = 1;
            buttonAddVenue.UseVisualStyleBackColor = true;
            // 
            // listViewTournamentNames
            // 
            listViewTournamentNames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTournamentNames.Columns.AddRange(new ColumnHeader[] { columnTournamentName });
            listViewTournamentNames.Location = new Point(9, 17);
            listViewTournamentNames.Name = "listViewTournamentNames";
            listViewTournamentNames.Size = new Size(346, 263);
            listViewTournamentNames.TabIndex = 0;
            listViewTournamentNames.UseCompatibleStateImageBehavior = false;
            listViewTournamentNames.View = View.Details;
            // 
            // columnTournamentName
            // 
            columnTournamentName.Text = "大会名";
            columnTournamentName.Width = 342;
            // 
            // tabPageVenues
            // 
            tabPageVenues.Location = new Point(4, 24);
            tabPageVenues.Name = "tabPageVenues";
            tabPageVenues.Padding = new Padding(3);
            tabPageVenues.Size = new Size(448, 295);
            tabPageVenues.TabIndex = 2;
            tabPageVenues.Text = "会場";
            tabPageVenues.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.Location = new Point(312, 341);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(393, 341);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // imageListTournamentNames
            // 
            imageListTournamentNames.ColorDepth = ColorDepth.Depth32Bit;
            imageListTournamentNames.ImageSize = new Size(16, 16);
            imageListTournamentNames.TransparentColor = Color.Transparent;
            // 
            // SettingForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(480, 376);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(tabControl1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "SettingForm";
            Text = "SettingForm";
            tabControl1.ResumeLayout(false);
            tabPageDataSaveFolders.ResumeLayout(false);
            tabPageDataSaveFolders.PerformLayout();
            tabPageTournamentNames.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageDataSaveFolders;
        private TabPage tabPageTournamentNames;
        private TabPage tabPageVenues;
        private Button buttonOK;
        private Button buttonCancel;
        private ListView listViewTournamentNames;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ColumnHeader columnTournamentName;
        private ImageList imageListTournamentNames;
        private Button buttonBrowseBaseDataFolder;
        private TextBox textBoxBaseDataFolder;
        private TextBox textBoxExcelWorksheetSaveFolder;
        private Button buttonBrowseExcelWorksheetSaveFolder;
        private TextBox textBoxTournamentDataFolder;
        private Button buttonBrowseTournamentDataFolder;
    }
}