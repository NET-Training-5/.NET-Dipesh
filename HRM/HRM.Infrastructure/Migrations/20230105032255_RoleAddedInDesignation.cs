using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    /// <inheritdoc />
    public partial class RoleAddedInDesignation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DesignationType",
                table: "Designations",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Designations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Designations",
                newName: "DesignationType");
        }
    }
}
