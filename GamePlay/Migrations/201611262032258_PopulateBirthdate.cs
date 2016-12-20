namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE CustomerModels SET Birthdate = CAST('1988-11-07' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
