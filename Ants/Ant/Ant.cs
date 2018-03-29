using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{
    class Ant
    {
        static protected Random r = new Random();
        public int X { get; set; }
        public int Y { get; set; }
        public virtual void Move()
        {
            switch (r.Next(8))
            {
                case 0:
            X += 1;
            Y += 1;
                    break;
                case 1:
                    X += 1;
                    break;
                case 2:
                    Y += 1;
                    break;
                case 3:
                    X -= 1;
                    Y += 1;
                    break;
                case 4:
                    X -= 1;
                    break;
                case 5:
                    Y -= 1;
                    break;
                case 6:
                    X += 1;
                    Y -= 1;
                    break;
                case 7:
                    X -= 1;
                    Y -= 1;
                    break;
            }
        }
        public virtual void MoveToBase()
        {
            if(X > 0)            
                X--;            
            if (X < 0)
                X++;
            if (Y > 0)
                Y--;
            if (Y < 0)
                Y++;
        }
        public virtual void Work()
        {
            int t = r.Next(-20, 20);
            if (t < 0)
                for (int X = 0; X < t; X++)
                {
                    X++;
                    Y++;
                }            
            if (t >= 0)
                for (int i = Y; i < t; i++)
                {
                    X++;
                    Y++;
                }
            
        }
    }
    class AntWorker : Ant
    {       
        public override void Work()
        {
            int f = r.Next(-20, 20);
            X = r.Next(-20, 20);
            Y = r.Next(-20, 20);
            base.Work();
            if (f < 5 && f >= 0)
                base.MoveToBase();
        }
    }
    class AntSoldier : Ant
    {        
        public override void MoveToBase()
        {
            int destX = r.Next(-20, 20);
            int destY = r.Next(-20, 20);
            if (X < destX)
                X++;
            if (Y < destY)
                Y++;
            if (X >= destX)
                X--;
            if (Y >= destY)
                Y--;
            this.MoveToBase();
            for (int i = destX; i < destX + 3; i++)
                for (int j = destY; j < destY + 3; j++)
                    base.Move();             
        }
        public override string ToString()
        {
            return $"AntSoldier {X}, {Y}";
        }

    }
}
