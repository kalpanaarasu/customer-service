﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerService.Migrations
{
    public partial class AlterCustomerSeedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerAddress", "CustomerEmail", "CustomerName", "CustomerPhone", "CustomerType" },
                values: new object[] { 2, "303, bm shomaparadise", "Ashwin@gmail.com", "Bhuvan", "999999999", "Gold" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
