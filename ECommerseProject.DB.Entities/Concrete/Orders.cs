using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Siparisler")]
    public class Orders:IEntity
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customers Customers { get; set; }
        public int PaymentID { get; set; }
        [ForeignKey("PaymentID")]
        public Payment Payment { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShipDate { get; set; }
        public int ShipperID { get; set; }
        [ForeignKey("ShipperID")]
        public Shippers Shippers { get; set; }
        [Column(TypeName = "Money")]
        public decimal Freight { get; set; }
        [Column(TypeName = "Money")]
        public decimal SalesTax { get; set; }
        [MaxLength(50)]
        public string Timestamp { get; set; }
        [MaxLength(50)]
        public string TransactStatus { get; set; }
        [MaxLength(50)]
        public string ErrLoc { get; set; }
        [MaxLength(250)]
        public string ErrMsg { get; set; }
        public bool Fulfilled { get; set; }
        public bool Deleted { get; set; }
        [Column(TypeName = "Money")]
        public decimal Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
