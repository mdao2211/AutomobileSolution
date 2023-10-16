using AutomobileSolution.BussinessObject;
using AutomobileSolution.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileSolution.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carId) => CarDBContext.Instace.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instace.GetCarList;
        
        public void InsertCar(Car car) => CarDBContext.Instace.AddNew(car);

        public void DeleteCar(int carID) => CarDBContext.Instace.Remove(carID);
        public void UpdateCar(Car car) => CarDBContext.Instace.Update(car);
    }
}
