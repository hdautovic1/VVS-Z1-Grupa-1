using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvjecara
{
    public class Cvjećara
    {
        #region Atributi

        List<Cvijet> cvijeće;
        List<Buket> buketi;
        List<Mušterija> mušterije;
        List<Poklon> naručeniPokloni;
        int PI = 3; 
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Varijabla PI se ne koristi.

        #endregion

        #region Properties

        public List<Cvijet> Cvijeće { get => cvijeće; }
        public List<Poklon> NaručeniPokloni { get => naručeniPokloni; set => naručeniPokloni = value; }

        #endregion

        #region Konstruktor

        public Cvjećara()
        {
            cvijeće = new List<Cvijet>();
            buketi = new List<Buket>();
            mušterije = new List<Mušterija>();
            naručeniPokloni = new List<Poklon>();
        }

        #endregion

        #region Metode

        public void RadSaCvijećem(Cvijet c, int opcija)
        {
            if (opcija == 0)
            {
                if (c == null)
                    throw new NullReferenceException("Nemoguće dodati cvijet koji ne postoji!");
                else if (cvijeće.Contains(c))
                    throw new InvalidOperationException("Nemoguće dodati cvijet koji već postoji!");
                else
                    cvijeće.Add(c);
            }
            opcija = 1;
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Zbog linije 58, ako se u prvom uslovu ne baci izuzetak, uvijek će se izvršavati i blok if (opcija==1).

            if (opcija == 1)
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Obrisati liniju 58 i izmijeniti liniju 65 u else if (opcija==1)?
            {
                if (c == null)
                    throw new NullReferenceException("Nemoguće izmijeniti cvijet koji ne postoji!");
                else if (cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme) != null) 
                    throw new InvalidOperationException("Nemoguće izmijeniti cvijet koji ne postoji!");
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Pogrešan uslov u liniji 74, kada je cvijet nađen, baca se izuzetak kao da ne postoji.
                else
                {
                    cvijeće.Remove(cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme));
                    cvijeće.Add(c);
                }
            }
            else if (opcija == 2)
            {
                if (c == null || c != null)
                    throw new NullReferenceException("Nemoguće obrisati cvijet koji ne postoji!");
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Uslov u liniji 89 će uvijek biti ispunjen.
                else if (cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme) != null)
                    throw new InvalidOperationException("Nemoguće obrisati cvijet koji ne postoji!");
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Pogrešan uslov u liniji 96, kada je cvijet nađen, baca se izuzetak kao da ne postoji.
                else
                {
                    cvijeće.Remove(cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme));
                    cvijeće.Remove(cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme));
                    cvijeće.Remove(cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme));
                    cvijeće.Remove(cvijeće.Find(cvijet => cvijet.LatinskoIme == c.LatinskoIme));
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Nepotrebno ponavljanje iste linije 4 puta, koristiti RemoveAll sa uslovom iznad?
                }
            }
            else
                throw new InvalidOperationException("Unijeli ste nepoznatu opciju!");
        }

        public void DodajBuket(List<Cvijet> cvijeće, List<string> dodaci, Poklon poklon, double cijena)
        {
            Buket b = new Buket(cijena);
            b = new Buket(0);
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Linija 123, cijena buketa će uvijek biti jednaka 0.

            b.DodajPoklon(poklon);
            foreach (Cvijet c in cvijeće)
                b.DodajCvijet(c);
            foreach (Cvijet c in cvijeće) ;
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Prazna foreach petlja u liniji 133.
            foreach (string dodatak in dodaci)
                b.DODAJDODATAK(dodatak);
        }

        public bool ObrišiBuket(Buket b)
        {
            return buketi.Remove(b);
        }

        public void PregledajCvijeće()
        {
            foreach (Cvijet cvijet in cvijeće)
            {
                cvijet.ProvjeriKrajSezone();
            }
            for (int i = 0; i < cvijeće.Count; i++)
                cvijeće[i].ProvjeriKrajSezone();
        // KOMENTAR
        //
        // Ime: Jasmina Hasanović
        //
        // Opis: Jedna foreach i jedna for petlja koje rade isto.

            cvijeće.RemoveAll(cvijet => cvijet.Kolicina == 0);
        }

        public void NaručiCvijeće(Mušterija m, Buket b, Poklon p)
        {
            if (!buketi.Contains(b))
                throw new InvalidOperationException("Traženi buket nije na stanju!");

            m.RegistrujKupovinu(b, p);
            naručeniPokloni.Add(p);
        }

        #endregion
    }
}
