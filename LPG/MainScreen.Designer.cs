
namespace LPG
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.valvesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlBTN = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.baseControl1 = new LPG.BaseControl();
            this.baseControl2 = new LPG.BaseControl();
            this.baseControl3 = new LPG.BaseControl();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.connectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valvesMenuItem,
            this.connectionMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(30, 20);
            this.Menu.Text = "☰";
            // 
            // valvesMenuItem
            // 
            this.valvesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.valvesMenuItem.Name = "valvesMenuItem";
            this.valvesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.valvesMenuItem.Size = new System.Drawing.Size(188, 22);
            this.valvesMenuItem.Text = "Valves";
            this.valvesMenuItem.ToolTipText = "Open/Close valves ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // controlBTN
            // 
            this.controlBTN.BackColor = System.Drawing.Color.Firebrick;
            this.controlBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controlBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBTN.Location = new System.Drawing.Point(424, 632);
            this.controlBTN.Name = "controlBTN";
            this.controlBTN.Size = new System.Drawing.Size(413, 48);
            this.controlBTN.TabIndex = 3;
            this.controlBTN.Text = "FIRE";
            this.controlBTN.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.baseControl1);
            this.flowLayoutPanel1.Controls.Add(this.baseControl2);
            this.flowLayoutPanel1.Controls.Add(this.baseControl3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 596);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // baseControl1
            // 
            this.baseControl1.AutoSize = true;
            this.baseControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseControl1.BackColor = System.Drawing.Color.Gray;
            this.baseControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl1.Location = new System.Drawing.Point(3, 3);
            this.baseControl1.MaximumSize = new System.Drawing.Size(411, 320);
            this.baseControl1.MinimumSize = new System.Drawing.Size(411, 32);
            this.baseControl1.Name = "baseControl1";
            this.baseControl1.Size = new System.Drawing.Size(411, 34);
            this.baseControl1.TabIndex = 0;
            // 
            // baseControl2
            // 
            this.baseControl2.AutoSize = true;
            this.baseControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseControl2.BackColor = System.Drawing.Color.Gray;
            this.baseControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl2.Location = new System.Drawing.Point(3, 43);
            this.baseControl2.MaximumSize = new System.Drawing.Size(411, 320);
            this.baseControl2.MinimumSize = new System.Drawing.Size(411, 32);
            this.baseControl2.Name = "baseControl2";
            this.baseControl2.Size = new System.Drawing.Size(411, 34);
            this.baseControl2.TabIndex = 1;
            // 
            // baseControl3
            // 
            this.baseControl3.AutoSize = true;
            this.baseControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseControl3.BackColor = System.Drawing.Color.Gray;
            this.baseControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl3.Location = new System.Drawing.Point(3, 83);
            this.baseControl3.MaximumSize = new System.Drawing.Size(411, 320);
            this.baseControl3.MinimumSize = new System.Drawing.Size(411, 32);
            this.baseControl3.Name = "baseControl3";
            this.baseControl3.Size = new System.Drawing.Size(411, 34);
            this.baseControl3.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1264, 599);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // connectionMenuItem
            // 
            this.connectionMenuItem.Name = "connectionMenuItem";
            this.connectionMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.connectionMenuItem.Size = new System.Drawing.Size(188, 22);
            this.connectionMenuItem.Text = "Connection";
            this.connectionMenuItem.Click += new System.EventHandler(this.connectionMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.controlBTN);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPG-Control";
            this.TopMost = true;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button controlBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BaseControl baseControl1;
        private BaseControl baseControl2;
        private BaseControl baseControl3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem valvesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionMenuItem;
    }
}

