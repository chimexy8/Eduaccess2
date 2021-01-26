using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class modifiedExamTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamTest_ExamType_ExamTypeId",
                table: "ExamTest");

            migrationBuilder.AlterColumn<int>(
                name: "ExamTypeId",
                table: "ExamTest",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDate",
                table: "ExamTest",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Score",
                table: "ExamTest",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ExamTest",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ExamTest_UserId",
                table: "ExamTest",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamTest_ExamType_ExamTypeId",
                table: "ExamTest",
                column: "ExamTypeId",
                principalTable: "ExamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamTest_User_UserId",
                table: "ExamTest",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamTest_ExamType_ExamTypeId",
                table: "ExamTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamTest_User_UserId",
                table: "ExamTest");

            migrationBuilder.DropIndex(
                name: "IX_ExamTest_UserId",
                table: "ExamTest");

            migrationBuilder.DropColumn(
                name: "ExamDate",
                table: "ExamTest");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "ExamTest");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExamTest");

            migrationBuilder.AlterColumn<int>(
                name: "ExamTypeId",
                table: "ExamTest",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ExamTest_ExamType_ExamTypeId",
                table: "ExamTest",
                column: "ExamTypeId",
                principalTable: "ExamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
