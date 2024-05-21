using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace blazorVaccine.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    Surname = table.Column<string>(type: "longtext", nullable: false),
                    Dob = table.Column<DateOnly>(type: "date", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false),
                    GPAddress = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PatientMedicalHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FeelingUnwell = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Immunisations = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    MedicalHistory = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CurrentMedicines = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Allergies = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SeriousReaction = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Hypersensitive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Epilepsy = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BlackWaterFever = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    LiverFunction = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BloodDisorders = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    MedicalTreatment = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HistoryAnxiety = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Notes = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalHistory", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vaccinator",
                columns: table => new
                {
                    GPHC = table.Column<string>(type: "varchar(255)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinator", x => x.GPHC);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    BatchNumber = table.Column<string>(type: "varchar(255)", nullable: false),
                    Expirey = table.Column<DateOnly>(type: "date", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false),
                    Brand = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.BatchNumber);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VaccineApplied",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DateApplied = table.Column<DateOnly>(type: "date", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    VaccinatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineApplied", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccineApplied_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineApplied_PatientId",
                table: "VaccineApplied",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientMedicalHistory");

            migrationBuilder.DropTable(
                name: "Vaccinator");

            migrationBuilder.DropTable(
                name: "VaccineApplied");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
