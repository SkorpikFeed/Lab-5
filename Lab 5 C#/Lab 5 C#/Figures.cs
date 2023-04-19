using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_C_
{
    internal class Figures
    {
        protected Point a; protected Point b; protected Point c; protected Point d;
        public Figures(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double Length(string A)
        {
            switch(A) 
            { 
                case "ab": return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
                case "bc": return Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2));
                case "cd": return Math.Sqrt(Math.Pow(d.X - c.X, 2) + Math.Pow(d.Y - c.Y, 2));
                case "da": return Math.Sqrt(Math.Pow(a.X - d.X, 2) + Math.Pow(a.Y - d.Y, 2));
                default : return 0;
            }
        }
    }
    class Trapezium : Figures
    {
        public Trapezium(Point a, Point b, Point c, Point d) : base(a, b, c, d) { }
        public bool IsTrapezium()
        {
            Point ab = new Point(b.X - a.X, b.Y - a.Y);
            Point dc = new Point(c.X - d.X, c.Y - d.Y);
            Point da = new Point(a.X - d.X, a.Y - d.Y);
            Point cb = new Point(b.X - c.X, b.Y - c.Y);
            if(IsParallel(ab,dc)) 
            {
                if(!IsParallel(da,cb)) return true; else return false;
            }
            else return false;
        }
        bool IsParallel(Point ab,Point dc)
        {
            if ((ab.X == 0 && ab.Y == 0) || (dc.X == 0 && dc.Y == 0)) return false;
            if ((ab.X == 0 && dc.X == 0) || (ab.Y == 0 && dc.Y == 0)) return true;
            else if (ab.X == 0 || ab.Y == 0 || dc.X == 0 || dc.Y == 0) return false;
            else if (ab.X / dc.X == ab.Y / dc.Y) return true;
            else return false;
        }
        public void Area()
        {
            double ab = Length("ab");
            double bc = Length("bc");
            double cd = Length("cd");
            double da = Length("da");
            double S1 = (ab + cd) / 2;
            double S2 = Math.Sqrt(Math.Pow(da, 2) - Math.Pow((Math.Pow(ab - cd, 2) + Math.Pow(da, 2) - Math.Pow(bc, 2)) / (2 * (ab - cd)),2));
            double res = S1 * S2;
            Console.WriteLine("Area of your Trapezium is {0} square units", res);
        }
        public void Perimeter()
        {
            double ab = Length("ab");
            double bc = Length("bc");
            double cd = Length("cd");
            double da = Length("da");
            double res = (ab + bc + cd + da);
            Console.WriteLine("Perimetr of your Trapezium is {0} units", res);
        }
        public void GetAll()
        {
            Console.WriteLine("Coordinates of your Trapezium:");
            Console.WriteLine("A = ({0};{1})\nB = ({2};{3})\nC = ({4};{5})\nD = ({6};{7})", a.X, a.Y, b.X, b.Y, c.X, c.Y, d.X, d.Y);
            Area();
            Perimeter();
        }
    }
}
