using System.Collections.Generic;
using Crud.Models;

namespace Crud.Interfaces
{
    public interface ICacheMemory
    {
        void Cache(List<Blog> data);
        void CacheGet();
    }
}