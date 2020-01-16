using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {

        class Fahrzeug
        {
            public event Action ZuSchnell; //1. muss als event deklariert werden
            public double AktuelleGeschwindigkeit { get; set; }

            public void GasGeben(double erhoehung)
            {
                AktuelleGeschwindigkeit += erhoehung;
                if (AktuelleGeschwindigkeit > 70)
                {
                    ZuSchnell();
                }
            }
        }

        static void Main(string[] args)
        {
            Fahrzeug f1 = new Fahrzeug()
            {
                AktuelleGeschwindigkeit = 0
            };
            f1.ZuSchnell += SieFahrenZuSchnell; //2. += oder -= mann kann die Methodensignatur nicht überschreiben und registriert sich nur durch + oder - = Event
            f1.ZuSchnell += RotAlarm; //bei Events kann ein Zustand mehrere Methoden aufrufen
            f1.GasGeben(10); //10km/h
            f1.GasGeben(90); //100 km/h
            f1.GasGeben(-50);
            f1.GasGeben(30);
        }

        public static void RotAlarm()
        {
            Console.WriteLine("Alarm");
        }

        public static void SieFahrenZuSchnell()
        {
            Console.WriteLine("Vorsicht - bitte bremsen");
        }
    }
}
