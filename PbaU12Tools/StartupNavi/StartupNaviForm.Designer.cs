namespace PbaU12Tools.StartupNavi
{
    partial class StartupNaviForm
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
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonOK = new Button();
            buttonNetTournamentData = new Button();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(6, 6);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(422, 364);
            treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonOK);
            panel1.Controls.Add(buttonNetTournamentData);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(6, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 35);
            panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(344, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(263, 8);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonNetTournamentData
            // 
            buttonNetTournamentData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonNetTournamentData.AutoSize = true;
            buttonNetTournamentData.Location = new Point(3, 7);
            buttonNetTournamentData.Name = "buttonNetTournamentData";
            buttonNetTournamentData.Size = new Size(127, 25);
            buttonNetTournamentData.TabIndex = 0;
            buttonNetTournamentData.Text = "新しい大会情報(&N)...";
            buttonNetTournamentData.UseVisualStyleBackColor = true;
            buttonNetTournamentData.Click += buttonNetTournamentData_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // StartupNaviForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(434, 411);
            Controls.Add(treeView1);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(330, 330);
            Name = "StartupNaviForm";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "スタートアップ・ナビ - ";
            Load += StartupNaviForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Panel panel1;
        private Button buttonNetTournamentData;
        private Button buttonCancel;
        private Button buttonOK;
        private ImageList imageList1;
    }
}