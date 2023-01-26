using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP1
{
    class Hrac : Herni_postava
    {
        public int XP;
        private enum oblicej
        { 
        velky_nos,
        usoplesk,
        make_up
        }

        private enum vlasy
        { 
            drodol,
            culik,
            pleska
        }

        private enum barva_vlasu
        { 
            kastanova,
            blond,
            cervena
        }

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
        public Herni_postava(string Jmeno, int xp) : base() // ???????????
        {
            XP = xp;

        }

        string specializace
        {
            get 
            {
                return specializace;
            }
            set
            {
                if ((specializace == "Kouzelník" || specializace == "Berserker") || (specializace == "Inženýr" || specializace == "Cizák"))
                {
                    specializace = value;
                }
                else
                {
                    specializace = "Neplatná specializace";
                }
            }
        }


        void xp(int zadana_hodnota)
        {
            XP = XP + zadana_hodnota;
            if (base.level * 100 == XP)
            {
            level++;
            XP = 0;
            }
        }

        public override string ToString()
        {
            return "Level: " + level.ToString() + " Pozice X: " + poziceX.ToString() + " Pozice Y: " + poziceY.ToString() + " Jmeno: " + jmeno + " XP: " + XP.ToString();
        }
    }
}
