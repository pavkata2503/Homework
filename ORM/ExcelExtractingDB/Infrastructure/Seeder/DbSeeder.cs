using Infrastructure.Data;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeder
{
    public class DbSeeder
    {
        private readonly ApplicationDbContext _context;

        public DbSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            CsvFileReader csvFileReader = new CsvFileReader();
            var db = csvFileReader.GetData();
            foreach (var item in db)
            {
                
            }
        }
    }
}
