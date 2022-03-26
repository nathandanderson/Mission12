using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    Booked = table.Column<bool>(nullable: false),
                    TimeValue = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimeID);
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 1, false, "3/23/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 66, false, "3/28/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 65, false, "3/27/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 64, false, "3/27/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 63, false, "3/27/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 62, false, "3/27/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 61, false, "3/27/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 60, false, "3/27/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 59, false, "3/27/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 58, false, "3/27/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 57, false, "3/27/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 56, false, "3/27/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 55, false, "3/27/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 54, false, "3/27/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 53, false, "3/27/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 52, false, "3/26/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 51, false, "3/26/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 50, false, "3/26/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 49, false, "3/26/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 48, false, "3/26/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 67, false, "3/28/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 47, false, "3/26/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 68, false, "3/28/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 70, false, "3/28/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 89, false, "3/29/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 88, false, "3/29/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 87, false, "3/29/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 86, false, "3/29/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 85, false, "3/29/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 84, false, "3/29/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 83, false, "3/29/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 82, false, "3/29/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 81, false, "3/29/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 80, false, "3/29/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 79, false, "3/29/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 78, false, "3/28/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 77, false, "3/28/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 76, false, "3/28/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 75, false, "3/28/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 74, false, "3/28/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 73, false, "3/28/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 72, false, "3/28/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 71, false, "3/28/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 69, false, "3/28/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 90, false, "3/29/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 46, false, "3/26/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 44, false, "3/26/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 20, false, "3/24/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 19, false, "3/24/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 18, false, "3/24/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 17, false, "3/24/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 16, false, "3/24/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 15, false, "3/24/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 14, false, "3/24/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 13, false, "3/23/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 12, false, "3/23/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 11, false, "3/23/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 10, false, "3/23/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 9, false, "3/23/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 8, false, "3/23/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 7, false, "3/23/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 6, false, "3/23/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 5, false, "3/23/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 4, false, "3/23/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 3, false, "3/23/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 2, false, "3/23/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 21, false, "3/24/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 45, false, "3/26/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 22, false, "3/24/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 24, false, "3/24/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 43, false, "3/26/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 42, false, "3/26/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 41, false, "3/26/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 40, false, "3/26/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 39, false, "3/25/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 38, false, "3/25/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 37, false, "3/25/2022", null, null, 0, null, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 36, false, "3/25/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 35, false, "3/25/2022", null, null, 0, null, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 34, false, "3/25/2022", null, null, 0, null, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 33, false, "3/25/2022", null, null, 0, null, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 32, false, "3/25/2022", null, null, 0, null, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 31, false, "3/25/2022", null, null, 0, null, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 30, false, "3/25/2022", null, null, 0, null, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 29, false, "3/25/2022", null, null, 0, null, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 28, false, "3/25/2022", null, null, 0, null, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 27, false, "3/25/2022", null, null, 0, null, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 26, false, "3/24/2022", null, null, 0, null, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 25, false, "3/24/2022", null, null, 0, null, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 23, false, "3/24/2022", null, null, 0, null, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "Email", "GroupName", "GroupSize", "Phone", "TimeValue" },
                values: new object[] { 91, false, "3/29/2022", null, null, 0, null, "8:00 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
