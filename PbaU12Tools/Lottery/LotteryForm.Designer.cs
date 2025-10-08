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
            panelDnDTeamBoys = new Panel();
            tableLayoutPanelLotteryBoys = new TableLayoutPanel();
            panel4 = new Panel();
            listViewDndLotteryNumberBoys = new ListView();
            columnDnDLotteryNumberBoys = new ColumnHeader();
            labelLotteryNumberBoys = new Label();
            panel2 = new Panel();
            listViewDnDTeamsBoys = new ListView();
            columnDnDTeamBoys = new ColumnHeader();
            columnDnDLotteryResultBoys = new ColumnHeader();
            panel3 = new Panel();
            buttonDeleteBoys = new Button();
            buttonAddBoys = new Button();
            panelDirectInputBoys = new Panel();
            listViewDiTeamsBoys = new ListView();
            columnLotteryNumberBoys = new ColumnHeader();
            columnTeamNameBoys = new ColumnHeader();
            tabPageGirls = new TabPage();
            lotteryResultCtrlGirls = new PbaU12Tools.ControlEx.LotteryResultCtrl();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            label1 = new Label();
            comboBoxInputMode = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPageBoys.SuspendLayout();
            panelDnDTeamBoys.SuspendLayout();
            tableLayoutPanelLotteryBoys.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelDirectInputBoys.SuspendLayout();
            tabPageGirls.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageBoys);
            tabControl1.Controls.Add(tabPageGirls);
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(409, 503);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBoys
            // 
            tabPageBoys.Controls.Add(panelDnDTeamBoys);
            tabPageBoys.Controls.Add(panelDirectInputBoys);
            tabPageBoys.Location = new Point(4, 24);
            tabPageBoys.Name = "tabPageBoys";
            tabPageBoys.Padding = new Padding(3);
            tabPageBoys.Size = new Size(401, 475);
            tabPageBoys.TabIndex = 0;
            tabPageBoys.Text = "男子";
            tabPageBoys.UseVisualStyleBackColor = true;
            // 
            // panelDnDTeamBoys
            // 
            panelDnDTeamBoys.Controls.Add(tableLayoutPanelLotteryBoys);
            panelDnDTeamBoys.Location = new Point(3, 6);
            panelDnDTeamBoys.Name = "panelDnDTeamBoys";
            panelDnDTeamBoys.Size = new Size(380, 390);
            panelDnDTeamBoys.TabIndex = 3;
            // 
            // tableLayoutPanelLotteryBoys
            // 
            tableLayoutPanelLotteryBoys.ColumnCount = 3;
            tableLayoutPanelLotteryBoys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelLotteryBoys.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanelLotteryBoys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelLotteryBoys.Controls.Add(panel4, 2, 0);
            tableLayoutPanelLotteryBoys.Controls.Add(panel2, 0, 0);
            tableLayoutPanelLotteryBoys.Controls.Add(panel3, 1, 0);
            tableLayoutPanelLotteryBoys.Dock = DockStyle.Fill;
            tableLayoutPanelLotteryBoys.Location = new Point(0, 0);
            tableLayoutPanelLotteryBoys.Name = "tableLayoutPanelLotteryBoys";
            tableLayoutPanelLotteryBoys.RowCount = 1;
            tableLayoutPanelLotteryBoys.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLotteryBoys.Size = new Size(380, 390);
            tableLayoutPanelLotteryBoys.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(listViewDndLotteryNumberBoys);
            panel4.Controls.Add(labelLotteryNumberBoys);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(281, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(6);
            panel4.Size = new Size(96, 384);
            panel4.TabIndex = 2;
            // 
            // listViewDndLotteryNumberBoys
            // 
            listViewDndLotteryNumberBoys.Columns.AddRange(new ColumnHeader[] { columnDnDLotteryNumberBoys });
            listViewDndLotteryNumberBoys.Dock = DockStyle.Fill;
            listViewDndLotteryNumberBoys.FullRowSelect = true;
            listViewDndLotteryNumberBoys.GridLines = true;
            listViewDndLotteryNumberBoys.Location = new Point(6, 49);
            listViewDndLotteryNumberBoys.MultiSelect = false;
            listViewDndLotteryNumberBoys.Name = "listViewDndLotteryNumberBoys";
            listViewDndLotteryNumberBoys.Size = new Size(84, 329);
            listViewDndLotteryNumberBoys.TabIndex = 0;
            listViewDndLotteryNumberBoys.UseCompatibleStateImageBehavior = false;
            listViewDndLotteryNumberBoys.View = View.Details;
            listViewDndLotteryNumberBoys.ItemDrag += listViewDndLotteryNumber_ItemDrag;
            listViewDndLotteryNumberBoys.ItemSelectionChanged += listViewDndLotteryNumber_ItemSelectionChanged;
            // 
            // columnDnDLotteryNumberBoys
            // 
            columnDnDLotteryNumberBoys.Text = "抽選番号";
            // 
            // labelLotteryNumberBoys
            // 
            labelLotteryNumberBoys.BorderStyle = BorderStyle.FixedSingle;
            labelLotteryNumberBoys.Dock = DockStyle.Top;
            labelLotteryNumberBoys.Font = new Font("Meiryo UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelLotteryNumberBoys.Location = new Point(6, 6);
            labelLotteryNumberBoys.Name = "labelLotteryNumberBoys";
            labelLotteryNumberBoys.Size = new Size(84, 43);
            labelLotteryNumberBoys.TabIndex = 2;
            labelLotteryNumberBoys.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewDnDTeamsBoys);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(229, 384);
            panel2.TabIndex = 0;
            // 
            // listViewDnDTeamsBoys
            // 
            listViewDnDTeamsBoys.Activation = ItemActivation.OneClick;
            listViewDnDTeamsBoys.AllowDrop = true;
            listViewDnDTeamsBoys.Columns.AddRange(new ColumnHeader[] { columnDnDTeamBoys, columnDnDLotteryResultBoys });
            listViewDnDTeamsBoys.Dock = DockStyle.Fill;
            listViewDnDTeamsBoys.FullRowSelect = true;
            listViewDnDTeamsBoys.GridLines = true;
            listViewDnDTeamsBoys.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewDnDTeamsBoys.Location = new Point(6, 6);
            listViewDnDTeamsBoys.MultiSelect = false;
            listViewDnDTeamsBoys.Name = "listViewDnDTeamsBoys";
            listViewDnDTeamsBoys.Size = new Size(217, 372);
            listViewDnDTeamsBoys.TabIndex = 0;
            listViewDnDTeamsBoys.UseCompatibleStateImageBehavior = false;
            listViewDnDTeamsBoys.View = View.Details;
            listViewDnDTeamsBoys.DragDrop += listViewDnDTeams_DragDrop;
            listViewDnDTeamsBoys.DragEnter += listViewDnDTeams_DragEnter;
            listViewDnDTeamsBoys.DragOver += listViewDnDTeams_DragOver;
            listViewDnDTeamsBoys.DoubleClick += listViewDnDTeamsBoys_DoubleClick;
            // 
            // columnDnDTeamBoys
            // 
            columnDnDTeamBoys.Text = "チーム名";
            columnDnDTeamBoys.Width = 140;
            // 
            // columnDnDLotteryResultBoys
            // 
            columnDnDLotteryResultBoys.Text = "抽選番号";
            columnDnDLotteryResultBoys.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonDeleteBoys);
            panel3.Controls.Add(buttonAddBoys);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(238, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(37, 384);
            panel3.TabIndex = 3;
            // 
            // buttonDeleteBoys
            // 
            buttonDeleteBoys.Location = new Point(3, 35);
            buttonDeleteBoys.Name = "buttonDeleteBoys";
            buttonDeleteBoys.Size = new Size(31, 23);
            buttonDeleteBoys.TabIndex = 1;
            buttonDeleteBoys.Text = "&>";
            buttonDeleteBoys.UseVisualStyleBackColor = true;
            // 
            // buttonAddBoys
            // 
            buttonAddBoys.Location = new Point(3, 6);
            buttonAddBoys.Name = "buttonAddBoys";
            buttonAddBoys.Size = new Size(31, 23);
            buttonAddBoys.TabIndex = 0;
            buttonAddBoys.Text = "&<";
            buttonAddBoys.UseVisualStyleBackColor = true;
            // 
            // panelDirectInputBoys
            // 
            panelDirectInputBoys.Controls.Add(listViewDiTeamsBoys);
            panelDirectInputBoys.Location = new Point(180, 144);
            panelDirectInputBoys.Name = "panelDirectInputBoys";
            panelDirectInputBoys.Padding = new Padding(6);
            panelDirectInputBoys.Size = new Size(200, 325);
            panelDirectInputBoys.TabIndex = 2;
            // 
            // listViewDiTeamsBoys
            // 
            listViewDiTeamsBoys.Columns.AddRange(new ColumnHeader[] { columnLotteryNumberBoys, columnTeamNameBoys });
            listViewDiTeamsBoys.Dock = DockStyle.Fill;
            listViewDiTeamsBoys.FullRowSelect = true;
            listViewDiTeamsBoys.GridLines = true;
            listViewDiTeamsBoys.LabelEdit = true;
            listViewDiTeamsBoys.Location = new Point(6, 6);
            listViewDiTeamsBoys.Name = "listViewDiTeamsBoys";
            listViewDiTeamsBoys.Size = new Size(188, 313);
            listViewDiTeamsBoys.TabIndex = 1;
            listViewDiTeamsBoys.UseCompatibleStateImageBehavior = false;
            listViewDiTeamsBoys.View = View.Details;
            // 
            // columnLotteryNumberBoys
            // 
            columnLotteryNumberBoys.Text = "抽選番号";
            // 
            // columnTeamNameBoys
            // 
            columnTeamNameBoys.Text = "チーム名";
            // 
            // tabPageGirls
            // 
            tabPageGirls.Controls.Add(lotteryResultCtrlGirls);
            tabPageGirls.Location = new Point(4, 24);
            tabPageGirls.Name = "tabPageGirls";
            tabPageGirls.Padding = new Padding(3);
            tabPageGirls.Size = new Size(401, 475);
            tabPageGirls.TabIndex = 1;
            tabPageGirls.Text = "女子";
            tabPageGirls.UseVisualStyleBackColor = true;
            // 
            // lotteryResultCtrlGirls
            // 
            lotteryResultCtrlGirls.BackColor = Color.Transparent;
            lotteryResultCtrlGirls.Category = Categories.Unknown;
            lotteryResultCtrlGirls.Dock = DockStyle.Fill;
            lotteryResultCtrlGirls.Location = new Point(3, 3);
            lotteryResultCtrlGirls.Name = "lotteryResultCtrlGirls";
            lotteryResultCtrlGirls.Size = new Size(395, 469);
            lotteryResultCtrlGirls.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxInputMode);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 29);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "入力モード(&I):";
            // 
            // comboBoxInputMode
            // 
            comboBoxInputMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInputMode.FormattingEnabled = true;
            comboBoxInputMode.Location = new Point(91, 4);
            comboBoxInputMode.Name = "comboBoxInputMode";
            comboBoxInputMode.Size = new Size(102, 23);
            comboBoxInputMode.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(325, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(241, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // LotteryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 532);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "LotteryForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "組合せ抽選";
            Load += LotteryForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageBoys.ResumeLayout(false);
            panelDnDTeamBoys.ResumeLayout(false);
            tableLayoutPanelLotteryBoys.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelDirectInputBoys.ResumeLayout(false);
            tabPageGirls.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private ListView listViewDiTeamsBoys;
        private ColumnHeader columnTeamNameBoys;
        private ColumnHeader columnLotteryNumberBoys;
        private Panel panelDirectInputBoys;
        private ComboBox comboBoxInputMode;
        private Panel panelDnDTeamBoys;
        private TableLayoutPanel tableLayoutPanelLotteryBoys;
        private Panel panel2;
        private ListView listViewDnDTeamsBoys;
        private Panel panel4;
        private ListView listViewDndLotteryNumberBoys;
        private Panel panel3;
        private Button buttonDeleteBoys;
        private Button buttonAddBoys;
        private ColumnHeader columnDnDTeamBoys;
        private ColumnHeader columnDnDLotteryResultBoys;
        private ColumnHeader columnDnDLotteryNumberBoys;
        private Label label1;
        private Label labelLotteryNumberBoys;
        private ControlEx.LotteryResultCtrl lotteryResultCtrlGirls;
    }
}