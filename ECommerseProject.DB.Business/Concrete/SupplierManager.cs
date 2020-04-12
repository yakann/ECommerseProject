using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.DB.Business.Abstract;
using ECommerseProject.DB.Entities.Concrete;
using ECommerseProject.DB.DAL.Abstract;

namespace ECommerseProject.DB.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private ISuppliersDal _suppliersDal;
        public SupplierManager(ISuppliersDal suppliersDal)
        {
            _suppliersDal = suppliersDal;
        }

        public List<Suppliers> GetAll()
        {
            return _suppliersDal.GetList();
        }
    }
}
