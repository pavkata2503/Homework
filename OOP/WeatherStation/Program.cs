using System;
using WeatherStation.Services;
using WeatherStation.UI;

namespace WeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Създаваме инстанция на метео станцията
            var weatherStation = new WeatherStationService();

            // Инициализираме конзолния интерфейс
            var consoleUI = new ConsoleUI(weatherStation);

            // Стартираме приложението
            consoleUI.Run();
        }
    }
}
