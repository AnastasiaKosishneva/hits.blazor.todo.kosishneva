using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class aa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TaskItems",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TaskItems",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Order",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedDate", "Order", "Product" },
                values: new object[] { "одежда", new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5253), "252 покупки", "Футболка" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CreatedDate", "Order", "Product" },
                values: new object[] { "одежда", new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5269), "1000 покупок", "Джинсы" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreatedDate", "Order", "Product" },
                values: new object[] { "верхняя одежда", new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5271), "2 покупки", "Куртка" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Order" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 11, 2, 321, DateTimeKind.Local).AddTicks(5273), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "TaskItems");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "TaskItems",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "TaskItems",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 34, 6, 761, DateTimeKind.Local).AddTicks(9165), "Описание задачи 1", "Задача 1" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 34, 6, 761, DateTimeKind.Local).AddTicks(9181), "Описание задачи 2", "Задача 2" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 34, 6, 761, DateTimeKind.Local).AddTicks(9183), "Описание задачи 3", "Задача 3" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 21, 34, 6, 761, DateTimeKind.Local).AddTicks(9184));
        }
    }
}
