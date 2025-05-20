using CsvHelper;
using CsvHelper.Configuration;
using IMBD_Movies.Converter;
using IMBD_Movies.GlobalParams;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static IMBD_Movies.Model;

namespace IMBD_Movies.CsvRead
{
    public class CsvFileReader
    {
        public List<Model> GetData()
        {
            using (var reader = new StreamReader(GlobalParams.GlobalParams.fileDir))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ModelClassMap>();
                var movies = csv.GetRecords<Model>()
                    .Where(m => !string.IsNullOrWhiteSpace(m.MovieName))
                    .ToList();
                return movies;
            }

        }
    }
}
