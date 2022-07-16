using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverReacted.Infrastructure.Migrations
{
    public partial class AddFluentValidationForArticleAndUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles");

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
                table: "Roles",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Articles",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Body", "CreatedOnUTC", "EstimationReadTime", "ShortDescription", "Title", "UpdatedOnUTC", "UserId" },
                values: new object[,]
                {
                    { new Guid("44ce8eee-2776-4a95-b5ff-862251113914"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), 5, "Rendering optimizations that come naturally.", "Before You memo()", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("50da83ff-de35-48e7-a3ec-6ba44444d44e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8265), new TimeSpan(0, 0, 0, 0, 0)), 26, "A personal reflection.", "My Decade in Review", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("5b9a19d0-203a-4d88-8b63-69353d487de4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 0, 0, 0, 0)), 5, "Let clean code guide you. Then let it go.", "Goodbye, Clean Code", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("69694838-6c41-4c82-86f5-4e2bbf8d4482"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, 0, 0, 0, 0)), 5, "Come waste your time with me.", "The WET Codebase", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") },
                    { new Guid("80d232ce-e0ca-4845-9311-c52adc5994ba"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8253), new TimeSpan(0, 0, 0, 0, 0)), 14, "Found 99 vulnerabilities (84 moderately irrelevant, 15 highly irrelevant)", "npm audit: Broken by Design", null, new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUTC",
                value: new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdceb4a-29c8-4cc2-b3f6-5ed60658f661"),
                columns: new[] { "CreatedOnUTC", "LastVerificationSent", "VerifyCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(7421), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 16, 8, 5, 24, 821, DateTimeKind.Unspecified).AddTicks(8193), new TimeSpan(0, 0, 0, 0, 0)), "2062bee11cfe42d1a4f8f660a1315d23" });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("44ce8eee-2776-4a95-b5ff-862251113914"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50da83ff-de35-48e7-a3ec-6ba44444d44e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5b9a19d0-203a-4d88-8b63-69353d487de4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69694838-6c41-4c82-86f5-4e2bbf8d4482"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("80d232ce-e0ca-4845-9311-c52adc5994ba"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Articles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
