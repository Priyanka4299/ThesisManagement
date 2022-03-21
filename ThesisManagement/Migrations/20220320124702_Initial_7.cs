using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisManagement.Migrations
{
    public partial class Initial_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContentType",
                table: "SubmissionDetails");

            migrationBuilder.RenameColumn(
                name: "remark",
                table: "SubmissionDetails",
                newName: "Remarks");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "SubmissionDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "SubmissionDetails",
                newName: "remark");

            migrationBuilder.AlterColumn<int>(
                name: "remark",
                table: "SubmissionDetails",
                type: "int",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FileContentType",
                table: "SubmissionDetails",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }
    }
}
