using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170212041116_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Aircraft", b =>
                {
                    b.Property<int>("AircraftId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftTotalTime");

                    b.Property<int>("AircraftType");

                    b.Property<string>("CallSign");

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

                    b.Property<string>("TailNumber");

                    b.Property<int>("TourqueEvents");

                    b.Property<int>("TourqueEventsRIN");

                    b.Property<int>("YearManufactured");

                    b.HasKey("AircraftId");

                    b.ToTable("Aircrafts");
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

                    b.Property<string>("MissionName");

                    b.Property<string>("MissionNumber");

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

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Engine", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Aircraft")
                        .WithMany("Engines")
                        .HasForeignKey("AircraftId");
                });

            modelBuilder.Entity("Airborne.Commander.AspNetCore.Models.Mission+CancelCode", b =>
                {
                    b.HasOne("Airborne.Commander.AspNetCore.Models.Mission")
                        .WithMany("CancelCodes")
                        .HasForeignKey("MissionId");
                });
        }
    }
}
