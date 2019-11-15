using System;

namespace zajecia6
{
    class Program
    {

        private static void DescribeCar(Car car)
        {
            Console.WriteLine(
                "[" + car.Vin + "]" + car.Model + ": " + car.Mileage +
                                     " km. Waga: " + car.Weight + "kg. Ilosc drzwi: " + car.DoorNum
                );
        }
        
        static void Main(string[] args)
        {
            Car theCar = new Car("Clio", 120000, 2500, 5);
            theCar.Weight = 1000;
            theCar.IncreaseMileage(1000);
            Car theSecondCar = new Car("Clio", 1200, 2000, 5);
            Car theThirdCar = new Car("Clio", 120000, 1000, 3);
            DescribeCar(theCar);
            DescribeCar(theSecondCar);
            DescribeCar(theThirdCar);
            Console.WriteLine("Wyprodukowano: " + Car.ModelNum);
        }
    }

}