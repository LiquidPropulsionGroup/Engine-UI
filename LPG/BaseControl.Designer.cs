
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sensorLbl = new System.Windows.Forms.Label();
            this.currentLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 95);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(397, 200);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.sensorLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximumSize = new System.Drawing.Size(411, 320);
            this.MinimumSize = new System.Drawing.Size(411, 32);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(409, 298);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sensorLbl;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
