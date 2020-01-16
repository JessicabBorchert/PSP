using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{

    //Generics
    class Teilnehmerin<T,V>
    {
        //Teilzeit, Vollzeit, Geringfügig
        //public string Art { get; set; }

        //T ist ein formaler Datentyp
        //T wird später beim Definieren des Objekts "konkretisiert"
        //Teilnehmerin<string>
        //Teilnehmerin<int>
        //Teilnehmerin<ArtEnum>
        public T Art { get; set; }

        public V Entlohnung{ get; set; }
    }
}
