using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        public Brand GetById(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Brands.SingleOrDefault(b => b.BrandId == id);
            }
        }
    }
}