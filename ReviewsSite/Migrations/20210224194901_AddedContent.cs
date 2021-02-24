using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musicals",
                columns: new[] { "Id", "Comment", "Description", "Genre", "Rating", "Title" },
                values: new object[,]
                {
                    { 3, "Amazing!", "A tale of two friends who happen to be political rivals and founders of a nation. Hijinks ensue.", "Historical", 5, "Hamilton" },
                    { 4, "Inspirational!", "A tale of the last days of Jesus. Hijinks ensue.", "Drama", 5, "Jesus Christ Superstar" },
                    { 5, "A roaring good time!", "A tale of two brothers who happen to be lions. Hijinks ensue.", "Family", 5, "The Lion King" },
                    { 6, "Great!", "A tale of roommates in the city. Hijinks ensue.", "Drama", 5, "Rent" },
                    { 7, "Don't go with your parents! There will be awkwardness.", "A tale of two Mormons who happen to be missionaries. Hijinks really ensue.", "Comedy", 5, "The Book of Mormon" },
                    { 8, "Memories will be made! Purrfect!", "A tale of many cats who happen to be magical. Hijinks ensue.", "Drama", 5, "Cats" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
