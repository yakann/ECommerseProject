using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerseProject.Core.Entities;

namespace ECommerseProject.DB.Entities.Concrete
{
    //[Table("Kategori")]
    public class Category:IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string Picture { get; set; }
        public bool Active { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
