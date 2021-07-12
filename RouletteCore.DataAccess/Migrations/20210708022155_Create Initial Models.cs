using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteCore.DataAccess.Migrations
{
    public partial class CreateInitialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Roulette");

            migrationBuilder.CreateTable(
                name: "Colors",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RouletteEvents",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinValue = table.Column<int>(type: "int", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouletteEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Numbers",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    OddEvenFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Numbers_Colors_ColorId",
                        column: x => x.ColorId,
                        principalSchema: "Roulette",
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSessionLog",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LogOutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSessionLog_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Roulette",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSessions",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AuthTokenSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthDoubleSubmitSessionIdCookie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    HardAbsoluteExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSessions_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Roulette",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "Roulette",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    RouletteEventId = table.Column<int>(type: "int", nullable: false),
                    UserSessionLogId = table.Column<int>(type: "int", nullable: true),
                    BetPlaced = table.Column<double>(type: "float", nullable: true),
                    UpdateFlag = table.Column<bool>(type: "bit", nullable: true),
                    DeleteFlag = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Numbers_NumberId",
                        column: x => x.NumberId,
                        principalSchema: "Roulette",
                        principalTable: "Numbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logs_RouletteEvents_RouletteEventId",
                        column: x => x.RouletteEventId,
                        principalSchema: "Roulette",
                        principalTable: "RouletteEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logs_Users_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "Roulette",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logs_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Roulette",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logs_UserSessionLog_UserSessionLogId",
                        column: x => x.UserSessionLogId,
                        principalSchema: "Roulette",
                        principalTable: "UserSessionLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_NumberId",
                schema: "Roulette",
                table: "Logs",
                column: "NumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_RouletteEventId",
                schema: "Roulette",
                table: "Logs",
                column: "RouletteEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_SupervisorId",
                schema: "Roulette",
                table: "Logs",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId",
                schema: "Roulette",
                table: "Logs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserSessionLogId",
                schema: "Roulette",
                table: "Logs",
                column: "UserSessionLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_ColorId",
                schema: "Roulette",
                table: "Numbers",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSessionLog_UserId",
                schema: "Roulette",
                table: "UserSessionLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSessions_UserId",
                schema: "Roulette",
                table: "UserSessions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "UserSessions",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "Numbers",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "RouletteEvents",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "UserSessionLog",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "Colors",
                schema: "Roulette");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Roulette");
        }
    }
}
