using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OU.BlogApp.DAL.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8266a8e8-1720-40d9-817b-169ec266b9c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b826a804-035a-400f-ad84-a0ce01a2e37a");

            migrationBuilder.AddColumn<string>(
                name: "AppuserId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cbbc99f-8130-40df-9063-b44c55f242a0", "2034033a-e500-489e-a586-12a55c939366", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e1a79fc-a35d-45cb-8ffb-96be4e2259a9", "45d5a9a4-141c-4b86-ab3a-600fb74a2b82", "admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AppuserId",
                table: "Articles",
                column: "AppuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AppuserId",
                table: "Articles",
                column: "AppuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AppuserId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AppuserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cbbc99f-8130-40df-9063-b44c55f242a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e1a79fc-a35d-45cb-8ffb-96be4e2259a9");

            migrationBuilder.DropColumn(
                name: "AppuserId",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8266a8e8-1720-40d9-817b-169ec266b9c2", "b8375e30-b9b0-49de-9ba5-cf0061f4a7f2", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b826a804-035a-400f-ad84-a0ce01a2e37a", "461b233c-8ca1-4c65-9f4b-1bd6046f4787", "user", "USER" });
        }
    }
}
