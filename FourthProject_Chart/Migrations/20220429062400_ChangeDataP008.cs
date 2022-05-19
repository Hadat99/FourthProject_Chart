using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourthProject_Chart.Migrations
{
    public partial class ChangeDataP008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "compaction_work_height",
                table: "P0008Compaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "compaction_work_height",
                table: "P0008Compaction",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
