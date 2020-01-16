using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            M1(); // CTRL + F5
            Program p1 = new Program();
            p1.Hello();
            //var mAdr = M1; JavaScript
            //mAdr();

            Action mAdrM1 = M1;
            mAdrM1();

            Action<string> mAdrM2 = M2;
            mAdrM2("Campus02");

            //Action = generisches Delegate ohne Rückgabewerte
            //mit bis zu 16 generischen Übergabeparametern
            Action<int, string> mAdrDemo1 = Demo1;
            mAdrDemo1(12, "Hello");
            //Action<bool, Teilnehmer, string, Tier> demo;

            //der letzte Parameter beschreibt den Return-Datentyp
            Func<string, string> mAdrM3 = M3;
            string erg = mAdrM3("Campus02");

            Func<int, int, bool> adrVergleich = Vergleich;
            bool istGleich = adrVergleich(12, 15);

        }

        public static bool Vergleich (int zahl, int zahl2)
        {
            return zahl == zahl2;
        }

        private static void Demo1 (int x, string s)
        {
            Console.WriteLine(x + " " + s);
        }

        private void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void M1()
        {
            Console.WriteLine("Hello from M1");
        }

        public static void M2(string arg)
        {
            Console.WriteLine("Hello from M2 " + arg);
        }

        public static string M3(string arg)
        {
            return "Hello" + arg;
        }
    }
}
