using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Models
{
    public static class TempStorage
    {
        private static List<EntryResponse> allMovies = new List<EntryResponse>();
        public static IEnumerable<EntryResponse> AllMovies
        {
            get { return allMovies; }
        }
        public static void Create(EntryResponse entry)
        {
            allMovies.Add(entry);
        }
        public static void Delete(EntryResponse entry)
        {
            allMovies.Remove(entry);
        }
    }
}
