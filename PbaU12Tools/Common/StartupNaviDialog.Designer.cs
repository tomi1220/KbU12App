namespace PbaU12Tools.Common
{
    partial class StartupNaviDialog
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
            radioButtonPrevData = new RadioButton();
            radioButton1 = new RadioButton();
            textBoxPrevData = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // radioButtonPrevData
            // 
            radioButtonPrevData.AutoSize = true;
            radioButtonPrevData.Location = new Point(18, 18);
            radioButtonPrevData.Name = "radioButtonPrevData";
            radioButtonPrevData.Size = new Size(159, 19);
            radioButtonPrevData.TabIndex = 0;
            radioButtonPrevData.TabStop = true;
            radioButtonPrevData.Text = "前回処理したデータを開く(&P)";
            radioButtonPrevData.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(174, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "新しい大会データを作成する(&N)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxPrevData
            // 
            textBoxPrevData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrevData.BorderStyle = BorderStyle.None;
            textBoxPrevData.Location = new Point(33, 43);
            textBoxPrevData.Name = "textBoxPrevData";
            textBoxPrevData.ReadOnly = true;
            textBoxPrevData.Size = new Size(320, 16);
            textBoxPrevData.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(199, 113);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(290, 113);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // StartupNaviDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(377, 148);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxPrevData);
            Controls.Add(radioButton1);
            Controls.Add(radioButtonPrevData);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartupNaviDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "処理の選択";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonPrevData;
        private RadioButton radioButton1;
        private TextBox textBoxPrevData;
        private Button buttonOK;
        private Button buttonCancel;
    }
}