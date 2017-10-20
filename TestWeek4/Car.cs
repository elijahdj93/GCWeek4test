using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek4
{
    class Car
    {
        #region Vars
        private string vin;
        private string make;
        #endregion

        #region Properties
        public string VIN
        {
            set { vin = value; }
            get { return vin; }
        }
        public string MAKE
        {
            set { make = value; }
            get { return make; }
        }
        #endregion

        #region Constructors
        public Car()
        {
            VIN = "";
            MAKE = "";
        }
        public Car(string Vin,string Make)
        {
            VIN = Vin;
            MAKE = Make;
        }
        #endregion

        public virtual void printInfo()
        {
            Console.WriteLine(VIN +" "+MAKE);
        }
    }
}
