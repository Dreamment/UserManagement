using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        private readonly List<Guid> _geoIds;
        private readonly List<Guid> _addressIds;

        public AddressConfig(List<Guid> geoIds, List<Guid> addressIds)
        {
            _geoIds = geoIds;
            _addressIds = addressIds;
        }
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                new Address
                {
                    Id = _addressIds.ElementAt(0),
                    Street = "Kulas Light",
                    Suite = "Apt. 556",
                    City = "Gwenborough",
                    Zipcode = "92998-3874",
                    GeoId = _geoIds.ElementAt(0)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(1),
                    Street = "Victor Plains",
                    Suite = "Suite 879",
                    City = "Wisokyburgh",
                    Zipcode = "90566-7771",
                    GeoId = _geoIds.ElementAt(1)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(2),
                    Street = "Douglas Extension",
                    Suite = "Suite 847",
                    City = "McKenziehaven",
                    Zipcode = "59590-4157",
                    GeoId = _geoIds.ElementAt(2)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(3),
                    Street = "Hoeger Mall",
                    Suite = "Apt. 692",
                    City = "South Elvis",
                    Zipcode = "53919-4257",
                    GeoId = _geoIds.ElementAt(3)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(4),
                    Street = "Skiles Walks",
                    Suite = "Suite 351",
                    City = "Roscoeview",
                    Zipcode = "33263",
                    GeoId = _geoIds.ElementAt(4)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(5),
                    Street = "Norberto Crossing",
                    Suite = "Apt. 950",
                    City = "South Christy",
                    Zipcode = "23505-1337",
                    GeoId = _geoIds.ElementAt(5)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(6),
                    Street = "Rex Trail",
                    Suite = "Suite 280",
                    City = "Howemouth",
                    Zipcode = "58804-1099",
                    GeoId = _geoIds.ElementAt(6)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(7),
                    Street = "Ellsworth Summit",
                    Suite = "Suite 729",
                    City = "Aliyaview",
                    Zipcode = "45169",
                    GeoId = _geoIds.ElementAt(7)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(8),
                    Street = "Dayna Park",
                    Suite = "Suite 449",
                    City = "Bartholomebury",
                    Zipcode = "76495-3109",
                    GeoId = _geoIds.ElementAt(8)
                },
                new Address
                {
                    Id = _addressIds.ElementAt(9),
                    Street = "Kattie Turnpike",
                    Suite = "Suite 198",
                    City = "Lebsackbury",
                    Zipcode = "31428-2261",
                    GeoId = _geoIds.ElementAt(9)
                }
                );
        }
    }
}
