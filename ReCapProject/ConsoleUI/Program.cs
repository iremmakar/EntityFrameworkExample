using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            EfCarDal car = new EfCarDal();
            

            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.ModelYear); 
            }

            EfColorDal color = new EfColorDal();
           

            EfBrandDal brand = new EfBrandDal();
            

            car.GetCarDetails();

           

        }
    }
}
