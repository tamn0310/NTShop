using Microsoft.AspNet.Identity.EntityFramework;
using NTShop.Model.Models;
using System.Data.Entity;

namespace NTShop.Data
{
    public class NTShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public NTShopDbContext() : base("NTShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Error> Errors { get; set; }

        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public static NTShopDbContext Create()
        {
            return new NTShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            Builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId});
            Builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}