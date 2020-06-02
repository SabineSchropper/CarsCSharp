using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Cars.models
{
    class Car
    {
        public Type Type { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public int YearOfConstruction { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string output = "\nType: " + "Normales Auto\n" + "Hersteller: " + Manufacturer +
                "\nName: " + Name + "\nBaujahr: " + YearOfConstruction + "\nFarbe: " + Color;
            return output;
        }
    }
   
}
