using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId, RoleId) SELECT '7cdd4ef1-6aa0-49a2-b02a-9c2632f098b9', Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = '7cdd4ef1-6aa0-49a2-b02a-9c2632f098b9'");
        }
    }
}
