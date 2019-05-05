namespace NTShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RevenusStaticSP : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("GetRevenueStatistic",
                p => new
                {
                    fromDate = p.String(),
                    toDate = p.String()
                }
                ,
                @"
                select
	                o.CreatedDate as Date,
	                sum(od.Quantity*od.Price) as Revenus,
	                sum((od.Quantity*od.Price)-(od.Quantity*p.OriginalPrice)) as Benefit
                from Orders o
	                inner join OrderDetails od
                on o.ID = od.OrderID
	                inner join Products p
                on od.ProductID = p.ID
                where o.CreatedDate<= cast(@toDate as date) and o.CreatedDate >=cast(@fromDate as date)
                group by o.CreatedDate"
                );
        }

        public override void Down()
        {
            DropStoredProcedure("dbo.GetRevenueStatistic");
        }
    }
}