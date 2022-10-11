using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Prevozi
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            AvtobusniPrevoz bus1 = new AvtobusniPrevoz("Osrednji express", new DateTime(2022 / 12 / 12, 12, 25), 5, 2, "Maribor", "Ljubljana", 20);
            AvtobusniPrevoz bus2 = new AvtobusniPrevoz(55, "Celje", 2);
            AvtobusniPrevoz bus3 = new AvtobusniPrevoz(15, "Lendava", 15);

            AvtoPrevoz avto1 = new AvtoPrevoz("Stanko", AvtoPrevoz.TipAvtaVelikost.Supermini, 4, "Maribor", "Ljubljana", 5);
            AvtoPrevoz avto2 = new AvtoPrevoz("Matija", 4, "Novo mesto");
            AvtoPrevoz avto3 = new AvtoPrevoz("Andrej", AvtoPrevoz.TipAvtaVelikost.Supermini, 4, "Murska Sobota", "Maribor", 10);

            KombiPrevoz kombi1 = new KombiPrevoz(70, 12);
            KombiPrevoz kombi2 = new KombiPrevoz(80, "Arriva", 20121, "Ljubljana", "Ajdovščina", 8);
            KombiPrevoz kombi3 = new KombiPrevoz(90, "Nomago", 11223, "Murska sobota", "Ljubljana", 15);

            List<Prevoz> SeznamPrevozov = new List<Prevoz>();
            SeznamPrevozov.Add(bus1);
            SeznamPrevozov.Add(bus2);
            SeznamPrevozov.Add(bus3);
            SeznamPrevozov.Add(avto1);
            SeznamPrevozov.Add(avto2);
            SeznamPrevozov.Add(avto3);
            SeznamPrevozov.Add(kombi1);
            SeznamPrevozov.Add(kombi2);
            SeznamPrevozov.Add(kombi3);

            UrnikPrevozov urnik = new UrnikPrevozov(SeznamPrevozov);
            // List<Prevoz> adsfg = urnik.IskanjePrevozov("as", "d", SeznamPrevozov);
            // Console.WriteLine(adsfg.First());



            

            UrnikPrevozov sofer = new UrnikPrevozov();
            sofer.voznikNaVoljo(SeznamPrevozov, "test");

            AvtobusniPrevoz novAvtobus = new AvtobusniPrevoz("Supernova", new DateTime(2015, 12, 25), 5, 2, "Maribor", "Ljubljana", 20);
            Console.WriteLine(novAvtobus);

            Console.WriteLine(kombi3);


        }
    }
}