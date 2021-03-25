using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDBContext _context;
        public EFMovieRepository (MovieDBContext context)
        {
            _context = context;
        }
        public IQueryable<EntryResponse> Entries => _context.Entries;
    }
}
