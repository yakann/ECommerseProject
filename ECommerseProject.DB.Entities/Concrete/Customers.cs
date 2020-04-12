using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Müşteriler")]
    public class Customers:IEntity
    {
        [Key]
        [MaxLength(50)]
        public string CustomerID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string Class { get; set; }
        [MaxLength(15)]
        public string Room { get; set; }
        [MaxLength(100)]
        public string Building { get; set; }
        [MaxLength(255)]
        public string Address1 { get; set; }
        [MaxLength(255)]
        public string Address2 { get; set; }
        [MaxLength(85)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(7)]
        public string PostalCode { get; set; }
        [MaxLength(48)]
        public string Country { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        [MaxLength(90)]
        public string Email { get; set; }
        [MaxLength(90)]
        public string VoiceMail { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        [MaxLength(16)]
        public string CreditCard { get; set; }
        public int CreditCardTypeID { get; set; }
        public int CardExpMo { get; set; }
        public int CardExpYr { get; set; }
        [MaxLength(255)]
        public string BillingAddress { get; set; }
        [MaxLength(85)]
        public string BillingCity { get; set; }
        [MaxLength(85)]
        public string BillingRegion { get; set; }
        [MaxLength(7)]
        public string BillingPostalCode { get; set; }
        [MaxLength(48)]
        public string BillingCountry { get; set; }
        [MaxLength(255)]
        public string ShipAddress { get; set; }
        [MaxLength(85)]
        public string ShipCity { get; set; }
        [MaxLength(85)]
        public string ShipRegion { get; set; }
        [MaxLength(7)]
        public string ShipPostalCode { get; set; }
        [MaxLength(48)]
        public string ShipCountry { get; set; }
        public DateTime DateEntered { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
