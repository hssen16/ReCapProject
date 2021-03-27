using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        public Color GetById(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Colors.SingleOrDefault(c => c.ColorId == id);
            }
        }
    }
}