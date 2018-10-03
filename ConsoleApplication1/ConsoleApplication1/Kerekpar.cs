using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kerekpar:Jarmu
    {
        private string changetype;
        private int numberofstages;

        public string Changetype
        {
            get
            {
                return changetype;
            }

            set
            {
                changetype = value;
            }
        }

        public int Numberofstages
        {
            get
            {
                return numberofstages;
            }

            set
            {
                numberofstages = value;
            }
        }

        public Kerekpar(string maker, string type, int year, string changetype, int numberofstages):base(maker, type, year)
        {
            this.changetype = changetype;
            this.numberofstages = numberofstages;
        }

        public override double GetSpeed(double kmnum, double time)
        {
            return kmnum / time;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.changetype + " " + this.numberofstages;
        }
    }
}
