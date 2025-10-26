namespace PbaU12Tools
{
    partial class TournamentNameDialog
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
            checkBoxNumOfTournaments = new CheckBox();
            panelNumOfTournaments = new Panel();
            labelNumOfTournaments2 = new Label();
            numericUpDownNumOfTournaments = new NumericUpDown();
            labelNumOfTournaments1 = new Label();
            comboBoxTournamentName = new ComboBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            comboBoxYear = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelNumOfTournaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfTournaments).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxNumOfTournaments
            // 
            checkBoxNumOfTournaments.AutoSize = true;
            checkBoxNumOfTournaments.Location = new Point(12, 52);
            checkBoxNumOfTournaments.Margin = new Padding(3, 3, 0, 3);
            checkBoxNumOfTournaments.Name = "checkBoxNumOfTournaments";
            checkBoxNumOfTournaments.Size = new Size(15, 14);
            checkBoxNumOfTournaments.TabIndex = 0;
            checkBoxNumOfTournaments.UseVisualStyleBackColor = true;
            checkBoxNumOfTournaments.CheckedChanged += checkBoxNumOfTournaments_CheckedChanged;
            // 
            // panelNumOfTournaments
            // 
            panelNumOfTournaments.Controls.Add(labelNumOfTournaments2);
            panelNumOfTournaments.Controls.Add(numericUpDownNumOfTournaments);
            panelNumOfTournaments.Controls.Add(labelNumOfTournaments1);
            panelNumOfTournaments.Enabled = false;
            panelNumOfTournaments.Location = new Point(30, 46);
            panelNumOfTournaments.Name = "panelNumOfTournaments";
            panelNumOfTournaments.Size = new Size(90, 29);
            panelNumOfTournaments.TabIndex = 1;
            // 
            // labelNumOfTournaments2
            // 
            labelNumOfTournaments2.AutoSize = true;
            labelNumOfTournaments2.Location = new Point(68, 5);
            labelNumOfTournaments2.Margin = new Padding(0, 0, 3, 0);
            labelNumOfTournaments2.Name = "labelNumOfTournaments2";
            labelNumOfTournaments2.Size = new Size(19, 15);
            labelNumOfTournaments2.TabIndex = 2;
            labelNumOfTournaments2.Text = "回";
            // 
            // numericUpDownNumOfTournaments
            // 
            numericUpDownNumOfTournaments.Location = new Point(25, 3);
            numericUpDownNumOfTournaments.Margin = new Padding(0, 3, 3, 3);
            numericUpDownNumOfTournaments.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumOfTournaments.Name = "numericUpDownNumOfTournaments";
            numericUpDownNumOfTournaments.Size = new Size(40, 23);
            numericUpDownNumOfTournaments.TabIndex = 2;
            numericUpDownNumOfTournaments.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumOfTournaments.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumOfTournaments.ValueChanged += numericUpDownNumOfTournaments_ValueChanged;
            // 
            // labelNumOfTournaments1
            // 
            labelNumOfTournaments1.AutoSize = true;
            labelNumOfTournaments1.Location = new Point(3, 5);
            labelNumOfTournaments1.Margin = new Padding(0, 0, 3, 0);
            labelNumOfTournaments1.Name = "labelNumOfTournaments1";
            labelNumOfTournaments1.Size = new Size(19, 15);
            labelNumOfTournaments1.TabIndex = 2;
            labelNumOfTournaments1.Text = "第";
            // 
            // comboBoxTournamentName
            // 
            comboBoxTournamentName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTournamentName.FormattingEnabled = true;
            comboBoxTournamentName.Location = new Point(12, 82);
            comboBoxTournamentName.Name = "comboBoxTournamentName";
            comboBoxTournamentName.Size = new Size(484, 23);
            comboBoxTournamentName.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(164, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(245, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(66, 14);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(72, 23);
            comboBoxYear.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "年度(&S):";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonOK, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 117);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 29);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // TournamentNameDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(508, 155);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxTournamentName);
            Controls.Add(panelNumOfTournaments);
            Controls.Add(checkBoxNumOfTournaments);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 194);
            MinimumSize = new Size(524, 194);
            Name = "TournamentNameDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "大会名称の設定";
            Load += TournamentNameDialog_Load;
            panelNumOfTournaments.ResumeLayout(false);
            panelNumOfTournaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfTournaments).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxNumOfTournaments;
        private Panel panelNumOfTournaments;
        private NumericUpDown numericUpDownNumOfTournaments;
        private Label labelNumOfTournaments1;
        private Label labelNumOfTournaments2;
        private ComboBox comboBoxTournamentName;
        private Button buttonOK;
        private Button buttonCancel;
        private ComboBox comboBoxYear;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}