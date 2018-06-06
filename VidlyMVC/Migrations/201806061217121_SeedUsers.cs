namespace VidlyMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d09d982-0a8a-4863-af6b-cb3a11305f05', N'admin@vidly.com', 0, N'AB3mnwnu7JHeC66yuRXBWwNsy0voAZBER5KtWE7jDN+Rax5nzFmTqKrHc+90/jYIsw==', N'493eaada-0a6b-4275-a48e-1dbba000ae26', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af48a452-c251-40fb-8c49-1528c8940cce', N'guest@vidly.com', 0, N'AA0okn2RoxU2f7vdCo97AV9lbPetFFM8F1BVnoj25APHCi+udDPRCujRUR5W3XY6CQ==', N'2e991a87-78b2-41c1-a9ee-a869e0d55e83', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c1198543-acaf-4a45-a829-25eb82f0fd13', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d09d982-0a8a-4863-af6b-cb3a11305f05', N'c1198543-acaf-4a45-a829-25eb82f0fd13')

");
        }

        public override void Down()
        {
        }
    }
}
