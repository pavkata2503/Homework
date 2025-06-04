using IMBD_Movies.Models;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetMoviesWithTitleContaining(string keyword)
        {
            return _context.Movies
                .Where(m => m.Name.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }
    }
}
