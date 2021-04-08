using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GHC2.Data.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "Latin1_General_CI_AS");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    NID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BitrhDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.NID);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    NID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BitrhDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.NID);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    NID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BitrhDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_1", x => x.NID);
                });

            migrationBuilder.CreateTable(
                name: "Analysis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DocID = table.Column<int>(type: "int", nullable: false),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analysis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Analyses_Doctor",
                        column: x => x.DocID,
                        principalTable: "Doctor",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analyses_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DocID = table.Column<int>(type: "int", nullable: false),
                    AppointmetDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accepted = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "(N'NO')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor",
                        column: x => x.DocID,
                        principalTable: "Doctor",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DocID = table.Column<int>(type: "int", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chat_Doctor",
                        column: x => x.DocID,
                        principalTable: "Doctor",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chat_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnose",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnoseDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DiagnoseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredRadiation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequiredAnalyses = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DocID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnose", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Diagnose_Doctor",
                        column: x => x.DocID,
                        principalTable: "Doctor",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnose_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Radiation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DocID = table.Column<int>(type: "int", nullable: false),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radiation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Radiation_Doctor",
                        column: x => x.DocID,
                        principalTable: "Doctor",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Radiation_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "NID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnose_Prescription",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnoseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnose_Prescription", x => x.PrescriptionID);
                    table.ForeignKey(
                        name: "FK_Diagnose_Prescription_Diagnose",
                        column: x => x.DiagnoseID,
                        principalTable: "Diagnose",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicine",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "int", nullable: false),
                    MedicineID = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Prescription_Medicine_Diagnose_Prescription",
                        column: x => x.PrescriptionID,
                        principalTable: "Diagnose_Prescription",
                        principalColumn: "PrescriptionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescription_Medicine_Medicine",
                        column: x => x.MedicineID,
                        principalTable: "Medicine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analysis_DocID",
                table: "Analysis",
                column: "DocID");

            migrationBuilder.CreateIndex(
                name: "IX_Analysis_PatientID",
                table: "Analysis",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DocID",
                table: "Appointment",
                column: "DocID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_DocID",
                table: "Chat",
                column: "DocID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_PatientID",
                table: "Chat",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnose_DocID",
                table: "Diagnose",
                column: "DocID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnose_PatientID",
                table: "Diagnose",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnose_Prescription_DiagnoseID",
                table: "Diagnose_Prescription",
                column: "DiagnoseID");

            migrationBuilder.CreateIndex(
                name: "Unique_Username",
                table: "Doctor",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicine_MedicineID",
                table: "Prescription_Medicine",
                column: "MedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicine_PrescriptionID",
                table: "Prescription_Medicine",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Radiation_DocID",
                table: "Radiation",
                column: "DocID");

            migrationBuilder.CreateIndex(
                name: "IX_Radiation_PatientID",
                table: "Radiation",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Analysis");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Prescription_Medicine");

            migrationBuilder.DropTable(
                name: "Radiation");

            migrationBuilder.DropTable(
                name: "Diagnose_Prescription");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Diagnose");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.AlterDatabase(
                oldCollation: "Latin1_General_CI_AS");
        }
    }
}
