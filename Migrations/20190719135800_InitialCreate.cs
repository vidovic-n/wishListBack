using Microsoft.EntityFrameworkCore.Migrations;

namespace WishListBack.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    price = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    purchased = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
