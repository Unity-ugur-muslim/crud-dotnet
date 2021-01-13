using System;
using System.Collections.Generic;
using Crud.Interfaces;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;

namespace Crud.Services
{
    public class CacheMemory : ICacheMemory
    {
        private Blog cacheEntry;
        public CacheMemory(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }
        
        private const string memoryType = "cache";
        private IMemoryCache _cache;
        public void Cache(List<Blog> data)
        {
            if (memoryType == "cache")
            {
                if (!_cache.TryGetValue(CacheKeys.Entry, out cacheEntry))
                {
                    // Key not in cache, so get data.
                    List<Blog> blog = data;

                    // Set cache options.
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        // Keep in cache for this time, reset time if accessed.
                        .SetSlidingExpiration(TimeSpan.FromSeconds(100));

                    // Save data in cache.
                    _cache.Set(CacheKeys.Entry, blog, cacheEntryOptions);
                }
            }                 
        }

        public List<Blog> CacheGet()
        {
            return _cache.Get<List<Blog>>(CacheKeys.Entry);
        }
    }
}