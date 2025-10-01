namespace PbaU12Tools.Settings
{
    partial class SettingsTourneyNameDialog
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
            label1 = new Label();
            textBoxTournamentName = new TextBox();
            checkBoxFixedNumOfBoysTeams = new CheckBox();
            numericUpDownNumOfGirlsTeams = new NumericUpDown();
            numericUpDownNumOfBoysTeams = new NumericUpDown();
            buttonOK = new Button();
            buttonCancel = new Button();
            checkBoxFixedNumOfGirlsTeams = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfGirlsTeams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfBoysTeams).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "大会名(&N):";
            // 
            // textBoxTournamentName
            // 
            textBoxTournamentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTournamentName.ImeMode = ImeMode.On;
            textBoxTournamentName.Location = new Point(85, 12);
            textBoxTournamentName.Name = "textBoxTournamentName";
            textBoxTournamentName.Size = new Size(357, 23);
            textBoxTournamentName.TabIndex = 1;
            // 
            // checkBoxFixedNumOfBoysTeams
            // 
            checkBoxFixedNumOfBoysTeams.AutoSize = true;
            checkBoxFixedNumOfBoysTeams.Location = new Point(26, 51);
            checkBoxFixedNumOfBoysTeams.Name = "checkBoxFixedNumOfBoysTeams";
            checkBoxFixedNumOfBoysTeams.Size = new Size(138, 19);
            checkBoxFixedNumOfBoysTeams.TabIndex = 2;
            checkBoxFixedNumOfBoysTeams.Text = "男子チーム数固定(&B):";
            checkBoxFixedNumOfBoysTeams.UseVisualStyleBackColor = true;
            checkBoxFixedNumOfBoysTeams.CheckedChanged += checkBoxFixedNumOfBoysTeams_CheckedChanged;
            // 
            // numericUpDownNumOfGirlsTeams
            // 
            numericUpDownNumOfGirlsTeams.Location = new Point(171, 89);
            numericUpDownNumOfGirlsTeams.Name = "numericUpDownNumOfGirlsTeams";
            numericUpDownNumOfGirlsTeams.Size = new Size(37, 23);
            numericUpDownNumOfGirlsTeams.TabIndex = 6;
            // 
            // numericUpDownNumOfBoysTeams
            // 
            numericUpDownNumOfBoysTeams.Location = new Point(170, 50);
            numericUpDownNumOfBoysTeams.Name = "numericUpDownNumOfBoysTeams";
            numericUpDownNumOfBoysTeams.Size = new Size(37, 23);
            numericUpDownNumOfBoysTeams.TabIndex = 5;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(367, 61);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(367, 90);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxFixedNumOfGirlsTeams
            // 
            checkBoxFixedNumOfGirlsTeams.AutoSize = true;
            checkBoxFixedNumOfGirlsTeams.Location = new Point(26, 90);
            checkBoxFixedNumOfGirlsTeams.Name = "checkBoxFixedNumOfGirlsTeams";
            checkBoxFixedNumOfGirlsTeams.Size = new Size(139, 19);
            checkBoxFixedNumOfGirlsTeams.TabIndex = 7;
            checkBoxFixedNumOfGirlsTeams.Text = "女子チーム数固定(&G):";
            checkBoxFixedNumOfGirlsTeams.UseVisualStyleBackColor = true;
            checkBoxFixedNumOfGirlsTeams.CheckedChanged += checkBoxFixedNumOfGirlsTeams_CheckedChanged;
            // 
            // SettingsTourneyNameDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(454, 124);
            Controls.Add(numericUpDownNumOfGirlsTeams);
            Controls.Add(checkBoxFixedNumOfGirlsTeams);
            Controls.Add(checkBoxFixedNumOfBoysTeams);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownNumOfBoysTeams);
            Controls.Add(buttonOK);
            Controls.Add(textBoxTournamentName);
            Controls.Add(label1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SettingsTourneyNameDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "［大会］のプロパティ";
            Load += SettingsTourneyNameDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfGirlsTeams).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumOfBoysTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTournamentName;
        private CheckBox checkBoxFixedNumOfBoysTeams;
        private NumericUpDown numericUpDownNumOfBoysTeams;
        private NumericUpDown numericUpDownNumOfGirlsTeams;
        private Button buttonOK;
        private Button buttonCancel;
        private CheckBox checkBoxFixedNumOfGirlsTeams;
    }
}