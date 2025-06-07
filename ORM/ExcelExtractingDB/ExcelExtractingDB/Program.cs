using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Excel;
using Service;
using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Globalization;

namespace ExcelExtractingDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ICsvFileReader csvFileReader = new CsvFileReader();
            var data = csvFileReader.GetData();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }
    }
}
