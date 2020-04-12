using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerseProject.DB.DAL.Migrations
{
    public partial class identity55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrunlerS_Tedarikciler_SuppliersSupplierID",
                table: "UrunlerS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UrunlerS",
                table: "UrunlerS");

            migrationBuilder.RenameTable(
                name: "UrunlerS",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_UrunlerS_SuppliersSupplierID",
                table: "Products",
                newName: "IX_Products_SuppliersSupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tedarikciler_SuppliersSupplierID",
                table: "Products",
                column: "SuppliersSupplierID",
                principalTable: "Tedarikciler",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tedarikciler_SuppliersSupplierID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "UrunlerS");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SuppliersSupplierID",
                table: "UrunlerS",
                newName: "IX_UrunlerS_SuppliersSupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UrunlerS",
                table: "UrunlerS",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_UrunlerS_Tedarikciler_SuppliersSupplierID",
                table: "UrunlerS",
                column: "SuppliersSupplierID",
                principalTable: "Tedarikciler",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
