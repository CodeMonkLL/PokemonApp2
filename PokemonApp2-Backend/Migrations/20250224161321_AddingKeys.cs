using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonApp2_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddingKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTeams");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "UserTeamID",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Slot1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot2 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot3 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot4 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot5 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot6 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot1",
                        column: x => x.Slot1,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot2",
                        column: x => x.Slot2,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot3",
                        column: x => x.Slot3,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot4",
                        column: x => x.Slot4,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot5",
                        column: x => x.Slot5,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_Slot6",
                        column: x => x.Slot6,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_FavPokemon",
                table: "Users",
                column: "FavPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTeamID",
                table: "Users",
                column: "UserTeamID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot1",
                table: "Teams",
                column: "Slot1");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot2",
                table: "Teams",
                column: "Slot2");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot3",
                table: "Teams",
                column: "Slot3");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot4",
                table: "Teams",
                column: "Slot4");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot5",
                table: "Teams",
                column: "Slot5");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Slot6",
                table: "Teams",
                column: "Slot6");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Pokemons_FavPokemon",
                table: "Users",
                column: "FavPokemon",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_UserTeamID",
                table: "Users",
                column: "UserTeamID",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Pokemons_FavPokemon",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_UserTeamID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Users_FavPokemon",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserTeamID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserTeamID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserTeams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Slot1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot2 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot3 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot4 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot5 = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot6 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeams", x => x.ID);
                });
        }
    }
}
