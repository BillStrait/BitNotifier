namespace BLNotifications
{
    partial class BitNotifier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitNotifier));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMtGoxLast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMtGoxHigh = new System.Windows.Forms.Label();
            this.lblMtGoxLow = new System.Windows.Forms.Label();
            this.lblMtGoxAvg = new System.Windows.Forms.Label();
            this.lblMtGoxSell = new System.Windows.Forms.Label();
            this.lblMtGoxBuy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMtGoxVol = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCalcDollarTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCalcBtcTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCalcFees = new System.Windows.Forms.ComboBox();
            this.txtCalcBreakShort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCalcBreakSell = new System.Windows.Forms.TextBox();
            this.txtCalcUFees = new System.Windows.Forms.TextBox();
            this.txtCalcBFees = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCalcSpend = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCalcLatest = new System.Windows.Forms.CheckBox();
            this.txtCalcUSD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalcBtc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Waiting for response";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lblMtGoxLast
            // 
            this.lblMtGoxLast.AutoSize = true;
            this.lblMtGoxLast.Location = new System.Drawing.Point(92, 21);
            this.lblMtGoxLast.Name = "lblMtGoxLast";
            this.lblMtGoxLast.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxLast.TabIndex = 1;
            this.lblMtGoxLast.Text = "Waiting for Response";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "High:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Low:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sell Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Buy Price:";
            // 
            // lblMtGoxHigh
            // 
            this.lblMtGoxHigh.AutoSize = true;
            this.lblMtGoxHigh.Location = new System.Drawing.Point(92, 62);
            this.lblMtGoxHigh.Name = "lblMtGoxHigh";
            this.lblMtGoxHigh.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxHigh.TabIndex = 8;
            this.lblMtGoxHigh.Text = "Waiting for Response";
            // 
            // lblMtGoxLow
            // 
            this.lblMtGoxLow.AutoSize = true;
            this.lblMtGoxLow.Location = new System.Drawing.Point(92, 103);
            this.lblMtGoxLow.Name = "lblMtGoxLow";
            this.lblMtGoxLow.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxLow.TabIndex = 9;
            this.lblMtGoxLow.Text = "Waiting for Response";
            // 
            // lblMtGoxAvg
            // 
            this.lblMtGoxAvg.AutoSize = true;
            this.lblMtGoxAvg.Location = new System.Drawing.Point(92, 144);
            this.lblMtGoxAvg.Name = "lblMtGoxAvg";
            this.lblMtGoxAvg.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxAvg.TabIndex = 10;
            this.lblMtGoxAvg.Text = "Waiting for Response";
            // 
            // lblMtGoxSell
            // 
            this.lblMtGoxSell.AutoSize = true;
            this.lblMtGoxSell.Location = new System.Drawing.Point(92, 185);
            this.lblMtGoxSell.Name = "lblMtGoxSell";
            this.lblMtGoxSell.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxSell.TabIndex = 11;
            this.lblMtGoxSell.Text = "Waiting for Response";
            // 
            // lblMtGoxBuy
            // 
            this.lblMtGoxBuy.AutoSize = true;
            this.lblMtGoxBuy.Location = new System.Drawing.Point(92, 226);
            this.lblMtGoxBuy.Name = "lblMtGoxBuy";
            this.lblMtGoxBuy.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxBuy.TabIndex = 12;
            this.lblMtGoxBuy.Text = "Waiting for Response";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Volume:";
            // 
            // lblMtGoxVol
            // 
            this.lblMtGoxVol.AutoSize = true;
            this.lblMtGoxVol.Location = new System.Drawing.Point(92, 267);
            this.lblMtGoxVol.Name = "lblMtGoxVol";
            this.lblMtGoxVol.Size = new System.Drawing.Size(109, 13);
            this.lblMtGoxVol.TabIndex = 17;
            this.lblMtGoxVol.Text = "Waiting for Response";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWebsiteToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Info";
            // 
            // viewWebsiteToolStripMenuItem
            // 
            this.viewWebsiteToolStripMenuItem.Name = "viewWebsiteToolStripMenuItem";
            this.viewWebsiteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewWebsiteToolStripMenuItem.Text = "View Website";
            this.viewWebsiteToolStripMenuItem.Click += new System.EventHandler(this.viewWebsiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.aboutToolStripMenuItem1.Text = "Copy Donation Address";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 341);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblMtGoxLast);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblMtGoxVol);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblMtGoxBuy);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblMtGoxSell);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblMtGoxAvg);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblMtGoxLow);
            this.tabPage1.Controls.Add(this.lblMtGoxHigh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCalcDollarTotal);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtCalcBtcTotal);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.cmbCalcFees);
            this.tabPage2.Controls.Add(this.txtCalcBreakShort);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtCalcBreakSell);
            this.tabPage2.Controls.Add(this.txtCalcUFees);
            this.tabPage2.Controls.Add(this.txtCalcBFees);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtCalcSpend);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.chkCalcLatest);
            this.tabPage2.Controls.Add(this.txtCalcUSD);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCalcBtc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCalcDollarTotal
            // 
            this.txtCalcDollarTotal.Enabled = false;
            this.txtCalcDollarTotal.Location = new System.Drawing.Point(105, 228);
            this.txtCalcDollarTotal.Name = "txtCalcDollarTotal";
            this.txtCalcDollarTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCalcDollarTotal.TabIndex = 21;
            this.txtCalcDollarTotal.Text = "$0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Dollars After Fees:";
            // 
            // txtCalcBtcTotal
            // 
            this.txtCalcBtcTotal.Enabled = false;
            this.txtCalcBtcTotal.Location = new System.Drawing.Point(105, 201);
            this.txtCalcBtcTotal.Name = "txtCalcBtcTotal";
            this.txtCalcBtcTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCalcBtcTotal.TabIndex = 19;
            this.txtCalcBtcTotal.Text = "0.00 BTC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "BTC After Fees:";
            // 
            // cmbCalcFees
            // 
            this.cmbCalcFees.FormattingEnabled = true;
            this.cmbCalcFees.Items.AddRange(new object[] {
            ".60",
            ".55",
            ".53",
            ".50",
            ".46",
            ".43",
            ".40",
            ".30",
            ".29",
            ".28",
            ".27",
            ".26",
            ".25"});
            this.cmbCalcFees.Location = new System.Drawing.Point(62, 96);
            this.cmbCalcFees.Name = "cmbCalcFees";
            this.cmbCalcFees.Size = new System.Drawing.Size(121, 21);
            this.cmbCalcFees.TabIndex = 17;
            // 
            // txtCalcBreakShort
            // 
            this.txtCalcBreakShort.Enabled = false;
            this.txtCalcBreakShort.Location = new System.Drawing.Point(105, 281);
            this.txtCalcBreakShort.Name = "txtCalcBreakShort";
            this.txtCalcBreakShort.Size = new System.Drawing.Size(100, 20);
            this.txtCalcBreakShort.TabIndex = 16;
            this.txtCalcBreakShort.Text = "$0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Break Even Short:";
            // 
            // txtCalcBreakSell
            // 
            this.txtCalcBreakSell.Enabled = false;
            this.txtCalcBreakSell.Location = new System.Drawing.Point(105, 254);
            this.txtCalcBreakSell.Name = "txtCalcBreakSell";
            this.txtCalcBreakSell.Size = new System.Drawing.Size(100, 20);
            this.txtCalcBreakSell.TabIndex = 14;
            this.txtCalcBreakSell.Text = "$0.00";
            // 
            // txtCalcUFees
            // 
            this.txtCalcUFees.Enabled = false;
            this.txtCalcUFees.Location = new System.Drawing.Point(105, 174);
            this.txtCalcUFees.Name = "txtCalcUFees";
            this.txtCalcUFees.Size = new System.Drawing.Size(100, 20);
            this.txtCalcUFees.TabIndex = 13;
            this.txtCalcUFees.Text = "$0.00";
            // 
            // txtCalcBFees
            // 
            this.txtCalcBFees.Enabled = false;
            this.txtCalcBFees.Location = new System.Drawing.Point(105, 147);
            this.txtCalcBFees.Name = "txtCalcBFees";
            this.txtCalcBFees.Size = new System.Drawing.Size(100, 20);
            this.txtCalcBFees.TabIndex = 12;
            this.txtCalcBFees.Text = "0.00 BTC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Total Fees (BTC):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Total Fees ($):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Break Even Sell: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Dollars:";
            // 
            // txtCalcSpend
            // 
            this.txtCalcSpend.Location = new System.Drawing.Point(62, 69);
            this.txtCalcSpend.Name = "txtCalcSpend";
            this.txtCalcSpend.Size = new System.Drawing.Size(100, 20);
            this.txtCalcSpend.TabIndex = 7;
            this.txtCalcSpend.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fees: ";
            // 
            // chkCalcLatest
            // 
            this.chkCalcLatest.AutoSize = true;
            this.chkCalcLatest.Location = new System.Drawing.Point(169, 45);
            this.chkCalcLatest.Name = "chkCalcLatest";
            this.chkCalcLatest.Size = new System.Drawing.Size(83, 17);
            this.chkCalcLatest.TabIndex = 4;
            this.chkCalcLatest.Text = "Use Latest?";
            this.chkCalcLatest.UseVisualStyleBackColor = true;
            this.chkCalcLatest.CheckedChanged += new System.EventHandler(this.chkCalcLatest_CheckedChanged);
            // 
            // txtCalcUSD
            // 
            this.txtCalcUSD.Location = new System.Drawing.Point(62, 42);
            this.txtCalcUSD.Name = "txtCalcUSD";
            this.txtCalcUSD.Size = new System.Drawing.Size(100, 20);
            this.txtCalcUSD.TabIndex = 3;
            this.txtCalcUSD.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Price ($):";
            // 
            // txtCalcBtc
            // 
            this.txtCalcBtc.Location = new System.Drawing.Point(62, 17);
            this.txtCalcBtc.Name = "txtCalcBtc";
            this.txtCalcBtc.Size = new System.Drawing.Size(100, 20);
            this.txtCalcBtc.TabIndex = 1;
            this.txtCalcBtc.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bitcoins:";
            // 
            // BitNotifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BitNotifier";
            this.Text = "BitNotifier - Alpha Version";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Resize += new System.EventHandler(this.Notification_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lblMtGoxLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMtGoxHigh;
        private System.Windows.Forms.Label lblMtGoxLow;
        private System.Windows.Forms.Label lblMtGoxAvg;
        private System.Windows.Forms.Label lblMtGoxSell;
        private System.Windows.Forms.Label lblMtGoxBuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMtGoxVol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCalcBtc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalcUSD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCalcLatest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCalcSpend;
        private System.Windows.Forms.TextBox txtCalcBreakShort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCalcBreakSell;
        private System.Windows.Forms.TextBox txtCalcUFees;
        private System.Windows.Forms.TextBox txtCalcBFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCalcFees;
        private System.Windows.Forms.TextBox txtCalcDollarTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCalcBtcTotal;
        private System.Windows.Forms.Label label16;
    }
}

