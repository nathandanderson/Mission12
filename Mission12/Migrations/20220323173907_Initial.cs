using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeValue",
                columns: table => new
                {
                    TimeValueId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeValueName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeValue", x => x.TimeValueId);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    Booked = table.Column<bool>(nullable: false),
                    TimeValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimeID);
                    table.ForeignKey(
                        name: "FK_Times_TimeValue_TimeValueId",
                        column: x => x.TimeValueId,
                        principalTable: "TimeValue",
                        principalColumn: "TimeValueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointments_Times_TimeID",
                        column: x => x.TimeID,
                        principalTable: "Times",
                        principalColumn: "TimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 1, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 2, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 3, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 4, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 5, "12:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 6, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 7, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 8, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 9, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 10, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 11, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 12, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeValue",
                columns: new[] { "TimeValueId", "TimeValueName" },
                values: new object[] { 13, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "Booked", "Date", "TimeValueId" },
                values: new object[] { 1, true, "3/23/2022", 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "TimeID" },
                values: new object[] { 1, "Test@test.com", "Nathan's Party Group", 1, "911", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeID",
                table: "Appointments",
                column: "TimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Times_TimeValueId",
                table: "Times",
                column: "TimeValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "TimeValue");
        }
    }
}
