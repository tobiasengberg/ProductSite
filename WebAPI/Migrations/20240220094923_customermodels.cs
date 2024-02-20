using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class customermodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerProfileId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EMailPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Campaigns = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Shipping = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NewsLetter = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMailPreferences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EMailPreferencesId = table.Column<int>(type: "int", nullable: false),
                    AdressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Adress_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_EMailPreferences_EMailPreferencesId",
                        column: x => x.EMailPreferencesId,
                        principalTable: "EMailPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PaymentOptions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerProfiles_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalAmmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Paid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CustomerProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPayment = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CustomerProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerProfileId",
                table: "AspNetUsers",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AdressId",
                table: "Account",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_EMailPreferencesId",
                table: "Account",
                column: "EMailPreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerProfileId",
                table: "Invoice",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerProfileId",
                table: "Order",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CustomerProfiles_CustomerProfileId",
                table: "AspNetUsers",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CustomerProfiles_CustomerProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "CustomerProfiles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "EMailPreferences");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomerProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "AspNetUsers");
        }
    }
}
