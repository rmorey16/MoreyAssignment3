using Microsoft.EntityFrameworkCore;

namespace MoreyAssignment3.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }
        public DbSet<EntryResponse> Entries { get; set; }
    }
}
