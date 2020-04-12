using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ECommerseProject.DB.Entities.Concrete
{
    public class ProductDetail:IEntity
    {
        [Key]
        public int ProductDetailID { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        [MaxLength(50)]
        public string Size { get; set; }
        public Products ProductID { get; set; }
    }
}
