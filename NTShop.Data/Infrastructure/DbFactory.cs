namespace NTShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NTShopDbContext dbContext;

        public NTShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NTShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}