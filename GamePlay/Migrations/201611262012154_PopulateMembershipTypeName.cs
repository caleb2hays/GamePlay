namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypeModels SET TypeName = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypeModels SET TypeName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypeModels SET TypeName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypeModels SET TypeName = 'Annual' WHERE Id = 4");

        }

        public override void Down()
        {
        }
    }
}
