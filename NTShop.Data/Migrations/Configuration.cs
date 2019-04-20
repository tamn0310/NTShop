namespace NTShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NTShop.Model.Models;
    using System;
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
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NTShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new NTShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "nguyennhi",
                Email = "tamn0310@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
               

            };

            manager.Create(user, "tamn0310");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tamn0310@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
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