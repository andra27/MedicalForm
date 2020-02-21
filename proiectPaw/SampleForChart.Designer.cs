namespace proiectPaw
{
    partial class SampleForChart
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
            this.barChartControl1 = new ChartLibrary.BarChartControl();
            this.btReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barChartControl1
            // 
            this.barChartControl1.Location = new System.Drawing.Point(288, 146);
            this.barChartControl1.Name = "barChartControl1";
            this.barChartControl1.Size = new System.Drawing.Size(253, 253);
            this.barChartControl1.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReturn.Location = new System.Drawing.Point(704, 41);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 23);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            // 
            // SampleForChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.barChartControl1);
            this.Name = "SampleForChart";
            this.Text = "SampleForChart";
            this.Load += new System.EventHandler(this.SampleForChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartLibrary.BarChartControl barChartControl1;
        private System.Windows.Forms.Button btReturn;
    }
}