using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public Car GetById(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.SingleOrDefault(c => c.Id == id);
            }
        }

        public IList<Car> GetByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
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

        public IList<CarDetail> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                                 on car.ColorId equals color.ColorId
                             join brand in context.Brands
                                 on car.BrandId equals brand.BrandId
                             join model in context.Models
                                 on car.ModelId equals model.ModelId
                                 join category in context.Categories
                                     on car.CategoryId equals category.CategoryId
                             select new CarDetail
                             {
                                 Id = car.Id,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 CategoryName = category.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelName = model.Name,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
