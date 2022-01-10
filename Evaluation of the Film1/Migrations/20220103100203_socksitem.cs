using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evaluation_of_the_Film1.Migrations
{
    public partial class socksitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocksITem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    socksId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    shopSocksid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocksITem", x => x.id);
                    table.ForeignKey(
                        name: "FK_SocksITem_Socks_socksId",
                        column: x => x.socksId,
                        principalTable: "Socks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocksITem_socksId",
                table: "SocksITem",
                column: "socksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocksITem");
        }
    }
}
