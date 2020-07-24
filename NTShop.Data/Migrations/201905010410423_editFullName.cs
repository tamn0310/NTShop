namespace NTShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editFullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "FullName", c => c.String(maxLength: 256));
            DropColumn("dbo.ApplicationUsers", "FuulName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUsers", "FuulName", c => c.String(maxLength: 256));
            DropColumn("dbo.ApplicationUsers", "FullName");
        }
    }
}
