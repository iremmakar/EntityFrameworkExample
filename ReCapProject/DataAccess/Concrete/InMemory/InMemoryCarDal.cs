using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car>()
            {
                new Car
                {
                    Id = 1,
                    BrandId=1,
                    ColorId=2,
                    DailyPrice=12,
                    Description="car1",
                    ModelYear=2020   
                },
                new Car
                {
                    Id = 2,
                    BrandId=1,
                    ColorId=2,
                    DailyPrice=12,
                    Description="car2",
                    ModelYear=2020
                },
                new Car
                {
                    Id = 3,
                    BrandId=1,
                    ColorId=2,
                    DailyPrice=12,
                    Description="car3",
                    ModelYear=2020
                },
                new Car
                {
                    Id = 4,
                    BrandId=1,
                    ColorId=2,
                    DailyPrice=12,
                    Description="car4",
                    ModelYear=2020
                }

            };



        }

        public Car GetById(int id)
        {
            return _cars.Where(c => c.Id == id).FirstOrDefault();

        }

        public List<Car> GetAll()
        {
            return _cars;   
        }

        public void Add(Car car)
        {

            _cars.Add(car); 

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(
                c => c.Id == car.Id);

            carToUpdate.BrandId = 3;
            carToUpdate.DailyPrice = 234;
            carToUpdate.ColorId = 4;
            carToUpdate.Description = "Car5";
            carToUpdate.ModelYear = 2025;


        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(
                c => c.Id == car.Id);

            _cars.Remove(car);
        }




    }
}
