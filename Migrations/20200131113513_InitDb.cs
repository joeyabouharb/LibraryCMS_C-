using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCMS.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAuthors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "TblCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TblMembers",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMembers", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "TblBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(maxLength: 100, nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    Isbn = table.Column<string>(nullable: true),
                    AuthorId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBooks", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_TblBooks_TblAuthors_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "TblAuthors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblLoans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLoans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_TblLoans_TblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "TblMembers",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblBooks_AuthorId1",
                table: "TblBooks",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_TblLoans_MemberId",
                table: "TblLoans",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblBooks");

            migrationBuilder.DropTable(
                name: "TblCategories");

            migrationBuilder.DropTable(
                name: "TblLoans");

            migrationBuilder.DropTable(
                name: "TblAuthors");

            migrationBuilder.DropTable(
                name: "TblMembers");
        }
    }
}
