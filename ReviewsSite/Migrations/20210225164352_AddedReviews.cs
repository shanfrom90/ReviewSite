using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Musicals");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Musicals");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MusicalId", "Rating" },
                values: new object[,]
                {
                    { 3, "It was a non-stop thrill ride!", 1, 4 },
                    { 4, "Razzle Dazzle!", 2, 4 },
                    { 5, "Inspirational!", 4, 4 },
                    { 6, "A roaring good time!", 5, 4 },
                    { 7, "Great!", 6, 4 },
                    { 8, "Don't go with your parents! There will be awkwardness.", 7, 4 },
                    { 9, "Memories will be made! Purrfect!", 8, 4 },
                    { 10, "Amazing!", 3, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Musicals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Musicals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "It was a non-stop thrill ride!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Razzle Dazzle!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Amazing!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Inspirational!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "A roaring good time!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Great!", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Don't go with your parents! There will be awkwardness.", 5 });

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "Rating" },
                values: new object[] { "Memories will be made! Purrfect!", 5 });
        }
    }
}
