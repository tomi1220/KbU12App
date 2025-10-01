namespace PbaU12Tools.ControlEx
{
    partial class NumOfTeamsCtrl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxTeams = new CheckBox();
            groupBoxTeams = new GroupBox();
            checkBoxFinalLeague = new CheckBox();
            numericUpDownSuperSeed = new NumericUpDown();
            labelNumOfSuperSeed = new Label();
            numericUpDownNumberOfTeams = new NumericUpDown();
            labelNumOfTeams = new Label();
            groupBoxTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeams).BeginInit();
            SuspendLayout();
            // 
            // checkBoxTeams
            // 
            checkBoxTeams.Location = new Point(16, 3);
            checkBoxTeams.Name = "checkBoxTeams";
            checkBoxTeams.Size = new Size(88, 27);
            checkBoxTeams.TabIndex = 2;
            checkBoxTeams.Text = "不明(&U)";
            checkBoxTeams.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBoxTeams.UseVisualStyleBackColor = true;
            checkBoxTeams.CheckedChanged += checkBoxTeams_CheckedChanged;
            // 
            // groupBoxTeams
            // 
            groupBoxTeams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTeams.Controls.Add(checkBoxFinalLeague);
            groupBoxTeams.Controls.Add(numericUpDownSuperSeed);
            groupBoxTeams.Controls.Add(labelNumOfSuperSeed);
            groupBoxTeams.Controls.Add(numericUpDownNumberOfTeams);
            groupBoxTeams.Controls.Add(labelNumOfTeams);
            groupBoxTeams.Enabled = false;
            groupBoxTeams.Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBoxTeams.Location = new Point(9, 6);
            groupBoxTeams.Name = "groupBoxTeams";
            groupBoxTeams.Size = new Size(252, 112);
            groupBoxTeams.TabIndex = 3;
            groupBoxTeams.TabStop = false;
            // 
            // checkBoxFinalLeague
            // 
            checkBoxFinalLeague.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxFinalLeague.AutoSize = true;
            checkBoxFinalLeague.Enabled = false;
            checkBoxFinalLeague.Location = new Point(37, 82);
            checkBoxFinalLeague.Name = "checkBoxFinalLeague";
            checkBoxFinalLeague.Size = new Size(93, 19);
            checkBoxFinalLeague.TabIndex = 5;
            checkBoxFinalLeague.Text = "決勝リーグ(&0)";
            checkBoxFinalLeague.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSuperSeed
            // 
            numericUpDownSuperSeed.Enabled = false;
            numericUpDownSuperSeed.Location = new Point(186, 56);
            numericUpDownSuperSeed.Name = "numericUpDownSuperSeed";
            numericUpDownSuperSeed.Size = new Size(36, 23);
            numericUpDownSuperSeed.TabIndex = 4;
            numericUpDownSuperSeed.TextAlign = HorizontalAlignment.Right;
            // 
            // labelNumOfSuperSeed
            // 
            labelNumOfSuperSeed.AutoSize = true;
            labelNumOfSuperSeed.Enabled = false;
            labelNumOfSuperSeed.Location = new Point(37, 58);
            labelNumOfSuperSeed.Name = "labelNumOfSuperSeed";
            labelNumOfSuperSeed.Size = new Size(143, 15);
            labelNumOfSuperSeed.TabIndex = 3;
            labelNumOfSuperSeed.Text = "スーパーシード・チーム数(&0):";
            // 
            // numericUpDownNumberOfTeams
            // 
            numericUpDownNumberOfTeams.Location = new Point(120, 25);
            numericUpDownNumberOfTeams.Name = "numericUpDownNumberOfTeams";
            numericUpDownNumberOfTeams.Size = new Size(46, 23);
            numericUpDownNumberOfTeams.TabIndex = 1;
            numericUpDownNumberOfTeams.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumberOfTeams.ValueChanged += numericUpDownNumberOfTeams_ValueChanged;
            // 
            // labelNumOfTeams
            // 
            labelNumOfTeams.AutoSize = true;
            labelNumOfTeams.Location = new Point(20, 27);
            labelNumOfTeams.Name = "labelNumOfTeams";
            labelNumOfTeams.Size = new Size(94, 15);
            labelNumOfTeams.TabIndex = 0;
            labelNumOfTeams.Text = "出場チーム数(&0):";
            // 
            // NumOfTeamsCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBoxTeams);
            Controls.Add(groupBoxTeams);
            MinimumSize = new Size(270, 127);
            Name = "NumOfTeamsCtrl";
            Padding = new Padding(6, 0, 6, 6);
            Size = new Size(270, 127);
            groupBoxTeams.ResumeLayout(false);
            groupBoxTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuperSeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfTeams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBoxTeams;
        private GroupBox groupBoxTeams;
        private NumericUpDown numericUpDownSuperSeed;
        private Label labelNumOfSuperSeed;
        private NumericUpDown numericUpDownNumberOfTeams;
        private Label labelNumOfTeams;
        private CheckBox checkBoxFinalLeague;
    }
}
