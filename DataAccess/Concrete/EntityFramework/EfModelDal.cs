using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfModelDal : EfEntityRepositoryBase<Model, RentACarContext>, IModelDal
    {
        public Model GetById(int id)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return context.Models.SingleOrDefault(m => m.ModelId == id);
            }
        }
    }
}