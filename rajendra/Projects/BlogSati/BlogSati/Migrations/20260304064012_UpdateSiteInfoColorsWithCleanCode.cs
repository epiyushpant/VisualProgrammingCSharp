using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSati.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSiteInfoColorsWithCleanCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "SiteInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryColor",
                table: "SiteInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryColor",
                table: "SiteInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TextColor",
                table: "SiteInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "SiteInfo");

            migrationBuilder.DropColumn(
                name: "PrimaryColor",
                table: "SiteInfo");

            migrationBuilder.DropColumn(
                name: "SecondaryColor",
                table: "SiteInfo");

            migrationBuilder.DropColumn(
                name: "TextColor",
                table: "SiteInfo");
        }
    }
}
