using CsvHelper.Configuration;
using IMBD_Movies.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using IMBD_Movies.Converter;

namespace IMBD_Movies
{
    public class ModelClassMap : ClassMap<Model>
    {
        public ModelClassMap()
        {
            Map(m => m.MovieName).Name("Movie Name");
            Map(m => m.ReleaseYear).Name("Release Year").TypeConverter<ReleaseYearConverter>();
            Map(m => m.Duration).Name("Duration");
            Map(m => m.IMDBRating).Name("IMDB Rating");
            Map(m => m.Metascore).Name("Metascore").TypeConverter<MetascoreConverter>();
            Map(m => m.Votes).Name("Votes");
            Map(m => m.Genre).Name("Genre");
            Map(m => m.Director).Name("Director");
            Map(m => m.Cast).Name("Cast");
            Map(m => m.Gross).Name("Gross").TypeConverter<GrossConverter>();
        }
    }
}
