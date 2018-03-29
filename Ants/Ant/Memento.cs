using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{
    class PositionMemento
    {
        public int X { get; set; }
        public int Y { get; set; }
        public String Name { get; set; }
        public PositionMemento(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            Name = name;
        }
    }
    
    class Memento
    {
        public List<PositionMemento> State { get; set; }
        public int BaseX { get; set; }
        public int BaseY { get; set; }

        //List<PositionMemento> state = new List<PositionMemento>();
        //public void SetAnts(List<PositionMemento> ants)
        //{
        //    state = ants;
        //}
        //public List<PositionMemento> GetAnts()
        //{
        //    return state;
        //}
    }
}
