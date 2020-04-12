using ECommerseProject.Core.DataAccess;
using ECommerseProject.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerseProject.DB.DAL.Abstract
{
    public interface IProductsDal:IEntityRepository<Products>
    {
    }
}
