using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Tedarikciler")]
    public class Suppliers:IEntity
    {
        [Key]
        public int SupplierID { get; set; }
        [MaxLength(50)]
        public string CompanyName { get; set; }
        [MaxLength(30)]
        public string ContactFName { get; set; }
        [MaxLength(50)]
        public string ContactLName { get; set; }
        [MaxLength(30)]
        public string ContactTitle { get; set; }
        [MaxLength(60)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(25)]
        public string State { get; set; }
        [MaxLength(15)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(25)]
        public string Phone { get; set; }
        [MaxLength(25)]
        public string Fax { get; set; }
        [MaxLength(75)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string WebSite { get; set; }
        [MaxLength(100)]
        public string PaymentMethods { get; set; }
        [MaxLength(100)]
        public int DiscountType { get; set; }//Standart bir indirim yüzdesi varsa, bunu burada ayarlayabilir ve daha sonra bu Tedarikçi'nin Tüm Ürünlerine uygulayabilirsiniz.
        public string DiscountRate { get; set; }
        [MaxLength(255)]
        public string TypeGoods { get; set; }
        public bool DiscountAvailable { get; set; }
        public bool CurrentOrder { get; set; }
        [MaxLength(50)]
        public string CustomerID { get; set; }
        [MaxLength(100)]
        public string SizeURLSize { get; set; }
        [MaxLength(100)]
        public string SizeURLColor { get; set; }
        [MaxLength(75)]
        public string Logo { get; set; }
        public int Ranking { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
