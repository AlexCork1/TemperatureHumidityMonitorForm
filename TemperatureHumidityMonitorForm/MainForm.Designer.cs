namespace TemperatureHumidityMonitorForm
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPortsList = new System.Windows.Forms.ComboBox();
            this.baudRateList = new System.Windows.Forms.ComboBox();
            this.serialPortsReload = new System.Windows.Forms.Button();
            this.baudrateReload = new System.Windows.Forms.Button();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.closePort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.Maximum = 50D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.AutoFitMinFontSize = 10;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 43);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1079, 558);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // serialPortsList
            // 
            this.serialPortsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serialPortsList.FormattingEnabled = true;
            this.serialPortsList.Location = new System.Drawing.Point(41, 12);
            this.serialPortsList.Name = "serialPortsList";
            this.serialPortsList.Size = new System.Drawing.Size(151, 21);
            this.serialPortsList.TabIndex = 1;
            // 
            // baudRateList
            // 
            this.baudRateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.Location = new System.Drawing.Point(247, 12);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(162, 21);
            this.baudRateList.TabIndex = 2;
            // 
            // serialPortsReload
            // 
            this.serialPortsReload.Location = new System.Drawing.Point(199, 12);
            this.serialPortsReload.Name = "serialPortsReload";
            this.serialPortsReload.Size = new System.Drawing.Size(26, 23);
            this.serialPortsReload.TabIndex = 3;
            this.serialPortsReload.Text = "R";
            this.serialPortsReload.UseVisualStyleBackColor = true;
            this.serialPortsReload.Click += new System.EventHandler(this.serialPortsReload_Click);
            // 
            // baudrateReload
            // 
            this.baudrateReload.Location = new System.Drawing.Point(415, 10);
            this.baudrateReload.Name = "baudrateReload";
            this.baudrateReload.Size = new System.Drawing.Size(26, 23);
            this.baudrateReload.TabIndex = 4;
            this.baudrateReload.Text = "R";
            this.baudrateReload.UseVisualStyleBackColor = true;
            this.baudrateReload.Click += new System.EventHandler(this.baudrateReload_Click);
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(469, 5);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(91, 32);
            this.OpenPortButton.TabIndex = 5;
            this.OpenPortButton.Text = "Open port";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPortButton_Click);
            // 
            // closePort
            // 
            this.closePort.Location = new System.Drawing.Point(577, 5);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(91, 32);
            this.closePort.TabIndex = 6;
            this.closePort.Text = "Close port";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 611);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.OpenPortButton);
            this.Controls.Add(this.baudrateReload);
            this.Controls.Add(this.serialPortsReload);
            this.Controls.Add(this.baudRateList);
            this.Controls.Add(this.serialPortsList);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Show data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox serialPortsList;
        private System.Windows.Forms.ComboBox baudRateList;
        private System.Windows.Forms.Button serialPortsReload;
        private System.Windows.Forms.Button baudrateReload;
        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.Button closePort;
    }
}

