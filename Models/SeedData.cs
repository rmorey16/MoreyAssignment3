using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            MovieDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MovieDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Entries.Any())
            {
                context.Entries.AddRange(
                    new EntryResponse
                    {
                        Category = "Seed",
                        Title = "Seed Data",
                        Year = 1997,
                        Director = "Rachel Morey",
                        Rating = "G",
                        Edited = false,
                        LentTo = "Seed Data",
                        Notes = "Seed Data"
                    });

                context.SaveChanges();
            }
        }
    }
}
