using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibrarySystem.Data.Migrations
{
    public partial class Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new Guid("c123b30a-bb3b-4415-9208-feb89a70fd28"), new DateTimeOffset(new DateTime(1964, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), "William", "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new Guid("19d3c6be-ddf5-4aa6-8448-30cd55a6ac0a"), new DateTimeOffset(new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)), "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new Guid("296ae62d-959d-42c4-ba9f-5b2713b03d5e"), new DateTimeOffset(new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)), "Agatha", "Christie" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "MainCategory", "Name", "SubCategory" },
                values: new object[] { new Guid("f9787b4e-8ee5-4b6a-b19c-f8bba5624d10"), new Guid("c123b30a-bb3b-4415-9208-feb89a70fd28"), "In this guide, I’ll walk you through how to write a book .....", "Poetry", "Hamlet", "novels" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "MainCategory", "Name", "SubCategory" },
                values: new object[] { new Guid("633212b6-f6de-4c98-a6ec-16e742643ef2"), new Guid("19d3c6be-ddf5-4aa6-8448-30cd55a6ac0a"), "In this guide, I’ll walk you through how to write a book .....", "History", "Hamlet", "Movies" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "MainCategory", "Name", "SubCategory" },
                values: new object[] { new Guid("790874ac-3910-4c4b-9287-a50a2b8f27b6"), new Guid("296ae62d-959d-42c4-ba9f-5b2713b03d5e"), "In this guide, I’ll walk you through how to write a book .....", "novels", "Hamlet", "Police novels" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("633212b6-f6de-4c98-a6ec-16e742643ef2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("790874ac-3910-4c4b-9287-a50a2b8f27b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f9787b4e-8ee5-4b6a-b19c-f8bba5624d10"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("19d3c6be-ddf5-4aa6-8448-30cd55a6ac0a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("296ae62d-959d-42c4-ba9f-5b2713b03d5e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c123b30a-bb3b-4415-9208-feb89a70fd28"));
        }
    }
}
