using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace activities8.Migrations
{
    /// <inheritdoc />
    public partial class user_profile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnableTestUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    City = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    About = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Other = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Base64Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: false),
                    Member = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalMessage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    IdActivity = table.Column<int>(type: "int", nullable: false),
                    IdCountry = table.Column<int>(type: "int", nullable: false),
                    IdLanguage = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Test = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
