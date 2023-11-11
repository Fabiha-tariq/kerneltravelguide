using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KernelTravelGuides.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resorts_ResortsImages_resort_image_id",
                table: "Resorts");

            migrationBuilder.DropForeignKey(
                name: "FK_TouriestSpots_TouriestSpotsImages_t_spot_image_id",
                table: "TouriestSpots");

            migrationBuilder.DropTable(
                name: "ResortsImages");

            migrationBuilder.DropTable(
                name: "TouriestSpotsImages");

            migrationBuilder.DropIndex(
                name: "IX_TouriestSpots_t_spot_image_id",
                table: "TouriestSpots");

            migrationBuilder.DropIndex(
                name: "IX_Resorts_resort_image_id",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "t_spot_image_id",
                table: "TouriestSpots");

            migrationBuilder.DropColumn(
                name: "resort_image_id",
                table: "Resorts");

            migrationBuilder.AddColumn<string>(
                name: "t_spot_img1",
                table: "TouriestSpots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_spot_img2",
                table: "TouriestSpots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_spot_img3",
                table: "TouriestSpots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "resorts_img1",
                table: "Resorts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "resorts_img2",
                table: "Resorts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "resorts_img3",
                table: "Resorts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "t_spot_img1",
                table: "TouriestSpots");

            migrationBuilder.DropColumn(
                name: "t_spot_img2",
                table: "TouriestSpots");

            migrationBuilder.DropColumn(
                name: "t_spot_img3",
                table: "TouriestSpots");

            migrationBuilder.DropColumn(
                name: "resorts_img1",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "resorts_img2",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "resorts_img3",
                table: "Resorts");

            migrationBuilder.AddColumn<int>(
                name: "t_spot_image_id",
                table: "TouriestSpots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "resort_image_id",
                table: "Resorts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ResortsImages",
                columns: table => new
                {
                    resort_image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    resort_image_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResortsImages", x => x.resort_image_id);
                });

            migrationBuilder.CreateTable(
                name: "TouriestSpotsImages",
                columns: table => new
                {
                    t_spot_image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    t_spot_image_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouriestSpotsImages", x => x.t_spot_image_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TouriestSpots_t_spot_image_id",
                table: "TouriestSpots",
                column: "t_spot_image_id");

            migrationBuilder.CreateIndex(
                name: "IX_Resorts_resort_image_id",
                table: "Resorts",
                column: "resort_image_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resorts_ResortsImages_resort_image_id",
                table: "Resorts",
                column: "resort_image_id",
                principalTable: "ResortsImages",
                principalColumn: "resort_image_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TouriestSpots_TouriestSpotsImages_t_spot_image_id",
                table: "TouriestSpots",
                column: "t_spot_image_id",
                principalTable: "TouriestSpotsImages",
                principalColumn: "t_spot_image_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
