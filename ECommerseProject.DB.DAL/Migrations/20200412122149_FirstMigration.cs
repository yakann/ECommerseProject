using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerseProject.DB.DAL.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Picture = table.Column<string>(maxLength: 250, nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Class = table.Column<string>(maxLength: 30, nullable: true),
                    Room = table.Column<string>(maxLength: 15, nullable: true),
                    Building = table.Column<string>(maxLength: 100, nullable: true),
                    Address1 = table.Column<string>(maxLength: 255, nullable: true),
                    Address2 = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 85, nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 7, nullable: true),
                    Country = table.Column<string>(maxLength: 48, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(maxLength: 90, nullable: true),
                    VoiceMail = table.Column<string>(maxLength: 90, nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: true),
                    CreditCard = table.Column<string>(maxLength: 16, nullable: true),
                    CreditCardTypeID = table.Column<int>(nullable: false),
                    CardExpMo = table.Column<int>(nullable: false),
                    CardExpYr = table.Column<int>(nullable: false),
                    BillingAddress = table.Column<string>(maxLength: 255, nullable: true),
                    BillingCity = table.Column<string>(maxLength: 85, nullable: true),
                    BillingRegion = table.Column<string>(maxLength: 85, nullable: true),
                    BillingPostalCode = table.Column<string>(maxLength: 7, nullable: true),
                    BillingCountry = table.Column<string>(maxLength: 48, nullable: true),
                    ShipAddress = table.Column<string>(maxLength: 255, nullable: true),
                    ShipCity = table.Column<string>(maxLength: 85, nullable: true),
                    ShipRegion = table.Column<string>(maxLength: 85, nullable: true),
                    ShipPostalCode = table.Column<string>(maxLength: 7, nullable: true),
                    ShipCountry = table.Column<string>(maxLength: 48, nullable: true),
                    DateEntered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(maxLength: 50, nullable: true),
                    Allowed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 150, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShipperID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: true),
                    ContactFName = table.Column<string>(maxLength: 30, nullable: true),
                    ContactLName = table.Column<string>(maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Address1 = table.Column<string>(maxLength: 60, nullable: true),
                    Address2 = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 15, nullable: true),
                    State = table.Column<string>(maxLength: 25, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 15, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 25, nullable: true),
                    Fax = table.Column<string>(maxLength: 25, nullable: true),
                    Email = table.Column<string>(maxLength: 75, nullable: true),
                    WebSite = table.Column<string>(maxLength: 100, nullable: true),
                    PaymentMethods = table.Column<string>(maxLength: 100, nullable: true),
                    DiscountType = table.Column<int>(maxLength: 100, nullable: false),
                    DiscountRate = table.Column<string>(nullable: true),
                    TypeGoods = table.Column<string>(maxLength: 255, nullable: true),
                    DiscountAvailable = table.Column<bool>(nullable: false),
                    CurrentOrder = table.Column<bool>(nullable: false),
                    CustomerID = table.Column<string>(maxLength: 50, nullable: true),
                    SizeURLSize = table.Column<string>(maxLength: 100, nullable: true),
                    SizeURLColor = table.Column<string>(maxLength: 100, nullable: true),
                    Logo = table.Column<string>(maxLength: 75, nullable: true),
                    Ranking = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<string>(nullable: true),
                    PaymentID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShipDate = table.Column<DateTime>(nullable: false),
                    ShipperID = table.Column<int>(nullable: false),
                    Freight = table.Column<decimal>(type: "Money", nullable: false),
                    SalesTax = table.Column<decimal>(type: "Money", nullable: false),
                    Timestamp = table.Column<string>(maxLength: 50, nullable: true),
                    TransactStatus = table.Column<string>(maxLength: 50, nullable: true),
                    ErrLoc = table.Column<string>(maxLength: 50, nullable: true),
                    ErrMsg = table.Column<string>(maxLength: 250, nullable: true),
                    Fulfilled = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Paid = table.Column<decimal>(type: "Money", nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperID",
                        column: x => x.ShipperID,
                        principalTable: "Shippers",
                        principalColumn: "ShipperID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(maxLength: 50, nullable: true),
                    SupplierProductID = table.Column<string>(maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(maxLength: 60, nullable: true),
                    ProductDescription = table.Column<string>(maxLength: 255, nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    QuantityPerUnit = table.Column<int>(nullable: false),
                    UnitSize = table.Column<string>(maxLength: 20, nullable: true),
                    UnitPrice = table.Column<int>(nullable: false),
                    MSRP = table.Column<int>(nullable: false),
                    AvailableSize = table.Column<string>(maxLength: 50, nullable: true),
                    AvailableColors = table.Column<string>(maxLength: 100, nullable: true),
                    SizeID = table.Column<int>(nullable: false),
                    ColorID = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    UnitWeight = table.Column<float>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitsOnOrder = table.Column<int>(nullable: false),
                    ReorderLevel = table.Column<short>(nullable: false),
                    ProductAvailable = table.Column<bool>(nullable: false),
                    DiscountAvailable = table.Column<bool>(nullable: false),
                    CurrentOrder = table.Column<bool>(nullable: false),
                    Picture = table.Column<string>(maxLength: 100, nullable: true),
                    Ranking = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    Quantity = table.Column<short>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    Total = table.Column<decimal>(type: "Money", nullable: false),
                    Size = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    Fulfilled = table.Column<bool>(nullable: false),
                    BillDate = table.Column<DateTime>(nullable: false),
                    ShipDate = table.Column<DateTime>(nullable: false),
                    ShipperID1 = table.Column<int>(nullable: true),
                    Freight = table.Column<decimal>(type: "Money", nullable: false),
                    SalesTax = table.Column<decimal>(type: "Money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Shippers_ShipperID1",
                        column: x => x.ShipperID1,
                        principalTable: "Shippers",
                        principalColumn: "ShipperID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ShipperID1",
                table: "OrderDetails",
                column: "ShipperID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentID",
                table: "Orders",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                column: "ShipperID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
