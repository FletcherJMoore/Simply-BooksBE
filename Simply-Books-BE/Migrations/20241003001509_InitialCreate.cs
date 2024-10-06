using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Simply_Books_BE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    First_Name = table.Column<string>(type: "text", nullable: true),
                    Last_Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    First_Name = table.Column<string>(type: "text", nullable: false),
                    Last_Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Author_Id = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "First_Name", "Image", "Last_Name", "Uid" },
                values: new object[,]
                {
                    { 1, "ta@ta.com", true, "Tomi", "https://upload.wikimedia.org/wikipedia/commons/1/17/Tomi_Adeyemi_2020.JPG", "Adeyemi", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 2, "ba@obama.com", true, "Barack", "https://upload.wikimedia.org/wikipedia/commons/8/8d/President_Barack_Obama.jpg", "Obama", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 3, "hz@zinn.com", false, "Howard", "https://upload.wikimedia.org/wikipedia/commons/e/ef/Howard_Zinn%2C_2009_%28cropped%29.jpg", "Zinn", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 4, "at@thomas.com", false, "Angie", "https://upload.wikimedia.org/wikipedia/commons/a/a1/Angie_thomas_9022008.jpg", "Thomas", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 5, "cw@whithead.com", false, "Colson", "https://upload.wikimedia.org/wikipedia/commons/5/5c/Colson_Whitehead_BBF_2011_Shankbone.JPG", "Whitehead", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 6, "mk@kendall.com", true, "Mikki", "https://upload.wikimedia.org/wikipedia/commons/1/17/Author%2C_activist%2C_and_cultural_critic_Mikki_Kendall.jpg", "Kendall", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 7, "lm@lm.com", true, "L.L", "https://mpd-biblio-authors.imgix.net/200066919.jpg?fit=crop&crop=faces&w=870&h=870", "McKinney", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 8, "jb@baldwin.com", false, "James", "https://upload.wikimedia.org/wikipedia/commons/3/37/James_Baldwin_33_Allan_Warren.jpg", "Baldwin", "bQ8n51pkphNBlIlN5RPliCL1N7o2" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Author_Id", "Description", "Image", "Price", "Sale", "Title", "Uid" },
                values: new object[,]
                {
                    { 1, null, 2, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", 24.99m, false, "A Promise Land", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 2, null, 1, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", 12.99m, true, "Children of Blood and Bone", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 3, null, 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", 30.00m, false, "A People's History of the United States of America", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 4, null, 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", 15.89m, false, "Concrete Rose", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 5, null, 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", 25.00m, true, "The Underground Railroad", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 6, null, 6, "this is a book", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", 50.00m, true, "Hood Feminism", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 7, null, 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", 15.00m, false, "A Blade So Black", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 8, null, 7, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", 14.99m, false, "A Dream So Dark", "bQ8n51pkphNBlIlN5RPliCL1N7o2" },
                    { 9, null, 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", 12.00m, false, "The Fire Next Time", "bQ8n51pkphNBlIlN5RPliCL1N7o2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "First_Name", "Last_Name", "Uid" },
                values: new object[] { 1, "fletcherjmoore14@gmail.com", "Fletcher", "Moore", "bQ8n51pkphNBlIlN5RPliCL1N7o2" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
