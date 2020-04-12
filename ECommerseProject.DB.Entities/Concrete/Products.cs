using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;//Data Annotations'ları kullabilmek için eklenir.
using System.ComponentModel.DataAnnotations;//Primarykey eklemek için.
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Urunler")]//Tablo Adı --Ek parametre olarak şema adıda verilebilir Schema="Admin".
    public class Products:IEntity
    {
        [Key]//Primary key
        public int ProductID { get; set; }
        [MaxLength(50)]
        public string SKU { get; set; }//SKU number from you or the Supplier
        [MaxLength(50)]
        public string SupplierProductID { get; set; }//Satıcının Ürün Kimliği (SKU veya kendi sistemi olabilir). (Yukarıdaki SKU'nun bir kopyası olabilir.)
        [MaxLength(60)]
        public string ProductName { get; set; }
        [MaxLength(255)]
        public string ProductDescription { get; set; }
        //Foreighn keylerimiz
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Suppliers Suppliers { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public int QuantityPerUnit { get; set; }
        [MaxLength(20)]
        public string UnitSize { get; set; }
        public int UnitPrice { get; set; }
        //[Required] Bir alanın zorunlu olduğunu belirtmek amacıyla kullanılır. Not null demektir.
        public int MSRP { get; set; }
        [MaxLength(50)]
        public string AvailableSize { get; set; }
        [MaxLength(100)]
        public string AvailableColors { get; set; }
        public int SizeID { get; set; }
        public int ColorID { get; set; }
        public decimal Discount { get; set; }
        public float UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public bool CurrentOrder { get; set; }
        [MaxLength(100)]
        public string Picture { get; set; }
        public int Ranking { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
