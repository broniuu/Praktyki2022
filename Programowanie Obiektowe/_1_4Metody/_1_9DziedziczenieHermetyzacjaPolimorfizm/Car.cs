using _1_9DziedziczenieHermetyzacjaPolimorfizm.Bodies;
using _1_9DziedziczenieHermetyzacjaPolimorfizm.Engines;
using _1_9DziedziczenieHermetyzacjaPolimorfizm.Suspections;
using _1_9DziedziczenieHermetyzacjaPolimorfizm.Tires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9DziedziczenieHermetyzacjaPolimorfizm
{
    internal class Car
    {
        public string CarBrand { get; set; }
        public IEnumerable<Tire> Tires { get; set; }
        public Engine Engine { get; set; }
        public Suspension Suspension { get; set; }
        public Body Body { get; set; }

        public Car(IEnumerable<Tire> tires, Engine engine, Suspension suspension, Body body, string carBrand)
        {
            if (tires.Count() < 0 || tires.Count() > 4)
                Console.WriteLine("Błędna liczba opon");
            else
            {
                CarBrand = carBrand;
                Tires = tires;
                Engine = engine;
                Suspension = suspension;
                Body = body;
            }
        }
        public void Drive()
        {
            Console.WriteLine("Pyr pyr pyr");
        }
    }

}
