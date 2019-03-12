namespace NTShop.Data.Migrations
{
    using NTShop.Model.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NTShop.Data.NTShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NTShop.Data.NTShopDbContext context)
        {
            CreateProductCategorySample(context);
            // var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NTShopDbContext()));
        }

        private void CreateProductCategorySample(NTShop.Data.NTShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                new ProductCategory(){ Name= "Điện Lạnh",Alias="dien-lanh", Status=true},
                new ProductCategory(){ Name= "Viễn Thông",Alias="vien-thong", Status=true},
                new ProductCategory(){ Name= "Đồ gia dụng",Alias="do-gia-dung", Status=true},
                new ProductCategory(){ Name= "Mỹ phẩm",Alias="my-pham", Status=true}
                };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}