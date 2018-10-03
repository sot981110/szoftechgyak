using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Jarmu
    {
        protected string maker;
        protected string type;
        protected int year;

        public string Maker
        {
            get
            {
                return maker;
            }

            set
            {
                maker = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public Jarmu(string maker, string type, int year)
        {
            this.maker = maker;
            this.type = type;
            if (1000 <= year && year <= 2050)
            {
                this.year = year;
            }
            else
            {
                this.year = 2018;
            }

        }

        public abstract double GetSpeed(double kmnum, double time);

        public override string ToString()
        {
            return this.maker + " " + this.type + " " + this.year;
        }
    }
}
