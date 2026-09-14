using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInfoDemo.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Students",
                newName: "stuphone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "stuname");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Students",
                newName: "stugender");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "stuemail");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "Students",
                newName: "stuDob");

            migrationBuilder.RenameColumn(
                name: "sid",
                table: "Students",
                newName: "stuid");

            migrationBuilder.AlterColumn<string>(
                name: "stuphone",
                table: "Students",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "stuname",
                table: "Students",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "stugender",
                table: "Students",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "stuemail",
                table: "Students",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stuphone",
                table: "Students",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "stuname",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "stugender",
                table: "Students",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "stuemail",
                table: "Students",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "stuDob",
                table: "Students",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "stuid",
                table: "Students",
                newName: "sid");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
