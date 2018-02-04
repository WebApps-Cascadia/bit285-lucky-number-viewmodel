namespace bit285_lucky_number_viewmodel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
