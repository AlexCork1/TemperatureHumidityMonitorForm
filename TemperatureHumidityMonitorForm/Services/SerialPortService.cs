using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using TemperatureHumidityMonitorForm.Models;

namespace TemperatureHumidityMonitorForm.Services
{
    internal class SerialPortService
    {
        public BackgroundWorker Worker { get; }

        public SerialPortService(BackgroundWorker backgroundWorker)
        {
            Worker = backgroundWorker;
            Worker.DoWork += Worker_DoWork;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var serialPortData = e.Argument as SerialPortModel;
            string datainput = string.Empty;
            using (SerialPort serialPort = new SerialPort(serialPortData.ComPort, serialPortData.BaudRate))
            {
                serialPort.Open();
                while (!Worker.CancellationPending)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        datainput += serialPort.ReadExisting();
                        try
                        {
                            if (datainput.Contains('{') && datainput.Contains('}'))
                            {
                                int startIndex = datainput.IndexOf('{');
                                int endIndex = datainput.IndexOf('}');
                                if (endIndex > startIndex)
                                {
                                    TempHumDataModel model = JsonConvert.DeserializeObject<TempHumDataModel>(datainput.Substring(startIndex, endIndex - startIndex + 1));

                                    //log to file
                                    Trace.TraceInformation(string.Format("{0} - {1} - {2} => Data:{3}",
                                        DateTime.UtcNow.ToString(),
                                        serialPortData.ComPort,
                                        serialPortData.BaudRate,
                                        model.ToDto().ToString()));

                                    //update gui
                                    Worker.ReportProgress(0, model.ToDto());
                                }

                                //remove current data from input string
                                datainput = datainput.Substring(endIndex + 1);
                            }
                        }
                        catch (Exception)
                        {
                            //reset - something is wrong
                            if (datainput.Contains('}')) //skip everything before
                            {
                                int endIndex = datainput.IndexOf('}');
                                datainput = datainput.Substring(endIndex + 1);
                            }
                            else if (datainput.Length > 100) //something weird is happening in data - rest input string
                                datainput = string.Empty;
                        }
                    }

                }
            }
        }

        internal void RunWorkerInBackground(SerialPortModel serialPortModel)
        {
            Worker.RunWorkerAsync(serialPortModel);
        }

        internal void CancelWorker()
        {
            Worker.CancelAsync();
        }
    }
}
