namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "Birthdate");
        }
    }
}
