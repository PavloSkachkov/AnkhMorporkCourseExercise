namespace AnkhMorporkCourseExercise.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assassins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinReward = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxReward = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsOccupied = c.Boolean(nullable: false),
                        Name = c.String(),
                        DealMoneyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Beggars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DealMoneyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DealMoneyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Thives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DealMoneyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Thives");
            DropTable("dbo.Fools");
            DropTable("dbo.Beggars");
            DropTable("dbo.Assassins");
        }
    }
}
