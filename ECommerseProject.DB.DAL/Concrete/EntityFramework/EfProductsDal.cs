using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.Core.DataAccess.EntityFramework;
using ECommerseProject.DB.DAL.Abstract;
using ECommerseProject.DB.Entities.Concrete;

namespace ECommerseProject.DB.DAL.Concrete.EntityFramework
{
    public class EfProductsDal : EfEntityRepositoryBase<Products, ECommerceContext>,IProductsDal
    {
    }
}
