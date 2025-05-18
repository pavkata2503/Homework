namespace WeatherStation.Converters
{
    // Клас с методи за конвертиране на температурни данни
    public static class TemperatureConverter
    {
        // Конвертира от Целзий във Фаренхайт
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Конвертира от Фаренхайт в Целзий
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    // Клас с методи за конвертиране на данни за валежи
    public static class PrecipitationConverter
    {
        // Конвертира от милиметри в инчове
        public static double MillimetersToInches(double millimeters)
        {
            return millimeters / 25.4;
        }

        // Конвертира от инчове в милиметри
        public static double InchesToMillimeters(double inches)
        {
            return inches * 25.4;
        }
    }
} 