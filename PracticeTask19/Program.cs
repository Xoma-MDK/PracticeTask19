using System;

namespace PracticeTask19
{
    public class Car 
    {
        public string _carCompany;
        public int _engineCapacity;
        public int _carMaxSpeed;
        public int _enginePower;
        public int _yearOfRelease;
        public Car(string carCompany, int engineCapacity, int carMaxSpeed, int enginePower, int yearOfRelease)
        {
            this._carCompany = carCompany;
            this._engineCapacity = engineCapacity;
            this._carMaxSpeed = carMaxSpeed;
            this._enginePower = enginePower;
            this._yearOfRelease = yearOfRelease;
        }
        public void Print() 
        {
            Console.WriteLine("Марка машины:\t\t" + _carCompany + "\nОбъем двигателя:\t" + _engineCapacity + "\nМаксимальная скорость:\t" + _carMaxSpeed + "\nМощность двигателя:\t" + _enginePower + "\nГод выпуска:\t\t" + _yearOfRelease);
        }
        public void setCarCompany(string carCompany) 
        {
            this._carCompany = carCompany;
        }
        public void setEngineCapacity(int engineCapacity)
        {
            this._engineCapacity = engineCapacity;
        }


        public void setMaxSpeedAndPower(int carMaxSpeed, int enginePower)
        {
            this._carMaxSpeed = carMaxSpeed;
            this._enginePower = enginePower;
        }
        public void setMaxSpeedAndPower(int enginePower)
        {
            this._enginePower = enginePower;
        }

    }
    public class Bus : Car
    {
        private int _namberOfSeats;
        public Bus(string carCompany, int engineCapacity, int carMaxSpeed, int enginePower, int yearOfRelease, int numberOfseats) : base(carCompany, engineCapacity, carMaxSpeed, enginePower, yearOfRelease)
        {
            this._namberOfSeats = numberOfseats;
        }
        public void Print()
        {
            Console.WriteLine("Марка автобуса:\t\t" + _carCompany + "\nОбъем двигателя:\t" + _engineCapacity + "\nМаксимальная скорость:\t" + _carMaxSpeed + "\nМощность двигателя:\t" + _enginePower + "\nГод выпуска:\t\t" + _yearOfRelease + "\nКоличество мест:\t" + _namberOfSeats);
        }
        
        public void setNamberOfSeats(int namberOfSeats)
        {
            _namberOfSeats = namberOfSeats;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2, 200, 120, 2009);
            myCar.Print();
            myCar.setCarCompany("Volvo");
            myCar.Print();
            myCar.setMaxSpeedAndPower(155, 15);
            myCar.Print();

            Bus myBus = new Bus("Toyota", 2, 120, 150, 2000, 45);
            myBus.Print();
            myBus.setMaxSpeedAndPower(2500, 5000);
            myBus.Print();

        }
    }
}
