using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class GeoConfig : IEntityTypeConfiguration<Geo>
    {
        private readonly List<Guid> _geoIds;

        public GeoConfig(List<Guid> geoIds)
        {
            _geoIds = geoIds;
        }

        public void Configure(EntityTypeBuilder<Geo> builder)
        {
            builder.HasData(
                new Geo
                {
                    Id = _geoIds.ElementAt(0),
                    Lat = "-37.3159",
                    Lng = "81.1496"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(1),
                    Lat = "-43.9509",
                    Lng = "-34.4618"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(2),
                    Lat = "-68.6102",
                    Lng = "-47.0653"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(3),
                    Lat = "29.4572",
                    Lng = "-164.2990"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(4),
                    Lat = "-31.8129",
                    Lng = "62.5342"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(5),
                    Lat = "-71.4197",
                    Lng = "71.7478"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(6),
                    Lat = "24.8918",
                    Lng = "21.8984"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(7),
                    Lat = "-14.3990",
                    Lng = "-120.7677"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(8),
                    Lat = "24.6463",
                    Lng = "-168.8889"
                },
                new Geo
                {
                    Id = _geoIds.ElementAt(9),
                    Lat = "-38.2386",
                    Lng = "57.2232"
                }
                );
        }
    }
}
