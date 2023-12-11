using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace School.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SchoolContext>>()))
            {
                // Look for any movies.
                if (context.About.Any())
                {
                    return;   // DB has been seeded
                }

                context.About.AddRange(
                    new About
                    {
                        Name = "Kendriya Vidyalaya",
                        HeadName = "Rupinder Singh",
                        Established = DateTime.Parse("1963-7-01"),
                        Area = "Jalandar",
                        Fees = 80M,
                        Buildings = 10,
                        Rating = "3star"
                    },

                    new About
                    {
                        Name = "Delhi Public School",
                        HeadName = "Wahaj Ali",
                        Established = DateTime.Parse("1972-1-29"),
                        Area = "Delhi",
                        Fees = 93.37M,
                        Buildings = 15,
                        Rating = "4star"
                    },

                    new About
                    {
                        Name = "St. Xavier's Collegiate School",
                        HeadName = "Kanishk",
                        Established = DateTime.Parse("1860-2-12"),
                        Area = "Kolkata",
                        Fees = 200M,
                        Buildings = 18,
                        Rating = "4star"
                    },

                    new About
                    {
                        Name = "GreenWood International High School",
                        HeadName = "Rayn",
                        Established = DateTime.Parse("2004-3-01"),
                        Area = "Banglore",
                        Fees = 156.76M,
                        Buildings = 20,
                        Rating = "5star"
                    },
                   
                   new About
                    {
                        Name = "The Shri Ram School",
                        HeadName = "Suman Rani",
                        Established = DateTime.Parse("1956-12-11"),
                        Area = "Gurugram",
                        Fees = 139.89M,
                        Buildings = 17,
                        Rating = "3star"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}