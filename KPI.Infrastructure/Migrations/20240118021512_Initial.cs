using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KPIs",
                columns: table => new
                {
                    KPIDNum = table.Column<int>(type: "int", nullable: false),
                    KPIDNescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepNo = table.Column<int>(type: "int", nullable: false),
                    MeasurementUnit = table.Column<bool>(type: "bit", nullable: false),
                    TargetedValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIs", x => x.KPIDNum);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KPIs");
        }
    }
}
