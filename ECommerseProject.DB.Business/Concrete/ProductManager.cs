using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.DB.Business.Abstract;
using ECommerseProject.DB.Entities.Concrete;
using ECommerseProject.DB.DAL.Abstract;

namespace ECommerseProject.DB.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductsDal _productsDal;

        public ProductManager(IProductsDal prodctsDal)
        {
            _productsDal = prodctsDal;
        }

        public void Add(Products products)
        {
            _productsDal.Add(products);
        }

        public void Delete(int productID)
        {
            _productsDal.Delete(new Products { ProductID = productID });
        }

        public List<Products> GetAll() 
        {
            return _productsDal.GetList();
        }

        public List<Products> GetByCategory(int categoryId)
        {
            return _productsDal.GetList(p=>p.CategoryID==categoryId);
        }

        public void Update(Products products)
        {
            _productsDal.Update(products);
        }
    }
}
