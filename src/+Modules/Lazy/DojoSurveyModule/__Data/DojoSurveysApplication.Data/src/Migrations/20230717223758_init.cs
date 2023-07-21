using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DojoSurveysApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DojoCompletedSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompletedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoCompletedSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DojoSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DojoSurveyQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DojoQuestionType = table.Column<int>(type: "INTEGER", nullable: false),
                    AllowedAnswerCount = table.Column<int>(type: "INTEGER", nullable: false),
                    DojoSurveyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoSurveyQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DojoSurveyQuestions_DojoSurveys_DojoSurveyId",
                        column: x => x.DojoSurveyId,
                        principalTable: "DojoSurveys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DojoSurveyQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false),
                    DojoSurveyQuestionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoSurveyQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DojoSurveyQuestionAnswers_DojoSurveyQuestions_DojoSurveyQuestionId",
                        column: x => x.DojoSurveyQuestionId,
                        principalTable: "DojoSurveyQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DojoCompletedSurveyQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DojoSurveyQuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DojoSurveyQuestionAnswerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false),
                    DojoCompletedSurveyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoCompletedSurveyQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DojoCompletedSurveyQuestionAnswers_DojoCompletedSurveys_DojoCompletedSurveyId",
                        column: x => x.DojoCompletedSurveyId,
                        principalTable: "DojoCompletedSurveys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DojoCompletedSurveyQuestionAnswers_DojoSurveyQuestionAnswers_DojoSurveyQuestionAnswerId",
                        column: x => x.DojoSurveyQuestionAnswerId,
                        principalTable: "DojoSurveyQuestionAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DojoCompletedSurveyQuestionAnswers_DojoSurveyQuestions_DojoSurveyQuestionId",
                        column: x => x.DojoSurveyQuestionId,
                        principalTable: "DojoSurveyQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DojoCompletedSurveyQuestionAnswers_DojoCompletedSurveyId",
                table: "DojoCompletedSurveyQuestionAnswers",
                column: "DojoCompletedSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoCompletedSurveyQuestionAnswers_DojoSurveyQuestionAnswerId",
                table: "DojoCompletedSurveyQuestionAnswers",
                column: "DojoSurveyQuestionAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoCompletedSurveyQuestionAnswers_DojoSurveyQuestionId",
                table: "DojoCompletedSurveyQuestionAnswers",
                column: "DojoSurveyQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoSurveyQuestionAnswers_DojoSurveyQuestionId",
                table: "DojoSurveyQuestionAnswers",
                column: "DojoSurveyQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoSurveyQuestions_DojoSurveyId",
                table: "DojoSurveyQuestions",
                column: "DojoSurveyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DojoCompletedSurveyQuestionAnswers");

            migrationBuilder.DropTable(
                name: "DojoCompletedSurveys");

            migrationBuilder.DropTable(
                name: "DojoSurveyQuestionAnswers");

            migrationBuilder.DropTable(
                name: "DojoSurveyQuestions");

            migrationBuilder.DropTable(
                name: "DojoSurveys");
        }
    }
}
