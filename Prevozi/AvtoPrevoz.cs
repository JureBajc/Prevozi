using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{   
   
    public class AvtoPrevoz : Prevoz
    {
        private string Prevoznik;
        public enum TipAvtaVelikost
        {
            Microcar,
            Citycar,
            Supermini
        }
        public TipAvtaVelikost TipAvtaVelikost1 { get; set; }
        private int SteviloKoles; 


        public string prevoznik { get { return Prevoznik; } set { Prevoznik = value; } }

        public int steviloKoles { get { return SteviloKoles; } set { SteviloKoles = value; } }

        public AvtoPrevoz( string prevoznik, TipAvtaVelikost tipAvtaVelikost, int steviloKoles, string vstop, string izstop, int cenaVozovnice) : base()
        {
            this.prevoznik = prevoznik;
            this.TipAvtaVelikost1 = tipAvtaVelikost;
            this.steviloKoles = steviloKoles;
            this.vstop = vstop;
            this.izstop = izstop;
            this.cenaVozovnice = cenaVozovnice;
        }

        public AvtoPrevoz(string prevoznik, int steviloKoles, string vstop) : base()
        {
            this.prevoznik = prevoznik;
            this.steviloKoles = steviloKoles;
            this.vstop = vstop;
        }

        public AvtoPrevoz()
        {
        }

        
    }
}
