using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        private string maker;
        private string type;
        private int year;
        private double motortype;
        private string fueltype;
        private double averageconsumption;

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

        public static int Year
        {
            get
            {
                return year;
            }
        }

        public double MotorType
        {
            get
            {
                return motortype;
            }

            set
            {
                motortype = value;
            }
        }

        public string FuelType
        {
            get
            {
                return fueltype;
            }

            set
            {
                fueltype = value;
            }
        }

        public double AverageConsumption
        {
            get
            {
                return averageconsumption;
            }

            set
            {
                averageconsumption = value;
            }
        }

        public Car(string maker, string type, int year, double motortype, string fueltype, double averageconsumption)
        {
            this.maker = maker;
            this.type = type;
            if(1000<=year && year <= 2050)
            {
                this.year = year;
            }
            this.motortype = motortype;
            this.fueltype = fueltype;
            this.averageconsumption = averageconsumption;
        }

        public Car(string maker, string type, int year, double motortype)
        {
            this.maker = maker;
            this.type = type;
            if (1998 <= year && year <= 2018)
            {
                this.year = year;
            }
            this.motortype = MotorType;
            this.fueltype = "Benzin";
            if(motortype == 1.4)
            {
                this.averageconsumption = 6.5;
            }
            else if(motortype == 1.8)
            {
                this.averageconsumption = 7.5;
            }
            else if(motortype == 2.0)
            {
                this.averageconsumption = 8.1;
            }
            else
            {
                this.averageconsumption = 5;
            }
        }

        public void ChangeEngine(double motortype, string fueltype, double averageconsumption)
        {
            this.motortype = motortype;
            this.fueltype = fueltype;
            this.averageconsumption = averageconsumption;
        }

        public double GetConsumption(double kmnum, double fuel)
        {
            return (fuel / kmnum) * 100;
        }

        public Boolean IsRightConsumption(double kmnum, double fuel)
        {
            if(this.GetConsumption(kmnum, fuel) == this.averageconsumption)
            {
                return true;
            }
            return false;
        }

        public double GetCost(double kmnum, double fuelprice)
        {
            return (kmnum * this.averageconsumption * fuelprice) / 100;
        }

        public override String ToString()
        {
            return this.maker + " " + this.type + " " + this.year + " " + this.motortype + " l engine " + this.fueltype + " " + this.averageconsumption + " l/100km ";
        }


    }
}
