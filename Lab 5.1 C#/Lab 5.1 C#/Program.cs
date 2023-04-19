using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_5._1_C_;
class Program
{
    static void Main()
    {
        again:
        Console.WriteLine("Enter type of the vehicle: ");
        string type = Console.ReadLine();
        if(type!="Bicycle" && type!="Airplane")
        {
            Console.Clear();
            Console.WriteLine("Wrong type of vehicle. Try again");
            goto again;
        }
        Console.WriteLine("Enter year of the vehicle: ");
        DateTime year = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter manufacturer of the vehicle: ");
        string manufacturer = Console.ReadLine();
        Console.WriteLine("Enter weight of the vehicle: ");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max speed of the vehicle: ");
        int maxSpeed = int.Parse(Console.ReadLine());
        if (type == "Bicycle")
        {
            Console.WriteLine("Enter type of the bicycle:");
            string typ = Console.ReadLine();
            Console.WriteLine("Enter number of gears: ");
            int gears = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter fee per hour: ");
            int fee = int.Parse(Console.ReadLine());
            Bicycle bicycle = new Bicycle( gears, color, maxSpeed, typ, year, manufacturer, weight, fee);
            while(true)
            {
                Console.WriteLine("Enter 1 to know the cost of rent, 2 to exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter time of use: ");
                    double time = double.Parse(Console.ReadLine());
                    Console.WriteLine("Total fee: " + bicycle.Rent(time));
                }
                else if (choice == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Wrong choice. Try again");
                }
            }
        }
        else if (type == "Airplane")
        {
            Console.WriteLine("Enter type of the plane:");
            string typ = Console.ReadLine();
            Console.WriteLine("Enter number of seats for passengers: ");
            int passengers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of flights: ");
            int numOfFlights = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last maintenance date: ");
            DateTime last = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter interval between maintenance: ");
            TimeSpan interval = TimeSpan.Parse(Console.ReadLine());
            Airplane airplane = new Airplane(passengers, numOfFlights, last, interval, maxSpeed, typ, year, manufacturer, weight);
            while(true)
            {
                Console.WriteLine("Enter 1 to know the days until the next maintenance");
                Console.WriteLine("Enter 2 to know total flight hours");
                Console.WriteLine("Enter 3 to know whether plane is in the use");
                if(airplane.Type == "Cargo")
                {
                    Console.WriteLine("Enter 5 to know the type of the cargo");
                }
                else Console.WriteLine("Enter 4 to calculate the ticket price");
                Console.WriteLine("Enter 0 to exit");
                string answer = Console.ReadLine();
                switch(answer) 
                {
                    case "1":
                        Console.WriteLine("Days until the next maintenance: " + airplane.Maintenance());
                        break;
                    case "2":
                        Console.WriteLine("Enter the avarage flight duration:");
                        double duration = double.Parse(Console.ReadLine());
                        Console.WriteLine("Total flight hours: " + airplane.Time(duration));
                        break;
                    case "3":
                        Console.WriteLine("Plane is in the use: " + airplane.IsUsed());
                        break;
                    case "5":
                        if(airplane.Type!="Cargo")
                        {
                            Console.WriteLine("Your type of plane is not cargo. Try again");
                            break;
                        }
                        Console.WriteLine("Enter weight of the cargo:");
                        int mass = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type of the cargo: " + airplane.CargoType(mass));
                        break;
                    case "4":
                        Console.WriteLine("Enter your desired profit:");
                        int profit = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ticket price: " + airplane.Price(profit));
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Try again");
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong type of vehicle. Try again");
            goto again;
        }

    }
}
