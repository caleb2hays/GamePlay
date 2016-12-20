namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypeModels", "TypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypeModels", "TypeName");
        }
    }
}
