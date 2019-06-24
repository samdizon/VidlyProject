namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'127c3efd-de4e-4074-910a-f28d57a9f556', N'admin@vidly.com', 0, N'AOY/QNRRejrJkAXgymhc969um80j9gCuPDdZAMIcwJbKEimbQsH/86dwgVKvRtfyhQ==', N'2e6b5314-7f13-4f35-9d9b-7ddef558e70f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7090af8a-a7e9-43d2-a9e7-9832df9ee9ee', N'guest@vidly.com', 0, N'AGzqbKVaBxXd7ed6MJSd57aBebtgmaxcRwlUKPBcKwV9ddgdyhopWFgEpUiiHKQU/A==', N'b8b69b17-1940-4544-b9ed-f06c58e752bb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2f50298b-29b7-4dda-95a5-e3f7278dde57', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127c3efd-de4e-4074-910a-f28d57a9f556', N'2f50298b-29b7-4dda-95a5-e3f7278dde57')

                ");

        }
        
        public override void Down()
        {
        }
    }
}
