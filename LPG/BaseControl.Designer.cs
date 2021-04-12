
namespace LPG
{
    partial class BaseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sensorLbl = new System.Windows.Forms.Label();
            this.currentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sensorLbl
            // 
            this.sensorLbl.AutoSize = true;
            this.sensorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorLbl.Location = new System.Drawing.Point(3, 8);
            this.sensorLbl.Name = "sensorLbl";
            this.sensorLbl.Size = new System.Drawing.Size(120, 24);
            this.sensorLbl.TabIndex = 0;
            this.sensorLbl.Text = "sensor name";
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(318, 8);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(92, 24);
            this.currentLbl.TabIndex = 1;
            this.currentLbl.Text = "cur: value";
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.sensorLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(413, 40);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseControl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sensorLbl;
        private System.Windows.Forms.Label currentLbl;
    }
}
