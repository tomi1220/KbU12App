namespace PbaU12Tools.TournamentData
{
    partial class TournamentDataForm
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
            panelName = new Panel();
            textBoxTournamentName = new TextBox();
            buttonTournamentName = new Button();
            tableLayoutPanelTournamentBaseData = new TableLayoutPanel();
            panelGirls = new Panel();
            checkBoxGirls = new CheckBox();
            groupBox1 = new GroupBox();
            numericUpDownSuperSeedGirls = new NumericUpDown();
            labelSuperSeedGirls = new Label();
            numericUpDownNumberOfTeamsGirls = new NumericUpDown();
            label2 = new Label();
            panelBoys = new Panel();
            checkBoxBoys = new CheckBox();
            groupBoxBoys = new GroupBox();
            numericUpDownSuperSeedBoys = new NumericUpDown();
            labelSuperSeedBoys = new Label();
            numericUpDownNumberOfTeamsBoys = new NumericUpDown();
            label1 = new Label();
            panelOptions = new Panel();
            checkBoxFinalLeague = new CheckBox();
            checkBoxDistrict = new CheckBox();
            checkBoxOpen = new CheckBox();
            panelVenue = new Panel();
            groupBoxVenue = new GroupBox();
            buttonDeleteVenue = new Button();
            buttonEditVenue = new Button();
            buttonAddVenue = new Button();
            listViewVenue = new ListView();
            columnTargetDate = new ColumnHeader();
            columnVenue = new ColumnHeader();
            columnCourt = new ColumnHeader();
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonOK = new Button();
            panelName.SuspendLayout();
            tableLayoutPanelTournamentBaseData.SuspendLayout();
            panelGirls.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeedGirls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsGirls).BeginInit();
            panelBoys.SuspendLayout();
            groupBoxBoys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeedBoys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsBoys).BeginInit();
            panelOptions.SuspendLayout();
            panelVenue.SuspendLayout();
            groupBoxVenue.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelName
            // 
            panelName.Controls.Add(textBoxTournamentName);
            panelName.Controls.Add(buttonTournamentName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(584, 47);
            panelName.TabIndex = 1;
            // 
            // textBoxTournamentName
            // 
            textBoxTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTournamentName.Font = new Font("Meiryo UI", 9F);
            textBoxTournamentName.Location = new Point(122, 14);
            textBoxTournamentName.Name = "textBoxTournamentName";
            textBoxTournamentName.ReadOnly = true;
            textBoxTournamentName.Size = new Size(450, 23);
            textBoxTournamentName.TabIndex = 1;
            // 
            // buttonTournamentName
            // 
            buttonTournamentName.AutoSize = true;
            buttonTournamentName.Font = new Font("Meiryo UI", 9F);
            buttonTournamentName.Location = new Point(12, 12);
            buttonTournamentName.Name = "buttonTournamentName";
            buttonTournamentName.Size = new Size(104, 25);
            buttonTournamentName.TabIndex = 0;
            buttonTournamentName.Text = "大会名(&N)...";
            buttonTournamentName.UseVisualStyleBackColor = true;
            buttonTournamentName.Click += buttonTournamentName_Click;
            // 
            // tableLayoutPanelTournamentBaseData
            // 
            tableLayoutPanelTournamentBaseData.ColumnCount = 2;
            tableLayoutPanelTournamentBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.Controls.Add(panelGirls, 1, 0);
            tableLayoutPanelTournamentBaseData.Controls.Add(panelBoys, 0, 0);
            tableLayoutPanelTournamentBaseData.Dock = DockStyle.Top;
            tableLayoutPanelTournamentBaseData.Location = new Point(0, 47);
            tableLayoutPanelTournamentBaseData.Name = "tableLayoutPanelTournamentBaseData";
            tableLayoutPanelTournamentBaseData.RowCount = 1;
            tableLayoutPanelTournamentBaseData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTournamentBaseData.Size = new Size(584, 98);
            tableLayoutPanelTournamentBaseData.TabIndex = 2;
            // 
            // panelGirls
            // 
            panelGirls.Controls.Add(checkBoxGirls);
            panelGirls.Controls.Add(groupBox1);
            panelGirls.Dock = DockStyle.Fill;
            panelGirls.Location = new Point(295, 3);
            panelGirls.Name = "panelGirls";
            panelGirls.Size = new Size(286, 92);
            panelGirls.TabIndex = 1;
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
            groupBox1.Controls.Add(numericUpDownSuperSeedGirls);
            groupBox1.Controls.Add(labelSuperSeedGirls);
            groupBox1.Controls.Add(numericUpDownNumberOfTeamsGirls);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 83);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // numericUpDownSuperSeedGirls
            // 
            numericUpDownSuperSeedGirls.Location = new Point(177, 53);
            numericUpDownSuperSeedGirls.Name = "numericUpDownSuperSeedGirls";
            numericUpDownSuperSeedGirls.Size = new Size(36, 23);
            numericUpDownSuperSeedGirls.TabIndex = 6;
            numericUpDownSuperSeedGirls.TextAlign = HorizontalAlignment.Right;
            // 
            // labelSuperSeedGirls
            // 
            labelSuperSeedGirls.AutoSize = true;
            labelSuperSeedGirls.Location = new Point(28, 55);
            labelSuperSeedGirls.Name = "labelSuperSeedGirls";
            labelSuperSeedGirls.Size = new Size(143, 15);
            labelSuperSeedGirls.TabIndex = 5;
            labelSuperSeedGirls.Text = "スーパーシード・チーム数(&4):";
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
            label2.Text = "出場チーム数(&3):";
            // 
            // panelBoys
            // 
            panelBoys.Controls.Add(checkBoxBoys);
            panelBoys.Controls.Add(groupBoxBoys);
            panelBoys.Dock = DockStyle.Fill;
            panelBoys.Location = new Point(3, 3);
            panelBoys.Name = "panelBoys";
            panelBoys.Size = new Size(286, 92);
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
            groupBoxBoys.Controls.Add(numericUpDownSuperSeedBoys);
            groupBoxBoys.Controls.Add(labelSuperSeedBoys);
            groupBoxBoys.Controls.Add(numericUpDownNumberOfTeamsBoys);
            groupBoxBoys.Controls.Add(label1);
            groupBoxBoys.Location = new Point(3, 6);
            groupBoxBoys.Name = "groupBoxBoys";
            groupBoxBoys.Size = new Size(280, 83);
            groupBoxBoys.TabIndex = 1;
            groupBoxBoys.TabStop = false;
            // 
            // numericUpDownSuperSeedBoys
            // 
            numericUpDownSuperSeedBoys.Location = new Point(177, 53);
            numericUpDownSuperSeedBoys.Name = "numericUpDownSuperSeedBoys";
            numericUpDownSuperSeedBoys.Size = new Size(36, 23);
            numericUpDownSuperSeedBoys.TabIndex = 4;
            numericUpDownSuperSeedBoys.TextAlign = HorizontalAlignment.Right;
            // 
            // labelSuperSeedBoys
            // 
            labelSuperSeedBoys.AutoSize = true;
            labelSuperSeedBoys.Location = new Point(28, 55);
            labelSuperSeedBoys.Name = "labelSuperSeedBoys";
            labelSuperSeedBoys.Size = new Size(143, 15);
            labelSuperSeedBoys.TabIndex = 3;
            labelSuperSeedBoys.Text = "スーパーシード・チーム数(&2):";
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
            panelOptions.Controls.Add(checkBoxFinalLeague);
            panelOptions.Controls.Add(checkBoxDistrict);
            panelOptions.Controls.Add(checkBoxOpen);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 145);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(584, 56);
            panelOptions.TabIndex = 3;
            // 
            // checkBoxFinalLeague
            // 
            checkBoxFinalLeague.AutoSize = true;
            checkBoxFinalLeague.Location = new Point(12, 31);
            checkBoxFinalLeague.Name = "checkBoxFinalLeague";
            checkBoxFinalLeague.Size = new Size(94, 19);
            checkBoxFinalLeague.TabIndex = 2;
            checkBoxFinalLeague.Text = "決勝リーグ(&R)";
            checkBoxFinalLeague.UseVisualStyleBackColor = true;
            // 
            // checkBoxDistrict
            // 
            checkBoxDistrict.AutoSize = true;
            checkBoxDistrict.Location = new Point(240, 6);
            checkBoxDistrict.Name = "checkBoxDistrict";
            checkBoxDistrict.Size = new Size(133, 19);
            checkBoxDistrict.TabIndex = 1;
            checkBoxDistrict.Text = "地区名の枠を作る(&D)";
            checkBoxDistrict.UseVisualStyleBackColor = true;
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
            // panelVenue
            // 
            panelVenue.Controls.Add(groupBoxVenue);
            panelVenue.Dock = DockStyle.Fill;
            panelVenue.Location = new Point(0, 201);
            panelVenue.Name = "panelVenue";
            panelVenue.Size = new Size(584, 153);
            panelVenue.TabIndex = 4;
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
            groupBoxVenue.Size = new Size(584, 153);
            groupBoxVenue.TabIndex = 5;
            groupBoxVenue.TabStop = false;
            groupBoxVenue.Text = "会場情報(&V):";
            // 
            // buttonDeleteVenue
            // 
            buttonDeleteVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteVenue.Location = new Point(526, 88);
            buttonDeleteVenue.Name = "buttonDeleteVenue";
            buttonDeleteVenue.Size = new Size(49, 27);
            buttonDeleteVenue.TabIndex = 3;
            buttonDeleteVenue.UseVisualStyleBackColor = true;
            buttonDeleteVenue.Click += buttonDeleteVenue_Click;
            // 
            // buttonEditVenue
            // 
            buttonEditVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditVenue.Location = new Point(526, 55);
            buttonEditVenue.Name = "buttonEditVenue";
            buttonEditVenue.Size = new Size(49, 27);
            buttonEditVenue.TabIndex = 2;
            buttonEditVenue.UseVisualStyleBackColor = true;
            buttonEditVenue.Click += buttonEditVenue_Click;
            // 
            // buttonAddVenue
            // 
            buttonAddVenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddVenue.Location = new Point(526, 22);
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
            listViewVenue.Size = new Size(514, 125);
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
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonOK);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 41);
            panel1.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(497, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.Location = new Point(410, 9);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // TournamentDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 395);
            Controls.Add(panelVenue);
            Controls.Add(panelOptions);
            Controls.Add(tableLayoutPanelTournamentBaseData);
            Controls.Add(panelName);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "TournamentDataForm";
            Text = "大会情報";
            Load += TournamentDataForm_Load;
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            tableLayoutPanelTournamentBaseData.ResumeLayout(false);
            panelGirls.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeedGirls).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsGirls).EndInit();
            panelBoys.ResumeLayout(false);
            groupBoxBoys.ResumeLayout(false);
            groupBoxBoys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeedBoys).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeamsBoys).EndInit();
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panelVenue.ResumeLayout(false);
            groupBoxVenue.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelName;
        private TextBox textBoxTournamentName;
        private Button buttonTournamentName;
        private TableLayoutPanel tableLayoutPanelTournamentBaseData;
        private Panel panelGirls;
        private CheckBox checkBoxGirls;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownNumberOfTeamsGirls;
        private Label label2;
        private Panel panelBoys;
        private CheckBox checkBoxBoys;
        private GroupBox groupBoxBoys;
        private NumericUpDown numericUpDownNumberOfTeamsBoys;
        private Label label1;
        private Panel panelOptions;
        private CheckBox checkBoxOpen;
        private Panel panelVenue;
        private GroupBox groupBoxVenue;
        private Button buttonDeleteVenue;
        private Button buttonEditVenue;
        private Button buttonAddVenue;
        private ListView listViewVenue;
        private ColumnHeader columnTargetDate;
        private ColumnHeader columnVenue;
        private ColumnHeader columnCourt;
        private CheckBox checkBoxFinalLeague;
        private CheckBox checkBoxDistrict;
        private NumericUpDown numericUpDownSuperSeedGirls;
        private Label labelSuperSeedGirls;
        private NumericUpDown numericUpDownSuperSeedBoys;
        private Label labelSuperSeedBoys;
        private Panel panel1;
        private Button buttonCancel;
        private Button buttonOK;
    }
}