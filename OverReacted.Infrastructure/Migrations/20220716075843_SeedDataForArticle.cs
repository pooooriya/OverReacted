using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverReacted.Infrastructure.Migrations
{
    public partial class SeedDataForArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Body", "CreatedOnUTC", "EstimationReadTime", "ShortDescription", "Title", "UpdatedOnUTC", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d928433-c7cb-4925-a1a0-17152171bfa3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)), 5, "Let clean code guide you. Then let it go.", "Goodbye, Clean Code", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("33837892-d49e-40a3-9c42-56f5162f6ddf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 0, 0, 0, 0)), 5, "Come waste your time with me.", "The WET Codebase", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("95ca93c7-da13-474c-a748-0392c0c6405e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 0, 0, 0, 0)), 14, "Found 99 vulnerabilities (84 moderately irrelevant, 15 highly irrelevant)", "npm audit: Broken by Design", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("be7739c9-2aa2-4a51-bd64-6aaf512daa16"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 0, 0, 0, 0)), 26, "A personal reflection.", "My Decade in Review", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("e7bbf83e-b89c-4b8d-8e8f-b2efb3cd185b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1447), new TimeSpan(0, 0, 0, 0, 0)), 5, "Rendering optimizations that come naturally.", "Before You memo()", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"),
                columns: new[] { "CreatedOnUTC", "LastVerificationSent", "VerifyCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)), "a5e65a01b18b41c395979ee85fcb3bdf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1d928433-c7cb-4925-a1a0-17152171bfa3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("33837892-d49e-40a3-9c42-56f5162f6ddf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("95ca93c7-da13-474c-a748-0392c0c6405e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("be7739c9-2aa2-4a51-bd64-6aaf512daa16"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e7bbf83e-b89c-4b8d-8e8f-b2efb3cd185b"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"),
                columns: new[] { "CreatedOnUTC", "LastVerificationSent", "VerifyCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 16, 7, 55, 11, 870, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 16, 7, 55, 11, 870, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), "01c0e6575d5540df90b41da9aca4bd4e" });
        }
    }
}
