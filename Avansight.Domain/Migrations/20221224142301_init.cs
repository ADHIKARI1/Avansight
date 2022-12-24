using Microsoft.EntityFrameworkCore.Migrations;

namespace Avansight.Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.StudyId);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentGroups",
                columns: table => new
                {
                    TreatmentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TreatmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentGroups", x => x.TreatmentCode);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    StudyId = table.Column<int>(type: "int", nullable: false),
                    TreatmentCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Studies_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Studies",
                        principalColumn: "StudyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_TreatmentGroups_TreatmentCode",
                        column: x => x.TreatmentCode,
                        principalTable: "TreatmentGroups",
                        principalColumn: "TreatmentCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_StudyId",
                table: "Patients",
                column: "StudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TreatmentCode",
                table: "Patients",
                column: "TreatmentCode",
                unique: true,
                filter: "[TreatmentCode] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "TreatmentGroups");
        }
    }
}
