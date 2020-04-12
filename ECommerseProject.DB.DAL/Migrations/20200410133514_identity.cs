using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerseProject.DB.DAL.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Müşteriler",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<int>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    Room = table.Column<int>(nullable: false),
                    Building = table.Column<int>(nullable: false),
                    Address1 = table.Column<int>(nullable: false),
                    Address2 = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Email = table.Column<int>(nullable: false),
                    VoiceMail = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    CreditCard = table.Column<int>(nullable: false),
                    CreditCardTypeID = table.Column<int>(nullable: false),
                    CardExpMo = table.Column<int>(nullable: false),
                    CardExpYr = table.Column<int>(nullable: false),
                    BillingAddress = table.Column<int>(nullable: false),
                    BillingCity = table.Column<int>(nullable: false),
                    BillingRegion = table.Column<int>(nullable: false),
                    BillingPostalCode = table.Column<int>(nullable: false),
                    BillingCountry = table.Column<int>(nullable: false),
                    ShipAddress = table.Column<int>(nullable: false),
                    ShipCity = table.Column<int>(nullable: false),
                    ShipRegion = table.Column<int>(nullable: false),
                    ShipPostalCode = table.Column<int>(nullable: false),
                    ShipCountry = table.Column<int>(nullable: false),
                    DateEntered = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Müşteriler", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Nakliyatçılar",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nakliyatçılar", x => x.ShipperID);
                });

            migrationBuilder.CreateTable(
                name: "Ödeme",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(nullable: true),
                    Allowed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ödeme", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetay",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Fulfilled = table.Column<int>(nullable: false),
                    BillDate = table.Column<int>(nullable: false),
                    ShipDate = table.Column<int>(nullable: false),
                    ShipperID = table.Column<int>(nullable: false),
                    Freight = table.Column<int>(nullable: false),
                    SalesTax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetay", x => x.OrderDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<string>(nullable: true),
                    PaymentID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<int>(nullable: false),
                    RequiredDate = table.Column<int>(nullable: false),
                    ShipDate = table.Column<int>(nullable: false),
                    ShipperID = table.Column<int>(nullable: false),
                    Freight = table.Column<int>(nullable: false),
                    SalesTax = table.Column<int>(nullable: false),
                    Timestamp = table.Column<int>(nullable: false),
                    TransactStatus = table.Column<int>(nullable: false),
                    ErrLoc = table.Column<int>(nullable: false),
                    ErrMsg = table.Column<int>(nullable: false),
                    Fulfilled = table.Column<int>(nullable: false),
                    Deleted = table.Column<int>(nullable: false),
                    Paid = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactFName = table.Column<int>(nullable: false),
                    ContactLName = table.Column<int>(nullable: false),
                    ContactTitle = table.Column<int>(nullable: false),
                    Address1 = table.Column<int>(nullable: false),
                    Address2 = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Fax = table.Column<int>(nullable: false),
                    Email = table.Column<int>(nullable: false),
                    WebSite = table.Column<int>(nullable: false),
                    PaymentMethods = table.Column<int>(nullable: false),
                    DiscountType = table.Column<int>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    TypeGoods = table.Column<int>(nullable: false),
                    DiscountAvailable = table.Column<int>(nullable: false),
                    CurrentOrder = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    SizeURL = table.Column<int>(nullable: false),
                    Logo = table.Column<int>(nullable: false),
                    Ranking = table.Column<int>(nullable: false),
                    Note = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "UrunlerS",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(nullable: true),
                    SupplierProductID = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    QuantityPerUnit = table.Column<int>(nullable: false),
                    UnitSize = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<int>(nullable: false),
                    MSRP = table.Column<int>(nullable: false),
                    AvailableSize = table.Column<int>(nullable: false),
                    AvailableColors = table.Column<int>(nullable: false),
                    SizeID = table.Column<int>(nullable: false),
                    ColorID = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    UnitWeight = table.Column<int>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitsOnOrder = table.Column<int>(nullable: false),
                    ReorderLevel = table.Column<int>(nullable: false),
                    ProductAvailable = table.Column<int>(nullable: false),
                    DiscountAvailable = table.Column<int>(nullable: false),
                    CurrentOrder = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    Ranking = table.Column<int>(nullable: false),
                    Note = table.Column<int>(nullable: false),
                    SuppliersSupplierID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunlerS", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_UrunlerS_Tedarikciler_SuppliersSupplierID",
                        column: x => x.SuppliersSupplierID,
                        principalTable: "Tedarikciler",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UrunlerS_SuppliersSupplierID",
                table: "UrunlerS",
                column: "SuppliersSupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Müşteriler");

            migrationBuilder.DropTable(
                name: "Nakliyatçılar");

            migrationBuilder.DropTable(
                name: "Ödeme");

            migrationBuilder.DropTable(
                name: "SiparisDetay");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "UrunlerS");

            migrationBuilder.DropTable(
                name: "Tedarikciler");
        }
    }
}
