using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("SiparisDetay")]
    public class OrderDetails:IEntity
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Orders Orders { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Products Products { get; set; }
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        [Column(TypeName = "Money")]
        public decimal Total { get; set; }
        [MaxLength(50)]
        public string Size { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        public bool Fulfilled { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime ShipDate { get; set; }
        public Shippers ShipperID { get; set; }
        [Column(TypeName = "Money")]
        public decimal Freight { get; set; }
        [Column(TypeName = "Money")]
        public decimal SalesTax { get; set; }
    }
}
