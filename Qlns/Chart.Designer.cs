namespace Qlns
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cbchart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).BeginInit();
            this.SuspendLayout();
            // 
            // BieuDo
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDo.Legends.Add(legend1);
            this.BieuDo.Location = new System.Drawing.Point(616, 360);
            this.BieuDo.Margin = new System.Windows.Forms.Padding(4);
            this.BieuDo.Name = "BieuDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BieuDo.Series.Add(series1);
            this.BieuDo.Size = new System.Drawing.Size(588, 333);
            this.BieuDo.TabIndex = 0;
            this.BieuDo.Text = "chart1";
            this.BieuDo.Click += new System.EventHandler(this.BieuDo_Click);
            // 
            // Cbchart
            // 
            this.Cbchart.FormattingEnabled = true;
            this.Cbchart.Items.AddRange(new object[] {
            "Line",
            "Bar",
            "Column",
            "Pie"});
            this.Cbchart.Location = new System.Drawing.Point(527, 0);
            this.Cbchart.Margin = new System.Windows.Forms.Padding(4);
            this.Cbchart.Name = "Cbchart";
            this.Cbchart.Size = new System.Drawing.Size(160, 24);
            this.Cbchart.TabIndex = 1;
            this.Cbchart.Text = "Select chart type";
            this.Cbchart.SelectedIndexChanged += new System.EventHandler(this.Cbchart_SelectedIndexChanged);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 953);
            this.Controls.Add(this.Cbchart);
            this.Controls.Add(this.BieuDo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDo;
        private System.Windows.Forms.ComboBox Cbchart;
    }
}