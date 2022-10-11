using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{
    public class KombiPrevoz : Prevoz
    {
        private int Hitrost;
        public string Firma;
        private int Kilometrina;

        public int hitrost { get { return Hitrost; } set { Hitrost = value; } }
        public string firma { get { return Firma; } set { Firma = value; } }
        public int kilometrina { get { return Kilometrina; } set { Kilometrina = value; } }

        public KombiPrevoz(int hitrost, string firma, int kilometrina, string vstop, string izstop, int cenaVozovnice) : base()
        {
            this.hitrost = hitrost;
            this.firma = firma;
            this.kilometrina = kilometrina;
            this.vstop = vstop;
            this.izstop = izstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        public KombiPrevoz(int hitrost, int cenaVozovnice)
        {
            this.hitrost = hitrost;
            this.cenaVozovnice = cenaVozovnice;
        }

        public KombiPrevoz()
        {
        }
    }
}
