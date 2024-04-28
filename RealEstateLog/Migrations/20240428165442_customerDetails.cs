using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateLog.Migrations
{
    /// <inheritdoc />
    public partial class customerDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CustomerPrice",
                table: "Customers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FSBODate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ListingDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListingNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListingRoomCount",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextCallDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerAddress",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerPrice",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FSBODate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ListingDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ListingNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ListingRoomCount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "NextCallDate",
                table: "Customers");
        }
    }
}
