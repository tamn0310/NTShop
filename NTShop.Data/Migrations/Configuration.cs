namespace NTShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NTShop.Common;
    using NTShop.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NTShop.Data.NTShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NTShop.Data.NTShopDbContext context)
        {
            CreateUser(context);
            CreateProductCategorySample(context);
            CreateSlide(context);
            CreatePage(context);
            CreateContactDetail(context);
        }

        private void CreateUser(NTShopDbContext context)
        {
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

            context.SaveChanges();
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

        private void CreateFooter(NTShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }

        private void CreateSlide(NTShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide()
                    {
                        Name = "Slide 1",
                        DisplayOrder = 1,
                        Status = true,
                        Url = "#",
                        Image = "/Assets/client/images/bag.jpg",
                        Content = @" <h2>FLAT 50% 0FF</h2>
                                <label> FOR ALL PURCHASE <b> VALUE </b></label>
                                <p> Lorem ipsum dolor sit amet,
                        consectetur adipisicing elit,
                        sed do eiusmod tempor incididunt ut labore et </p>
                        <span class=""on-get"">GET NOW</span>"},
                     new Slide()
                     {
                         Name = "Slide 2",
                         DisplayOrder = 2,
                         Status = true,
                         Url = "#",
                         Image = "/Assets/client/images/bag.jpg",
                         Content = @"<h2>FLAT 50% 0FF</h2>
                                <label>FOR ALL PURCHASE <b>VALUE</b></label>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>
                                <span class=""on-get"">GET NOW</span>"
                     }
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }

        private void CreatePage(NTShopDbContext context)
        {
            if (context.Pages.Count() == 0)
            {
                var page = new Page()
                {
                    Name = "Giới thiệu",
                    Alias = "gioi-thieu",
                    Content = @"Lorem Ipsum is simply dummy text of the printing and
                                typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever
                                since the 1500s, when an unknown printer took a galley of type and scrambled it to
                                make a type specimen book. It has survived not only five centuries, but also the leap into
                                electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of
                                Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus
                                PageMaker including versions of Lorem Ipsum.",
                    Status = true
                };
                context.Pages.Add(page);
                context.SaveChanges();
            }
        }

        private void CreateContactDetail(NTShopDbContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                var contactDetail = new ContactDetail()
                {
                    Name = "NTSHOP",
                    Address = "Bình Dương - Bình Thành - Hương Trà - Huế",
                    Phone = "0899918754",
                    Email = "tamn0310@gmail.com",
                    Lat = 16.3175313,
                    Lng = 107.5149463,
                    Website = "",
                    Orther = "",

                    Status = true
                };
                context.ContactDetails.Add(contactDetail);
                context.SaveChanges();
            }
        }
    }
}