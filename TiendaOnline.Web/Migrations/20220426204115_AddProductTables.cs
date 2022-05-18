using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaOnline.Web.Migrations
{
      public partial class AddProductTables : Migration
      {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                  migrationBuilder.CreateTable(
                      name: "Categories",
                      columns: table => new
                      {
                            Id = table.Column<int>(type: "int", nullable: false)
                              .Annotation("SqlServer:Identity", "1, 1"),
                            Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                            ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                      },
                      constraints: table =>
                      {
                            table.PrimaryKey("PK_Categories", x => x.Id);
                      });

                  migrationBuilder.CreateTable(
                      name: "Products",
                      columns: table => new
                      {
                            Id = table.Column<int>(type: "int", nullable: false)
                              .Annotation("SqlServer:Identity", "1, 1"),
                            Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                            Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                            IsActive = table.Column<bool>(type: "bit", nullable: false),
                            IsStarred = table.Column<bool>(type: "bit", nullable: false),
                            CategoryId = table.Column<int>(type: "int", nullable: true)
                      },
                      constraints: table =>
                      {
                            table.PrimaryKey("PK_Products", x => x.Id);
                            table.ForeignKey(
                          name: "FK_Products_Categories_CategoryId",
                          column: x => x.CategoryId,
                          principalTable: "Categories",
                          principalColumn: "Id");
                      });

                  migrationBuilder.CreateTable(
                      name: "ProductImages",
                      columns: table => new
                      {
                            Id = table.Column<int>(type: "int", nullable: false)
                              .Annotation("SqlServer:Identity", "1, 1"),
                            ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                            ProductId = table.Column<int>(type: "int", nullable: true)
                      },
                      constraints: table =>
                      {
                            table.PrimaryKey("PK_ProductImages", x => x.Id);
                            table.ForeignKey(
                          name: "FK_ProductImages_Products_ProductId",
                          column: x => x.ProductId,
                          principalTable: "Products",
                          principalColumn: "Id");
                      });

                  migrationBuilder.CreateIndex(
                      name: "IX_Categories_Name",
                      table: "Categories",
                      column: "Name",
                      unique: true);

                  migrationBuilder.CreateIndex(
                      name: "IX_ProductImages_ProductId",
                      table: "ProductImages",
                      column: "ProductId");

                  migrationBuilder.CreateIndex(
                      name: "IX_Products_CategoryId",
                      table: "Products",
                      column: "CategoryId");

                  migrationBuilder.CreateIndex(
                      name: "IX_Products_Name",
                      table: "Products",
                      column: "Name",
                      unique: true);
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                  migrationBuilder.DropTable(
                      name: "ProductImages");

                  migrationBuilder.DropTable(
                      name: "Products");

                  migrationBuilder.DropTable(
                      name: "Categories");
            }
      }
}
