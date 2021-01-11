using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Migrations
{
    public partial class BlogMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    blogText = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    title = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
