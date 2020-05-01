using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIdemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Class", "Name" },
                values: new object[,]
                {
                    { 1, "KTPM3", "Tuan Hai" },
                    { 2, "KTPM1", "Tuan Chung" },
                    { 3, "KTPM2", "Tuan Anh" },
                    { 4, "KTPM3", "Tuan Tung" },
                    { 5, "KTPM1", "Tuan Tu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
