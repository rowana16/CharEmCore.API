using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharEmCore.Repository.Migrations
{
    public partial class AddCompositeIdtoMtoMtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_OrganizationCounty_Id",
                table: "OrganizationCounty");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationCounty_CountyId",
                table: "OrganizationCounty");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrganizationCounty");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OrganizationCounty_CountyId_OrganizationId",
                table: "OrganizationCounty",
                columns: new[] { "CountyId", "OrganizationId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_OrganizationCounty_CountyId_OrganizationId",
                table: "OrganizationCounty");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrganizationCounty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OrganizationCounty_Id",
                table: "OrganizationCounty",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCounty_CountyId",
                table: "OrganizationCounty",
                column: "CountyId");
        }
    }
}
