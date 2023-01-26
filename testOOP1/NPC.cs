using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP1
{
    class NPC : Herni_postava
    {
        public enum prace
        { 
        obchodnik,
        nepritel,
        obyvatel
        }

        public bool boss = true;
        static int pozicex;
        static int pozicey;
        public NPC(string jmeno, int PoziceX, int PoziceY) : base.Herni_postava(string jmeno)
        {
            poziceX = poziceX;
            poziceY = poziceY;
        }

        public NPC()
        {
            boss = false;
        }

        public override string ToString()
        {
            return "Level: " + level.ToString() + " Pozice X: " + poziceX.ToString() + " Pozice Y: " + poziceY.ToString() + " Jmeno: " + jmeno + " boss: " + boss.ToString() ;
        }
    }
}
