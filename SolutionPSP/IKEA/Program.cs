using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Möbel> meineMöbel = new List<Möbel>()
               {
                new Möbel() { Bezeichnung = "Tisch", Preis = 20 },
                new Möbel() { Bezeichnung = "Sessel", Preis = 30 },
                new Möbel() { Bezeichnung = "Kasten", Preis = 5 },
                new Möbel() { Bezeichnung = "Bett", Preis = 40 },
               };

            foreach (var item in meineMöbel.FindAll(
                m=>m.Preis>20 || m.Bezeichnung =="Sessel"))
            {
                Console.WriteLine(item.Bezeichnung);
            }

        }
    }
}
