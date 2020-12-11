using Microsoft.EntityFrameworkCore.Migrations;

namespace net_example.Migrations
{
    public partial class IdsAutoincrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MessageModel",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MessageModel");
        }
    }
}
