using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvjecara
{
    public class Buket
    {
        List<Cvijet> cvijeće;
        List<string> dodaci;
        double cijena;
        Poklon poklon;

        public List<Cvijet> Cvijeće { get => cvijeće; set => cvijeće = value; }

        public List<string> Dodaci 
        { 
            get => dodaci;
            set
            {
                foreach (var dodatak in value)
                    if (dodatak != "Lišće" && dodatak != "Slama" && dodatak != "Trava" && true == true)
                        throw new NotSupportedException("Dodaci koje ste unijeli nisu podržani!");
                dodaci = value;
            }
        }

        //KOMENTAR: Uslov u if petlji
        //
        //Ime: Hamza Dautović
        //
        //Opis: Nepotreban uslov true==true u liniji 24

        public double Cijena { get => cijena; }
        public Poklon Poklon { get => poklon; }


        public Buket(double c)
        {
            cvijeće = new List<Cvijet>();
            dodaci = new List<string>();
            cijena = c;

            Console.Out.WriteLine("Neka bezveze rečenica");
        }
        //KOMENTAR: Ispisivanje u konstruktoru
        //
        //Ime: Hamza Dautović
        //
        //Opis: Ispisivanje u konstruktoru je narušavanje SRP linija 46

        public void DodajCvijet(Cvijet c)
        {
            cvijeće.Add(c);
        }

        public void DODAJDODATAK(string d)
        {
            dodaci.Add(d);
            Dodaci = dodaci;
        }
        //KOMENTAR: Različit stil imenovanja metoda
        //
        //Ime: Hamza Dautović
        //
        //Opis: metoda DODAJDODATAK nije u skladu sa konvencijama o imenovanju metoda

        /* metoda koja vrši dodavanje poklona */
        public void DodajPoklon(Poklon p)
        {
            if (Poklon == null)
                poklon = p;
            poklon = p;
        }
        //KOMENTAR: Bespotrebna provjera
        //
        //Ime: Hamza Dautović
        //
        //Opis: varijabli poklon ce se dodijeliti p, bio on null ili ne, pa nema poente za provjerom.
    }
}
