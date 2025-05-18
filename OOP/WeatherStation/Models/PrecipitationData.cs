using System;

namespace WeatherStation.Models
{
    // Клас за данни за валежи в метрична система (милиметри)
    public class MetricPrecipitationData : WeatherData, IPrecipitationData
    {
        public double Value { get; private set; }

        public MetricPrecipitationData(double precipitationInMm, DateTime timestamp, string location)
            : base(timestamp, location)
        {
            Value = precipitationInMm;
        }

        public override string GetFormattedValue()
        {
            return $"Валежи: {Value:F1} мм";
        }

        public override bool HasWarning()
        {
            // В случая с валежи може да се добави предупреждение за обилни валежи
            return Value > 50; // Например, над 50 мм се счита за много силен валеж
        }

        public override string GetWarningMessage()
        {
            if (HasWarning())
                return "Warning: heavy precipitation";
            return string.Empty;
        }
    }

    // Клас за данни за валежи в имперска система (инчове)
    public class ImperialPrecipitationData : WeatherData, IPrecipitationData
    {
        public double Value { get; private set; }
        
        // Стойността в милиметри за проверка на условията за предупреждения
        private double ValueInMm => Value * 25.4;

        public ImperialPrecipitationData(double precipitationInInches, DateTime timestamp, string location)
            : base(timestamp, location)
        {
            Value = precipitationInInches;
        }

        public override string GetFormattedValue()
        {
            return $"Валежи: {Value:F2} инча";
        }

        public override bool HasWarning()
        {
            // Използваме конвертирани стойности за проверката
            return ValueInMm > 50; // 50 mm е приблизително 1.97 инча
        }

        public override string GetWarningMessage()
        {
            if (HasWarning())
                return "Warning: heavy precipitation";
            return string.Empty;
        }
    }
} 