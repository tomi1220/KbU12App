namespace PbaU12Tools.Settings
{
    partial class SettingsVenueDialog
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
            numericUpDownNumberOfCourts = new NumericUpDown();
            buttonOK = new Button();
            textBoxVenueName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfCourts).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(367, 48);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // numericUpDownNumberOfCourts
            // 
            numericUpDownNumberOfCourts.Location = new Point(100, 50);
            numericUpDownNumberOfCourts.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownNumberOfCourts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumberOfCourts.Name = "numericUpDownNumberOfCourts";
            numericUpDownNumberOfCourts.Size = new Size(37, 23);
            numericUpDownNumberOfCourts.TabIndex = 3;
            numericUpDownNumberOfCourts.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumberOfCourts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(286, 48);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxVenueName
            // 
            textBoxVenueName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVenueName.ImeMode = ImeMode.On;
            textBoxVenueName.Location = new Point(85, 12);
            textBoxVenueName.Name = "textBoxVenueName";
            textBoxVenueName.Size = new Size(357, 23);
            textBoxVenueName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "会場名(&N):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "コート数(&C):";
            // 
            // SettingsVenueDialog
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(454, 83);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownNumberOfCourts);
            Controls.Add(buttonOK);
            Controls.Add(textBoxVenueName);
            Controls.Add(label1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "SettingsVenueDialog";
            Text = "［会場］のプロパティ";
            Load += SettingsVenueDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfCourts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private NumericUpDown numericUpDownNumberOfCourts;
        private Button buttonOK;
        private TextBox textBoxVenueName;
        private Label label1;
        private Label label2;
    }
}