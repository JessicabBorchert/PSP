using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern
{

    public interface IBegruessung
    {
        string GetGreeting(string firstName);
    }

    public class BegruessungEnglisch : IBegruessung //STRG .
    {
        public string GetGreeting (string firstName)
        {
            return "Hello " + firstName;
        }
    }

    public class BegruessungDeutsch : IBegruessung //STRG .
    {
        public string GetGreeting(string firstName)
        {
            return "Hallo " + firstName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string vorName = "Hans";
            //Anwendung aus dem Client
            IBegruessung begrE = new BegruessungEnglisch();
            IBegruessung begrD = new BegruessungDeutsch();
            SayHello(vorName, begrE);//Interface
            SayHello(vorName, begrD);//Interface
            SayHello(vorName, begrE.GetGreeting);//Delegate
            SayHello(vorName, begrD.GetGreeting);//Delegate
            SayHello(vorName, HalloAufSteirisch);
            //x fließt in die Methode
            //Ciau wird zurückgegeben -> return muss nich angegeben werden
            // => Lambda Expression / in JavaScript = Pfeilfunktion
            //x = => Übergabeparameter
            //"Ciau " + x => Rumpf
            SayHello(vorName, x => "Ciao " + x);

            //ginge auch folgendermaßen zu schreiben:
            SayHello(vorName, x =>
            {
                var erg = "Ciao " + x;
                return erg;
            });

            Calc(2, 5, addieren);
            //Calc(2, 5, subtrahieren);
            //Lambda sparrt eine extra Methode anzulegen
            Calc(2, 5, (x, y) => x + y);
            Calc(2, 5, (x, y) => x - y);
            Calc(2, 5, (x, y) => x * y);
            Calc(2, 5, (x, y) => x / y);

            int[] zahlen = { 2, 4, 7, 12, 23, 30, 50, 2 };

            var ergebnisListe = Array.FindAll(zahlen, x => x > 20);
            foreach (var item in ergebnisListe)
            {
                Console.WriteLine(item);
            }
        }

        public static int addieren (int z1, int z2)
        {
            return z1 + z2;
        }

        public static void Calc (int z1, int z2, Func<int, int, int>berechnung)
        {
            Console.WriteLine(berechnung(z1, z2));
        }

         /*
        public static string HalloAufItalienisch(string einVorName)
        {
            return "Ciao " + einVorName;
        }
        */

        public static string HalloAufSteirisch (string einVorName)
        {
            return "Servus " + einVorName;
        }

        //Delegate
        public static void SayHello(string vorName, Func<string, string> mAdr)
        {
            Console.WriteLine(mAdr(vorName));
        }

        //Interface
        public static void SayHello (string vorName, IBegruessung begr)
        {
            Console.WriteLine(begr.GetGreeting(vorName));
        }
    }
}
