using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'7cdd4ef1-6aa0-49a2-b02a-9c2632f098b9', N'Admin', N'ADMIN', N'Admin@aot.com', N'ADMIN@AOT.COM', 0, N'AQAAAAEAACcQAAAAEHpYYJ9uCHaVxxuEiMCJfcAnqCqvpr3+ghcWJgdA13Tqt2WSqHbtuh9AqEhudawl1Q==', N'LZHHADI7V73LRVVRUZSLNBWCTEEM63OW', N'3349d164-6a58-4807-a82b-61a86f60f8a7', NULL, 0, 0, NULL, 1, 0, N'Abdelmoniem 1', N'Selim 1', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM  [security].[Users] WHERE Id=N'7cdd4ef1-6aa0-49a2-b02a-9c2632f098b9'");
        }
    }
}
