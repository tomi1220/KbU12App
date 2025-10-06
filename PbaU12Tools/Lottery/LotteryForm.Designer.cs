namespace PbaU12Tools.Lottery
{
    partial class LotteryForm
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
            tabControl1 = new TabControl();
            tabPageBoys = new TabPage();
            tabPageGirls = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            listViewLotteryResult = new ListView();
            columnNumberBoys = new ColumnHeader();
            columnTeamBoys = new ColumnHeader();
            splitContainer1 = new SplitContainer();
            tabControl1.SuspendLayout();
            tabPageBoys.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBoys);
            tabControl1.Controls.Add(tabPageGirls);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(316, 503);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBoys
            // 
            tabPageBoys.Controls.Add(splitContainer1);
            tabPageBoys.Controls.Add(listViewLotteryResult);
            tabPageBoys.Location = new Point(4, 24);
            tabPageBoys.Name = "tabPageBoys";
            tabPageBoys.Padding = new Padding(3);
            tabPageBoys.Size = new Size(308, 475);
            tabPageBoys.TabIndex = 0;
            tabPageBoys.Text = "男子";
            tabPageBoys.UseVisualStyleBackColor = true;
            // 
            // tabPageGirls
            // 
            tabPageGirls.Location = new Point(4, 24);
            tabPageGirls.Name = "tabPageGirls";
            tabPageGirls.Padding = new Padding(3);
            tabPageGirls.Size = new Size(308, 504);
            tabPageGirls.TabIndex = 1;
            tabPageGirls.Text = "女子";
            tabPageGirls.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 29);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(148, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(232, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listViewLotteryResult
            // 
            listViewLotteryResult.Columns.AddRange(new ColumnHeader[] { columnNumberBoys, columnTeamBoys });
            listViewLotteryResult.Location = new Point(191, 12);
            listViewLotteryResult.Name = "listViewLotteryResult";
            listViewLotteryResult.Size = new Size(121, 463);
            listViewLotteryResult.TabIndex = 0;
            listViewLotteryResult.UseCompatibleStateImageBehavior = false;
            listViewLotteryResult.View = View.Details;
            // 
            // columnNumberBoys
            // 
            columnNumberBoys.Text = "№";
            // 
            // columnTeamBoys
            // 
            columnTeamBoys.Text = "チーム名";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(97, 165);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 1;
            // 
            // LotteryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 532);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "LotteryForm";
            Text = "組合せ抽選";
            tabControl1.ResumeLayout(false);
            tabPageBoys.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBoys;
        private TabPage tabPageGirls;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private ImageList imageList1;
        private ListView listViewLotteryResult;
        private ColumnHeader columnNumberBoys;
        private ColumnHeader columnTeamBoys;
        private SplitContainer splitContainer1;
    }
}