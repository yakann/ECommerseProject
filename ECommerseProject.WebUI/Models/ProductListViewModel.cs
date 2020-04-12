using ECommerseProject.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerseProject.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Products> Products { get; internal set; }
    }
}
