using CsvHelper.Configuration;
using CsvHelper;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD_Movies.Converter
{
    public class MetascoreConverter:DefaultTypeConverter
    {
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (string.IsNullOrWhiteSpace(text) || text == "NA")
            {
                return 0.0;
            }
            else
            {
                return double.Parse(text, CultureInfo.InvariantCulture);
            }
        }
    }
}
