using Microsoft.EntityFrameworkCore.Migrations;

namespace book_store.Migrations
{
    public partial class updateBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "kolvo",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kolvo",
                table: "Books");
        }
    }
}
