using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface ITagRepository : IReponsitory<Tag> { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}