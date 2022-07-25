using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_12RoznicaPomiedzyKlasaAStruktura
{
    public interface Figura
    {
        abstract public void WyswietlWzor();
    }

    public struct Kwadrat : Figura
    {
        public void WyswietlWzor()
        {
            Console.WriteLine("P = a * a");
        }
    }

}
