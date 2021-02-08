using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Araç Bilgileri...");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id + "-" + item.BrandId + "-" + item.ColorId + "-" + item.ModelYear + "-" + item.DailyPrice + "-" + item.Description);
            }
        }
    }
}
