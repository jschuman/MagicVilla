using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsem",
                    ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Luxury Villa",
                    Details = "Very Nice",
                    ImageUrl = "",
                    Occupancy = 10,
                    Rate = 500,
                    Sqft = 2500,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Cheapo Villa",
                    Details = "A bit small",
                    ImageUrl = "",
                    Occupancy = 3,
                    Rate = 150,
                    Sqft = 400,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
