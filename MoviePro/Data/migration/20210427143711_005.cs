using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.data.migration
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast");

            migrationBuilder.DropIndex(
                name: "IX_Cast_MovieId",
                table: "Cast");

            migrationBuilder.AddColumn<int>(
                name: "CrewId",
                table: "Movie",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Castmovie",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "integer", nullable: false),
                    MovieIDId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Castmovie", x => new { x.CastId, x.MovieIDId });
                    table.ForeignKey(
                        name: "FK_Castmovie_Cast_CastId",
                        column: x => x.CastId,
                        principalTable: "Cast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Castmovie_Movie_MovieIDId",
                        column: x => x.MovieIDId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CrewId",
                table: "Movie",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_Castmovie_MovieIDId",
                table: "Castmovie",
                column: "MovieIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Crew_CrewId",
                table: "Movie",
                column: "CrewId",
                principalTable: "Crew",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Crew_CrewId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Castmovie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CrewId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CrewId",
                table: "Movie");

            migrationBuilder.CreateIndex(
                name: "IX_Cast_MovieId",
                table: "Cast",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
