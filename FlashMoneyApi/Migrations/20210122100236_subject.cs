using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class subject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Subject_SubjectId",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_ExamCategory_ExamCategoryId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_ExamScholarship_ExamScholarshipId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_ExamTest_ExamTestId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_ExamType_ExamTypeId",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "ExamScholarship");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ExamCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ExamCategoryId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ExamScholarshipId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ExamCategoryId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ExamScholarshipId",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_ExamTypeId",
                table: "Subjects",
                newName: "IX_Subjects_ExamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_ExamTestId",
                table: "Subjects",
                newName: "IX_Subjects_ExamTestId");

            migrationBuilder.AlterColumn<int>(
                name: "ExamTypeId",
                table: "Subjects",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Subjects_SubjectId",
                table: "ExamQuestion",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_ExamTest_ExamTestId",
                table: "Subjects",
                column: "ExamTestId",
                principalTable: "ExamTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_ExamType_ExamTypeId",
                table: "Subjects",
                column: "ExamTypeId",
                principalTable: "ExamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Subjects_SubjectId",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_ExamTest_ExamTestId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_ExamType_ExamTypeId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_ExamTypeId",
                table: "Subject",
                newName: "IX_Subject_ExamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_ExamTestId",
                table: "Subject",
                newName: "IX_Subject_ExamTestId");

            migrationBuilder.AlterColumn<int>(
                name: "ExamTypeId",
                table: "Subject",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamCategoryId",
                table: "Subject",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExamScholarshipId",
                table: "Subject",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ExamCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    ExamQuestion = table.Column<string>(nullable: true),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamScholarship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamCategoryId = table.Column<int>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false),
                    ScholarshipApplicationId = table.Column<int>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    SponsorId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamScholarship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamScholarship_ExamCategory_ExamCategoryId",
                        column: x => x.ExamCategoryId,
                        principalTable: "ExamCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamScholarship_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamScholarship_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamCategoryId",
                table: "Subject",
                column: "ExamCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamScholarshipId",
                table: "Subject",
                column: "ExamScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScholarship_ExamCategoryId",
                table: "ExamScholarship",
                column: "ExamCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScholarship_ExamTypeId",
                table: "ExamScholarship",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScholarship_UserId1",
                table: "ExamScholarship",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Question_SubjectId",
                table: "Question",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Subject_SubjectId",
                table: "ExamQuestion",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_ExamCategory_ExamCategoryId",
                table: "Subject",
                column: "ExamCategoryId",
                principalTable: "ExamCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_ExamScholarship_ExamScholarshipId",
                table: "Subject",
                column: "ExamScholarshipId",
                principalTable: "ExamScholarship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_ExamTest_ExamTestId",
                table: "Subject",
                column: "ExamTestId",
                principalTable: "ExamTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_ExamType_ExamTypeId",
                table: "Subject",
                column: "ExamTypeId",
                principalTable: "ExamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
