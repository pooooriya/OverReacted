using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverReacted.Infrastructure.Migrations
{
    public partial class SeedDataForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOnUTC", "Name", "UpdatedOnUTC" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Authenticated", null },
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Author", null },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "God", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedOnUTC", "Email", "IsActive", "IsEmailActive", "LastVerificationSent", "Name", "Password", "RoleId", "UpdatedOnUTC", "VerifyCode" },
                values: new object[] { new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"), "https://miro.medium.com/max/3150/1*xxVEfOOAmIKHWOUloRKLhw.jpeg", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 55, 11, 870, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 0, 0, 0, 0)), "Dan.Abramov@Facebook.com", true, true, new DateTimeOffset(new DateTime(2022, 7, 16, 7, 55, 11, 870, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), "Dan Abramov", "73l8gRjwLftklgfdXT+MdiMEjJwGPVMsyVxe16iYpk8=", 2, null, "01c0e6575d5540df90b41da9aca4bd4e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
