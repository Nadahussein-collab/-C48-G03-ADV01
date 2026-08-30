using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; }
            public DateTime ExpirationTime { get; }

            public CacheItem(TValue value, TimeSpan timeToLive)
            {
                Value = value;
                ExpirationTime = DateTime.UtcNow.Add(timeToLive);
            }

            public bool IsExpired => DateTime.UtcNow >= ExpirationTime;
        }

        private readonly Dictionary<TKey, CacheItem> _cache = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan timeToLive)
        {
            _cache[key] = new CacheItem(value, timeToLive);
        }
        public bool TryGet(TKey key, out TValue value)
        {
            if (_cache.TryGetValue(key, out CacheItem item))
            {
                if (!item.IsExpired)
                {
                    value = item.Value;
                    return true;
                }

                _cache.Remove(key);
            }

            value = default;
            return false;
        }

        public bool Remove(TKey key)
        {
            return _cache.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (_cache.TryGetValue(key, out CacheItem item))
            {
                if (!item.IsExpired)
                {
                    return true;
                }

                _cache.Remove(key); 
            }

            return false;
        }
        public void RemoveExpired()
        {
            var keysToRemove = new List<TKey>();

            foreach (var pair in _cache)
            {
                if (pair.Value.IsExpired)
                {
                    keysToRemove.Add(pair.Key);
                }
            }

            foreach (var key in keysToRemove)
            {
                _cache.Remove(key);
            }
        }
    }
}
