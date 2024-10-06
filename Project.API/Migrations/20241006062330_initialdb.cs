using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.API.Migrations
{
    /// <inheritdoc />
    public partial class initialdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommentMent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameHack = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateStart = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateEnd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Organizer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMentor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AreaExp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameParti = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleParti = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExperienceParti = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescripPro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StatePro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateEnd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripPriz = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumberMem = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ExperienceTeam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hacks_NameHack",
                table: "Hacks",
                column: "NameHack",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_NameMentor",
                table: "Mentors",
                column: "NameMentor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participants_NameParti",
                table: "Participants",
                column: "NameParti",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plans_NamePro",
                table: "Plans",
                column: "NamePro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_NameTe",
                table: "Teams",
                column: "NameTe",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Hacks");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Prizes");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
