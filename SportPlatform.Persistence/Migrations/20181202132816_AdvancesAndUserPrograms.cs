using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportPlatform.Persistence.Migrations
{
    public partial class AdvancesAndUserPrograms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Workers_WorkerId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Workers_WorkerId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodPrograms_Workers_WorkerId",
                table: "FoodPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Workers_WorkerId",
                table: "TrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistories_Workers_WorkerId",
                table: "WorkHistories");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "WorkHistories",
                newName: "SpecialistId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkHistories_WorkerId",
                table: "WorkHistories",
                newName: "IX_WorkHistories_SpecialistId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Workers",
                newName: "SpecialistId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "TrainingPrograms",
                newName: "SpecialistId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingPrograms_WorkerId",
                table: "TrainingPrograms",
                newName: "IX_TrainingPrograms_SpecialistId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "FoodPrograms",
                newName: "SpecialistId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPrograms_WorkerId",
                table: "FoodPrograms",
                newName: "IX_FoodPrograms_SpecialistId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Courses",
                newName: "SpecialistId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_WorkerId",
                table: "Courses",
                newName: "IX_Courses_SpecialistId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Certificates",
                newName: "SpecialistId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_WorkerId",
                table: "Certificates",
                newName: "IX_Certificates_SpecialistId");

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    AdvanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SpecialistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.AdvanceId);
                    table.ForeignKey(
                        name: "FK_Advances_Workers_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Workers",
                        principalColumn: "SpecialistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFoodPrograms",
                columns: table => new
                {
                    ClientFoodProgramId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodProgramId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFoodPrograms", x => x.ClientFoodProgramId);
                    table.ForeignKey(
                        name: "FK_ClientFoodPrograms_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientFoodPrograms_FoodPrograms_FoodProgramId",
                        column: x => x.FoodProgramId,
                        principalTable: "FoodPrograms",
                        principalColumn: "FoodProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientTrainingPrograms",
                columns: table => new
                {
                    ClientTrainingProgramId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTrainingPrograms", x => x.ClientTrainingProgramId);
                    table.ForeignKey(
                        name: "FK_ClientTrainingPrograms_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTrainingPrograms_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "TrainingProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_SpecialistId",
                table: "Advances",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFoodPrograms_ClientId",
                table: "ClientFoodPrograms",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFoodPrograms_FoodProgramId",
                table: "ClientFoodPrograms",
                column: "FoodProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientTrainingPrograms_ClientId",
                table: "ClientTrainingPrograms",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTrainingPrograms_TrainingProgramId",
                table: "ClientTrainingPrograms",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Workers_SpecialistId",
                table: "Certificates",
                column: "SpecialistId",
                principalTable: "Workers",
                principalColumn: "SpecialistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Workers_SpecialistId",
                table: "Courses",
                column: "SpecialistId",
                principalTable: "Workers",
                principalColumn: "SpecialistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPrograms_Workers_SpecialistId",
                table: "FoodPrograms",
                column: "SpecialistId",
                principalTable: "Workers",
                principalColumn: "SpecialistId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Workers_SpecialistId",
                table: "TrainingPrograms",
                column: "SpecialistId",
                principalTable: "Workers",
                principalColumn: "SpecialistId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistories_Workers_SpecialistId",
                table: "WorkHistories",
                column: "SpecialistId",
                principalTable: "Workers",
                principalColumn: "SpecialistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Workers_SpecialistId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Workers_SpecialistId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodPrograms_Workers_SpecialistId",
                table: "FoodPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Workers_SpecialistId",
                table: "TrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistories_Workers_SpecialistId",
                table: "WorkHistories");

            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "ClientFoodPrograms");

            migrationBuilder.DropTable(
                name: "ClientTrainingPrograms");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "WorkHistories",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkHistories_SpecialistId",
                table: "WorkHistories",
                newName: "IX_WorkHistories_WorkerId");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "Workers",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "TrainingPrograms",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingPrograms_SpecialistId",
                table: "TrainingPrograms",
                newName: "IX_TrainingPrograms_WorkerId");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "FoodPrograms",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPrograms_SpecialistId",
                table: "FoodPrograms",
                newName: "IX_FoodPrograms_WorkerId");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "Courses",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_SpecialistId",
                table: "Courses",
                newName: "IX_Courses_WorkerId");

            migrationBuilder.RenameColumn(
                name: "SpecialistId",
                table: "Certificates",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_SpecialistId",
                table: "Certificates",
                newName: "IX_Certificates_WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Workers_WorkerId",
                table: "Certificates",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Workers_WorkerId",
                table: "Courses",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPrograms_Workers_WorkerId",
                table: "FoodPrograms",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Workers_WorkerId",
                table: "TrainingPrograms",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistories_Workers_WorkerId",
                table: "WorkHistories",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
