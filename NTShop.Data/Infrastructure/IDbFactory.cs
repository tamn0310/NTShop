using System;

namespace NTShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NTShopDbContext Init();
    }
}