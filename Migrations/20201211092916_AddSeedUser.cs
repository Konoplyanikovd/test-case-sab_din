using Microsoft.EntityFrameworkCore.Migrations;

namespace net_example.Migrations
{
    public partial class AddSeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserModel",
                columns: new[] { "Name", "LastName" },
                values: new object[] { "Denis", "Konoplyanikov" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "LastName",
                keyValue: "Konoplyanikov"
            );
        }
    }
}
