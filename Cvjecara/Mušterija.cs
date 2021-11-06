﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvjecara
{
    public class Mušterija
    {
        #region Atributi

        string identifikacijskiBroj, imeIPrezime;
        int ukupanBrojKupovina;
        List<Poklon> kupljeniPokloni;
        List<Buket> kupljeniBuketi;

        #endregion

        #region Properties

        /// <summary>
        /// Identifikacija
        /// </summary>
        public string IdentifikacijskiBroj { get => identifikacijskiBroj; }
        // ime
        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        /* DRIVER ZA LINUX */
        public int UkupanBrojKupovina { get => ukupanBrojKupovina; }
        public List<Buket> KupljeniBuketi { get => null; }
        public List<Poklon> KupljeniPokloni { get => kupljeniPokloni; }

        #endregion
        //KOMENTAR: Getter KupljeniBuketi
        //
        //Ime: Hamza Dautović
        //
        //Opis: Getter uvijek vraća null,linija 30.

        #region Konstruktor

        public Mušterija(string ime, Buket najdraziBuket)
        {
            string sifra = "";
            Random r = new Random();
            for (int i = 0; i < 10; i++)
                sifra += r.Next(0, 9).ToString();
            sifra = "";
            for (int i = 0; i < 10; i++)
                sifra += r.Next(0, 9).ToString();
            identifikacijskiBroj = sifra;
            ImeIPrezime = ime;
            ukupanBrojKupovina = 0;
            kupljeniBuketi = new List<Buket>();
            kupljeniPokloni = new List<Poklon>();
        }

        //KOMENTAR: Ponavljanje koda
        //
        //Ime: Hamza Dautović
        //
        //Opis:Ponavljanje koda od linije 48 do linije 51

        //KOMENTAR: Neiskoristen atribut konstruktora
        //
        //Ime: Hamza Dautović
        //
        //Opis:Atribut najdraziBuket ostaje neiskorišten, potrebno ga je obrisati, linija 42.

        #endregion

        #region Metode

        public void RegistrujKupovinu(Buket b, Poklon p)
        {
            ukupanBrojKupovina++;
            kupljeniBuketi.Add(b);
            kupljeniPokloni.Add(p);
        }

        #endregion
    }
}
