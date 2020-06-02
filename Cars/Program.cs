using Cars.models;
using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasChosen = false;
            Car car;
            string input;
            bool isSportsCar = false;
            bool isReadyToShow = false;
            List<Car> cars = new List<Car>();

            while(!isReadyToShow)
            {
                hasChosen = false;
                while (!hasChosen)
                {
                    Console.WriteLine("Welchen Typ Auto wählst du?");
                    Console.WriteLine("1) Sportauto \n2) Normales Auto ");

                    isSportsCar = false;
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input.Equals("1") || input.Equals("sportauto"))
                    {
                        isSportsCar = true;
                        hasChosen = true;
                    }
                    else if (input.Equals("2") || input.Equals("normales auto"))
                    {
                        hasChosen = true;
                    }
                    else
                    {
                        Console.WriteLine("Wählen Sie bitte zwischen den angegebenen Möglichkeiten.");
                    }
                }
                if (isSportsCar)
                {
                    car = new SportsCar();
                    car.Type = models.Type.SPORTS_CAR;
                }
                else
                {
                    car = new Car();
                    car.Type = models.Type.CAR;
                }
                Console.WriteLine("Hersteller?");
                car.Manufacturer = Console.ReadLine();
                Console.WriteLine("Name?");
                car.Name = Console.ReadLine();
                Console.WriteLine("Baujahr?");
                car.YearOfConstruction = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Farbe?");
                car.Color = Console.ReadLine();
                cars.Add(car);
                Console.WriteLine("Mit \"Show\" können Sie die eingegeben Autos anzeigen lassen. " +
                    "\nMit jeder anderen Eingabe können Sie das nächste Auto eintragen.");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input.Equals("show"))
                {
                    isReadyToShow = true;
                }
            }
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
        }
    }
}
