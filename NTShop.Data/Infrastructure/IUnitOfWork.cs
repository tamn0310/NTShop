namespace NTShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}