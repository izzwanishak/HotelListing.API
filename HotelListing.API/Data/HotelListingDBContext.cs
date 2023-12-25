using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDBContext : DbContext
    {

        public HotelListingDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Malaysia",
                    ShortName = "MYS"
                },
                new Country
                {
                    Id = 2,
                    Name = "Indonesia",
                    ShortName = "IDN"
                },
                new Country
                {
                    Id = 3,
                    Name = "Thailand",
                    ShortName = "THA"
                },
                new Country
                {
                    Id = 4,
                    Name = "Singapore",
                    ShortName = "SGP"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Holiday Inn Kuala Lumpur",
                    Address = "Kuala Lumpur",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Holiday Inn Jakarta",
                    Address = "Jakarta",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Holiday Inn Bangkok",
                    Address = "Bangkok",
                    CountryId = 3,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Holiday Inn Singapore",
                    Address = "Singapore",
                    CountryId = 4,
                    Rating = 4.5
                }
            );
        }

    }
}
