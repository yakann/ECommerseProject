using ECommerseProject.Core.DataAccess.EntityFramework;
using ECommerseProject.DB.DAL.Abstract;
using ECommerseProject.DB.Entities.Concrete;

namespace ECommerseProject.DB.DAL.Concrete.EntityFramework
{
    public class EfSuppliersDal : EfEntityRepositoryBase<Suppliers, ECommerceContext>,ISuppliersDal
    {
    }
}
