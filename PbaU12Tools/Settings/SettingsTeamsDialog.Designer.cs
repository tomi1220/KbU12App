namespace PbaU12Tools.Settings
{
    partial class SettingsTeamsDialog
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
            buttonCancel = new Button();
            buttonOK = new Button();
            textBoxTeamID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTeamName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxTeamNameKana = new TextBox();
            label6 = new Label();
            textBoxShortName = new TextBox();
            label7 = new Label();
            labelCategory = new Label();
            label8 = new Label();
            comboBoxDistrict = new ComboBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(470, 176);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(389, 176);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxTeamID
            // 
            textBoxTeamID.ImeMode = ImeMode.On;
            textBoxTeamID.Location = new Point(102, 12);
            textBoxTeamID.Margin = new Padding(0, 3, 3, 3);
            textBoxTeamID.Name = "textBoxTeamID";
            textBoxTeamID.Size = new Size(113, 23);
            textBoxTeamID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "チームID(&I):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 15);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 6;
            label2.Text = "T";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "チーム名(&N):";
            // 
            // textBoxTeamName
            // 
            textBoxTeamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTeamName.ImeMode = ImeMode.On;
            textBoxTeamName.Location = new Point(88, 41);
            textBoxTeamName.Name = "textBoxTeamName";
            textBoxTeamName.Size = new Size(295, 23);
            textBoxTeamName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 44);
            label4.Name = "label4";
            label4.Size = new Size(158, 15);
            label4.TabIndex = 9;
            label4.Text = "※JBAに登録している正式名称";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 10;
            label5.Text = "チーム名カナ(&K):";
            // 
            // textBoxTeamNameKana
            // 
            textBoxTeamNameKana.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTeamNameKana.ImeMode = ImeMode.On;
            textBoxTeamNameKana.Location = new Point(108, 70);
            textBoxTeamNameKana.Name = "textBoxTeamNameKana";
            textBoxTeamNameKana.Size = new Size(437, 23);
            textBoxTeamNameKana.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 102);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "略称(&S):";
            // 
            // textBoxShortName
            // 
            textBoxShortName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxShortName.ImeMode = ImeMode.On;
            textBoxShortName.Location = new Point(88, 99);
            textBoxShortName.Name = "textBoxShortName";
            textBoxShortName.Size = new Size(149, 23);
            textBoxShortName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 102);
            label7.Name = "label7";
            label7.Size = new Size(160, 15);
            label7.TabIndex = 14;
            label7.Text = "※トーナメント表に表示する名称";
            // 
            // labelCategory
            // 
            labelCategory.Location = new Point(416, 15);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(131, 15);
            labelCategory.TabIndex = 16;
            labelCategory.Text = "女子";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 131);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 17;
            label8.Text = "地区(&D):";
            // 
            // comboBoxDistrict
            // 
            comboBoxDistrict.FormattingEnabled = true;
            comboBoxDistrict.Location = new Point(87, 128);
            comboBoxDistrict.Name = "comboBoxDistrict";
            comboBoxDistrict.Size = new Size(150, 23);
            comboBoxDistrict.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 160);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 19;
            label9.Text = "JBA登録状況(&R):";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 20;
            // 
            // SettingsTeamsDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(557, 211);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(comboBoxDistrict);
            Controls.Add(label8);
            Controls.Add(labelCategory);
            Controls.Add(label7);
            Controls.Add(textBoxShortName);
            Controls.Add(label6);
            Controls.Add(textBoxTeamNameKana);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxTeamName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxTeamID);
            Controls.Add(label1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "SettingsTeamsDialog";
            Text = "［チーム］のプロパティ";
            Load += SettingsVenueDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private NumericUpDown numericUpDownNumberOfCourts;
        private Button buttonOK;
        private TextBox textBoxTeamID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTeamName;
        private Label label4;
        private Label label5;
        private TextBox textBoxTeamNameKana;
        private Label label6;
        private TextBox textBoxShortName;
        private Label label7;
        private Label labelCategory;
        private Label label8;
        private ComboBox comboBoxDistrict;
        private Label label9;
        private ComboBox comboBox1;
    }
}