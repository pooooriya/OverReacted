using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverReacted.Infrastructure.Migrations
{
    public partial class SeedDataForRoleAndChangeFieldOnUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Body", "CreatedOnUTC", "EstimationReadTime", "ShortDescription", "Title", "UpdatedOnUTC", "UserId" },
                values: new object[,]
                {
                    { new Guid("0880877d-d485-4c2e-9015-da06ccb6f065"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9737), new TimeSpan(0, 0, 0, 0, 0)), 5, "Come waste your time with me.", "The WET Codebase", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("6028cde4-367b-46d4-8d70-79f83c7e1846"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9647), new TimeSpan(0, 0, 0, 0, 0)), 14, "Found 99 vulnerabilities (84 moderately irrelevant, 15 highly irrelevant)", "npm audit: Broken by Design", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("64aad55d-7e79-4abc-9641-02e155d5fbe4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 0, 0, 0, 0)), 5, "Let clean code guide you. Then let it go.", "Goodbye, Clean Code", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("8d83f709-6d82-406e-a9ac-5f532519c983"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9753), new TimeSpan(0, 0, 0, 0, 0)), 26, "A personal reflection.", "My Decade in Review", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("fc0ac3e3-96ef-4f3d-adbb-8ba040844e09"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9652), new TimeSpan(0, 0, 0, 0, 0)), 5, "Rendering optimizations that come naturally.", "Before You memo()", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(8419), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"),
                columns: new[] { "CreatedOnUTC", "LastVerificationSent", "VerifyCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(8570), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 16, 8, 1, 1, 729, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 0, 0, 0, 0)), "45c167842a224854ae9ac2780074891f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0880877d-d485-4c2e-9015-da06ccb6f065"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6028cde4-367b-46d4-8d70-79f83c7e1846"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("64aad55d-7e79-4abc-9641-02e155d5fbe4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8d83f709-6d82-406e-a9ac-5f532519c983"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fc0ac3e3-96ef-4f3d-adbb-8ba040844e09"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"),
                columns: new[] { "CreatedOnUTC", "LastVerificationSent", "VerifyCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 16, 7, 58, 43, 557, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)), "a5e65a01b18b41c395979ee85fcb3bdf" });
        }
    }
}
