using System;

namespace WeatherStation.Models
{
    // Интерфейс за всички видове метео данни
    public interface IWeatherData
    {
        DateTime Timestamp { get; }
        string Location { get; }
        string GetFormattedValue();
        bool HasWarning();
        string GetWarningMessage();
    }

    // Интерфейс за температурни данни
    public interface ITemperatureData : IWeatherData
    {
        double Value { get; }
        string GetWeatherCondition();
    }

    // Интерфейс за данни за валежи
    public interface IPrecipitationData : IWeatherData
    {
        double Value { get; }
    }

    // Абстрактен базов клас за метео данни
    public abstract class WeatherData : IWeatherData
    {
        public DateTime Timestamp { get; protected set; }
        public string Location { get; protected set; }

        protected WeatherData(DateTime timestamp, string location)
        {
            Timestamp = timestamp;
            Location = location;
        }

        public abstract string GetFormattedValue();
        public abstract bool HasWarning();
        public abstract string GetWarningMessage();
    }
} 