using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.DB.Entities.Concrete;

namespace ECommerseProject.DB.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GetByCategory(int CategoryID);
        void Add(Products products);
        void Update(Products products);
        void Delete(int ProductID);
    }
}
