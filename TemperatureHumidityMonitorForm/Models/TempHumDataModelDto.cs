namespace TemperatureHumidityMonitorForm
{
    public class TempHumDataModelDto
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public int Error { get; set; }

        public override string ToString()
        {
            return string.Format("Temperature: {0}, Humidity: {1}, Error: {2}", Temperature, Humidity, Error);
        }
    }
}
