using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class roleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutScholarship",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "AmountForEach",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationStatus",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "MadePayment",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "NumberOfPeople",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "SponsorProvideExam",
                table: "ScholarshipApplications");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "ScholarshipApplications");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ConfirmationAwaitings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "ConfirmationAwaitings");

            migrationBuilder.AddColumn<string>(
                name: "AboutScholarship",
                table: "ScholarshipApplications",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountForEach",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationStatus",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MadePayment",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfPeople",
                table: "ScholarshipApplications",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SponsorProvideExam",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "ScholarshipApplications",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
