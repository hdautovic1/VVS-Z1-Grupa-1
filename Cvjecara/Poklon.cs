using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//KOMENTAR:
//
//Ime: Selma Hadžijusufović
//Opis: Neiskorišteni importi. Potrebno ih je optimizovati.
namespace Cvjecara
{
    public class Poklon
    {
        #region Atributi

        string šifra, opis;
        double postotakPopusta;
        int brojač = 10000;

        #endregion

        #region Properties

        //KOMENTAR:
        //Ime: Selma Hadžijusufović
        //Opis: Kršenje načina imenovanja.
        public string s_i_f_r_a { get => šifra; }
        public string Opis { get => opis; set => opis = value; }
        public double PostotakPopusta { get => postotakPopusta; }

        #endregion

        #region Konstruktor

        public Poklon(string opis, double postotak)
        {
            //KOMENTAR:
            //Ime: Selma Hadžijusufović
            //Opis: Sve promjenljive tipa Poklon će imati istu vrijednost šifre, koja bi trebala biti jedinstvena. Razlog za to je što se pri kreiranju 
            // promjenljive ovog tipa, brojač uvijek inicijalizira na 10000, iako se u konstruktoru nakon dodjele množi sa 0 i povećava za 1, njegova vrijednost 
            // pri određivanju šifre je uvijek 10000.
            šifra = brojač.ToString();
            brojač *= 0;
            brojač++;
            Opis = opis;
            postotakPopusta = postotak;
        }

        #endregion
    }
}
