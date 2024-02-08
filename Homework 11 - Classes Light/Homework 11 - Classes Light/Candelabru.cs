using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11___Classes_Light
{
    public class Candelabru
    {
        //campuri
        private BecReglabil[] _becuri;

        //constructor
        public Candelabru(params byte[] puteriMax)
        {
            _becuri = new BecReglabil[puteriMax.Length];

            for (byte i = 0; i < _becuri.Length; i++) 
            {
                _becuri[i] = new BecReglabil(puteriMax[i], 0);
            }
        }

        //proprietati

        public bool Aprins
        {
            get
            {
                foreach (BecReglabil b in _becuri)
                {
                    if (b.Aprins == true)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public int PutereCurenta
        {
            get
            {
                int sum = 0;
                foreach (BecReglabil b in _becuri )
                {
                    sum += b.CurrentPower;
                }
                return sum;
            }
        }

        public int PutereMaxima
        {
            get
            {
                int sum = 0;
                foreach (BecReglabil b in _becuri)
                {
                    sum += b.MaxPower;
                }
                return sum;
            }
        }

        public byte Id { get; set; }

        //metode
        public void Aprinde()
        {
            foreach (BecReglabil b in _becuri)
            {
                b.CurrentPower = b.MaxPower;
            }
        }

        public void Stinge()
        {
            foreach (BecReglabil b in _becuri)
            {
                b.CurrentPower = 0;
            }
        }

        public void MaresteLumina(byte putere)
        {
            foreach (BecReglabil b in _becuri)
            {
                b.CurrentPower += putere;
            }
        }

        public void ReduceLumina(byte putere)
        {
            foreach (BecReglabil b in _becuri)
            {
                b.CurrentPower -= putere;
            }
        }

        public void AfiseazaStare()
        {
            if (Aprins == true)
            {
                Console.WriteLine($"Candelabrul {Id} este aprins.");
            } else
            {
                Console.WriteLine($"Candelabrul {Id} este stins.");
            }
        }
    }
}
