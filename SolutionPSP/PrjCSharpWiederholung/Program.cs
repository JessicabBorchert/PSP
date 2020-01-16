using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int zahl = 22;

            //Instanzieren / Objekt erstellen
            //new -> fordert speicher dynamisch an
            //Möglichkeit 1 -> gleich erstellen
            Tier t1 = new Tier();
            t1.AlterInJahren = 12;

            //Möglichkeit 2 -> später erstellen
            Tier t2 = null;
            t2 = new Tier();
            t2.AlterInJahren = 30;

            t2 = t1; //jetzt zeigen beide Objekte auf Alter 12
            t2.AlterInJahren = 5; //da t1 und t2 jetzt ein Objekt sind, sind beide 5 ?!

            Console.WriteLine(t2.GetAlterInMonaten());

            //Debuggen Breakpoint setzen (links aussen oder F9)
            //Debugg starten mit F5
            //Schritt weitergehen im Debugg F11

            Teilnehmerin<int, string> teiln1 = new Teilnehmerin<int, string>();
            teiln1.Art = 0;

            Teilnehmerin<string, int> teiln2 = new Teilnehmerin<string, int>();
            teiln2.Art = "Teilzeit";

            Teilnehmerin<Arbeitszeitmodel, int> teiln3 = new Teilnehmerin<Arbeitszeitmodel, int>();
            teiln3.Art = new Arbeitszeitmodel();
            teiln3.Art.MinStunden = 15;
            teiln3.Art.MaxStunden = 20;

            Teilnehmerin<int, Entlohnungsschema<string>> teiln5 = new Teilnehmerin<int, Entlohnungsschema<string>>();
            Teilnehmerin<string, Entlohnungsschema<int>> teiln6 = new Teilnehmerin<string, Entlohnungsschema<int>>();

            teiln5.Entlohnung = new Entlohnungsschema<string>();
            teiln5.Art = 12;
            teiln5.Entlohnung.Bezeichnung = "Kollektiv";

            teiln6.Entlohnung = new Entlohnungsschema<int>();
            teiln6.Art = "Gering";
            teiln6.Entlohnung.Bezeichnung = 2;

            System.Collections.Generic.Dictionary<int, Tier> meineTiere;

            //Dictionary ist vergleichbar mit Java Map
            meineTiere = new Dictionary<int, Tier>();

            meineTiere.Add(12, new Tier()
            {
                AlterInJahren = 12,
                Bezeichnung = "Hase"
            });
            meineTiere.Add(7, new Tier()
            {
                AlterInJahren = 2,
                Bezeichnung = "Vogel"
            });

            //foreach ist zugleich das code snipet
            foreach (KeyValuePair<int, Tier> tier in meineTiere)
            {
                Console.WriteLine(tier);
                Console.WriteLine(tier.Value.Bezeichnung);
            }

            List<string> lvs = new List<string>();
            lvs.Add("PSP");
            lvs.Add("Datenbankprogrammierung");
            lvs.Add("JavaScripts");
            foreach (string eintrag in lvs)
            {
                Console.WriteLine(eintrag);
            }



        }
    }
}
