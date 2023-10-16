using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.DataAccess
{
    internal class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car{ CarID = 1, CarName="Lamborghini", Manufacturer="Lamborghini", Price=10000000000, ReleaseYear=2007};
            new Car{ CarID = 2, CarName="Ferrari", Manufacturer="Ferrari", Price=1000000, ReleaseYear=2009};
        };
//--------------------------------------------------------------------------
private static CarDBContext instance = null;
private static readonly object instanceLock = new object();
private CarDBContext() { }
public static CarDBContext Instance()
{
    get
    {
        lock (instanceLock)
        {
            if (instance == null)
            {
                instance = new CarDBContext();
            }
            return instance;
        }
    }
}
//----------------------------------------------------------------------------
public List<Car> GetCarList => CarList;
//----------------------------------------------------------------------------
public Car GetCarByID(int carID)
{
    Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
    return car;
}
//----------------------------------------------------------------------------
public void AddNew(Car car)
{
    Car pro = GetCarByID(car.CarID);
    if(pro == null)
    {
        CarList.Add(car);
    }
    else {
        throw new Exception("Car is already exists. ");
    }
}
//Update
public void Update (Car car)
{
    Car c = GetCarByID(car.CarID);
    if(c != null) {
        var index = CarList.IndexOf(c);
        CarList[index] = car;
    }
    else
    {
        throw new Exception("Car does not already exists.");
    }
}
//Remove
public void Remove(int CarID)
{
    Car p = GetCarByID(CarID);
    if(p != null)
    {
        CarList.Remove(p);
    }
    else
    {
        throw new Exception("Car does not already exists.");
    }
}
}