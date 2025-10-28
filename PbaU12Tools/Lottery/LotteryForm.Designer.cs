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
            lotteryResultCtrlBoys = new PbaU12Tools.ControlEx.LotteryResultCtrl();
            tabPageGirls = new TabPage();
            lotteryResultCtrlGirls = new PbaU12Tools.ControlEx.LotteryResultCtrl();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPageBoys.SuspendLayout();
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
            tabPageBoys.Controls.Add(lotteryResultCtrlBoys);
            tabPageBoys.Location = new Point(4, 24);
            tabPageBoys.Name = "tabPageBoys";
            tabPageBoys.Padding = new Padding(3);
            tabPageBoys.Size = new Size(401, 475);
            tabPageBoys.TabIndex = 0;
            tabPageBoys.Text = "男子";
            tabPageBoys.UseVisualStyleBackColor = true;
            // 
            // lotteryResultCtrlBoys
            // 
            lotteryResultCtrlBoys.BackColor = Color.Transparent;
            lotteryResultCtrlBoys.Category = Categories.Unknown;
            lotteryResultCtrlBoys.Dock = DockStyle.Fill;
            lotteryResultCtrlBoys.Location = new Point(3, 3);
            lotteryResultCtrlBoys.Name = "lotteryResultCtrlBoys";
            lotteryResultCtrlBoys.Size = new Size(395, 469);
            lotteryResultCtrlBoys.TabIndex = 0;
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 29);
            panel1.TabIndex = 1;
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
            button1.Click += button1_Click;
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
            tabPageGirls.ResumeLayout(false);
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
        private ControlEx.LotteryResultCtrl lotteryResultCtrlGirls;
        private ControlEx.LotteryResultCtrl lotteryResultCtrlBoys;
    }
}