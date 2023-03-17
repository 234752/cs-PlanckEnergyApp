using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanckEnergyMVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _chemical_formula_moiety = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _symmetry_cell_setting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _symmetry_space_group_name_H_M = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _symmetry_Int_Tables_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _space_group_name_Hall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_length_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_length_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_length_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_angle_alpha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_angle_beta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_angle_gamma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _cell_volume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
