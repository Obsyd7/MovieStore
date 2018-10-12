namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'84584728-b786-45a6-89fd-68e6e910e553', N'guest@movies.com', 0, N'AIaAQ7+yw9E5ec+5eQYUJX7cbkd2FCQGJ0ZwmGF12kEUQgFX29uyC5V6BfdjMNE99g==', N'19bb20ec-2d73-4219-a7a5-dfed126e1098', NULL, 0, 0, NULL, 1, 0, N'guest@movies.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd58c11b6-41da-4be2-9127-42dfb6a177b5', N'admin@movies.com', 0, N'ANvjQ+k4q4j2rD3Lat2ZRWEyIET9pzkAgHEX0mvjYj7jBztwQVbJZPgArvssQJlqcg==', N'84b8efb6-865d-4c2a-a522-77dc4153c73e', NULL, 0, 0, NULL, 1, 0, N'admin@movies.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b10f0bb9-896a-460d-96e9-7d0b38223263', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd58c11b6-41da-4be2-9127-42dfb6a177b5', N'b10f0bb9-896a-460d-96e9-7d0b38223263')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
