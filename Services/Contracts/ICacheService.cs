namespace Services.Contracts
{
    public interface ICacheService
    {
        Task<bool> SetValueAsync(string key, string value);
        Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> action) where T : class;
        Task ClearAsync(string key);
    }
}
