using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1_C_
{
    internal class Vehicle
    {
        protected int MaxSpeed;
        protected string type;
        protected DateTime year;
        protected string manufacturer;
        protected int weight;
        public string Type
        {
            get
            {
                return type;
            }
        }
        protected Vehicle(int speed, string type, DateTime year, string man, int weight) 
        { 
            this.year = year;
            this.type = type;
            this.manufacturer = man;
            this.weight = weight;
            this.MaxSpeed = speed;
        }
    }
    internal class Bicycle : Vehicle 
    {
        private int gears;
        private string color;
        private int fee;
        public Bicycle(int gears, string color, int speed, string type, DateTime year, string man, int weight, int fee) : base(speed, type, year, man, weight)
        {
            this.gears = gears;
            this.color = color;
            this.fee = fee;
        }
        public double Rent(double TimeOfUse)
        {
            return TimeOfUse * fee;
        }
    }
    internal class Airplane : Vehicle
    {
        private int passengers;
        private int NumOfFlights;
        DateTime last;
        TimeSpan interval;
        public Airplane(int passengers, int numOfFlights, DateTime last, TimeSpan interval, int speed, string type, DateTime year, string man, int weight) : base(speed, type, year, man, weight)
        {
            this.passengers = passengers;
            NumOfFlights = numOfFlights;
            this.last = last;
            this.interval = interval;
        }

        public int Maintenance()
        {
            DateTime next = last + interval;
            return (next - DateTime.Now).Days;
        }
        public double Time(double avg)
        {
            return (double)NumOfFlights * avg;
        }
        public bool IsUsed()
        {
            if(Maintenance()<=0)
                return false;
            else if((DateTime.Now.Year - year.Year)>10)
                return false;
            else return true;
        }
        public string CargoType(int CargoWeight)
        {
            if (CargoWeight <= 1000)
            {
                return "Light";
            }
            else if (CargoWeight > 1000 && CargoWeight <= 10000)
            {
                return "Avarage";
            }
            else
            {
                return "Heavy";
            }
        }
        public int Price(int money)
        {
            return money / passengers;
        }
    }
}
