using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class Coordinates
    {   
        //campuri
        private byte _x;
        private byte _y;

        //constructor
        public Coordinates(byte x, byte y)
        {
            _x = x;
            _y = y;
        }

        //proprietati
        public byte X 
        {
            get { return _x; }
            set { _x = value; }
        }
        public byte Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
