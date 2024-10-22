using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace October8.Migrations
{
    public partial class teams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "abi");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "ny");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "ss");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "atl", "nfc", "south", "ATL.png", "Atlanta Falcons" },
                    { "bal", "afc", "north", "BAL.png", "Baltimore Ravens" },
                    { "buf", "afc", "east", "BUF.png", "Buffalo Bills" },
                    { "car", "nfc", "south", "CAR.png", "Carolina Panthers" },
                    { "chi", "nfc", "north", "CHI.png", "Chicago Bears" },
                    { "cin", "afc", "north", "CIN.png", "Cincinnati Bengals" },
                    { "cle", "afc", "north", "CLE.png", "Cleveland Browns" },
                    { "dal", "nfc", "east", "DAL.png", "Dallas Cowboys" },
                    { "den", "afc", "west", "DEN.png", "Denver Broncos" },
                    { "det", "nfc", "north", "DET.png", "Detroit Lions" },
                    { "gb", "nfc", "north", "GB.png", "Green Bay Packers" },
                    { "hou", "afc", "south", "HOU.png", "Houston Texans" },
                    { "ind", "afc", "south", "IND.png", "Indianapolis Colts" },
                    { "jax", "afc", "south", "JAX.png", "Jacksonville Jaguars" },
                    { "kc", "afc", "west", "KC.png", "Kansas City Chiefs" },
                    { "lac", "afc", "west", "LAC.png", "Los Angeles Chargers" },
                    { "lar", "nfc", "west", "LAR.png", "Los Angeles Rams" },
                    { "lv", "afc", "west", "LV.png", "Las Vegas Raiders" },
                    { "mia", "afc", "east", "MIA.png", "Miami Dolphins" },
                    { "min", "nfc", "north", "MIN.png", "Minnesota Vikings" },
                    { "ne", "afc", "east", "NE.png", "New England Patriots" },
                    { "no", "nfc", "south", "NO.png", "New Orleans Saints" },
                    { "nyg", "nfc", "east", "NYG.png", "New York Giants" },
                    { "nyj", "afc", "east", "NYJ.png", "New York Jets" },
                    { "phi", "nfc", "east", "PHI.png", "Philadelphia Eagles" },
                    { "pit", "afc", "north", "PIT.png", "Pittsburgh Steelers" },
                    { "sea", "nfc", "west", "SEA.png", "Seattle Seahawks" },
                    { "sf", "nfc", "west", "SF.png", "San Francisco 49ers" },
                    { "tb", "nfc", "south", "TB.png", "Tampa Bay Buccaneers" },
                    { "ten", "afc", "south", "TEN.png", "Tennessee Titans" },
                    { "was", "nfc", "east", "WAS.png", "Washington Commanders" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "atl");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "bal");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "buf");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "car");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "chi");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "cin");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "cle");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "dal");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "den");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "det");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "gb");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "hou");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "ind");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "jax");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "kc");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "lac");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "lar");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "lv");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "mia");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "min");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "ne");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "no");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "nyg");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "nyj");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "phi");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "pit");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "sea");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "sf");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "tb");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "ten");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: "was");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "abi", "nfc", "west", "ARI.png", "Arizona Cardinals" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ny", "nfc", "west", "ARI.png", "Arizona Cardinals" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ss", "nfc", "west", "ARI.png", "Arizona Cardinals" });
        }
    }
}
