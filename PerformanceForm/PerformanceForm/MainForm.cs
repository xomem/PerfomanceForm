using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceForm
{
    public partial class MainForm : Form
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[60];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetCPUInfo();
        }

        public void GetCPUInfo()
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();

  
            CPUTitle.Text = HardwareInfo.GetCPUName();         
        }


        public TimeSpan UpTime
        {
            get
            {
                using (var uptime = new PerformanceCounter("System", "System Up Time"))
                {
                    uptime.NextValue();       //Call this an extra time before reading its value
                    return TimeSpan.FromSeconds(uptime.NextValue());
                }
            }
        }
        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (CPUChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCPUChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateCPUChart()
        {
            CPUChart.Series["Series1"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                CPUChart.Series["Series1"].Points.AddY(cpuArray[i]);
            }
        }

        private async void CPUTimer_Tick(object sender, EventArgs e)
        {



            string timeFormat = @"dd\:hh\:mm\:ss";

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            dynamic firstValue = cpuCounter.NextValue();
            await Task.Delay(1000);
            dynamic secondValue = cpuCounter.NextValue();


            labelProcesses.Text = Process.GetProcesses().Length.ToString();
            labelCPUUtil.Text = Convert.ToInt32(secondValue) + "%";
            labelUpTime.Text = UpTime.ToString(timeFormat);
        }
    }
}
