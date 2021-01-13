using System;
using System.Collections.Generic;
using Crud.Models;
using Crud.Services;
using Microsoft.Extensions.Caching.Memory;

namespace Crud.Classes.Cache
{
    public class CacheMemoryHelper
    {
        public  IMemoryCache _cache;
        public  Blog _cacheEntry;
        public CacheMemoryHelper(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public void Cache(List<Blog> data)
        {
            if (!_cache.TryGetValue(CacheKeys.Entry, out _cacheEntry))
            {
                // Key not in cache, so get data.
                List<Blog> blog = data;

                // Set cache options.
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromSeconds(3600));

                // Save data in cache.
                _cache.Set(CacheKeys.Entry, blog, cacheEntryOptions);
            }
        }
        
        /*public static List<Blog> CacheGet()
        {
            return _cache.Get<List<Blog>>(CacheKeys.Entry);
        }*/
    }
}