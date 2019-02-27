namespace NTShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NTShop.Model.Models;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<NTShop.Data.NTShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NTShop.Data.NTShopDbContext context)
        {
           // var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NTShopDbContext()));
        }
    }
}