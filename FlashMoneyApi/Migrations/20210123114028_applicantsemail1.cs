using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class applicantsemail1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScholarshipApplications_ScholarshipCategories_ScholarshipCategoryId",
                table: "ScholarshipApplications");

            migrationBuilder.DropIndex(
                name: "IX_ScholarshipApplications_ScholarshipCategoryId",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "ScholarshipCategoryId",
                table: "ScholarshipApplications");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScholarshipCategoryId",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_ScholarshipCategoryId",
                table: "ScholarshipApplications",
                column: "ScholarshipCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScholarshipApplications_ScholarshipCategories_ScholarshipCategoryId",
                table: "ScholarshipApplications",
                column: "ScholarshipCategoryId",
                principalTable: "ScholarshipCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
