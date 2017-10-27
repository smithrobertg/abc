using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170425041639_AddStaticFrat")]
    partial class AddStaticFrat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Aircraft", b =>
                {
                    b.Property<int>("AircraftId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftTotalTime");

                    b.Property<int>("AircraftType");

                    b.Property<string>("CallSign")
                        .IsRequired();

                    b.Property<string>("EngineType");

                    b.Property<DateTimeOffset>("FaaRegistrationExpiration");

                    b.Property<double>("FlightHobbs");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Landings");

                    b.Property<double>("MaintenanceHobbs");

                    b.Property<string>("Make");

                    b.Property<string>("ModeSCode");

                    b.Property<string>("Model");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("Status");

                    b.Property<string>("TailNumber")
                        .IsRequired();

                    b.Property<int>("TourqueEvents");

                    b.Property<int>("TourqueEventsRIN");

                    b.Property<int>("YearManufactured");

                    b.HasKey("AircraftId");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Discrepancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionTaken");

                    b.Property<string>("Airbase");

                    b.Property<string>("Aircraft");

                    b.Property<bool>("AircraftGrounded");

                    b.Property<DateTimeOffset>("AircraftGroundedDate");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTimeOffset>("InServiceDate");

                    b.Property<string>("Occurence");

                    b.Property<string>("ReportedBy");

                    b.HasKey("Id");

                    b.ToTable("Discrepancies");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Engine", b =>
                {
                    b.Property<int>("EngineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AircraftId");

                    b.Property<int>("Flights");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<double>("NgCycles");

                    b.Property<double>("NpNf");

                    b.Property<string>("SerialNumber");

                    b.Property<double>("TotalTime");

                    b.HasKey("EngineId");

                    b.HasIndex("AircraftId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Frat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirBase");

                    b.Property<string>("AirbaseVmcOrImc");

                    b.Property<int?>("AircraftId");

                    b.Property<string>("Crew");

                    b.Property<DateTimeOffset>("FratDate");

                    b.Property<int>("Hobbs");

                    b.Property<string>("Shift");

                    b.Property<string>("StatewideVmcOrImc");

                    b.Property<string>("Tfr");

                    b.Property<int>("WeatherBriefing");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId");

                    b.ToTable("Frats");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirBase");

                    b.Property<string>("AuthorizedBy");

                    b.Property<bool>("BostonPdPatrol");

                    b.Property<string>("CityTown");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("FlightConfirmationInfo");

                    b.Property<string>("Gist");

                    b.Property<DateTime>("LauchTime");

                    b.Property<bool>("MidShiftCallout");

                    b.Property<string>("MissionCode");

                    b.Property<DateTimeOffset>("MissionDate");

                    b.Property<string>("MissionName")
                        .IsRequired();

                    b.Property<string>("MissionNumber")
                        .IsRequired();

                    b.Property<bool>("Msp");

                    b.Property<bool>("OvertimeMission");

                    b.Property<string>("PickupLocation");

                    b.Property<DateTimeOffset>("RequestDate");

                    b.Property<string>("RequestingAgency");

                    b.Property<string>("TroopJurisdiction");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Mission+CancelCode", b =>
                {
                    b.Property<int>("CancelCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int?>("MissionId");

                    b.HasKey("CancelCodeId");

                    b.HasIndex("MissionId");

                    b.ToTable("CancelCode");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Pilot", b =>
                {
                    b.Property<int>("PilotId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PilotId");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.ReadBeforeFlight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionTaken");

                    b.Property<string>("Airbase");

                    b.Property<string>("Aircraft");

                    b.Property<bool>("AircraftGrounded");

                    b.Property<DateTimeOffset>("AircraftGroundedDate");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTimeOffset>("InServiceDate");

                    b.Property<string>("Occurence");

                    b.Property<string>("ReportedBy");

                    b.HasKey("Id");

                    b.ToTable("ReadBeforeFlights");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.StaticFrat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aircraft_KnownDiscrepancies");

                    b.Property<int>("Aircraft_Performance");

                    b.Property<int>("Aircraft_RecentMaintenance");

                    b.Property<int?>("FratId");

                    b.Property<int>("Pilot_CurrencyTraining");

                    b.Property<int>("Pilot_Fatigue");

                    b.Property<int>("Pilot_FlightTimeInMakeModel");

                    b.Property<int>("Pilot_IllnessPhysicalCondition");

                    b.Property<int>("Pilot_ImcPrep");

                    b.Property<int>("Pilot_LastFlightInMakeModel");

                    b.Property<int>("Pilot_Medication");

                    b.Property<int>("Pilot_TotalFlightTime");

                    b.Property<bool>("SoloFlight");

                    b.Property<int>("TfoCoPilot_Fatigue");

                    b.Property<int>("TfoCoPilot_FlightCrew");

                    b.Property<int>("TfoCoPilot_IllnessPhysicalCondition");

                    b.Property<int>("TfoCoPilot_ImcPrep");

                    b.Property<int>("TfoCoPilot_Medication");

                    b.Property<int>("TfoCoPilot_TotalFlightTime");

                    b.Property<bool>("ThirdCrewMember");

                    b.HasKey("Id");

                    b.HasIndex("FratId");

                    b.ToTable("StaticFrats");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Engine", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Aircraft")
                        .WithMany("Engines")
                        .HasForeignKey("AircraftId");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Frat", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Aircraft", "Aircraft")
                        .WithMany()
                        .HasForeignKey("AircraftId");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Mission+CancelCode", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Mission")
                        .WithMany("CancelCodes")
                        .HasForeignKey("MissionId");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.StaticFrat", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Frat", "Frat")
                        .WithMany("StaticFrat")
                        .HasForeignKey("FratId");
                });
        }
    }
}
