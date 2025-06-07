using CsvHelper;
using CsvHelper.Configuration;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CsvFileReader:ICsvFileReader
    {
        private double SafeParseDouble(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            return double.TryParse(value, out double result) ? result : 0;
        }

        private int SafeParseInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            return int.TryParse(value, out int result) ? result : 0;
        }

        private DateTime SafeParseDateTime(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return DateTime.MinValue;
            return DateTime.TryParse(value, out DateTime result) ? result : DateTime.MinValue;
        }

        public List<Model> GetData()
        {
            var records = new List<Model>();
            
            using (var workbook = new XLWorkbook(GlobalParams.GlobalParam.fileDir))
            {
                var worksheet = workbook.Worksheet(1); // Първият лист
                var firstRow = worksheet.FirstRowUsed();
                var lastRow = worksheet.LastRowUsed();
                
                // Пропускаме първия ред (заглавията)
                var dataRows = worksheet.Rows(firstRow.RowNumber() + 1, lastRow.RowNumber());
                
                foreach (var row in dataRows)
                {
                    var record = new Model
                    {
                        RowID = SafeParseInt(row.Cell("A").GetString()),
                        OrderPriority = row.Cell("B").GetString() ?? string.Empty,
                        Discount = row.Cell("C").GetString() ?? string.Empty,
                        UnitPrice = row.Cell("D").GetString() ?? string.Empty,
                        ShippingCost = SafeParseDouble(row.Cell("E").GetString()),
                        CustomerID = SafeParseInt(row.Cell("F").GetString()),
                        CustomerName = row.Cell("G").GetString() ?? string.Empty,
                        ShipMode = row.Cell("H").GetString() ?? string.Empty,
                        CustomerSegment = row.Cell("I").GetString() ?? string.Empty,
                        ProductCategory = row.Cell("J").GetString() ?? string.Empty,
                        ProductSub_Category = row.Cell("K").GetString() ?? string.Empty,
                        ProductContainer = row.Cell("L").GetString() ?? string.Empty,
                        ProductName = row.Cell("M").GetString() ?? string.Empty,
                        ProductBaseMargin = SafeParseDouble(row.Cell("N").GetString()),
                        Country = row.Cell("O").GetString() ?? string.Empty,
                        Region = row.Cell("P").GetString() ?? string.Empty,
                        StateorProvince = row.Cell("Q").GetString() ?? string.Empty,
                        City = row.Cell("R").GetString() ?? string.Empty,
                        PostalCode = SafeParseInt(row.Cell("S").GetString()),
                        OrderDate = SafeParseDateTime(row.Cell("T").GetString()),
                        ShipDate = SafeParseDateTime(row.Cell("U").GetString()),
                        Profit = SafeParseDouble(row.Cell("V").GetString()),
                        Quantityorderednew = SafeParseInt(row.Cell("W").GetString()),
                        Sales = SafeParseDouble(row.Cell("X").GetString()),
                        OrderID = SafeParseInt(row.Cell("Y").GetString())
                    };
                    records.Add(record);
                }
            }
            
            return records;
        }
    }
}
