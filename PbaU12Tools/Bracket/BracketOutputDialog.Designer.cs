namespace PbaU12Tools.Bracket
{
    partial class BracketOutputDialog
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
            groupBoxPurpose = new GroupBox();
            panelPurposeVenueAndMatchOrder = new Panel();
            checkBoxDistrict = new CheckBox();
            checkBoxOpen = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            radioButtonPurposeVenueAndMatchOrder = new RadioButton();
            radioButtonPurposeForRaffle = new RadioButton();
            buttonOutput = new Button();
            groupBoxPurpose.SuspendLayout();
            panelPurposeVenueAndMatchOrder.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPurpose
            // 
            groupBoxPurpose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPurpose.Controls.Add(panelPurposeVenueAndMatchOrder);
            groupBoxPurpose.Controls.Add(label2);
            groupBoxPurpose.Controls.Add(label1);
            groupBoxPurpose.Controls.Add(radioButtonPurposeVenueAndMatchOrder);
            groupBoxPurpose.Controls.Add(radioButtonPurposeForRaffle);
            groupBoxPurpose.Location = new Point(12, 12);
            groupBoxPurpose.Name = "groupBoxPurpose";
            groupBoxPurpose.Size = new Size(414, 136);
            groupBoxPurpose.TabIndex = 0;
            groupBoxPurpose.TabStop = false;
            groupBoxPurpose.Text = "用途";
            // 
            // panelPurposeVenueAndMatchOrder
            // 
            panelPurposeVenueAndMatchOrder.Controls.Add(checkBoxDistrict);
            panelPurposeVenueAndMatchOrder.Controls.Add(checkBoxOpen);
            panelPurposeVenueAndMatchOrder.Enabled = false;
            panelPurposeVenueAndMatchOrder.Location = new Point(34, 72);
            panelPurposeVenueAndMatchOrder.Name = "panelPurposeVenueAndMatchOrder";
            panelPurposeVenueAndMatchOrder.Size = new Size(277, 56);
            panelPurposeVenueAndMatchOrder.TabIndex = 3;
            // 
            // checkBoxDistrict
            // 
            checkBoxDistrict.AutoSize = true;
            checkBoxDistrict.Location = new Point(6, 31);
            checkBoxDistrict.Name = "checkBoxDistrict";
            checkBoxDistrict.Size = new Size(133, 19);
            checkBoxDistrict.TabIndex = 3;
            checkBoxDistrict.Text = "地区名の枠を作る(&D)";
            checkBoxDistrict.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpen
            // 
            checkBoxOpen.AutoSize = true;
            checkBoxOpen.Checked = true;
            checkBoxOpen.CheckState = CheckState.Checked;
            checkBoxOpen.Location = new Point(6, 6);
            checkBoxOpen.Name = "checkBoxOpen";
            checkBoxOpen.Size = new Size(206, 19);
            checkBoxOpen.TabIndex = 2;
            checkBoxOpen.Text = "TO/オープン参加等表示枠を作る(&O)";
            checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(178, 49);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 2;
            label2.Text = "⇦　抽選結果反映後に競技部へ提供";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(126, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 1;
            label1.Text = "⇦　抽選会前に競技部へ提供";
            // 
            // radioButtonPurposeVenueAndMatchOrder
            // 
            radioButtonPurposeVenueAndMatchOrder.AutoSize = true;
            radioButtonPurposeVenueAndMatchOrder.Location = new Point(18, 47);
            radioButtonPurposeVenueAndMatchOrder.Name = "radioButtonPurposeVenueAndMatchOrder";
            radioButtonPurposeVenueAndMatchOrder.Size = new Size(145, 19);
            radioButtonPurposeVenueAndMatchOrder.TabIndex = 1;
            radioButtonPurposeVenueAndMatchOrder.TabStop = true;
            radioButtonPurposeVenueAndMatchOrder.Text = "会場・試合順調整用(&A)";
            radioButtonPurposeVenueAndMatchOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonPurposeForRaffle
            // 
            radioButtonPurposeForRaffle.AutoSize = true;
            radioButtonPurposeForRaffle.Location = new Point(18, 22);
            radioButtonPurposeForRaffle.Name = "radioButtonPurposeForRaffle";
            radioButtonPurposeForRaffle.Size = new Size(91, 19);
            radioButtonPurposeForRaffle.TabIndex = 0;
            radioButtonPurposeForRaffle.TabStop = true;
            radioButtonPurposeForRaffle.Text = "抽選会用(&R)";
            radioButtonPurposeForRaffle.UseVisualStyleBackColor = true;
            radioButtonPurposeForRaffle.CheckedChanged += radioButtonPurpose_CheckedChanged;
            // 
            // buttonOutput
            // 
            buttonOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOutput.Location = new Point(12, 160);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(414, 23);
            buttonOutput.TabIndex = 1;
            buttonOutput.Text = "出力(&F)";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // BracketOutputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 195);
            Controls.Add(buttonOutput);
            Controls.Add(groupBoxPurpose);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BracketOutputDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "トーナメント表出力";
            Load += BracketOutputDialog_Load;
            groupBoxPurpose.ResumeLayout(false);
            groupBoxPurpose.PerformLayout();
            panelPurposeVenueAndMatchOrder.ResumeLayout(false);
            panelPurposeVenueAndMatchOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPurpose;
        private RadioButton radioButtonPurposeVenueAndMatchOrder;
        private RadioButton radioButtonPurposeForRaffle;
        private Label label1;
        private Button buttonOutput;
        private Label label2;
        private Panel panelPurposeVenueAndMatchOrder;
        private CheckBox checkBoxDistrict;
        private CheckBox checkBoxOpen;
    }
}