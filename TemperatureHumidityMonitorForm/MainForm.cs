using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using TemperatureHumidityMonitorForm.Models;
using TemperatureHumidityMonitorForm.Services;

namespace TemperatureHumidityMonitorForm
{
    public partial class MainForm : Form
    {

        readonly SerialPortService _serialPortService;

        public MainForm()
        {
            InitializeComponent();
            _serialPortService = new SerialPortService(new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            });
            _serialPortService.Worker.ProgressChanged += Worker_ProgressChanged;
        }
        /*
            GUI events
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSerialPorts();
            LoadBaudRates();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPortService.CancelWorker();
            Trace.Close();
        }

        private void OpenPortButton_Click(object sender, EventArgs e)
        {
            _serialPortService.RunWorkerInBackground(new SerialPortModel
            {
                ComPort = (string)serialPortsList.Items[serialPortsList.SelectedIndex],
                BaudRate = (int)baudRateList.Items[baudRateList.SelectedIndex]
            });

        }
        private void serialPortsReload_Click(object sender, EventArgs e)
        {
            LoadSerialPorts();
        }
        private void baudrateReload_Click(object sender, EventArgs e)
        {
            LoadBaudRates();
        }
        private void closePort_Click(object sender, EventArgs e)
        {
            _serialPortService.CancelWorker();
        }

        /*
         * Other functions functions
         */

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TempHumDataModelDto model = e.UserState as TempHumDataModelDto;
            chart1.Series[0].Points.AddY(model.Temperature);
            if (chart1.Series[0].Points.Count > 50)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.Series[1].Points.AddY(model.Humidity);
            if (chart1.Series[1].Points.Count > 50)
                chart1.Series[1].Points.RemoveAt(0);
        }
        private void LoadSerialPorts()
        {
            serialPortsList.Items.Clear();
            foreach (string serialPort in SerialPort.GetPortNames())
                serialPortsList.Items.Add(serialPort);

            if (serialPortsList.Items.Count > 0)
                serialPortsList.SelectedIndex = 0;
        }
        private void LoadBaudRates()
        {
            baudRateList.Items.Clear();
            foreach (int baudRate in new int[] { 115200, 9600 })
                baudRateList.Items.Add(baudRate);

            if (baudRateList.Items.Count > 0)
                baudRateList.SelectedIndex = 0;
        }

    }
}
