namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IAddressRepository Address { get; }
        ICompanyRepository Company { get; }
        IGeoRepository Geo { get; }
        Task SaveAsync();
    }
}
