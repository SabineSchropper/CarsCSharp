using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.models
{
    class SportsCar : Car
    {
        public override string ToString()
        {
            string output = "\nType: " + "Sportauto\n" + "Hersteller: " + Manufacturer +
                "\nName: " + Name + "\nBaujahr: " + YearOfConstruction + "\nFarbe: " + Color;
            return output;
        }
    }
}
