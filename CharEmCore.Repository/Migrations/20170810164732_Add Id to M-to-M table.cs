using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharEmCore.Repository.Migrations
{
    public partial class AddIdtoMtoMtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrganizationCounty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OrganizationCounty_Id",
                table: "OrganizationCounty",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_OrganizationCounty_Id",
                table: "OrganizationCounty");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrganizationCounty");
        }
    }
}
