namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (2, 'Fighting')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (3, 'Role-Playing')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (4, 'Shooter')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (5, 'Simulation')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (6, 'Strategy')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (7, 'Sports')");
            Sql("INSERT INTO CategoryModels (Id, Name) VALUES (8, 'Racing')");
        }


        public override void Down()
        {
        }
    }
}
