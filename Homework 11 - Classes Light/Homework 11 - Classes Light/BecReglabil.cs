using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11___Classes_Light
{
    public class BecReglabil
    {
        //campuri
        private byte _maxPower;
        private byte _currentPower;

        //constructor
        public BecReglabil(byte maxPower = 0, byte currentPower = 0)
        {
            if (maxPower >= 0)
            {
                MaxPower = maxPower;
            }

            if (currentPower >= 0)
            {
                CurrentPower = currentPower;
            }
        }

        //proprietati
        public byte MaxPower 
        { 
            get { return _maxPower; } 
            set { _maxPower = value; }
        }
        public byte CurrentPower
        {
            get { return _currentPower; }
            set { _currentPower = value; }
        }

        public bool Aprins
        {
            get
            {
                if (CurrentPower > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //metode
        public void Aprinde()
        {
            CurrentPower = MaxPower;
        }

        public void Stinge()
        {
            CurrentPower = 0;
        }

        public void MaresteLumina(byte power)
        {
            CurrentPower += power;
            if (CurrentPower > MaxPower) 
            {
                CurrentPower = MaxPower;
            }
        }

        public void ReduceLumina(byte power)
        {
            CurrentPower -= power;
            if (CurrentPower < 0)
            {
                CurrentPower = 0;
            }
        }
    }
}
