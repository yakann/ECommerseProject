﻿// <auto-generated />
using System;
using ECommerseProject.DB.DAL.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerseProject.DB.DAL.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20200410134916_identity2")]
    partial class identity2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Customers", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Address1")
                        .HasColumnType("int");

                    b.Property<int>("Address2")
                        .HasColumnType("int");

                    b.Property<int>("BillingAddress")
                        .HasColumnType("int");

                    b.Property<int>("BillingCity")
                        .HasColumnType("int");

                    b.Property<int>("BillingCountry")
                        .HasColumnType("int");

                    b.Property<int>("BillingPostalCode")
                        .HasColumnType("int");

                    b.Property<int>("BillingRegion")
                        .HasColumnType("int");

                    b.Property<int>("Building")
                        .HasColumnType("int");

                    b.Property<int>("CardExpMo")
                        .HasColumnType("int");

                    b.Property<int>("CardExpYr")
                        .HasColumnType("int");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<int>("CreditCard")
                        .HasColumnType("int");

                    b.Property<int>("CreditCardTypeID")
                        .HasColumnType("int");

                    b.Property<int>("DateEntered")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("Room")
                        .HasColumnType("int");

                    b.Property<int>("ShipAddress")
                        .HasColumnType("int");

                    b.Property<int>("ShipCity")
                        .HasColumnType("int");

                    b.Property<int>("ShipCountry")
                        .HasColumnType("int");

                    b.Property<int>("ShipPostalCode")
                        .HasColumnType("int");

                    b.Property<int>("ShipRegion")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("VoiceMail")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.ToTable("Müşteriler");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillDate")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Freight")
                        .HasColumnType("int");

                    b.Property<int>("Fulfilled")
                        .HasColumnType("int");

                    b.Property<string>("OrderID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("SalesTax")
                        .HasColumnType("int");

                    b.Property<int>("ShipDate")
                        .HasColumnType("int");

                    b.Property<int>("ShipperID")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.ToTable("SiparisDetay");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<int>("ErrLoc")
                        .HasColumnType("int");

                    b.Property<int>("ErrMsg")
                        .HasColumnType("int");

                    b.Property<int>("Freight")
                        .HasColumnType("int");

                    b.Property<int>("Fulfilled")
                        .HasColumnType("int");

                    b.Property<int>("OrderDate")
                        .HasColumnType("int");

                    b.Property<int>("Paid")
                        .HasColumnType("int");

                    b.Property<int>("PaymentDate")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("RequiredDate")
                        .HasColumnType("int");

                    b.Property<int>("SalesTax")
                        .HasColumnType("int");

                    b.Property<int>("ShipDate")
                        .HasColumnType("int");

                    b.Property<int>("ShipperID")
                        .HasColumnType("int");

                    b.Property<int>("Timestamp")
                        .HasColumnType("int");

                    b.Property<int>("TransactStatus")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allowed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Ödeme");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvailableColors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvailableSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.Property<bool>("CurrentOrder")
                        .HasColumnType("bit");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("DiscountAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("MSRP")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.Property<string>("SupplierProductID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuppliersSupplierID")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<string>("UnitSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitWeight")
                        .HasColumnType("int");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("SuppliersSupplierID");

                    b.ToTable("UrunlerS");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Shippers", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipperID");

                    b.ToTable("Nakliyatçılar");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Suppliers", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Address1")
                        .HasColumnType("int");

                    b.Property<int>("Address2")
                        .HasColumnType("int");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactFName")
                        .HasColumnType("int");

                    b.Property<int>("ContactLName")
                        .HasColumnType("int");

                    b.Property<int>("ContactTitle")
                        .HasColumnType("int");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<int>("CurrentOrder")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("DiscountAvailable")
                        .HasColumnType("int");

                    b.Property<int>("DiscountRate")
                        .HasColumnType("int");

                    b.Property<int>("DiscountType")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("Fax")
                        .HasColumnType("int");

                    b.Property<int>("Logo")
                        .HasColumnType("int");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethods")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<int>("SizeURL")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("TypeGoods")
                        .HasColumnType("int");

                    b.Property<int>("WebSite")
                        .HasColumnType("int");

                    b.HasKey("SupplierID");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("ECommerseProject.DB.Entities.Concrete.Products", b =>
                {
                    b.HasOne("ECommerseProject.DB.Entities.Concrete.Suppliers", "Suppliers")
                        .WithMany()
                        .HasForeignKey("SuppliersSupplierID");
                });
#pragma warning restore 612, 618
        }
    }
}