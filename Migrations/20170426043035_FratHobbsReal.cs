using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Airborne.Commander.AspNetCore.Migrations
{
    public partial class FratHobbsReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Hobbs",
                table: "Frats",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Hobbs",
                table: "Frats",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
