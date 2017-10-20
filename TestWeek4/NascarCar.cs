using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek4
{
    class NascarCar:Car
    {
        private string teamName;

        public string TeamName
        {
            set { teamName = value; }
            get { return teamName; }
        }

        public NascarCar()
        {
            TeamName = "";
        }
        public NascarCar(string TN, string vIn, string mAke)
        {
            TeamName = TN;
            VIN = vIn;
            MAKE = mAke;
        }

        public override void printInfo()
        {
            Console.WriteLine(TeamName+" "+VIN+" "+MAKE);
        }
    }
}
