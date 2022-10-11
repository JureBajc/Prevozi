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
    public class UrnikPrevozov
    {
        private List<Prevoz> SeznamPrevozov;
        private List<Prevoz> SeznamVoznikov;
        public List<Prevoz> TEST { get; set; }

        public List<Prevoz> seznamPrevozov { get { return SeznamPrevozov; } set { SeznamPrevozov = value; } }
        public List<Prevoz> seznamVoznikov { get { return SeznamVoznikov; } set { SeznamVoznikov = value; } }

        public UrnikPrevozov(List<Prevoz> seznamPrevozov, List<Prevoz> seznamVoznikov)
        {
            this.seznamPrevozov = seznamPrevozov;
            this.seznamVoznikov = seznamVoznikov;
        }

        public UrnikPrevozov()
        {
        }

        public UrnikPrevozov(List<Prevoz> tEST)
        {
            TEST = tEST;
        }


        public static bool JePrazno<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
        /* public List<Prevoz> IskanjePrevozov(string vstop, string izstop,List<Prevoz>test)
            {
              List<Prevoz> urnikPrevozovs = new List<Prevoz>();

                var result = test.Find(x => x.izstop == izstop&&x.vstop==vstop);

                urnikPrevozovs.Add(result);

                if (!JePrazno(urnikPrevozovs))
                {
                    throw new InvalidOperationException("Sequence contains no elements");
                }

                return urnikPrevozovs;

            } */

        public bool voznikNaVoljo(List<Prevoz> prevoz, string prevoznik)
        {
            foreach (AvtoPrevoz x in prevoz.OfType<AvtoPrevoz>())
            {
                if (x.prevoznik == prevoznik)
                {
                    Console.Write("deluje");
                    return true;
                }
            }
            return false;
        }
        public void isciInOdstrani(string iskanoIme)
        {
            var iskanPrevoz = SeznamPrevozov.FindAll(x => x.imePoti == iskanoIme);
            SeznamPrevozov.RemoveAll(x => x.imePoti == iskanoIme);
            foreach (var prevoz1 in iskanPrevoz)
                Console.WriteLine("Odstranjena je bila pot: {0}", prevoz1.imePoti);
        }

        public List<Prevoz> VrniZadnjiDodanPrevoz(List<Prevoz> Prevoz1)
        {
            if (!JePrazno(Prevoz1))
            {
                return Prevoz1;
            }
            else
            {
                return null;
            }
        }

        public void input()
        {
            string[] vrste = File.ReadAllLines(@"C:\Users\sarad\Desktop\Prevozi\Prevozi.csv");

            for (int i = 1; i < vrste.Length; i++)
            {
                var index = vrste[i].Split(';');

                for (int j = 0; j < index.Length; j++)
                {
                    index[j] = index[j].Trim();
                }
                switch (index[0])
                {
                    case "AvtobusniPrevoz":
                        {
                            AvtobusniPrevoz avtobus = new AvtobusniPrevoz();
                            avtobus.imePoti = Convert.ToString(index[1]);
                            avtobus.casOdhoda = Convert.ToDateTime(index[2]);
                            avtobus.steviloSedezev = Convert.ToInt32(index[3]);
                            avtobus.stevilovodicev = Convert.ToInt32(index[4]);
                            avtobus.vstop = (string)index[5];
                            avtobus.izstop = (string)index[6];
                            avtobus.cenaVozovnice = Convert.ToInt32(index[7]);
                        }
                        break;

                    case "AvtoPrevoz":
                        {
                            AvtoPrevoz avto = new AvtoPrevoz();
                            avto.imePoti = Convert.ToString(index[1]);
                            avto.vstop = (string)index[5];
                            avto.izstop = (string)index[6];
                            avto.cenaVozovnice = Convert.ToInt32(index[7]);
                            avto.prevoznik = index[8];
                            avto.TipAvtaVelikost1 = (AvtoPrevoz.TipAvtaVelikost)Enum.Parse(typeof(AvtoPrevoz.TipAvtaVelikost), (string)index[9]);
                            avto.steviloKoles = Convert.ToInt32(index[10]);
                        }
                        break;

                    case "KombiPrevoz":
                        {
                            KombiPrevoz kombi = new KombiPrevoz();
                            kombi.imePoti = Convert.ToString(index[1]);
                            kombi.vstop = (string)index[5];
                            kombi.izstop = (string)index[6];
                            kombi.cenaVozovnice = Convert.ToInt32(index[7]);
                            kombi.hitrost = Convert.ToInt32(index[11]);
                            kombi.firma = (string)index[12];
                            kombi.kilometrina = Convert.ToInt32(index[13]);
                        }
                        break;
                    
                }
            }
            }
        }

    }
        
    


