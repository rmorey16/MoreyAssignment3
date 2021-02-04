using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Models
{
    public static class TempStorage
    {
        private static List<EntryResponse> movies = new List<EntryResponse>();

        public static IEnumerable<EntryResponse> Entries => movies;

        public static void AddEntry(EntryResponse entry)
        {
            movies.Add(entry);
        }
    }
}
