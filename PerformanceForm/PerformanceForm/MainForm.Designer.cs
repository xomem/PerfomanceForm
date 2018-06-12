namespace PerformanceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CPUChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUpTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPUTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCPUUtil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.labelProcesses = new System.Windows.Forms.Label();
            this.labelCPUTemp = new System.Windows.Forms.Label();
            this.labelCPUSpeed = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(-5, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(543, 587);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCPUSpeed);
            this.tabPage1.Controls.Add(this.labelCPUTemp);
            this.tabPage1.Controls.Add(this.labelProcesses);
            this.tabPage1.Controls.Add(this.CPUChart);
            this.tabPage1.Controls.Add(this.labelUpTime);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CPUTitle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelCPUUtil);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU INFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CPUChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CPUChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CPUChart.Legends.Add(legend1);
            this.CPUChart.Location = new System.Drawing.Point(6, 6);
            this.CPUChart.Name = "CPUChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CPUChart.Series.Add(series1);
            this.CPUChart.Size = new System.Drawing.Size(523, 182);
            this.CPUChart.TabIndex = 10;
            // 
            // labelUpTime
            // 
            this.labelUpTime.AutoSize = true;
            this.labelUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpTime.Location = new System.Drawing.Point(114, 315);
            this.labelUpTime.Name = "labelUpTime";
            this.labelUpTime.Size = new System.Drawing.Size(58, 25);
            this.labelUpTime.TabIndex = 9;
            this.labelUpTime.Text = "15%";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Максимальная температура";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Температура";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Время работы";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Процессы";
            // 
            // CPUTitle
            // 
            this.CPUTitle.AutoSize = true;
            this.CPUTitle.Location = new System.Drawing.Point(14, 191);
            this.CPUTitle.Name = "CPUTitle";
            this.CPUTitle.Size = new System.Drawing.Size(249, 20);
            this.CPUTitle.TabIndex = 3;
            this.CPUTitle.Text = "INTEL CORE I56600 CPI 330Ghz";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость";
            // 
            // labelCPUUtil
            // 
            this.labelCPUUtil.AutoSize = true;
            this.labelCPUUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUUtil.Location = new System.Drawing.Point(13, 253);
            this.labelCPUUtil.Name = "labelCPUUtil";
            this.labelCPUUtil.Size = new System.Drawing.Size(58, 25);
            this.labelCPUUtil.TabIndex = 1;
            this.labelCPUUtil.Text = "15%";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ипользование";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM INFO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CPUTimer
            // 
            this.CPUTimer.Enabled = true;
            this.CPUTimer.Interval = 1200;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUTimer_Tick);
            // 
            // labelProcesses
            // 
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesses.Location = new System.Drawing.Point(13, 315);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(58, 25);
            this.labelProcesses.TabIndex = 11;
            this.labelProcesses.Text = "15%";
            // 
            // labelCPUTemp
            // 
            this.labelCPUTemp.AutoSize = true;
            this.labelCPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUTemp.Location = new System.Drawing.Point(13, 391);
            this.labelCPUTemp.Name = "labelCPUTemp";
            this.labelCPUTemp.Size = new System.Drawing.Size(58, 25);
            this.labelCPUTemp.TabIndex = 12;
            this.labelCPUTemp.Text = "15%";
            // 
            // labelCPUSpeed
            // 
            this.labelCPUSpeed.AutoSize = true;
            this.labelCPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUSpeed.Location = new System.Drawing.Point(114, 253);
            this.labelCPUSpeed.Name = "labelCPUSpeed";
            this.labelCPUSpeed.Size = new System.Drawing.Size(58, 25);
            this.labelCPUSpeed.TabIndex = 13;
            this.labelCPUSpeed.Text = "15%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 581);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "Perfomance Informer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPUUtil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPUTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUpTime;
        private System.Windows.Forms.Timer CPUTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPUChart;
        private System.Windows.Forms.Label labelProcesses;
        private System.Windows.Forms.Label labelCPUTemp;
        private System.Windows.Forms.Label labelCPUSpeed;
    }
}

