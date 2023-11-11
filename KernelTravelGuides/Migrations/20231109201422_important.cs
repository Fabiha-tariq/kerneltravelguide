using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KernelTravelGuides.Migrations
{
    public partial class important : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    city_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.city_id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    hotel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotel_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_rating = table.Column<int>(type: "int", nullable: false),
                    hotel_average = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.hotel_id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    messages_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    messages_user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messages_desc = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    messages_status = table.Column<bool>(type: "bit", nullable: false),
                    messages_content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.messages_id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    province_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.province_id);
                });

            migrationBuilder.CreateTable(
                name: "ResortsImages",
                columns: table => new
                {
                    resort_image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resort_image_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResortsImages", x => x.resort_image_id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    restaurants_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    restaurants_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restaurants_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restaurants_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restaurants_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.restaurants_id);
                });

            migrationBuilder.CreateTable(
                name: "TouriestSpotsImages",
                columns: table => new
                {
                    t_spot_image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_spot_image_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouriestSpotsImages", x => x.t_spot_image_id);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    transport_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transport_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transport_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transport_price = table.Column<int>(type: "int", nullable: false),
                    transport_rating = table.Column<int>(type: "int", nullable: false),
                    transport_desc = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    transport_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.transport_id);
                });

            migrationBuilder.CreateTable(
                name: "TravelCategories",
                columns: table => new
                {
                    tra_category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tra_category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tra_category_desc = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    tra_category_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelCategories", x => x.tra_category_id);
                });

            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    resorts_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resorts_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resorts_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resorts_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    resort_image_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.resorts_id);
                    table.ForeignKey(
                        name: "FK_Resorts_ResortsImages_resort_image_id",
                        column: x => x.resort_image_id,
                        principalTable: "ResortsImages",
                        principalColumn: "resort_image_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TouriestSpots",
                columns: table => new
                {
                    t_spot_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_spot_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_spot_locaion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_spot_desc = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    t_spot_rating = table.Column<int>(type: "int", nullable: false),
                    t_spot_image_id = table.Column<int>(type: "int", nullable: false),
                    t_spot_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouriestSpots", x => x.t_spot_id);
                    table.ForeignKey(
                        name: "FK_TouriestSpots_TouriestSpotsImages_t_spot_image_id",
                        column: x => x.t_spot_image_id,
                        principalTable: "TouriestSpotsImages",
                        principalColumn: "t_spot_image_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    packages_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    packages_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    packages_desc = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    packages_or_price = table.Column<int>(type: "int", nullable: false),
                    packages_img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resorts_id = table.Column<int>(type: "int", nullable: false),
                    tra_category_id = table.Column<int>(type: "int", nullable: false),
                    t_spot_id = table.Column<int>(type: "int", nullable: false),
                    transport_id = table.Column<int>(type: "int", nullable: false),
                    packages_status = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.packages_id);
                    table.ForeignKey(
                        name: "FK_Packages_Resorts_resorts_id",
                        column: x => x.resorts_id,
                        principalTable: "Resorts",
                        principalColumn: "resorts_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Packages_TouriestSpots_t_spot_id",
                        column: x => x.t_spot_id,
                        principalTable: "TouriestSpots",
                        principalColumn: "t_spot_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Packages_Transports_transport_id",
                        column: x => x.transport_id,
                        principalTable: "Transports",
                        principalColumn: "transport_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Packages_TravelCategories_tra_category_id",
                        column: x => x.tra_category_id,
                        principalTable: "TravelCategories",
                        principalColumn: "tra_category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_resorts_id",
                table: "Packages",
                column: "resorts_id");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_t_spot_id",
                table: "Packages",
                column: "t_spot_id");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_tra_category_id",
                table: "Packages",
                column: "tra_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_transport_id",
                table: "Packages",
                column: "transport_id");

            migrationBuilder.CreateIndex(
                name: "IX_Resorts_resort_image_id",
                table: "Resorts",
                column: "resort_image_id");

            migrationBuilder.CreateIndex(
                name: "IX_TouriestSpots_t_spot_image_id",
                table: "TouriestSpots",
                column: "t_spot_image_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Resorts");

            migrationBuilder.DropTable(
                name: "TouriestSpots");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "TravelCategories");

            migrationBuilder.DropTable(
                name: "ResortsImages");

            migrationBuilder.DropTable(
                name: "TouriestSpotsImages");
        }
    }
}
