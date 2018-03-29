using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{

    class Swarm
    {
        List<Ant> lst = new List<Ant>();
        public  void BornW()
        {
            lst.Add(new AntWorker());
        }
        public  void BornS()
        {
            lst.Add(new AntSoldier());
        }
        public void MustMove()
        {
            foreach (var item in lst)
            {
                item.Move();
            }
        }
        public void MustMoveToBase()
        {
            foreach (var item in lst)
            {
                item.MoveToBase();
            }
        }

        public void MustMoveToWork()
        {
            foreach (var item in lst)
            {
                item.Work();
            }
        }
        public void PrintSwar()
        {
            int count = 0;
            foreach (var item in lst)
            {
                Console.WriteLine(item);
                count++;
            }
            Console.WriteLine($"All ants are : {count}");
        }
     
        public void SetMemento(Memento memento)
        {
            this.lst = new List<Ant>();
            for (int i = 0; i < memento.State.Count; i++)
            {
                if (memento.State[i].Name=="Ant")
                {
                    lst.Add(new Ant(){  X = memento.State[i].X,
                                        Y = memento.State[i].Y
                    });
                }
                else if(memento.State[i].Name == "AntSoldier")
                {
                    lst.Add(new AntSoldier()
                    {
                        X = memento.State[i].X,
                        Y = memento.State[i].Y
                    });
                }
                else if (memento.State[i].Name == "AntWorker")
                {
                    lst.Add(new AntWorker()
                    {
                        X = memento.State[i].X,
                        Y = memento.State[i].Y
                    });
                }
            }
           
            // memento.BaseX
            //memento.State[0].
        }
        public Memento CreateMemento()
        {
            List<PositionMemento> p = new List<PositionMemento>();            
            foreach (var item in lst)
            {
                if (item is AntSoldier)
                    p.Add(new PositionMemento(item.X, item.Y, "AntSoldier"));
                if (item is AntWorker)
                    p.Add(new PositionMemento(item.X, item.Y, "AntWorker"));               
            }
            return new Memento();
        }
        

    }
}
