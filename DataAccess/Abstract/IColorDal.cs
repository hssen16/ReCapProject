using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
        Color GetById(int id);
    }
}