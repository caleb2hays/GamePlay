namespace GamePlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"  
                    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'bb00c584-103e-4b9c-a54d-23592166c427', N'admin@gameplay.com', 0, N'APWNukNNDxPb4YsFFm0xfIHnoT+qpYRmRP0ZItXHXI4csmt8BQ7TeAdM7/rv/xYCkA==', N'43f4d4a1-301c-4a5c-bed1-6596cff874c9', NULL, 0, 0, NULL, 1, 0, N'admin@gameplay.com')
                    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'be1d284a-193b-47cc-89df-cb2af5b7a25a', N'guest@gameplay.com', 0, N'AFkU+cKNzr0ZXdbB1bfO4NfhZZhAxGfBFV2EkCtlGkyNiN4rhBV2NW2sbikkr0/OEQ==', N'7125c83b-9c8b-44ef-938b-80cf90c8ef7f', NULL, 0, 0, NULL, 1, 0, N'guest@gameplay.com')
            
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2672a382-1e68-415e-acd4-89361a57ebc6', N'CanManageGames')
                    
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bb00c584-103e-4b9c-a54d-23592166c427', N'2672a382-1e68-415e-acd4-89361a57ebc6')

            ");
        }

    public override void Down()
        {
        }
    }
}
