using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){ Id=1,BrandId=3,ColorId=4,ModelYear=2008,DailyPrice=35000,Description="ford"},
                new Car(){ Id=2,BrandId=4,ColorId=3,ModelYear=2020,DailyPrice=100000,Description="Honda"},
                new Car(){ Id=3,BrandId=5,ColorId=3,ModelYear=2010,DailyPrice=456800,Description="audi"}
            };


        }

        public void Add(Car car)
        {

            _cars.Add(car);
            Console.WriteLine(car.Description + " isimli araba eklendi");
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            var idGetir = from c in _cars
                          where c.Id == id
                          select c;

            return idGetir.ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}

