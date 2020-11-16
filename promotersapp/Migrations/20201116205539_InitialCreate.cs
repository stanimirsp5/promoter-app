using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace promotersapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Perks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerkName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weekday = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeID = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FailedLogins = table.Column<int>(type: "int", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_To_UserTypes",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(10,0)", nullable: true, defaultValueSql: "((0.00))"),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Firms_To_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Firms_To_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsProfilePic = table.Column<bool>(type: "bit", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pictures_To_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Promoters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Middlename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promoters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promoters_To_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promoters_To_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmID = table.Column<int>(type: "int", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PaymentCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_To_Firms",
                        column: x => x.FirmID,
                        principalTable: "Firms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoterID = table.Column<int>(type: "int", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Discussions_To_Firms",
                        column: x => x.FirmID,
                        principalTable: "Firms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discussions_To_Promoters",
                        column: x => x.PromoterID,
                        principalTable: "Promoters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerksToPromoter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoterID = table.Column<int>(type: "int", nullable: false),
                    PerkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerksToPromoter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PerksToPromoter_To_Perks",
                        column: x => x.PerkID,
                        principalTable: "Perks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerksToPromoter_To_Promoters",
                        column: x => x.PromoterID,
                        principalTable: "Promoters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoterID = table.Column<int>(type: "int", nullable: false),
                    EyeColor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    MotherLanguage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ForeignLanguage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ForeignLanguage2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ForeignLanguage3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_To_Promoters",
                        column: x => x.PromoterID,
                        principalTable: "Promoters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoterID = table.Column<int>(type: "int", nullable: false),
                    WeekDayID = table.Column<int>(type: "int", nullable: false),
                    FreeFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    FreeTo = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    isStatic = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schedules_To_Promoters",
                        column: x => x.PromoterID,
                        principalTable: "Promoters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_To_WeekDays",
                        column: x => x.PromoterID,
                        principalTable: "WeekDays",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscussionID = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsFirm = table.Column<bool>(type: "bit", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
                    Notify = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Messages_To_Discussions",
                        column: x => x.DiscussionID,
                        principalTable: "Discussions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_FirmID",
                table: "Discussions",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_PromoterID",
                table: "Discussions",
                column: "PromoterID");

            migrationBuilder.CreateIndex(
                name: "IX_Firms_CityID",
                table: "Firms",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Firms_UserID",
                table: "Firms",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_DiscussionID",
                table: "Messages",
                column: "DiscussionID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_FirmID",
                table: "Payments",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_PerksToPromoter_PerkID",
                table: "PerksToPromoter",
                column: "PerkID");

            migrationBuilder.CreateIndex(
                name: "IX_PerksToPromoter_PromoterID",
                table: "PerksToPromoter",
                column: "PromoterID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_PromoterID",
                table: "PersonalDetails",
                column: "PromoterID");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_UserID",
                table: "Pictures",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Promoters_CityID",
                table: "Promoters",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Promoters_UserID",
                table: "Promoters",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_PromoterID",
                table: "Schedules",
                column: "PromoterID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PerksToPromoter");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Perks");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "Promoters");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
