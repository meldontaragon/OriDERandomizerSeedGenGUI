using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicVisualAid
{
    class Location
    {
        private int x;
        private int y;
        private Item I;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Item ItemName
        {
            get { return I; }
            set { I = value; }
        }
    }
}
