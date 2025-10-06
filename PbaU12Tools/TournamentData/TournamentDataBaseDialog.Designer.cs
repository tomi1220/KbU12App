namespace PbaU12Tools.TournamentData
{
    partial class TournamentDataBaseDialog
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
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonOK = new Button();
            panelTournamentBaseData.SuspendLayout();
            panelVenue.SuspendLayout();
            groupBoxVenue.SuspendLayout();
            tableLayoutPanelTournamentBaseData.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTournamentBaseData
            // 
            panelTournamentBaseData.Controls.Add(panelVenue);
            panelTournamentBaseData.Controls.Add(tableLayoutPanelTournamentBaseData);
            panelTournamentBaseData.Dock = DockStyle.Fill;
            panelTournamentBaseData.Location = new Point(0, 0);
            panelTournamentBaseData.Name = "panelTournamentBaseData";
            panelTournamentBaseData.Size = new Size(728, 387);
            panelTournamentBaseData.TabIndex = 1;
            // 
            // panelVenue
            // 
            panelVenue.Controls.Add(groupBoxVenue);
            panelVenue.Dock = DockStyle.Fill;
            panelVenue.Location = new Point(0, 162);
            panelVenue.Name = "panelVenue";
            panelVenue.Size = new Size(728, 225);
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
            groupBoxVenue.Size = new Size(728, 225);
            groupBoxVenue.TabIndex = 5;
            groupBoxVenue.TabStop = false;
            groupBoxVenue.Text = "会場情報(&V):";
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(661, 85);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(55, 26);
            buttonDeleteVenue.TabIndex = 3;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(661, 53);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(55, 26);
            buttonEditVenue.TabIndex = 2;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(661, 21);
            buttonAddVenue.Name = "buttonAddVenue";
            buttonAddVenue.Size = new Size(55, 26);
            buttonAddVenue.TabIndex = 1;
            buttonAddVenue.UseVisualStyleBackColor = true;
            buttonAddVenue.Click += buttonAddVenue_Click;
            // 
            // listViewVenue
            // 
            listViewVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVenue.Columns.AddRange(new ColumnHeader[] { columnTargetDate, columnVenue, columnCourt });
            listViewVenue.Location = new Point(12, 21);
            listViewVenue.Name = "listViewVenue";
            listViewVenue.Size = new Size(637, 193);
            listViewVenue.TabIndex = 0;
            listViewVenue.UseCompatibleStateImageBehavior = false;
            listViewVenue.View = View.Details;
            listViewVenue.DoubleClick += listViewVenue_DoubleClick;
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
            tableLayoutPanelTournamentBaseData.Size = new Size(728, 162);
            tableLayoutPanelTournamentBaseData.TabIndex = 3;
            // 
            // numOfTeamsCtrlGirls
            // 
            numOfTeamsCtrlGirls.Category = Categories.Girls;
            numOfTeamsCtrlGirls.CategoryValidity = false;
            numOfTeamsCtrlGirls.Dock = DockStyle.Fill;
            numOfTeamsCtrlGirls.FinalLeage = false;
            numOfTeamsCtrlGirls.Location = new Point(367, 4);
            numOfTeamsCtrlGirls.Margin = new Padding(3, 4, 3, 4);
            numOfTeamsCtrlGirls.MinimumSize = new Size(348, 161);
            numOfTeamsCtrlGirls.Name = "numOfTeamsCtrlGirls";
            numOfTeamsCtrlGirls.NumberOfSuperSeeds = 0;
            numOfTeamsCtrlGirls.NumberOfTeams = 0;
            numOfTeamsCtrlGirls.Padding = new Padding(8, 0, 8, 8);
            numOfTeamsCtrlGirls.Size = new Size(358, 161);
            numOfTeamsCtrlGirls.TabIndex = 1;
            numOfTeamsCtrlGirls.UseFinalLeage = false;
            numOfTeamsCtrlGirls.UseSuperSeeds = false;
            // 
            // numOfTeamsCtrlBoys
            // 
            numOfTeamsCtrlBoys.Category = Categories.Boys;
            numOfTeamsCtrlBoys.CategoryValidity = false;
            numOfTeamsCtrlBoys.Dock = DockStyle.Fill;
            numOfTeamsCtrlBoys.FinalLeage = false;
            numOfTeamsCtrlBoys.Location = new Point(3, 4);
            numOfTeamsCtrlBoys.Margin = new Padding(3, 4, 3, 4);
            numOfTeamsCtrlBoys.MinimumSize = new Size(348, 161);
            numOfTeamsCtrlBoys.Name = "numOfTeamsCtrlBoys";
            numOfTeamsCtrlBoys.NumberOfSuperSeeds = 0;
            numOfTeamsCtrlBoys.NumberOfTeams = 0;
            numOfTeamsCtrlBoys.Padding = new Padding(8, 0, 8, 8);
            numOfTeamsCtrlBoys.Size = new Size(358, 161);
            numOfTeamsCtrlBoys.TabIndex = 0;
            numOfTeamsCtrlBoys.UseFinalLeage = false;
            numOfTeamsCtrlBoys.UseSuperSeeds = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonOK);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 41);
            panel1.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(622, 6);
            buttonCancel.Margin = new Padding(3, 6, 3, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(514, 6);
            buttonOK.Margin = new Padding(3, 6, 3, 6);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // TournamentDataBaseDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(728, 428);
            Controls.Add(panelTournamentBaseData);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TournamentDataBaseDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "大会基本情報";
            Load += TournamentDataBaseDialog_Load;
            panelTournamentBaseData.ResumeLayout(false);
            panelVenue.ResumeLayout(false);
            groupBoxVenue.ResumeLayout(false);
            tableLayoutPanelTournamentBaseData.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTournamentBaseData;
        private Panel panelVenue;
        private GroupBox groupBoxVenue;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ListView listViewVenue;
        private ColumnHeader columnTargetDate;
        private ColumnHeader columnVenue;
        private ColumnHeader columnCourt;
        private TableLayoutPanel tableLayoutPanelTournamentBaseData;
        private Panel panel1;
        private Button buttonCancel;
        private Button buttonOK;
        private ControlEx.NumOfTeamsCtrl numOfTeamsCtrlGirls;
        private ControlEx.NumOfTeamsCtrl numOfTeamsCtrlBoys;
    }
}