using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularApi.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(maxLength: 50, nullable: true),
                    OrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Document__1ABEEF6F86285147", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDocNum = table.Column<int>(nullable: true),
                    OrderCusName = table.Column<string>(maxLength: 50, nullable: true),
                    OrderGBNum = table.Column<int>(nullable: true),
                    OrderPrice = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    OrderTrafficType = table.Column<string>(maxLength: 50, nullable: true),
                    OrderNote = table.Column<string>(nullable: true),
                    OrderFile = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    OrderPriceStat = table.Column<bool>(nullable: true),
                    OrderServiceStat = table.Column<bool>(nullable: true),
                    OrderServiceID = table.Column<int>(nullable: true),
                    OrderDocID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(maxLength: 50, nullable: true),
                    OrderID = table.Column<int>(nullable: true),
                    ServiceStat = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Services__C51BB0EA51162725", x => x.ServiceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
