using System;

namespace WeatherStation.Models
{
    // Клас за температурни данни в метрична система (Целзий)
    public class MetricTemperatureData : WeatherData, ITemperatureData
    {
        public double Value { get; private set; }

        public MetricTemperatureData(double temperatureInCelsius, DateTime timestamp, string location)
            : base(timestamp, location)
        {
            Value = temperatureInCelsius;
        }

        public override string GetFormattedValue()
        {
            return $"Температура: {Value:F1}°C";
        }

        public override bool HasWarning()
        {
            return Value < -5 || Value > 30;
        }

        public override string GetWarningMessage()
        {
            if (Value < -5)
                return "Warning: cold weather";
            else if (Value > 30)
                return "Warning: hot weather";
            else
                return string.Empty;
        }

        public string GetWeatherCondition()
        {
            if (Value < -5)
                return "Extreme Cold";
            else if (Value >= -5 && Value < 5)
                return "Cold";
            else if (Value >= 5 && Value <= 30)
                return "Warm";
            else
                return "Hot";
        }
    }

    // Клас за температурни данни в имперска система (Фаренхайт)
    public class ImperialTemperatureData : WeatherData, ITemperatureData
    {
        public double Value { get; private set; }
        
        // Стойността в Целзий за проверка на условията за предупреждения
        private double ValueInCelsius => (Value - 32) * 5 / 9;

        public ImperialTemperatureData(double temperatureInFahrenheit, DateTime timestamp, string location)
            : base(timestamp, location)
        {
            Value = temperatureInFahrenheit;
        }

        public override string GetFormattedValue()
        {
            return $"Температура: {Value:F1}°F";
        }

        public override bool HasWarning()
        {
            return ValueInCelsius < -5 || ValueInCelsius > 30;
        }

        public override string GetWarningMessage()
        {
            if (ValueInCelsius < -5)
                return "Warning: cold weather";
            else if (ValueInCelsius > 30)
                return "Warning: hot weather";
            else
                return string.Empty;
        }

        public string GetWeatherCondition()
        {
            if (ValueInCelsius < -5)
                return "Extreme Cold";
            else if (ValueInCelsius >= -5 && ValueInCelsius < 5)
                return "Cold";
            else if (ValueInCelsius >= 5 && ValueInCelsius <= 30)
                return "Warm";
            else
                return "Hot";
        }
    }
} 