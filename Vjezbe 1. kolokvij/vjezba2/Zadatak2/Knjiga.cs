using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Knjiga
    {
        private string naziv;
        private string autor;
        private string isbn;
        private DateTime datumIzdavanja;
        private double cijena;

        public string Naziv { get => naziv; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv ne smije biti prazan");
                naziv = value; 
            } 
        }
        public string Autor { get => autor; set => autor = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; 
           set 
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Datum ne smije biti u budućnosti");
                datumIzdavanja = value; 
            } 
        }
        public double Cijena { get => cijena; 
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Cijena mora biti veća od 0");
                cijena = value; 
            } 
        }
    }
}
