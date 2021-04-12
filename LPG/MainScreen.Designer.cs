
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
            this.controlBTN = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.baseControl1 = new LPG.BaseControl();
            this.baseControl2 = new LPG.BaseControl();
            this.baseControl3 = new LPG.BaseControl();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            this.flowLayoutPanel1.Controls.Add(this.baseControl1);
            this.flowLayoutPanel1.Controls.Add(this.baseControl2);
            this.flowLayoutPanel1.Controls.Add(this.baseControl3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 371);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // baseControl1
            // 
            this.baseControl1.BackColor = System.Drawing.Color.Gray;
            this.baseControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl1.Location = new System.Drawing.Point(3, 3);
            this.baseControl1.Name = "baseControl1";
            this.baseControl1.Size = new System.Drawing.Size(413, 40);
            this.baseControl1.TabIndex = 0;
            // 
            // baseControl2
            // 
            this.baseControl2.BackColor = System.Drawing.Color.Gray;
            this.baseControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl2.Location = new System.Drawing.Point(3, 49);
            this.baseControl2.Name = "baseControl2";
            this.baseControl2.Size = new System.Drawing.Size(413, 40);
            this.baseControl2.TabIndex = 1;
            // 
            // baseControl3
            // 
            this.baseControl3.BackColor = System.Drawing.Color.Gray;
            this.baseControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseControl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseControl3.Location = new System.Drawing.Point(3, 95);
            this.baseControl3.Name = "baseControl3";
            this.baseControl3.Size = new System.Drawing.Size(413, 40);
            this.baseControl3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.controlBTN);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPG-Control";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
    }
}

