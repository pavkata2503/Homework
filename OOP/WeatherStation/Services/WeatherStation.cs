using System;
using System.Collections.Generic;
using System.Linq;
using WeatherStation.Models;

namespace WeatherStation.Services
{
    public class WeatherStationService
    {
        private readonly List<IWeatherData> _weatherDataList = new List<IWeatherData>();

        // Добавя нови метео данни
        public void AddWeatherData(IWeatherData weatherData)
        {
            _weatherDataList.Add(weatherData);
        }

        // Връща последните данни за дадена локация
        public IEnumerable<IWeatherData> GetCurrentWeatherForLocation(string location)
        {
            // Намираме последните данни за всеки тип метео данни за дадената локация
            var latestTemperature = GetLatestDataOfType<ITemperatureData>(location);
            var latestPrecipitation = GetLatestDataOfType<IPrecipitationData>(location);

            var result = new List<IWeatherData>();
            if (latestTemperature != null)
                result.Add(latestTemperature);
            if (latestPrecipitation != null)
                result.Add(latestPrecipitation);

            return result;
        }

        // Връща обобщени данни за определен период и локация
        public WeatherSummary GetSummaryForPeriod(string location, DateTime startDate, DateTime endDate)
        {
            var temperatureDataInPeriod = _weatherDataList
                .Where(d => d.Location == location && d.Timestamp >= startDate && d.Timestamp <= endDate && d is ITemperatureData)
                .Cast<ITemperatureData>()
                .ToList();

            var precipitationDataInPeriod = _weatherDataList
                .Where(d => d.Location == location && d.Timestamp >= startDate && d.Timestamp <= endDate && d is IPrecipitationData)
                .Cast<IPrecipitationData>()
                .ToList();

            return new WeatherSummary
            {
                Location = location,
                StartDate = startDate,
                EndDate = endDate,
                AverageTemperature = temperatureDataInPeriod.Any() ? temperatureDataInPeriod.Average(t => t.Value) : 0,
                TotalPrecipitation = precipitationDataInPeriod.Sum(p => p.Value),
                TemperatureReadings = temperatureDataInPeriod.Count,
                PrecipitationReadings = precipitationDataInPeriod.Count
            };
        }

        // Помощен метод за намиране на последните данни от определен тип за дадена локация
        private T GetLatestDataOfType<T>(string location) where T : IWeatherData
        {
            return _weatherDataList
                .Where(d => d.Location == location && d is T)
                .Cast<T>()
                .OrderByDescending(d => d.Timestamp)
                .FirstOrDefault();
        }
    }

    // Клас за съхранение на обобщени данни за определен период
    public class WeatherSummary
    {
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double AverageTemperature { get; set; }
        public double TotalPrecipitation { get; set; }
        public int TemperatureReadings { get; set; }
        public int PrecipitationReadings { get; set; }

        public override string ToString()
        {
            return $"Обобщение за времето в {Location} от {StartDate:dd.MM.yyyy} до {EndDate:dd.MM.yyyy}:\n" +
                   $"Средна температура: {AverageTemperature:F1}°C ({TemperatureReadings} отчитания)\n" +
                   $"Общо валежи: {TotalPrecipitation:F1} мм ({PrecipitationReadings} отчитания)";
        }
    }
} 