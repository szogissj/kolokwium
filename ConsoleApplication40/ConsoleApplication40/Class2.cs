using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrodekLokomocji
    class Autobus : SrodekLokomocji;
            public Autobus(int iloscMiejsc);
    {
        this.iloscMiejsc = iloscMiejsc;

    }
}
 public string Informacje() //metoda zwracająca informacje o lokomotywie
        {
            return "Autobus: IloscMiejsc=24  " + iloscMiejsc + ",  cena biletu=72 " + cenaBiletu;
        }