using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.DB.Entities.Concrete;

namespace ECommerseProject.DB.Business.Abstract
{
    public interface ISupplierService
    {
        List<Suppliers> GetAll();
    }
}
