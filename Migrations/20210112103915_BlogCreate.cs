using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Migrations
{
    public partial class BlogCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    blogText = table.Column<string>(type: "longtext", unicode: false, nullable: false),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    title = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}
