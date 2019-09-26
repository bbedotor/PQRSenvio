using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PQRSenvio.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    category_id = table.Column<string>(nullable: true),
                    theme_id = table.Column<string>(nullable: true),
                    detail_id = table.Column<string>(nullable: true),
                    assigned_user_id = table.Column<string>(nullable: false),
                    ans = table.Column<int>(nullable: false),
                    account_id = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    Is_Active = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(nullable: false),
                    ans = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    Desription = table.Column<string>(maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    Created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    is_active = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    Created_at = table.Column<DateTime>(nullable: false),
                    created_by_id = table.Column<string>(nullable: true),
                    modified_at = table.Column<DateTime>(nullable: false),
                    modified_by_id = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false),
                    StateId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryId",
                table: "Locations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StateId",
                table: "Locations",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
