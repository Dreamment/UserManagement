namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IAdressRepository Adress { get; }
        ICompanyRepository Company { get; }
        Task SaveAsync();
    }
}
