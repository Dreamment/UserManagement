using Services.Contracts;
using StackExchange.Redis;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class RedisCacheManager : ICacheService
    {
        private readonly IConnectionMultiplexer _redisCon;
        private readonly IDatabase _cache;
        private TimeSpan ExpireTime = TimeSpan.FromMinutes(60);

        public RedisCacheManager(IConnectionMultiplexer redisCon)
        {
            _redisCon = redisCon;
            _cache = redisCon.GetDatabase();
        }

        public void ClearAll()
        {
            _redisCon.GetDatabase().Execute("FLUSHALL");
        }

        public async Task ClearAsync(string key)
            => await _cache.KeyDeleteAsync(key);

        public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> action) where T : class
        {
            var result = await _cache.StringGetAsync(key);
            if (result.IsNull)
            {
                result = JsonSerializer.SerializeToUtf8Bytes(await action());
                await SetValueAsync(key, result);
            }
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }

        public async Task<bool> SetValueAsync(string key, string value)
            => await _cache.StringSetAsync(key, value, ExpireTime);
    }
}
