using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{
    public abstract class Prevoz
    {
        private string ImePoti;
        private string Vstop;
        private string Izstop;
        private int CenaVozovnice;

        public string vstop { get { return Vstop; } set { Vstop = value; } }
        public string izstop { get { return Izstop; } set { Izstop = value; } }
        public int cenaVozovnice { get { return CenaVozovnice; } set { CenaVozovnice = value; } }
        public string imePoti { get { return ImePoti; } set { ImePoti = value; } }


        protected Prevoz(string imePoti, string vstop, string izstop, int cenaVozovnice)
        {
            this.imePoti = imePoti;
            this.vstop = vstop;
            this.izstop = izstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        protected Prevoz(string vstop, int cenaVozovnice)
        {
            this.vstop = vstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        protected Prevoz()
        {
        }


        public override string ToString()
        {
          return "Ime poti: " + imePoti + " Vstopna postaja: "+ vstop + " Izstopna postaja: "+ izstop+ " Cena vozovnice: " +cenaVozovnice;
        }
    }
}
