using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{
    class Program
    {
        static void Main(string[] args)
        {
            Swarm s = new Swarm();
            for (int i = 0; i < 10; i++)
            {
                s.BornS();
                s.BornW();
            }
            s.PrintSwar();
            s.MustMoveToWork();
            s.PrintSwar();
        }
    }
}
