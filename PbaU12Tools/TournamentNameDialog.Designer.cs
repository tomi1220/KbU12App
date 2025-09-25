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
            panelNumOfTournaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfTournaments).BeginInit();
            SuspendLayout();
            // 
            // checkBoxNumOfTournaments
            // 
            checkBoxNumOfTournaments.AutoSize = true;
            checkBoxNumOfTournaments.Location = new Point(12, 18);
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
            panelNumOfTournaments.Location = new Point(30, 12);
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
            comboBoxTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTournamentName.FormattingEnabled = true;
            comboBoxTournamentName.Location = new Point(12, 47);
            comboBoxTournamentName.Name = "comboBoxTournamentName";
            comboBoxTournamentName.Size = new Size(484, 23);
            comboBoxTournamentName.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(340, 85);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(421, 85);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // TournamentNameDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(508, 120);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxTournamentName);
            Controls.Add(panelNumOfTournaments);
            Controls.Add(checkBoxNumOfTournaments);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TournamentNameDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "大会名称の設定";
            Load += TournamentNameDialog_Load;
            panelNumOfTournaments.ResumeLayout(false);
            panelNumOfTournaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfTournaments).EndInit();
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
    }
}