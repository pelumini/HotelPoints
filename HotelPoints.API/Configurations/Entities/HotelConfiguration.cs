using HotelPoints.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelPoints.API.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Grand Cherokee Hotel",
                   Address = "23, Adetokunbo Ademola, Lagos",
                   CountryId = 1,
                   Rating = 4.5
               },
                new Hotel
                {
                    Id = 2,
                    Name = "Supernova Inn",
                    Address = "4, Jakande Olumide, PH",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Red Bull Hotel",
                    Address = "9A, Bemil Road, Ibadan",
                    CountryId = 1,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Cock & Bull Hotel",
                    Address = "23, Micheal Enns Street, London",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Romania Love Garden",
                    Address = "4, Town Center, Bedford",
                    CountryId = 2,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Sanderton Inn",
                    Address = "9A, Yaunde Ondo Road, Accra",
                    CountryId = 3,
                    Rating = 4.0
                },
                 new Hotel
                 {
                     Id = 7,
                     Name = "Casper Joe Hotel",
                     Address = "9A, Raspa Road, Legun",
                     CountryId = 3,
                     Rating = 4.0
                 }
            );
        }
    }
}
