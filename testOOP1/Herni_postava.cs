using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP1
{
    class Herni_postava
    {
        protected int level;
        protected int poziceX;
        protected int poziceY;
        protected string jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (jmeno.Length <= 10)
                {
                    jmeno = value;
                }
                else
                {
                    jmeno = "Příliš dlouhé jméno!";
                }
            }
        }

        public Herni_postava(string Jmeno)
        {
            level = 1;
            poziceX = 0;
            poziceY = 0;
            jmeno = Jmeno;
        }

        public void zmena_pozice(int x, int y)
        {
            poziceX = x;
            poziceY = y;
        }

        public override string ToString()
        {
            return "Level: " + level.ToString() + " Pozice X: " + poziceX.ToString() + " Pozice Y: " + poziceY.ToString() + " Jmeno: " + jmeno;
        }
    }
}
