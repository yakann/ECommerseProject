using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Ödeme")]
    public class Payment:IEntity
    {
        //[Key]
        public int PaymentID { get; set; }
        [MaxLength(50)]
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
