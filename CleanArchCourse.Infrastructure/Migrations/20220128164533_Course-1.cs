using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchCourse.Infrastructure.Migrations
{
    public partial class Course1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySub_Categories_CategoryId",
                table: "CategorySub");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySub",
                table: "CategorySub");

            migrationBuilder.RenameTable(
                name: "CategorySub",
                newName: "CategorySubs");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySub_CategoryId",
                table: "CategorySubs",
                newName: "IX_CategorySubs_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategorySubs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySubs",
                table: "CategorySubs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubs_Categories_CategoryId",
                table: "CategorySubs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubs_Categories_CategoryId",
                table: "CategorySubs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySubs",
                table: "CategorySubs");

            migrationBuilder.RenameTable(
                name: "CategorySubs",
                newName: "CategorySub");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubs_CategoryId",
                table: "CategorySub",
                newName: "IX_CategorySub_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategorySub",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySub",
                table: "CategorySub",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySub_Categories_CategoryId",
                table: "CategorySub",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
