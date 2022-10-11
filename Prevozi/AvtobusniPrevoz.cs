using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{
    public class AvtobusniPrevoz : Prevoz
    {
        public DateTime CasOdhoda;
        private int SteviloSedezev;
        private int Stevilovodicev;

        public DateTime casOdhoda { get { return CasOdhoda; } set { CasOdhoda = value; } }
        public int steviloSedezev { get { return SteviloSedezev; } set { SteviloSedezev = value; } }
        public int stevilovodicev { get { return Stevilovodicev; } set { Stevilovodicev = value; } }

        public AvtobusniPrevoz(string imePoti,DateTime casOdhoda, int steviloSedezev, int stevilovodicev, string vstop, string izstop, int cenaVozovnice) : base()
        {
            this.imePoti = imePoti;
            this.casOdhoda = casOdhoda;
            this.steviloSedezev = steviloSedezev;
            this.stevilovodicev = stevilovodicev;
            this.vstop = vstop;
            this.izstop = izstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        public AvtobusniPrevoz( int steviloSedezev,string vstop, int cenaVozovnice) : base()
        {
            this.steviloSedezev = steviloSedezev;
            this.vstop = vstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        public AvtobusniPrevoz(string imePoti, string vstop, string izstop): base()
        {
            this.imePoti = imePoti;
            this.vstop = vstop;
            this.izstop = izstop;
        }

        public AvtobusniPrevoz()
        {
        }

       

    }
}
