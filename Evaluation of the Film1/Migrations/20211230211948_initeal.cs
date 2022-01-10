using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evaluation_of_the_Film1.Migrations
{
    public partial class initeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                 },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SocksCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    namecategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocksCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floorid = table.Column<int>(type: "int", nullable: false),
                    shortDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    sockscategoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socks_Floor_floorid",
                        column: x => x.floorid,
                        principalTable: "Floor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Socks_SocksCategories_sockscategoryid",
                        column: x => x.sockscategoryid,
                        principalTable: "SocksCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Socks_floorid",
                table: "Socks",
                column: "floorid");

            migrationBuilder.CreateIndex(
                name: "IX_Socks_sockscategoryid",
                table: "Socks",
                column: "sockscategoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socks");

            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "SocksCategories");
        }
    }
}
