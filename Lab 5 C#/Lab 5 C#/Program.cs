using Lab_5_C_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Start:
        Console.WriteLine("Enter the coordinates of the points:");
        Console.WriteLine("Point AX:");
        int ax = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point AY:");
        int ay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point BX:");
        int bx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point BY:");
        int by = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point CX:");
        int cx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point CY:");
        int cy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point DX:");
        int dx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Point DY:");
        int dy = Convert.ToInt32(Console.ReadLine());
        Point a = new Point(ax, ay);
        Point b = new Point(bx, by);
        Point c = new Point(cx, cy);
        Point d = new Point(dx, dy);
        Trapezium tr = new Trapezium(a, b, c, d);
        if (!tr.IsTrapezium())
        {
            Console.Clear();
            Console.WriteLine("Your input doesn't form Trapezium\nTry again");
            goto Start;
        }

        while (true)
        {
            Console.WriteLine("If you want know the area of your Trapezium enter 1");
            Console.WriteLine("If you want know the perimeter of your Trapezium enter 2");
            Console.WriteLine("If you want know all data of your Trapezium's enter 3");
            Console.WriteLine("If you want to exit enter 0");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tr.Area();
                    break;
                case 2:
                    tr.Perimeter();
                    break;
                case 3:
                    tr.GetAll();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You entered wrong number");
                    break;
            }
        }
    }
}
