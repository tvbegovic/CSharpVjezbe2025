using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Polaznik
    {
        private string ime;
        private string prezime;
        private string oib;
        private DateTime datumUpisa;
        private double dug;

        public string Ime { get => ime; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Ime ne smije biti prazno"); ;
                ime = value; 
            } 
        }
        //TODO
        public string Prezime { get => prezime; set => prezime = value; }
        public string Oib { get => oib; 
            set 
            {
                if (value.Length != 11)
                    throw new ArgumentException("Oib mora imati 11 znakova");
                oib = value; 
            } 
        }
        public DateTime DatumUpisa { get => datumUpisa; 
            set 
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Datum ne smije biti u budućnosti");
                datumUpisa = value; 
            } 
        }
        public double Dug { get => dug; 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Dug ne smije biti negativan");
                dug = value; 
            } 
        }
    }
}
