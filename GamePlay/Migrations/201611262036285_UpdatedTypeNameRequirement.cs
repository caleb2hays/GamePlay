namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTypeNameRequirement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypeModels", "TypeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypeModels", "TypeName", c => c.String());
        }
    }
}
