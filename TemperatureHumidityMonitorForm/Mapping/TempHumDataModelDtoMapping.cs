namespace TemperatureHumidityMonitorForm
{
    public static class TempHumDataModelDtoMapping
    {
        public static TempHumDataModelDto ToDto(this TempHumDataModel model)
        {
            return new TempHumDataModelDto
            {
                Temperature = model.Temperature / 10.0,
                Humidity = model.Humidity / 10.0,
                Error = model.Error
            };
        }
    }
}
