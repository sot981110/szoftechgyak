using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car:Jarmu
    {
        private double motortype;
        private string fueltype;
        private double averageconsumption;
    
        private static List<double> motortypes = new List<double>();

        private static int numberofinstances = 0;

        public static void IncreaseNumberOfInstances()
        {
            Car.numberofinstances++;
        }

        public static int GetNumberOfInstances()
        {
            return Car.numberofinstances;
        }

        static Car()
        {
            Car.motortypes.Add(1.4);
            Car.motortypes.Add(1.6);
            Car.motortypes.Add(1.8);
            Car.motortypes.Add(2.0);
            Car.motortypes.Add(2.3);
        }

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

        public Car(string maker, string type, int year, double motortype, string fueltype, double averageconsumption):base(maker, type, year)
        {
            this.motortype = motortype;
            this.fueltype = fueltype;
            this.averageconsumption = averageconsumption;

            Car.IncreaseNumberOfInstances();
        }

        public Car(string maker, string type, int year, double motortype):base(maker, type, year)
        {
            if (Car.motortypes.Contains(motortype))
            {
                this.motortype = motortype;
            }
            else
            {
                Car.motortypes.Add(motortype);
                this.motortype = motortype;
            }
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

            Car.IncreaseNumberOfInstances();
        }

        public void ChangeEngine(double motortype, string fueltype, double averageconsumption)
        {
            if (Car.motortypes.Contains(motortype)){
                this.motortype = motortype;
            }
            else
            {
                Car.motortypes.Add(motortype);
                this.motortype = motortype;
            }
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

        public double GetCost(double kmnum, double fuelprice, double ftpereuro)
        {
            return (kmnum * this.averageconsumption * fuelprice) / 100 / ftpereuro;
        }

        public override double GetSpeed(double kmnum, double time)
        {
            return kmnum / time;
        }

        public override String ToString()
        {
            return base.ToString() + " " + this.motortype + " l engine " + this.fueltype + " " + this.averageconsumption + " l/100km ";
        }


    }
}
