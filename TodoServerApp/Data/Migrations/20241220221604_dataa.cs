using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class dataa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "TaskItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsAddedToCart",
                table: "TaskItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAddedToCart",
                value: false);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAddedToCart",
                value: false);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAddedToCart",
                value: false);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsAddedToCart", "Order" },
                values: new object[] { false, "2 покупки" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAddedToCart",
                table: "TaskItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5253), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5269), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5271), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate", "Order" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5273), null, null });
        }
    }
}
