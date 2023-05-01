
using Coree.DataAccess.Concrete;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarNameDetailDto> GetCarDetails()
        {
            using (RecapContext context = new RecapContext())
            {

                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarNameDetailDto
                             {
                                 BrandName = b.Name,
                                 CarName = c.Description,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,

                             };
                return result.ToList(); 


            }

            
        }
    }
}
