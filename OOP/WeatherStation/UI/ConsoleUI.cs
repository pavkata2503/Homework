using System;
using System.Collections.Generic;
using WeatherStation.Models;
using WeatherStation.Services;

namespace WeatherStation.UI
{
    public class ConsoleUI
    {
        private readonly WeatherStationService _weatherStation;

        public ConsoleUI(WeatherStationService weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool running = true;

            while (running)
            {
                DisplayMenu();
                var choice = GetUserChoice();

                switch (choice)
                {
                    case 1:
                        InputMetricTemperature();
                        break;
                    case 2:
                        InputImperialTemperature();
                        break;
                    case 3:
                        InputMetricPrecipitation();
                        break;
                    case 4:
                        InputImperialPrecipitation();
                        break;
                    case 5:
                        DisplayCurrentWeather();
                        break;
                    case 6:
                        DisplayWeatherSummary();
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
                        break;
                }

                Console.WriteLine("\nНатиснете произволен клавиш, за да продължите...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("===== Метео Станция =====");
            Console.WriteLine("1. Въведете температура (метрична система - °C)");
            Console.WriteLine("2. Въведете температура (имперска система - °F)");
            Console.WriteLine("3. Въведете валежи (метрична система - мм)");
            Console.WriteLine("4. Въведете валежи (имперска система - инчове)");
            Console.WriteLine("5. Покажете текущото време за локация");
            Console.WriteLine("6. Покажете обобщение за период");
            Console.WriteLine("0. Изход");
            Console.Write("\nИзберете опция: ");
        }

        private int GetUserChoice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
                return choice;
            return -1;
        }

        private void InputMetricTemperature()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                Console.Write("Въведете температура в °C: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    var data = new MetricTemperatureData(temperature, DateTime.Now, location);
                    _weatherStation.AddWeatherData(data);
                    Console.WriteLine("Данните са успешно записани.");
                }
                else
                {
                    Console.WriteLine("Невалидна температура.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        private void InputImperialTemperature()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                Console.Write("Въведете температура в °F: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    var data = new ImperialTemperatureData(temperature, DateTime.Now, location);
                    _weatherStation.AddWeatherData(data);
                    Console.WriteLine("Данните са успешно записани.");
                }
                else
                {
                    Console.WriteLine("Невалидна температура.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        private void InputMetricPrecipitation()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                Console.Write("Въведете количество валежи в мм: ");
                if (double.TryParse(Console.ReadLine(), out double precipitation))
                {
                    var data = new MetricPrecipitationData(precipitation, DateTime.Now, location);
                    _weatherStation.AddWeatherData(data);
                    Console.WriteLine("Данните са успешно записани.");
                }
                else
                {
                    Console.WriteLine("Невалидно количество валежи.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        private void InputImperialPrecipitation()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                Console.Write("Въведете количество валежи в инчове: ");
                if (double.TryParse(Console.ReadLine(), out double precipitation))
                {
                    var data = new ImperialPrecipitationData(precipitation, DateTime.Now, location);
                    _weatherStation.AddWeatherData(data);
                    Console.WriteLine("Данните са успешно записани.");
                }
                else
                {
                    Console.WriteLine("Невалидно количество валежи.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        private void DisplayCurrentWeather()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                var weatherData = _weatherStation.GetCurrentWeatherForLocation(location);
                
                Console.WriteLine($"\nТекущо време за {location}:");
                foreach (var data in weatherData)
                {
                    Console.WriteLine(data.GetFormattedValue());
                    if (data.HasWarning())
                    {
                        Console.WriteLine($"* {data.GetWarningMessage()} *");
                    }

                    if (data is ITemperatureData tempData)
                    {
                        Console.WriteLine($"Състояние: {tempData.GetWeatherCondition()}");
                    }
                }

                if (!weatherData.GetEnumerator().MoveNext())
                {
                    Console.WriteLine("Няма данни за тази локация.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        private void DisplayWeatherSummary()
        {
            try
            {
                Console.Write("Въведете локация: ");
                string location = Console.ReadLine();
                
                Console.Write("Въведете начална дата (дд.мм.гггг): ");
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime startDate))
                {
                    Console.WriteLine("Невалидна дата.");
                    return;
                }
                
                Console.Write("Въведете крайна дата (дд.мм.гггг): ");
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime endDate))
                {
                    Console.WriteLine("Невалидна дата.");
                    return;
                }

                var summary = _weatherStation.GetSummaryForPeriod(location, startDate, endDate);
                Console.WriteLine("\n" + summary.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }
    }
} 