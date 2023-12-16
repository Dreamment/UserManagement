using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        private readonly List<Guid> _addressIds;
        private readonly List<Guid> _companyIds;
        public UserConfig(List<Guid> addressIds, List<Guid> companyIds)
        {
            _addressIds = addressIds;
            _companyIds = companyIds;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { 
                    Id = 1,
                    Name = "Leanne Graham",
                    UserName = "Bret",
                    NormalizedUserName = "BRET",
                    Email = "Sincere@april.biz",
                    NormalizedEmail = "SINCERE@APRIL.BIZ",
                    AddressId = _addressIds.ElementAt(0),
                    PhoneNumber = "1-770-736-8031 x56442",
                    Website = "hildegard.org",
                    CompanyId = _companyIds.ElementAt(0),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 2,
                    Name = "Ervin Howell",
                    UserName = "Antonette",
                    NormalizedUserName = "ANTONETTE",
                    Email = "Shanna@melissa.tv",
                    NormalizedEmail = "SHANNA@MELISSA.TV",
                    AddressId = _addressIds.ElementAt(1),
                    PhoneNumber = "010-692-6593 x09125",
                    Website = "anastasia.net",
                    CompanyId = _companyIds.ElementAt(1),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 3,
                    Name = "Clementine Bauch",
                    UserName = "Samantha",
                    NormalizedUserName = "SAMANTHA",
                    Email = "Nathan@yesenia.net",
                    NormalizedEmail = "NATHAN@YESENIA.NET",
                    AddressId = _addressIds.ElementAt(2),
                    PhoneNumber = "1-463-123-4447",
                    Website = "ramiro.info",
                    CompanyId = _companyIds.ElementAt(2),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 4,
                    Name = "Patricia Lebsack",
                    UserName = "Karianne",
                    NormalizedUserName = "KARIANNE",
                    Email = "Julianne.OConner@kory.org",
                    NormalizedEmail = "JULIANNE.OCONNER@KORY.ORG",
                    AddressId = _addressIds.ElementAt(3),
                    PhoneNumber = "493-170-9623 x156",
                    Website = "kale.biz",
                    CompanyId = _companyIds.ElementAt(3),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 5,
                    Name = "Chelsey Dietrich",
                    UserName = "Kamren",
                    NormalizedUserName = "KAMREN",
                    Email = "Lucio_Hettinger@annie.ca",
                    NormalizedEmail = "LUCIO_HETTINGER@ANNIE.CA",
                    AddressId = _addressIds.ElementAt(4),
                    PhoneNumber = "(254)954-1289",
                    Website = "demarco.info",
                    CompanyId = _companyIds.ElementAt(4),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 6,
                    Name = "Mrs. Dennis Schulist",
                    UserName = "Leopoldo_Corkery",
                    NormalizedUserName = "LEOPOLDO_CORKERY",
                    Email = "Karley_Dach@jasper.info",
                    NormalizedEmail = "KARLEY_DACH@JASPER.INFO",
                    AddressId = _addressIds.ElementAt(5),
                    PhoneNumber = "1-477-935-8478 x6430",
                    Website = "ola.org",
                    CompanyId = _companyIds.ElementAt(5),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 7,
                    Name = "Kurtis Weissnat",
                    UserName = "Elwyn.Skiles",
                    NormalizedUserName = "ELWYN.SKILES",
                    Email = "Telly.Hoeger@billy.biz",
                    NormalizedEmail = "TELLY.HOEGER@BILLY.BIZ",
                    AddressId = _addressIds.ElementAt(6),
                    PhoneNumber = "210.067.6132",
                    Website = "elvis.io",
                    CompanyId = _companyIds.ElementAt(6),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 8,
                    Name = "Nicholas Runolfsdottir V",
                    UserName = "Maxime_Nienow",
                    NormalizedUserName = "MAXIME_NIENOW",
                    Email = "Sherwood@rosamond.me",
                    NormalizedEmail = "SHERWOOD@ROSAMOND.ME",
                    AddressId = _addressIds.ElementAt(7),
                    PhoneNumber = "586.493.6943 x140",
                    Website = "jacynthe.com",
                    CompanyId = _companyIds.ElementAt(7),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 9,
                    Name = "Glenna Reichert",
                    UserName = "Delphine",
                    NormalizedUserName = "DELPHINE",
                    Email = "Chaim_McDermott@dana.io",
                    NormalizedEmail = "CHAIM_MCDERMOTT@DANA.IO",
                    AddressId = _addressIds.ElementAt(8),
                    PhoneNumber = "(775)976-6794 x41206",
                    Website = "conrad.com",
                    CompanyId = _companyIds.ElementAt(8),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = 10,
                    Name = "Clementina DuBuque",
                    UserName = "Moriah.Stanton",
                    NormalizedUserName = "MORIAH.STANTON",
                    Email = "Rey.Padberg@karina.biz",
                    NormalizedEmail = "REY.PADBERG@KARINA.BIZ",
                    AddressId = _addressIds.ElementAt(9),
                    PhoneNumber = "024-648-3804",
                    Website = "ambrose.net",
                    CompanyId = _companyIds.ElementAt(9),
                    LockoutEnabled = true
                }
                );
        }
    }
}
