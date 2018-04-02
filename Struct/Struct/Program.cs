using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Struct
{
    class Program
    {
        struct Unit
        {
            public double X { get; set; }
            public double Y { get; set; }
            public int Rotation { get; set; }
            public double Power { get; set; }
            public void TurnLeft()
            {                
                this.Rotation -= 5;
            }
            public void TurnRight()
            {
                this.Rotation += 5;
            }
            public void Move()
            {
                double r = Rotation * (Math.PI / 180);
                Y = Math.Cos(r) * Power + Y;
                X = Math.Sin(r) * Power + X;

            }
            public void Accelerator()
            {
                this.Power += 0.7;
            }
            public void Stop()
            {
                this.Power -= 0.9;
            }
            public void TurnToPoint(double x, double y)
            {
                double a = (x - X);
                double b = y - Y;
                double c = Math.Atan(b / a) * 180 / Math.PI;                
            }
            public override string ToString()
            {
                return $"X = {X}, Y = {Y}";
            }
        }
        
        static void Main(string[] args)
        {
            Unit u = new Unit();
            //Console.WriteLine(Math.Sin(45 * Math.PI/180));
            //Console.WriteLine(Math.Asin(0.707106781186547)*180/Math.PI);
            Console.WriteLine( );
            
            Console.WriteLine($"X = {u.X}");
            
        }
    }
}
