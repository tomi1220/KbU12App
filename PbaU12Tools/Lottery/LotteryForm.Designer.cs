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
            splitContainerLotteryBoys = new SplitContainer();
            listViewLotteryResultBoys = new ListView();
            columnNumberBoys = new ColumnHeader();
            columnTeamBoys = new ColumnHeader();
            listViewTeamsBoys = new ListView();
            columnTeamListNameBoys = new ColumnHeader();
            tabPageGirls = new TabPage();
            splitContainerLotteryGirls = new SplitContainer();
            listViewLotteryResultGirls = new ListView();
            columnNumberGirls = new ColumnHeader();
            columnTeamGirls = new ColumnHeader();
            listViewTeamsGirls = new ListView();
            columnHeader3 = new ColumnHeader();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPageBoys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLotteryBoys).BeginInit();
            splitContainerLotteryBoys.Panel1.SuspendLayout();
            splitContainerLotteryBoys.Panel2.SuspendLayout();
            splitContainerLotteryBoys.SuspendLayout();
            tabPageGirls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLotteryGirls).BeginInit();
            splitContainerLotteryGirls.Panel1.SuspendLayout();
            splitContainerLotteryGirls.Panel2.SuspendLayout();
            splitContainerLotteryGirls.SuspendLayout();
            panel1.SuspendLayout();
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
            tabControl1.Size = new Size(542, 503);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBoys
            // 
            tabPageBoys.Controls.Add(splitContainerLotteryBoys);
            tabPageBoys.Location = new Point(4, 24);
            tabPageBoys.Name = "tabPageBoys";
            tabPageBoys.Padding = new Padding(3);
            tabPageBoys.Size = new Size(534, 475);
            tabPageBoys.TabIndex = 0;
            tabPageBoys.Text = "男子";
            tabPageBoys.UseVisualStyleBackColor = true;
            // 
            // splitContainerLotteryBoys
            // 
            splitContainerLotteryBoys.Dock = DockStyle.Fill;
            splitContainerLotteryBoys.Location = new Point(3, 3);
            splitContainerLotteryBoys.Name = "splitContainerLotteryBoys";
            // 
            // splitContainerLotteryBoys.Panel1
            // 
            splitContainerLotteryBoys.Panel1.Controls.Add(listViewLotteryResultBoys);
            // 
            // splitContainerLotteryBoys.Panel2
            // 
            splitContainerLotteryBoys.Panel2.Controls.Add(listViewTeamsBoys);
            splitContainerLotteryBoys.Size = new Size(528, 469);
            splitContainerLotteryBoys.SplitterDistance = 316;
            splitContainerLotteryBoys.TabIndex = 1;
            // 
            // listViewLotteryResultBoys
            // 
            listViewLotteryResultBoys.Columns.AddRange(new ColumnHeader[] { columnNumberBoys, columnTeamBoys });
            listViewLotteryResultBoys.Dock = DockStyle.Fill;
            listViewLotteryResultBoys.Location = new Point(0, 0);
            listViewLotteryResultBoys.Name = "listViewLotteryResultBoys";
            listViewLotteryResultBoys.Size = new Size(316, 469);
            listViewLotteryResultBoys.TabIndex = 0;
            listViewLotteryResultBoys.UseCompatibleStateImageBehavior = false;
            listViewLotteryResultBoys.View = View.Details;
            // 
            // columnNumberBoys
            // 
            columnNumberBoys.Text = "№";
            // 
            // columnTeamBoys
            // 
            columnTeamBoys.Text = "チーム名";
            // 
            // listViewTeamsBoys
            // 
            listViewTeamsBoys.Columns.AddRange(new ColumnHeader[] { columnTeamListNameBoys });
            listViewTeamsBoys.Dock = DockStyle.Fill;
            listViewTeamsBoys.Location = new Point(0, 0);
            listViewTeamsBoys.Name = "listViewTeamsBoys";
            listViewTeamsBoys.Size = new Size(208, 469);
            listViewTeamsBoys.TabIndex = 1;
            listViewTeamsBoys.UseCompatibleStateImageBehavior = false;
            listViewTeamsBoys.View = View.Details;
            // 
            // columnTeamListNameBoys
            // 
            columnTeamListNameBoys.Text = "チーム名";
            // 
            // tabPageGirls
            // 
            tabPageGirls.Controls.Add(splitContainerLotteryGirls);
            tabPageGirls.Location = new Point(4, 24);
            tabPageGirls.Name = "tabPageGirls";
            tabPageGirls.Padding = new Padding(3);
            tabPageGirls.Size = new Size(534, 475);
            tabPageGirls.TabIndex = 1;
            tabPageGirls.Text = "女子";
            tabPageGirls.UseVisualStyleBackColor = true;
            // 
            // splitContainerLotteryGirls
            // 
            splitContainerLotteryGirls.Dock = DockStyle.Fill;
            splitContainerLotteryGirls.Location = new Point(3, 3);
            splitContainerLotteryGirls.Name = "splitContainerLotteryGirls";
            // 
            // splitContainerLotteryGirls.Panel1
            // 
            splitContainerLotteryGirls.Panel1.Controls.Add(listViewLotteryResultGirls);
            // 
            // splitContainerLotteryGirls.Panel2
            // 
            splitContainerLotteryGirls.Panel2.Controls.Add(listViewTeamsGirls);
            splitContainerLotteryGirls.Size = new Size(528, 469);
            splitContainerLotteryGirls.SplitterDistance = 316;
            splitContainerLotteryGirls.TabIndex = 2;
            // 
            // listViewLotteryResultGirls
            // 
            listViewLotteryResultGirls.Columns.AddRange(new ColumnHeader[] { columnNumberGirls, columnTeamGirls });
            listViewLotteryResultGirls.Dock = DockStyle.Fill;
            listViewLotteryResultGirls.Location = new Point(0, 0);
            listViewLotteryResultGirls.Name = "listViewLotteryResultGirls";
            listViewLotteryResultGirls.Size = new Size(316, 469);
            listViewLotteryResultGirls.TabIndex = 0;
            listViewLotteryResultGirls.UseCompatibleStateImageBehavior = false;
            listViewLotteryResultGirls.View = View.Details;
            // 
            // columnNumberGirls
            // 
            columnNumberGirls.Text = "№";
            // 
            // columnTeamGirls
            // 
            columnTeamGirls.Text = "チーム名";
            // 
            // listViewTeamsGirls
            // 
            listViewTeamsGirls.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            listViewTeamsGirls.Dock = DockStyle.Fill;
            listViewTeamsGirls.Location = new Point(0, 0);
            listViewTeamsGirls.Name = "listViewTeamsGirls";
            listViewTeamsGirls.Size = new Size(208, 469);
            listViewTeamsGirls.TabIndex = 1;
            listViewTeamsGirls.UseCompatibleStateImageBehavior = false;
            listViewTeamsGirls.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "チーム名";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 29);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(458, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(374, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // LotteryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 532);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "LotteryForm";
            Text = "組合せ抽選";
            Load += LotteryForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageBoys.ResumeLayout(false);
            splitContainerLotteryBoys.Panel1.ResumeLayout(false);
            splitContainerLotteryBoys.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLotteryBoys).EndInit();
            splitContainerLotteryBoys.ResumeLayout(false);
            tabPageGirls.ResumeLayout(false);
            splitContainerLotteryGirls.Panel1.ResumeLayout(false);
            splitContainerLotteryGirls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLotteryGirls).EndInit();
            splitContainerLotteryGirls.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private ListView listViewLotteryResultBoys;
        private ColumnHeader columnNumberBoys;
        private ColumnHeader columnTeamBoys;
        private SplitContainer splitContainerLotteryBoys;
        private ListView listViewTeamsBoys;
        private ColumnHeader columnTeamListNameBoys;
        private SplitContainer splitContainerLotteryGirls;
        private ListView listViewLotteryResultGirls;
        private ColumnHeader columnNumberGirls;
        private ColumnHeader columnTeamGirls;
        private ListView listViewTeamsGirls;
        private ColumnHeader columnHeader3;
    }
}