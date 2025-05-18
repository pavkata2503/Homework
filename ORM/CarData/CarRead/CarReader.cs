using ExcelDataReader;

namespace CarRead
{
    public class CarReader
    {
        public void GetData()
        {
            using (var stream = File.Open("", FileMode Open,)
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {

                        }
                    } while (reader.NextResult());


                    var result = reader.AsDataSet();

                }


                
            }
        }
    }
}
