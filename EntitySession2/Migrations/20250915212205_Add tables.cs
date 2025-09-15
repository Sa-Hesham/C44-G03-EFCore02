using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession2.Migrations
{
    /// <inheritdoc />
    public partial class Addtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments_Table",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 2"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments_Table", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employess",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 3"),
                    EmployeeName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employess", x => x.EmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments_Table");

            migrationBuilder.DropTable(
                name: "Employess");
        }
    }
}
