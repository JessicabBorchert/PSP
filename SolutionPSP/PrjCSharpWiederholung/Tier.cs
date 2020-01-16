using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{
    //Abstracte Definition (Ding) / Vorlage - Blueprint
    //Klassen beeinhalten Attribute / Membervariablen / Eigenschaften / Properties (alles das selbe)
    //.NET Properties get; set; (sowohl die automatisch erzeugten als auch die ausgeschriebenen) 
    //Klassen beeinhalten Methoden / Funktionen / Aktionen
    class Tier
    {
        //Public Membervariablen
        public string Name;
        public double Gewicht;
        double Dummy; //Internal


        //Encapsulation, C#Style beginn mit _
        private int _AlterInJahren;

        public int AlterInJahren  //.NET Properties
        {
            get
            {
                return _AlterInJahren;
            }
            set
            {
                _AlterInJahren = value;
            }
        }

        //Automatic .NET Property -- codesnippet prop
        public string Bezeichnung { get; set; }

        public static int InstanzAnzahl;

        //Konstruktor -- ctor
        public Tier()
        {
            InstanzAnzahl++;
        }

        public int GetAlterInMonaten()
        {
            //lokale Variable 
            int ergebnis = AlterInJahren * 12;
            return ergebnis;
        }

        //overloading anhand der Übergabeparameter
        public int GetAlterInMonaten(int multiplikationsfaktor)
        {
            int ergebnis = AlterInJahren * multiplikationsfaktor;
            return ergebnis;
        }
    }
}
