using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class examcat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    HasResetPin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardAddProcess",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    IsProcessed = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAddProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfirmationAwaitings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmationAwaitings", x => x.Id);
                });

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
                name: "ExamType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    SessionId = table.Column<string>(nullable: true),
                    LoggedIn = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OTPValidation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTPValidation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scholarship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    SponsorId = table.Column<Guid>(nullable: false),
                    StartReg = table.Column<DateTime>(nullable: false),
                    EndReg = table.Column<DateTime>(nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    MaxNumberOfApplicants = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IsThereExam = table.Column<bool>(nullable: false),
                    UserProvideQuestion = table.Column<bool>(nullable: false),
                    ExamCutOffMark = table.Column<double>(nullable: false),
                    MadePayment = table.Column<bool>(nullable: false),
                    UploadDocument = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scholarship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HistOwnerId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    CardName = table.Column<string>(nullable: true),
                    CardExpMonth = table.Column<string>(nullable: true),
                    CardExpYear = table.Column<string>(nullable: true),
                    CardType = table.Column<string>(nullable: true),
                    Receipient = table.Column<string>(nullable: true),
                    ReceipientPassport = table.Column<string>(nullable: true),
                    DestinationPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SenderId = table.Column<Guid>(nullable: false),
                    SenderPhone = table.Column<string>(nullable: true),
                    ReceiverId = table.Column<Guid>(nullable: true),
                    ReceiverPhone = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    SendDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Claimed = table.Column<bool>(nullable: false),
                    Narration = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    MothersMedianName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Pin = table.Column<int>(nullable: false),
                    TwoFactor = table.Column<int>(nullable: false),
                    Passport = table.Column<string>(nullable: true),
                    ValidId = table.Column<string>(nullable: true),
                    UtilityBill = table.Column<string>(nullable: true),
                    HasTransactionPin = table.Column<bool>(nullable: false),
                    HasResetPin = table.Column<bool>(nullable: false),
                    AllowTransactionNotif = table.Column<bool>(nullable: false),
                    AllowAccountActivityNotif = table.Column<bool>(nullable: false),
                    LastWalletFundedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamTest_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ScholarshipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamDocument_Scholarship_ScholarshipId",
                        column: x => x.ScholarshipId,
                        principalTable: "Scholarship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScholarshipCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ScholarshipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScholarshipCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScholarshipCategories_Scholarship_ScholarshipId",
                        column: x => x.ScholarshipId,
                        principalTable: "Scholarship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityModel_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirtimeRecharge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    DestinationPhone = table.Column<string>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirtimeRecharge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirtimeRecharge_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    CardName = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    CardEmail = table.Column<string>(nullable: true),
                    CardExpMonth = table.Column<string>(nullable: true),
                    CardExpYear = table.Column<string>(nullable: true),
                    CardUrl = table.Column<string>(nullable: true),
                    CardRef = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    CardPIN = table.Column<string>(nullable: true),
                    TransID = table.Column<string>(nullable: true),
                    CardMessage = table.Column<string>(nullable: true),
                    CVV = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    CardType = table.Column<string>(nullable: true),
                    Valid = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    LastDebited = table.Column<decimal>(nullable: false),
                    TransactionCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardDetail_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamScholarship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTypeId = table.Column<int>(nullable: false),
                    ExamCategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    SponsorId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true),
                    ScholarshipApplicationId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "NextOfKin",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NextOfKin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    TransactionReference = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    TransactionType = table.Column<int>(nullable: false),
                    TransactionStatus = table.Column<int>(nullable: false),
                    IsAddCard = table.Column<bool>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    CardName = table.Column<string>(nullable: true),
                    CardExpMonth = table.Column<string>(nullable: true),
                    CardExpYear = table.Column<string>(nullable: true),
                    CVV = table.Column<string>(nullable: true),
                    CardType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CurrentBallance = table.Column<decimal>(nullable: false),
                    AvailableBalance = table.Column<decimal>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Withdrawal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdrawal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Withdrawal_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScholarshipApplications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScholarshipId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ScholarshipType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ScholarshipCategoryId = table.Column<int>(nullable: false),
                    Date_Time = table.Column<DateTime>(nullable: false),
                    AmountForEach = table.Column<decimal>(nullable: false),
                    AboutScholarship = table.Column<string>(nullable: true),
                    NumberOfPeople = table.Column<string>(nullable: true),
                    SponsorProvideExam = table.Column<bool>(nullable: false),
                    ApplicationStatus = table.Column<int>(nullable: false),
                    ApprovalStatus = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MadePayment = table.Column<bool>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScholarshipApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScholarshipApplications_ScholarshipCategories_ScholarshipCategoryId",
                        column: x => x.ScholarshipCategoryId,
                        principalTable: "ScholarshipCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScholarshipApplications_Scholarship_ScholarshipId",
                        column: x => x.ScholarshipId,
                        principalTable: "Scholarship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScholarshipApplications_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ExamTestId = table.Column<int>(nullable: true),
                    ExamTypeId = table.Column<int>(nullable: false),
                    ExamCategoryId = table.Column<int>(nullable: false),
                    ExamScholarshipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_ExamCategory_ExamCategoryId",
                        column: x => x.ExamCategoryId,
                        principalTable: "ExamCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_ExamScholarship_ExamScholarshipId",
                        column: x => x.ExamScholarshipId,
                        principalTable: "ExamScholarship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_ExamTest_ExamTestId",
                        column: x => x.ExamTestId,
                        principalTable: "ExamTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    ScholarshipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamQuestion_Scholarship_ScholarshipId",
                        column: x => x.ScholarshipId,
                        principalTable: "Scholarship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamQuestion_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamQuestion = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_ActivityModel_UserId1",
                table: "ActivityModel",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AirtimeRecharge_UserId",
                table: "AirtimeRecharge",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardDetail_UserId",
                table: "CardDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamDocument_ScholarshipId",
                table: "ExamDocument",
                column: "ScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestion_ScholarshipId",
                table: "ExamQuestion",
                column: "ScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestion_SubjectId",
                table: "ExamQuestion",
                column: "SubjectId");

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
                name: "IX_ExamTest_ExamTypeId",
                table: "ExamTest",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKin_UserId",
                table: "NextOfKin",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_SubjectId",
                table: "Question",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_ScholarshipCategoryId",
                table: "ScholarshipApplications",
                column: "ScholarshipCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_ScholarshipId",
                table: "ScholarshipApplications",
                column: "ScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_UserId",
                table: "ScholarshipApplications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipCategories_ScholarshipId",
                table: "ScholarshipCategories",
                column: "ScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamCategoryId",
                table: "Subject",
                column: "ExamCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamScholarshipId",
                table: "Subject",
                column: "ExamScholarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamTestId",
                table: "Subject",
                column: "ExamTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ExamTypeId",
                table: "Subject",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_UserId",
                table: "UserTransaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Withdrawal_UserId",
                table: "Withdrawal",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityModel");

            migrationBuilder.DropTable(
                name: "AirtimeRecharge");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CardAddProcess");

            migrationBuilder.DropTable(
                name: "CardDetail");

            migrationBuilder.DropTable(
                name: "ConfirmationAwaitings");

            migrationBuilder.DropTable(
                name: "ExamDocument");

            migrationBuilder.DropTable(
                name: "ExamQuestion");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "NextOfKin");

            migrationBuilder.DropTable(
                name: "OTPValidation");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ScholarshipApplications");

            migrationBuilder.DropTable(
                name: "TransactionHistory");

            migrationBuilder.DropTable(
                name: "Transfer");

            migrationBuilder.DropTable(
                name: "UserTransaction");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Withdrawal");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "ScholarshipCategories");

            migrationBuilder.DropTable(
                name: "ExamScholarship");

            migrationBuilder.DropTable(
                name: "ExamTest");

            migrationBuilder.DropTable(
                name: "Scholarship");

            migrationBuilder.DropTable(
                name: "ExamCategory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ExamType");
        }
    }
}
