using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Nakliyatçılar")]
    public class Shippers:IEntity
    {
        [Key]
        public int ShipperID { get; set; }
        [MaxLength(150)]
        public string CompanyName { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
