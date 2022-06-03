using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityDbContextCustomFields.Data.Migrations
{
    public partial class SecondaryMigrationsWithCustomFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetUserTokens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetUserLogins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetUserClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserUserId",
                table: "AspNetRoleClaims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayrollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserTokens_ApplicationUserUserId",
                table: "AspNetUserTokens",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationUserUserId",
                table: "AspNetUsers",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationUserUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_ApplicationUserUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_ApplicationUserUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApplicationUserUserId",
                table: "AspNetRoles",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_ApplicationUserUserId",
                table: "AspNetRoleClaims",
                column: "ApplicationUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetRoleClaims",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetRoles",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUsers",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserTokens",
                column: "ApplicationUserUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUsers_ApplicationUserUserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserTokens_ApplicationUserUserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationUserUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_ApplicationUserUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_ApplicationUserUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_ApplicationUserUserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_ApplicationUserUserId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "AspNetRoleClaims");
        }
    }
}
