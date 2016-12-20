namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentalModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_Id = c.Int(nullable: false),
                        Game_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerModels", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.GameModels", t => t.Game_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Game_Id);
            
            AddColumn("dbo.GameModels", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentalModels", "Game_Id", "dbo.GameModels");
            DropForeignKey("dbo.RentalModels", "Customer_Id", "dbo.CustomerModels");
            DropIndex("dbo.RentalModels", new[] { "Game_Id" });
            DropIndex("dbo.RentalModels", new[] { "Customer_Id" });
            DropColumn("dbo.GameModels", "NumberAvailable");
            DropTable("dbo.RentalModels");
        }
    }
}
