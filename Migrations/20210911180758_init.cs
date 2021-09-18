using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 101, "Maharashtrian" },
                    { 102, "Punjabi" },
                    { 103, "Italian" },
                    { 104, "Thai" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Details", "ImgURL", "IsSpecial", "ItemName", "Price" },
                values: new object[,]
                {
                    { 1, 101, "Made with love to satisfy your taste buds!", "", true, "Puran Poli", 50 },
                    { 2, 101, "Made with love to satisfy your taste buds!", "", false, "Masale Vange", 150 },
                    { 3, 102, "Made with love to satisfy your taste buds!", "", false, "Lachha Paratha", 50 },
                    { 4, 102, "Made with love to satisfy your taste buds!", "", true, "Paneer Makhani", 220 },
                    { 5, 103, "Made with love to satisfy your taste buds!", "", true, "Spaghetti Aglio E Olio", 150 },
                    { 6, 103, "Made with love to satisfy your taste buds!", "", false, "Bruschetta", 120 },
                    { 8, 103, "Made with love to satisfy your taste buds!", "", false, "Pad Thai Noodles", 200 },
                    { 7, 104, "Made with love to satisfy your taste buds!", "", true, "Green Thai Curry", 250 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
