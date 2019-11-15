using System;

namespace zajecia6
{
    public class Car
    {
        public static int ModelNum { get; private set; } = 0;
        public readonly string Model;
        
        public int Vin { get; set; }
        public int Mileage { get; private set; }

        public void IncreaseMileage(int distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("dystans nie moze byc ujemny");
            }
            Mileage += distance;
        }
//        private int _mileage;
//        public int Mileage
//        {
//            get => _mileage;
//            set
//            {
//                if (value > _mileage)
//                {
//                    _mileage = value;
//                }
//            }
//        }

        private int _weight;

        public int Weight
        {
            get => _weight;
            set => _weight = value >= 0 ? value : 0;
        }
        
        public int DoorNum {get; private set;}

        public Car(string model, int mileage, int weight, int doorNum)
        {
            Model = model;
            Mileage = mileage;
            Weight = weight;
            DoorNum = doorNum;
            Vin = ModelNum++;
        }
    }
}