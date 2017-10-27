using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Airborne.Commander.AspNetCore.Migrations
{
    public partial class AddStaticFrat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MissionNumber",
                table: "Missions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MissionName",
                table: "Missions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TailNumber",
                table: "Aircrafts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CallSign",
                table: "Aircrafts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Discrepancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionTaken = table.Column<string>(nullable: true),
                    Airbase = table.Column<string>(nullable: true),
                    Aircraft = table.Column<string>(nullable: true),
                    AircraftGrounded = table.Column<bool>(nullable: false),
                    AircraftGroundedDate = table.Column<DateTimeOffset>(nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InServiceDate = table.Column<DateTimeOffset>(nullable: false),
                    Occurence = table.Column<string>(nullable: true),
                    ReportedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discrepancies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirBase = table.Column<string>(nullable: true),
                    AirbaseVmcOrImc = table.Column<string>(nullable: true),
                    AircraftId = table.Column<int>(nullable: true),
                    Crew = table.Column<string>(nullable: true),
                    FratDate = table.Column<DateTimeOffset>(nullable: false),
                    Hobbs = table.Column<int>(nullable: false),
                    Shift = table.Column<string>(nullable: true),
                    StatewideVmcOrImc = table.Column<string>(nullable: true),
                    Tfr = table.Column<string>(nullable: true),
                    WeatherBriefing = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frats_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReadBeforeFlights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionTaken = table.Column<string>(nullable: true),
                    Airbase = table.Column<string>(nullable: true),
                    Aircraft = table.Column<string>(nullable: true),
                    AircraftGrounded = table.Column<bool>(nullable: false),
                    AircraftGroundedDate = table.Column<DateTimeOffset>(nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InServiceDate = table.Column<DateTimeOffset>(nullable: false),
                    Occurence = table.Column<string>(nullable: true),
                    ReportedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadBeforeFlights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaticFrats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aircraft_KnownDiscrepancies = table.Column<int>(nullable: false),
                    Aircraft_Performance = table.Column<int>(nullable: false),
                    Aircraft_RecentMaintenance = table.Column<int>(nullable: false),
                    FratId = table.Column<int>(nullable: true),
                    Pilot_CurrencyTraining = table.Column<int>(nullable: false),
                    Pilot_Fatigue = table.Column<int>(nullable: false),
                    Pilot_FlightTimeInMakeModel = table.Column<int>(nullable: false),
                    Pilot_IllnessPhysicalCondition = table.Column<int>(nullable: false),
                    Pilot_ImcPrep = table.Column<int>(nullable: false),
                    Pilot_LastFlightInMakeModel = table.Column<int>(nullable: false),
                    Pilot_Medication = table.Column<int>(nullable: false),
                    Pilot_TotalFlightTime = table.Column<int>(nullable: false),
                    SoloFlight = table.Column<bool>(nullable: false),
                    TfoCoPilot_Fatigue = table.Column<int>(nullable: false),
                    TfoCoPilot_FlightCrew = table.Column<int>(nullable: false),
                    TfoCoPilot_IllnessPhysicalCondition = table.Column<int>(nullable: false),
                    TfoCoPilot_ImcPrep = table.Column<int>(nullable: false),
                    TfoCoPilot_Medication = table.Column<int>(nullable: false),
                    TfoCoPilot_TotalFlightTime = table.Column<int>(nullable: false),
                    ThirdCrewMember = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticFrats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticFrats_Frats_FratId",
                        column: x => x.FratId,
                        principalTable: "Frats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Frats_AircraftId",
                table: "Frats",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticFrats_FratId",
                table: "StaticFrats",
                column: "FratId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discrepancies");

            migrationBuilder.DropTable(
                name: "ReadBeforeFlights");

            migrationBuilder.DropTable(
                name: "StaticFrats");

            migrationBuilder.DropTable(
                name: "Frats");

            migrationBuilder.AlterColumn<string>(
                name: "MissionNumber",
                table: "Missions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MissionName",
                table: "Missions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TailNumber",
                table: "Aircrafts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CallSign",
                table: "Aircrafts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
