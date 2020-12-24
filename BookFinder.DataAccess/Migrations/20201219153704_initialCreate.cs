using Microsoft.EntityFrameworkCore.Migrations;

namespace BookFinder.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            //eklenen tablo
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    //tablo alanları
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    authorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
