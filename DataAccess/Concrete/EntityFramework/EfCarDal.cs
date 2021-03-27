using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,RentACarContext>,ICarDal
    {
        public Car GetById(int id)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return context.Cars.SingleOrDefault(c=>c.Id==id);
            }
        }
        
        public IList<Car> GetByBrandId(int brandId)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return context.Cars.Where(c => c.BrandId == brandId).ToList();
            }
        }

        public IList<Car> GetByModelId(int modelId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.Where(c => c.ModelId == modelId).ToList();
            }
        }

        public IList<Car> GetByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.Where(c => c.ColorId == colorId).ToList();
            }
        }
    }
}
