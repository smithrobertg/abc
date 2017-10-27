using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Airborne.Commander.AspNetCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    AircraftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AircraftTotalTime = table.Column<double>(nullable: false),
                    AircraftType = table.Column<int>(nullable: false),
                    CallSign = table.Column<string>(nullable: true),
                    EngineType = table.Column<string>(nullable: true),
                    FaaRegistrationExpiration = table.Column<DateTimeOffset>(nullable: false),
                    FlightHobbs = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Landings = table.Column<int>(nullable: false),
                    MaintenanceHobbs = table.Column<double>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    ModeSCode = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TailNumber = table.Column<string>(nullable: true),
                    TourqueEvents = table.Column<int>(nullable: false),
                    TourqueEventsRIN = table.Column<int>(nullable: false),
                    YearManufactured = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.AircraftId);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirBase = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<string>(nullable: true),
                    BostonPdPatrol = table.Column<bool>(nullable: false),
                    CityTown = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FlightConfirmationInfo = table.Column<string>(nullable: true),
                    Gist = table.Column<string>(nullable: true),
                    LauchTime = table.Column<DateTime>(nullable: false),
                    MidShiftCallout = table.Column<bool>(nullable: false),
                    MissionCode = table.Column<string>(nullable: true),
                    MissionDate = table.Column<DateTimeOffset>(nullable: false),
                    MissionName = table.Column<string>(nullable: true),
                    MissionNumber = table.Column<string>(nullable: true),
                    Msp = table.Column<bool>(nullable: false),
                    OvertimeMission = table.Column<bool>(nullable: false),
                    PickupLocation = table.Column<string>(nullable: true),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    RequestingAgency = table.Column<string>(nullable: true),
                    TroopJurisdiction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MissionId);
                });

            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    PilotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.PilotId);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    EngineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AircraftId = table.Column<int>(nullable: true),
                    Flights = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NgCycles = table.Column<double>(nullable: false),
                    NpNf = table.Column<double>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    TotalTime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.EngineId);
                    table.ForeignKey(
                        name: "FK_Engines_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CancelCode",
                columns: table => new
                {
                    CancelCodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancelCode", x => x.CancelCodeId);
                    table.ForeignKey(
                        name: "FK_CancelCode_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engines_AircraftId",
                table: "Engines",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_CancelCode_MissionId",
                table: "CancelCode",
                column: "MissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "CancelCode");

            migrationBuilder.DropTable(
                name: "Pilots");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Missions");
        }
    }
}
