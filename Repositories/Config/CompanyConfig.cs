using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        private readonly List<Guid> _companyIds;

        public CompanyConfig(List<Guid> companyIds)
        {
            _companyIds = companyIds;
        }

        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = _companyIds.ElementAt(0),
                    Name = "Romaguera-Crona",
                    CatchPhrase = "Multi-layered client-server neural-net",
                    Bs = "harness real-time e-markets"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(1),
                    Name = "Deckow-Crist",
                    CatchPhrase = "Proactive didactic contingency",
                    Bs = "synergize scalable supply-chains"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(2),
                    Name = "Romaguera-Jacobson",
                    CatchPhrase = "Face to face bifurcated interface",
                    Bs = "e-enable strategic applications"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(3),
                    Name = "Robel-Corkery",
                    CatchPhrase = "Multi-tiered zero tolerance productivity",
                    Bs = "transition cutting-edge web services"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(4),
                    Name = "Keebler LLC",
                    CatchPhrase = "User-centric fault-tolerant solution",
                    Bs = "revolutionize end-to-end systems"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(5),
                    Name = "Considine-Lockman",
                    CatchPhrase = "Synchronised bottom-line interface",
                    Bs = "e-enable innovative applications"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(6),
                    Name = "Johns Group",
                    CatchPhrase = "Configurable multimedia task-force",
                    Bs = "generate enterprise e-tailers"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(7),
                    Name = "Abernathy Group",
                    CatchPhrase = "Implemented secondary concept",
                    Bs = "e-enable extensible e-tailers"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(8),
                    Name = "Yost and Sons",
                    CatchPhrase = "Switchable contextually-based project",
                    Bs = "aggregate real-time technologies"
                },
                new Company
                {
                    Id = _companyIds.ElementAt(9),
                    Name = "Hoeger LLC",
                    CatchPhrase = "Centralized empowering task-force",
                    Bs = "target end-to-end models"
                }
                );
        }
    }
}
