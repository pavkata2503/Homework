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
    public class GrossConverter: DefaultTypeConverter
    {
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0.0;
            }

            text = text.Trim().Replace("$", "").ToUpper();
            double multiplier = 1.0;
            if (text == "NA")
            {
                double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out double zero);
                zero = 0;
                return zero;

            }
            if (text.EndsWith("M"))
            {
                multiplier = 1_000_000;
                text=text.Replace("M", "");
            }
            if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
            {
                return Math.Round(value * multiplier);
            }
            else
            {
                return 0.0;
            }

        }
    }
}
